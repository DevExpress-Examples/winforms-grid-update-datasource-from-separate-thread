' Developer Express Code Central Example:
' How to avoid the ArgumentOutOfRangeException exception when updating the Grid's data source within a background thread
' 
' This example shows how to properly update the Grid's underlying data source from
' a background thread, and avoid possible synchronization problems.
' 
' 
' See
' Also:
' <kblink id = "AK2981"/>
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E813

Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("Thread")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("Thread")>
<Assembly: AssemblyCopyright("Copyright ©  2010")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("da8fd144-bcf7-4d41-b23d-38d8288e78b7")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
