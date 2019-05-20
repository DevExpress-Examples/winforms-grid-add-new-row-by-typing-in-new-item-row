Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace DXSample
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Function GetCustomerInfoDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.TableName = "CustomerInfo"
            table.Columns.Add(New DataColumn("CustomerID", GetType(Integer)))
            table.Columns.Add(New DataColumn("FirstName", GetType(String)))
            table.Columns.Add(New DataColumn("LastName", GetType(String)))
            table.Columns.Add(New DataColumn("Date", GetType(DateTime)))
            table.Columns.Add(New DataColumn("Check", GetType(Boolean)))
            For i As Integer = 0 To 5 - 1
                table.Rows.Add(i, String.Format("FirstName {0}", i), i, DateTime.Today.AddDays(i), i Mod 2 = 0)
            Next
            Return table
        End Function

        Private Sub OnEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If gridView.FocusedRowHandle = GridControl.NewItemRowHandle Then
                gridView.CloseEditor()
                gridView.UpdateCurrentRow()
                gridView.ShowEditor()
                Dim edit As TextEdit = TryCast(sender, TextEdit)
                If edit Is Nothing Then Return
                edit.SelectionStart = 1
                edit.SelectionLength = 0
            End If
        End Sub

        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            InitData()
            gridControl.ForceInitialize()
            For i As Integer = 0 To gridView.VisibleColumns.Count - 1
                AddHandler gridView.VisibleColumns(i).RealColumnEdit.EditValueChanged, AddressOf OnEditValueChanged
            Next
        End Sub

        Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
            For i As Integer = 0 To gridView.VisibleColumns.Count - 1
                AddHandler gridView.VisibleColumns(i).RealColumnEdit.EditValueChanged, AddressOf OnEditValueChanged
            Next
            MyBase.OnFormClosing(e)
        End Sub

        Public Sub InitData()
            customerInfoBindingSource.DataSource = GetCustomerInfoDataTable()
        End Sub
    End Class
End Namespace
