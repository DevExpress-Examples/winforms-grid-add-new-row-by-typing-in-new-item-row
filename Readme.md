<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128625244/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2891)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Add a new row by typing within the New Item Row (as in DataGridView)

This example demonstrates how to add a new data row to the grid's data source after the user starts typing within the New Item Row (the behavior inspired by the standard `DataGridView`).

![WinForms Data Grid - Add a new row by typing within the New Item Row](https://raw.githubusercontent.com/DevExpress-Examples/winforms-grid-add-new-row-by-typing-in-new-item-row/13.1.4%2B/media/winforms-grid-new-item-row.gif)

Follow the steps below:

1. Set the [GridView.OptionsView.NewItemRowPosition](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsView.NewItemRowPosition) property to `NewItemRowPosition.Bottom`.
2. Handle the cell editor's `EditValueChanged` event to check whether the New Item Row is focused and close the active editor ([GridView.CloseEditor](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.BaseView.CloseEditor)), save a new row to the data source ([GridView.UpdateCurrentRow](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.BaseView.UpdateCurrentRow)), and show/activate the cell's editor ([GridView.ShowEditor](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.BaseView.ShowEditor)).

```csharp
private void OnEditValueChanged(object sender, EventArgs e)
{
    if(gridView.FocusedRowHandle == GridControl.NewItemRowHandle)
    {
        gridView.CloseEditor();
        gridView.UpdateCurrentRow();
        gridView.ShowEditor();
        TextEdit edit = sender as TextEdit;
        if(edit == null) return;
        edit.SelectionStart = 1;
        edit.SelectionLength = 0;
    }
}
private void OnLoad(object sender, EventArgs e)
{
    InitData();
    gridControl.ForceInitialize();
    for(int i = 0; i < gridView.VisibleColumns.Count; i++)
        gridView.VisibleColumns[i].RealColumnEdit.EditValueChanged += OnEditValueChanged;
}
```

## Files to Review

* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
