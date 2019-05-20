Namespace DXSample
    Partial Class Main
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.customerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck = New DevExpress.XtraGrid.Columns.GridColumn()
            CType((Me.customerInfoBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.customerInfoBindingSource.DataMember = "CustomerInfo"
            Me.gridControl.DataSource = Me.customerInfoBindingSource
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(551, 467)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomerID, Me.colFirstName, Me.colLastName, Me.colDate, Me.colCheck})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.Visible = True
            Me.colCustomerID.VisibleIndex = 0
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.Visible = True
            Me.colFirstName.VisibleIndex = 1
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            Me.colLastName.Visible = True
            Me.colLastName.VisibleIndex = 2
            Me.colDate.FieldName = "Date"
            Me.colDate.Name = "colDate"
            Me.colDate.Visible = True
            Me.colDate.VisibleIndex = 3
            Me.colCheck.FieldName = "Check"
            Me.colCheck.Name = "colCheck"
            Me.colCheck.Visible = True
            Me.colCheck.VisibleIndex = 4
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 16.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(551, 467)
            Me.Controls.Add(Me.gridControl)
            Me.Name = "Main"
            Me.Text = "New Item Row"
            CType((Me.customerInfoBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private customerInfoBindingSource As System.Windows.Forms.BindingSource
        Private gridControl As DevExpress.XtraGrid.GridControl
        Private gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
        Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
        Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
        Private colDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colCheck As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
