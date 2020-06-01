// Developer Express Code Central Example:
// How to avoid the ArgumentOutOfRangeException exception when updating the Grid's data source within a background thread
// 
// This example shows how to properly update the Grid's underlying data source from
// a background thread, and avoid possible synchronization problems.
// 
// 
// See
// Also:
// <kblink id = "AK2981"/>
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E813

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using System.Threading;
using System.Threading.Tasks;

namespace Thread {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitData();
            FillData();
            InitGridColumns();
        }

        DataTable data;
        private void InitData() {
            data = new DataTable("ColumnsTable");
            data.BeginInit();
            AddColumn(data, "ID", System.Type.GetType("System.Int32"), true);
            AddColumn(data, "First Name", System.Type.GetType("System.String"));
            data.EndInit();
        }

        private void AddColumn(DataTable data, string name, Type type) {
            AddColumn(data, name, type, false);
        }
        private void AddColumn(DataTable data, string name, Type type, bool ro) {
            DataColumn col;
            col = new DataColumn(name, type);
            col.Caption = name;
            col.ReadOnly = ro;
            data.Columns.Add(col);
        }

        private void FillData() {
            FillData(data, false);
        }

        private void FillData(DataTable data, bool deleteRows) {
            if(deleteRows) {
                for(int i = data.Rows.Count - 1; i >= 0; i--)
                    if(i % 2 != 0)
                        data.Rows.RemoveAt(i);
            }
            else {
                data.Clear();
                for(int i = 0; i <= 300; i++)
                    data.Rows.Add(new Object[] { i + 1, "Row " + (i + 1).ToString() });
            }
        }
        GridControl gridControl1;
        private void InitGridColumns() {
            gridControl1 = new GridControl();
            gridControl1.Dock = DockStyle.Right;
            Controls.Add(gridControl1);
            gridControl1.DataSource = data;
        }

        volatile bool deleting = false;

        private void UpdateGridDataSource(DataTable copy) {
            FillData(copy, deleting);
            deleting = !deleting;
            gridControl1.BeginInvoke(new Action(() => {
                gridControl1.DataSource = copy;
            }));
        }

        private void button1_Click(object sender, EventArgs e) {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Task.Run(() => UpdateGridDataSource(data.Copy()));
        }
    }
}