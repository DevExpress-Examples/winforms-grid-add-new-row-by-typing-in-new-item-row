Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.customerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet11 = New DXSample.DataSet1()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.gridControl = New DevExpress.XtraGrid.GridControl()
			Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCheck = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.customerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customerInfoBindingSource
			' 
			Me.customerInfoBindingSource.DataMember = "CustomerInfo"
			Me.customerInfoBindingSource.DataSource = Me.dataSet11
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' gridControl
			' 
			Me.gridControl.DataSource = Me.customerInfoBindingSource
			Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl.Location = New System.Drawing.Point(0, 0)
			Me.gridControl.MainView = Me.gridView
			Me.gridControl.Name = "gridControl"
			Me.gridControl.Size = New System.Drawing.Size(551, 467)
			Me.gridControl.TabIndex = 0
			Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView})
			' 
			' gridView
			' 
			Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colFirstName, Me.colLastName, Me.colDate, Me.colCheck})
			Me.gridView.GridControl = Me.gridControl
			Me.gridView.Name = "gridView"
			Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
			' 
			' colCustomerID
			' 
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 0
			' 
			' colFirstName
			' 
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 1
			' 
			' colLastName
			' 
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.Visible = True
			Me.colLastName.VisibleIndex = 2
			' 
			' colDate
			' 
			Me.colDate.FieldName = "Date"
			Me.colDate.Name = "colDate"
			Me.colDate.Visible = True
			Me.colDate.VisibleIndex = 3
			' 
			' colCheck
			' 
			Me.colCheck.FieldName = "Check"
			Me.colCheck.Name = "colCheck"
			Me.colCheck.Visible = True
			Me.colCheck.VisibleIndex = 4
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(551, 467)
			Me.Controls.Add(Me.gridControl)
			Me.Name = "Main"
			Me.Text = "New Item Row"
'			Me.Load += New System.EventHandler(Me.OnLoad);
			CType(Me.customerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region


		Private customerInfoBindingSource As System.Windows.Forms.BindingSource
		Private dataSet11 As DataSet1
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private gridControl As DevExpress.XtraGrid.GridControl
		Private gridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private colDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colCheck As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

