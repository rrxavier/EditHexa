using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace editeurHexadecimal {
    public partial class Form1 : Form {
        HexaEditModel model;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dataGridView.RowCount = model.Hexadecimal.Rows.Count;
        }

        private void btnOpenFile_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                model = new HexaEditModel(openFileDialog1.FileName);
                updateGridView();
            }
        }

        private void updateGridView() {
            IEnumerable<DataRow> rows = model.Hexadecimal.AsEnumerable().Skip(19).Take(61);
            DataTable table = rows.CopyToDataTable();
            dataGridView.DataSource = table;
            dataGridView.Columns[0].Width = 80;
        }

        private void dataGridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e) {
            e.Value = 0;
        }
    }
}
