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
        int firstRowIndex;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dataGridView.MouseWheel += new System.Windows.Forms.MouseEventHandler(askRange);
        }

        private void btnOpenFile_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                model = new HexaEditModel(openFileDialog1.FileName);
                firstRowIndex = 0;
                updateGridView(true, 17);
            }
        }

        private void updateGridView(bool down, int nbRow) {
            int firstWantedRow;

            if (dataGridView.Rows.Count == 0)
                firstWantedRow = 1;
            else if (down)
                firstWantedRow = dataGridView.Rows[dataGridView.Rows.Count - 1].Index + firstRowIndex + 1;
            else
                firstWantedRow = dataGridView.Rows[0].Index + firstRowIndex - 1 - 17;

            dataGridView.DataSource = model.GetDataTable(firstWantedRow, nbRow);

            if (down)
                firstRowIndex += 17;
            else
                firstRowIndex -= 17;

            dataGridView.Columns[0].Width = 80;
        }

        private void askRange(object sender, MouseEventArgs e) {
            if (e.Delta < 0)
                updateGridView(true, 17);
            else
                updateGridView(false, 17);
        }
    }
}
