<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632656/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E813)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Data Grid for Windows Forms - Update a Grid Control's datasource from a separate thread


This example shows how to safely update a [Grid Control](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl)'s data source from a background thread. The technique shown allows you to avoid possible synchronization issues between the main and background threads.


<!-- default file list -->
## Files to Look At

* [Form1.cs](./CS/Thread/Form1.cs) (VB: [Form1.vb](./VB/Thread/Form1.vb))
* [Program.cs](./CS/Thread/Program.cs) (VB: [Program.vb](./VB/Thread/Program.vb))
<!-- default file list end -->

## See Also
- [Can I avoid the ArgumentOutOfRangeException when I update the Grid's data](https://www.devexpress.com/Support/Center/p/AK2981)
- [DevExpress WinForms Troubleshooting - Asynchronous Programming](https://go.devexpress.com/CheatSheets_WinForms_Examples_T964838.aspx)
- [DevExpress WinForms Troubleshooting - Grid Control](https://go.devexpress.com/CheatSheets_WinForms_Examples_T934742.aspx)
