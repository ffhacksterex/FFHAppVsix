using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FFHExWizard
{
    public class Wizard : IWizard
    {
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            HandleRunStarted(automationObject, replacementsDictionary, runKind, customParams);
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }


        // PRIVATE

        private static readonly string SafeProjectNameKey = "$safeprojectname$";
        private static readonly string ProjectVersionKey = "$projectversion$";
        private static readonly string DefaultProjectVersion = "0,9,7,0";

        private static void OpenFolder(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    var startInfo = new ProcessStartInfo
                    {
                        Arguments = path,
                        FileName = "explorer.exe"
                    };
                    System.Diagnostics.Process.Start(startInfo);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Unable to open a File explorer window to\n{path}\n\n{ex.Message}");
                Trace.WriteLine(ex);
            }
        }

        private void HandleRunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            // $safeprojectversion$ is built in, but $projectversion$ is template-provided.
            // If the project template omitted it, then use a default to avoid an exception.
            if (!replacementsDictionary.ContainsKey(ProjectVersionKey))
            {
                MessageBox.Show($"'{ProjectVersionKey}' was not defined in the project template.\n" +
                    $"Project version will default to '{DefaultProjectVersion}'.");
                replacementsDictionary[ProjectVersionKey] = DefaultProjectVersion;
            }

            // Dashes aren't safe in C++ variable names/identifiers, change to underscores.
            var safeprj = replacementsDictionary[SafeProjectNameKey]
                .Replace('-', '_');

            // Set the defaults, then invoke the user input with those defaults.
            var prjver = replacementsDictionary[ProjectVersionKey];
            var projsym = safeprj.ToUpper();
            var inigrp = safeprj.ToLower();

            try
            {
                using (var form = new UserParamForm())
                {
                    InitLabelAndEdit(form.labelProjSymbol, form.textBoxProjSymbol, projsym);
                    InitLabelAndEdit(form.labelIniGroup, form.textBoxIniGroup, inigrp);
                    InitLabelAndEdit(form.labelProjVersion, form.textBoxProjVersion, prjver);
                    form.StartPosition = FormStartPosition.CenterParent;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        projsym = IfNotEmpty(projsym, form.textBoxProjSymbol);
                        inigrp = IfNotEmpty(inigrp, form.textBoxIniGroup);
                        prjver = IfNotEmpty(prjver, form.textBoxProjVersion);
                    }
                    else
                    {
                        throw new OperationCanceledException("Project creation cancelled.");
                    }
                }
                replacementsDictionary["$projectsymbol$"] = projsym;
                replacementsDictionary["$inigroupname$"] = inigrp;
                replacementsDictionary["$projectversion$"] = prjver;
            }
            catch (OperationCanceledException ex) when (HandleCancellation(ex)) { }
            catch (Exception ex) when (ex.GetType() != typeof(OperationCanceledException))
            {
                MessageBox.Show($"An error has prevented post processing customizations:\n{ex.Message}");
                Debug.WriteLine(ex.ToString());
            }

            // NESTED FUNCTIONS
            void InitLabelAndEdit(Label label, TextBox box, string value)
            {
                label.Text = $"If blank, defaults to {value}";
                box.Text = value;
            }

            string IfNotEmpty(string original, TextBox box)
            {
                var value = box.Text;
                return !string.IsNullOrWhiteSpace(value) ? value : original;
            }

            bool HandleCancellation(OperationCanceledException ex)
            {
                // If the project was created standalone, then a solution was
                // created around it and the exclusive property is set to "Tr
                var exkey = "$exclusiveproject$";
                bool excl = replacementsDictionary.ContainsKey(exkey) &&
                    replacementsDictionary[exkey] == "True";

                // Ask the user if they want to remove the folder of the failed project.
                var dest = replacementsDictionary["$destinationdirectory$"];
                var result = MessageBox.Show($"{ex.Message}\n" +
                    $"Do you want to remove the newly created destination folder?\n{dest}",
                    "Cancelled",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    // If standalone, open FileExplorer to the solution's parent folder.
                    // Else, open FileExplorer to the solution dir (the project's parent).
                    var solkey = "$solutiondirectory$";
                    var projPath = replacementsDictionary.ContainsKey(solkey) && excl
                        ? replacementsDictionary[solkey] : dest;
                    var pathToOpen = Path.GetDirectoryName(projPath);
                    OpenFolder(pathToOpen);
                }
                return false;
            }
        }
    }
}