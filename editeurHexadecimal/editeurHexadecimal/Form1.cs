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
        Size previousSize;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            hexaGridView.MouseWheel += new System.Windows.Forms.MouseEventHandler(askRange); /* TO-DO: bug, si on commence par scroller vers le haut, il faut après scroller plus longtemps vers le bas pour que ça réagisse */
            previousSize = new Size(this.Size.Width, this.Size.Height);
        }

        private void btnOpenFile_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                model = new HexaEditModel(openFileDialog1.FileName);
                firstRowIndex = 0;
                updateGridView(true, 17);
                hexaGridView.Columns[0].Width = 80;
                hexaGridView.Columns[0].ReadOnly = true;
                hexaGridView.Columns[0].DefaultCellStyle.BackColor = Color.Gray;
                hexaGridView.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Gray;
                hexaGridView.Columns[0].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;

                for (int i = 0; i < hexaGridView.Columns.Count; i++) { 
                    hexaGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    hexaGridView.Columns[i].MinimumWidth = 22;
                }

                hexaGridView.Columns[0].MinimumWidth = 30;
            }
        }

        private void updateGridView(bool down, int nbRow) {
            int firstWantedRow;

            if (hexaGridView.Rows.Count == 0)
                firstWantedRow = 1;
            else if (down)
                firstWantedRow = hexaGridView.Rows[hexaGridView.Rows.Count - 1].Index + firstRowIndex + 1;
            else
                firstWantedRow = hexaGridView.Rows[0].Index + firstRowIndex - 1 - 17;

            hexaGridView.DataSource = model.GetDataTable(firstWantedRow, nbRow);
            //asciiGridView.DataSource = model.GetAsciiDataTable(firstWanterRow, nbRow);

            if (down)
                firstRowIndex += 17;
            else
                firstRowIndex -= 17;
        }

        private void askRange(object sender, MouseEventArgs e) {
            if (e.Delta < 0)
                updateGridView(true, 17);
            else
                updateGridView(false, 17);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) { /*marche pas, analyse un carré dans les 17 affichés, mais pas par rapport à tous */
            DataGridView dtgv = sender as DataGridView;

            if (e.ColumnIndex != 0 && e.RowIndex != -1) { /* -1 is header */
                Point cellPt = new Point(e.ColumnIndex, e.RowIndex);

                lblBinary.Text = model.ConvertHexaToBinary(cellPt);
                lblOctal.Text = model.ConvertHexaToOctal(cellPt);
                lbl8BitsSigned.Text = model.ConvertHexaTo8BitsSigned(cellPt);
                lbl8BitsNS.Text = model.ConvertHexaTo8BitsUnsigned(cellPt);
                lbl16BitSigned.Text = model.ConvertHexaTo16BitsSigned(cellPt);
                lbl16BitsNS.Text = model.ConvertHexaTo16BitsUnsigned(cellPt);
                lbl32BitsSigned.Text = model.ConvertHexaTo32BitsSigned(cellPt);
                lbl32BitsNS.Text = model.ConvertHexaTo32BitsUnsigned(cellPt);
                lbl64BitsSigned.Text = model.ConvertHexaTo64BitsSigned(cellPt);
                lblFloat.Text = model.ConvertHexaToFloat(cellPt);
                lblDouble.Text = model.ConvertHexaToDouble(cellPt);

                tctrlData.SelectedIndex = 1;
            } 
            //DataGridViewCell cell = dtgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //cell.Style.BackColor = Color.Red; //just to test the click event*/
        }

        private void Form1_SizeChanged(object sender, EventArgs e) { /*Je ferais sûrement mieux de prendre un autre event */
            Form1 form = sender as Form1;
            int heightDiff = form.Size.Height - previousSize.Height;
            int widthDiff = form.Size.Width - previousSize.Width;

            hexaGridView.Height += (heightDiff / 2) + (heightDiff % 2);
            hexaGridView.Width += (widthDiff / 2) + (widthDiff % 2);

            asciiGridView.Height += heightDiff / 2;
            asciiGridView.Width += widthDiff / 2;

            //adapter avec les restes de divisions car bug!

            asciiGridView.Location = new Point(asciiGridView.Location.X + (widthDiff / 2), asciiGridView.Location.Y);
            previousSize = new Size(form.Size.Width, form.Size.Height);

            //hexaGridView.AutoResizeRows();
        }
    }
}
