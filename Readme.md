<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2891)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DataSet1.cs](./CS/WindowsApplication3/DataSet1.cs) (VB: [DataSet1.vb](./VB/WindowsApplication3/DataSet1.vb))
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
<!-- default file list end -->
# How to add a new row to a grid by typing in a New Item Row as in DataGridView


<p>If you want to exactly emulate the standard DataGridView behavior, i.e. the new item row should appear immediately after typing in a column's cell, you need to introduce this functionality manually. </p><p>For this, set the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridOptionsView_NewItemRowPositiontopic"><u>GridView.OptionsView.NewItemRowPosition property</u></a> to Bottom. <br />
Then, handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItem_EditValueChangedtopic"><u>RepositoryItem.EditValueChanged event</u></a>: <br />
      close the active editor and post changes by calling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseBaseView_CloseEditortopic"><u>GridView.CloseEditor method</u></a>, <br />
      then call the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseColumnView_UpdateCurrentRowtopic"><u>GridView.UpdateCurrentRow method</u></a> to save a new row to the underlying data source. <br />
To show the cell's in-place editor again, call the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_ShowEditortopic"><u>GridView.ShowEditor method</u></a>.</p><p>This example illustrates how to accomplish this task. </p>

<br/>


