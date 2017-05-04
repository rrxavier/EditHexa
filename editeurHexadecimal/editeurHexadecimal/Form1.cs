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
        bool firstTime = true;
        List<Point> redCellPosList = new List<Point>();
        const int NB_ROW = 17;

        public Form1() {
            InitializeComponent();
            firstTime = false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(askRange); /* TO-DO: bug, si on commence par scroller vers le haut, il faut après scroller plus longtemps vers le bas pour que ça réagisse */
            previousSize = new Size(this.Size.Width, this.Size.Height);
        }

        private void btnOpenFile_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                model = new HexaEditModel(openFileDialog1.FileName);
                firstRowIndex = 0;
                updateGridView();

                hexaGridView.Columns[0].Width = 55; // TO-DO: Je ne devrais pas définir cela ici 
                hexaGridView.Columns[0].ReadOnly = true;
                hexaGridView.Columns[0].DefaultCellStyle.BackColor = Color.Gray;
                hexaGridView.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Gray;
                hexaGridView.Columns[0].DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;

                setHexaDimension(true);
                setAsciiDimension(true);

                lblAttribute.Text = model.MyFileData.Attributs;
                lblCreatedDate.Text = model.MyFileData.CreationTime.ToString();
                lblLastAccess.Text = model.MyFileData.LastAccessTime.ToString();
                lblModifyOn.Text = model.MyFileData.LastWriteTime.ToString();
                lblName.Text = model.MyFileData.Name;
                lblShortName.Text = model.MyFileData.ShortName;
                lblSize.Text = model.MyFileData.FileSize.ToString();
            }

            asciiGridView.Rows[0].Cells[0].Selected = false; //It was automatically selected for an unknown reason
        }

        private void setHexaDimension(bool isInitializing = false) {
            setHexaColumnsWidth(isInitializing);
            setHexaRowsHeight();
        }

        private void setAsciiDimension(bool isInitializing = false) {
            setAsciiColumnsWidth(isInitializing);
            setAsciiRowsHeight();
        }

        private void setHexaColumnsWidth(bool isInitializing = false) {
            int columnsWidth = (hexaGridView.Width - hexaGridView.Columns[0].Width) / 16;

            foreach (DataGridViewColumn column in hexaGridView.Columns) {
                if (isInitializing) { 
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.MinimumWidth = 22;
                }

                column.Width = columnsWidth;
            }

            if(isInitializing)
                hexaGridView.Columns[0].MinimumWidth = 55;
        }

        private void setHexaRowsHeight() {
            int rowHeight = (hexaGridView.Height - hexaGridView.ColumnHeadersHeight) / 17;

            foreach (DataGridViewRow row in hexaGridView.Rows) 
                row.Height = rowHeight;
        }

        private void setAsciiRowsHeight() {
            int rowHeight = asciiGridView.Height / 17;

            foreach (DataGridViewRow row in asciiGridView.Rows)
                row.Height = rowHeight;
        }

        private void setAsciiColumnsWidth(bool isInitializing = false) {
            int columnsWidth = columnsWidth = asciiGridView.Width / 16;

            foreach (DataGridViewColumn column in asciiGridView.Columns) {
                if (isInitializing) {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.MinimumWidth = 22;
                }

                column.Width = columnsWidth;
            }
        }

        private void updateGridView(bool down) {
            if (down && hexaGridView.Rows.Count != 0)
                firstRowIndex += NB_ROW;
            else if(!down && hexaGridView.Rows.Count != 0)
                firstRowIndex -= NB_ROW;

            hexaGridView.DataSource = model.GetHexaDataTable(firstRowIndex, NB_ROW);
            asciiGridView.DataSource = model.GetAsciiDataTable(firstRowIndex, NB_ROW);
            asciiGridView.Rows[0].Cells[0].Selected = false; //It was automatically selected for an unknown reason

            updateCellForeColor();
        }

        private void updateGridView() {
            hexaGridView.DataSource = model.GetHexaDataTable(firstRowIndex, NB_ROW);
            asciiGridView.DataSource = model.GetAsciiDataTable(firstRowIndex, NB_ROW);
            asciiGridView.Rows[0].Cells[0].Selected = false; //It was automatically selected for an unknown reason

            updateCellForeColor();
        }

        private void askRange(object sender, MouseEventArgs e) {
            if (e.Delta < 0) //scroll down
                updateGridView(true);
            else if(firstRowIndex - NB_ROW >= 0)
                updateGridView(false);
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (((DataGridView)sender).Name == "hexaGridView") {
                if (e.ColumnIndex != 0 && e.RowIndex != -1) { //column 0 and row -1 are offset 
                    updateLabel(new Point(e.ColumnIndex, e.RowIndex + firstRowIndex), false);
                    asciiGridView.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Selected = true;
                }
            } else if (((DataGridView)sender).Name == "asciiGridView") {
                updateLabel(new Point(e.ColumnIndex + 1, e.RowIndex + firstRowIndex), true);
                hexaGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Selected = true;
            }
        }

        private void updateLabel(Point cellPt, bool asciiTable){
            //lblChar.Text = asciiGridView.Rows[cellPt.Y].Cells[cellPt.X].Value.ToString();

            if(asciiTable)
                lblChar.Text = model.GetAsciiDataTable().Rows[cellPt.Y][cellPt.X].ToString();
            else
                lblChar.Text = model.GetAsciiDataTable().Rows[cellPt.Y][cellPt.X - 1].ToString();

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

        private void Form1_SizeChanged(object sender, EventArgs e) {
            if (!firstTime) { 
                Form1 form = sender as Form1;
                int heightDiff = form.Size.Height - previousSize.Height;
                int widthDiff = form.Size.Width - previousSize.Width;

                hexaGridView.Height += (heightDiff / 2) + (heightDiff % 2);
                hexaGridView.Width += (widthDiff / 2) + (widthDiff % 2);

                asciiGridView.Height += heightDiff / 2;
                asciiGridView.Width += widthDiff / 2;

                //adapter avec les restes de divisions car bug!

                //always 20px after hexaGridView
                asciiGridView.Location = new Point(hexaGridView.Location.X + hexaGridView.Width + 20, asciiGridView.Location.Y);

                previousSize = new Size(form.Size.Width, form.Size.Height);

                DataGridViewCellStyle hexaDefaultCellStyle = hexaGridView.DefaultCellStyle;
                DataGridViewCellStyle asciiDefaultCellStyle = asciiGridView.DefaultCellStyle;

                if (heightDiff < 0 || widthDiff < 0) {
                    if (hexaDefaultCellStyle.Font.Size - 0.25F >= 8.25F) { 
                        hexaDefaultCellStyle.Font = new Font(hexaDefaultCellStyle.Font.FontFamily, hexaDefaultCellStyle.Font.Size - 0.25F);
                        asciiDefaultCellStyle.Font = new Font(hexaDefaultCellStyle.Font.FontFamily, hexaDefaultCellStyle.Font.Size - 0.25F);
                    }
                } else {
                    if (hexaDefaultCellStyle.Font.Size + 0.25F <= 12F) {
                        hexaDefaultCellStyle.Font = new Font(hexaDefaultCellStyle.Font.FontFamily, hexaDefaultCellStyle.Font.Size + 0.25F);
                        asciiDefaultCellStyle.Font = new Font(hexaDefaultCellStyle.Font.FontFamily, hexaDefaultCellStyle.Font.Size + 0.25F);
                    }
                }

                setHexaDimension();
                setAsciiDimension();


                //rajouter à l'offset l'espace entre la dernière colonne et la fin, ou régler divisions entiier/double

                //hexaGridView.Columns[0].Width++;
            }
        }

        public void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            DataGridView dgv = sender as DataGridView;
            Point cellPos = new Point(e.ColumnIndex, e.RowIndex + firstRowIndex);

            if (dgv.Name == "hexaGridView")
            {
                // test that the user didn't erase the content of the cell or write something longer than 2 character 
                if (hexaGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != String.Empty && hexaGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Length <= 2) { 
                    model.ChangeValueHex(cellPos, hexaGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    updateAfterEdit(e.RowIndex, e.ColumnIndex, cellPos);
                } else {
                    updateGridView(); // cancel user deletion
                }
            } else {
                // test that the user didn't erase the content of the cell or write something longer than 1 character 
                if (asciiGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != String.Empty && asciiGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Length <= 1) {
                    model.ChangeValueAscii(cellPos, Convert.ToChar(asciiGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
                    updateAfterEdit(e.RowIndex, e.ColumnIndex + 1, new Point(e.ColumnIndex + 1, e.RowIndex));
                } else {
                    updateGridView(); // cancel user deletion
                }
            }

            //TO_DO: il reste juste 1 bug : quand on click sur une autre cell après avoir édité, sans validé, celle courante
        }

        private void updateAfterEdit(int rowIndex, int columnIndex, Point cellPos) {
            updateGridView();

            hexaGridView.Rows[rowIndex].Cells[columnIndex].Style.ForeColor = Color.Red;
            asciiGridView.Rows[rowIndex].Cells[columnIndex - 1].Style.ForeColor = Color.Red;

            redCellPosList.Add(cellPos);
        }

        private void updateCellForeColor() {
            foreach (DataGridViewRow row in hexaGridView.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (redCellPosList.Contains(new Point(cell.ColumnIndex, cell.RowIndex + firstRowIndex)))
                    {
                        cell.Style.ForeColor = Color.Red;
                        asciiGridView.Rows[cell.RowIndex].Cells[cell.ColumnIndex - 1].Style.ForeColor = Color.Red;
                    }
                }
        }
    }
}
