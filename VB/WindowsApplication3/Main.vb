Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub InitData()
			For i As Integer = 0 To 4
				dataSet11.Tables(0).Rows.Add(New Object() { i, String.Format("FirstName {0}", i), i, DateTime.Today.AddDays(i), True })
			Next i
		End Sub

		Private Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitData()
			gridControl.ForceInitialize()
			For i As Integer = 0 To gridView.VisibleColumns.Count - 1
				AddHandler gridView.VisibleColumns(i).RealColumnEdit.EditValueChanged, AddressOf OnEditValueChanged
			Next i
		End Sub

		Private Sub OnEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If gridView.FocusedRowHandle = GridControl.NewItemRowHandle Then
				gridView.CloseEditor()
				gridView.UpdateCurrentRow()
				gridView.ShowEditor()
				Dim edit As TextEdit = TryCast(sender, TextEdit)
				If edit Is Nothing Then
					Return
				End If
				edit.SelectionStart = 1
				edit.SelectionLength = 0
			End If
		End Sub
		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			For i As Integer = 0 To gridView.VisibleColumns.Count - 1
				RemoveHandler gridView.VisibleColumns(i).RealColumnEdit.EditValueChanged, AddressOf OnEditValueChanged
			Next i
			MyBase.OnFormClosing(e)
		End Sub
	End Class
End Namespace
