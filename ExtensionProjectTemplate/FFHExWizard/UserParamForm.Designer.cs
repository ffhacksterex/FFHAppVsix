
namespace FFHExWizard
{
    partial class UserParamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProjSymbol = new System.Windows.Forms.TextBox();
            this.labelProjSymbol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIniGroup = new System.Windows.Forms.TextBox();
            this.labelIniGroup = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProjVersion = new System.Windows.Forms.TextBox();
            this.labelProjVersion = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project &Symbol";
            // 
            // textBoxProjSymbol
            // 
            this.textBoxProjSymbol.Location = new System.Drawing.Point(102, 22);
            this.textBoxProjSymbol.Name = "textBoxProjSymbol";
            this.textBoxProjSymbol.Size = new System.Drawing.Size(308, 20);
            this.textBoxProjSymbol.TabIndex = 1;
            // 
            // labelProjSymbol
            // 
            this.labelProjSymbol.AutoSize = true;
            this.labelProjSymbol.Location = new System.Drawing.Point(99, 45);
            this.labelProjSymbol.Name = "labelProjSymbol";
            this.labelProjSymbol.Size = new System.Drawing.Size(100, 13);
            this.labelProjSymbol.TabIndex = 2;
            this.labelProjSymbol.Text = "If blank, defaults to ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ini Group &Name";
            // 
            // textBoxIniGroup
            // 
            this.textBoxIniGroup.Location = new System.Drawing.Point(102, 74);
            this.textBoxIniGroup.Name = "textBoxIniGroup";
            this.textBoxIniGroup.Size = new System.Drawing.Size(308, 20);
            this.textBoxIniGroup.TabIndex = 4;
            // 
            // labelIniGroup
            // 
            this.labelIniGroup.AutoSize = true;
            this.labelIniGroup.Location = new System.Drawing.Point(99, 97);
            this.labelIniGroup.Name = "labelIniGroup";
            this.labelIniGroup.Size = new System.Drawing.Size(100, 13);
            this.labelIniGroup.TabIndex = 5;
            this.labelIniGroup.Text = "If blank, defaults to ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Project &Version";
            // 
            // textBoxProjVersion
            // 
            this.textBoxProjVersion.Location = new System.Drawing.Point(102, 125);
            this.textBoxProjVersion.Name = "textBoxProjVersion";
            this.textBoxProjVersion.Size = new System.Drawing.Size(308, 20);
            this.textBoxProjVersion.TabIndex = 7;
            // 
            // labelProjVersion
            // 
            this.labelProjVersion.AutoSize = true;
            this.labelProjVersion.Location = new System.Drawing.Point(99, 148);
            this.labelProjVersion.Name = "labelProjVersion";
            this.labelProjVersion.Size = new System.Drawing.Size(100, 13);
            this.labelProjVersion.TabIndex = 8;
            this.labelProjVersion.Text = "If blank, defaults to ";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(254, 182);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "&OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(335, 182);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // UserParamForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(434, 224);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelProjVersion);
            this.Controls.Add(this.textBoxProjVersion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelIniGroup);
            this.Controls.Add(this.textBoxIniGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelProjSymbol);
            this.Controls.Add(this.textBoxProjSymbol);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserParamForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Project Creation Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.TextBox textBoxProjSymbol;
        public System.Windows.Forms.Label labelProjSymbol;
        public System.Windows.Forms.TextBox textBoxIniGroup;
        public System.Windows.Forms.Label labelIniGroup;
        public System.Windows.Forms.TextBox textBoxProjVersion;
        public System.Windows.Forms.Label labelProjVersion;
    }
}