<!-- default file list -->
*Files to look at*:

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


