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
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            string[][] allHexaArray = new string[][] {
                                        new string[] {"100000", "0","1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"},
                                        new string[] {"100000", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"},
                                  };

            DataTable table = new DataTable();
            List<DataColumn> dataColumnList = new List<DataColumn>();
            List<DataRow> dataRowList = new List<DataRow>();

            for (int i = 0; i < 17; i++) { 
                dataColumnList.Add(new DataColumn());
                dataColumnList.ElementAt(i).DataType = System.Type.GetType("System.String");

                if (i == 0) {
                    dataColumnList.ElementAt(i).ColumnName = "Offset";
                } else if (i > 10) {
                    switch (i) { 
                        /* all the cases are shifted by 1 because of the offset. This word takes position 0 and shift every number after it by one */
                        case 11:
                            dataColumnList.ElementAt(i).ColumnName = "A";
                            break;
                        case 12:
                            dataColumnList.ElementAt(i).ColumnName = "B";
                            break;
                        case 13:
                            dataColumnList.ElementAt(i).ColumnName = "C";
                            break;
                        case 14:
                            dataColumnList.ElementAt(i).ColumnName = "D";
                            break;
                        case 15:
                            dataColumnList.ElementAt(i).ColumnName = "E";
                            break;
                        case 16:
                            dataColumnList.ElementAt(i).ColumnName = "F";
                            break;
                    }
                } else {
                    dataColumnList.ElementAt(i).ColumnName = (i-1).ToString();
                }
                
                table.Columns.Add(dataColumnList.ElementAt(i));
            }

            foreach(string[] hexaArray in allHexaArray)
                table.Rows.Add(hexaArray);

            dataGridView.DataSource = table;
            dataGridView.Columns[0].Width = 50;
        }

        private void tpFile_Click(object sender, EventArgs e) {

        }
    }
}
