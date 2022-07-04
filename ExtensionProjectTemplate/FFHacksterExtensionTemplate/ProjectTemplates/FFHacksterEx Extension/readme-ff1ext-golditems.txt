$projectname$
===========================
esselle jaye

This is a example of an experimental extension to FFHacksterEx.
Projects can access it in one of the following ways:

1) Directly in the project (recommended)
Place the DLL into the same folder as the FFHacksterEx project file.
When FFhacksterEx loads the project, it will spot the DLL.

2) In a specified folder
FFHacksterEx allows projects to specify a folder where extensions
can be stored. Only use this if there are multiple projects
that use the same extension.

3) In the FFHacksterEx application folder (not recommended)
Except during initial development and debugging,
it's best not to put extensions in the app folder.
If working on multiple projects, having all of their extensions
in the same folder can lead to confusion.