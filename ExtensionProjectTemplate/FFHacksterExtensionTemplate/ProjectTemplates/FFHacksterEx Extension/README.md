# **$projectname$**
### Esselle Jaye
 \
This sample project illustrates an example of an ***experimental*** extension
support DLL. The project exports the functions expected by FFHacksterEx
and implements functionality for use with either a ROM or disassembly project.
New editors can be add and existing editors can extended, replaced, or dropped
from the list or available editors presented to FFHacksterEx.

\
&nbsp;
# Files

#### **$projectname$.h/cpp**
The header is defines import/export symbols.
The cpp file instantiates the main module object that implements all functionality.

#### **CustomModule.h/cpp**
Derived from CFFBaseApp, this class implements all functionality of the extension. \
It also furnishes to FFHacksterEx the details of what editors this extension
will add, override, or remove.

#### **$projectname$.rc and Resource.h**
This .rc is a listing of all of Windows resources that the program uses.  \
The header lists all IDs used to identity those resources.

#### **res\$projectname$.rc2**
This file contains resources that are not edited by Microsoft
Visual C++.  You should place all resources not editable by
the resource editor in this file.

#### **$projectname$.def**
This file contains information about the DLL that must be
provided to run with Microsoft Windows.  It defines parameters
such as the name and description of the DLL.  It also exports
functions from the DLL.

\
&nbsp;
# Issues

There are some warnings regarding symbols in the resource headers. \
FFHacksterEx's coredefs lobrary has some shared IDs that can cause
warnings when included in other libraries and executables. \
While these haven't caused resource conflicts yet, the potential is
there. \
 \
While FFhacksterEx isn't an a maintenance schedule, it's possible that
this could be addressed in a subsequent release. \
In the meantime, if any dialog control seems to be missing, unresponsive,
or behaving oddly, look at the control's ID and see if there's a warning
about that ID having a conflict. \
If so, then give the control a new, unique ID and the problem should be resolved. 