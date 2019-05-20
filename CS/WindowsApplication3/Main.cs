using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Data;
using System.Windows.Forms;


namespace DXSample
{
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        DataTable GetCustomerInfoDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "CustomerInfo";
            table.Columns.Add(new DataColumn("CustomerID", typeof(int)));
            table.Columns.Add(new DataColumn("FirstName", typeof(string)));
            table.Columns.Add(new DataColumn("LastName", typeof(string)));
            table.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            table.Columns.Add(new DataColumn("Check", typeof(bool)));
            for(int i = 0; i < 5; i++)
            {
                table.Rows.Add(i, string.Format("FirstName {0}", i), i, DateTime.Today.AddDays(i), i % 2 == 0);
            }
            return table;
        }

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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            for(int i = 0; i < gridView.VisibleColumns.Count; i++)
                gridView.VisibleColumns[i].RealColumnEdit.EditValueChanged -= OnEditValueChanged;
            base.OnFormClosing(e);
        }

        public void InitData()
        {
            customerInfoBindingSource.DataSource = GetCustomerInfoDataTable();
        }
    }
}
