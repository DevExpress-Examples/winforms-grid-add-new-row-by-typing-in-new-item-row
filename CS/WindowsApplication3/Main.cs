using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;


namespace DXSample {
    public partial class Main: XtraForm {
        public Main() {
            InitializeComponent();
        }
        public void InitData() {
            for(int i = 0;i < 5;i++) 
                dataSet11.Tables[0].Rows.Add(new object[] { i, string.Format("FirstName {0}", i), i, DateTime.Today.AddDays(i), true });
        }

        private void OnLoad(object sender, EventArgs e) {
            InitData();
            gridControl.ForceInitialize();
            for(int i = 0;i < gridView.VisibleColumns.Count;i++)
                gridView.VisibleColumns[i].RealColumnEdit.EditValueChanged += OnEditValueChanged;
        }

        private void OnEditValueChanged(object sender, EventArgs e) {
            if(gridView.FocusedRowHandle == GridControl.NewItemRowHandle) {
                gridView.CloseEditor();
                gridView.UpdateCurrentRow();
                gridView.ShowEditor();
                TextEdit edit = sender as TextEdit;
                if(edit == null) return;
                edit.SelectionStart = 1;
                edit.SelectionLength = 0;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            for(int i = 0;i < gridView.VisibleColumns.Count;i++)
                gridView.VisibleColumns[i].RealColumnEdit.EditValueChanged -= OnEditValueChanged;
            base.OnFormClosing(e);
        }
    }
}
