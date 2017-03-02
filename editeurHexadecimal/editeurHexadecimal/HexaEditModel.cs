using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace editeurHexadecimal
{
    class HexaEditModel
    {
        string _filePath;
        byte[] _byteFile;

        public HexaEditModel(string filePath)
        {
            this._filePath = filePath;
            this._byteFile = File.ReadAllBytes(_filePath);
        }

        public string FilePath
        {
            get
            { return _filePath; }
        }

        public byte[] ByteFile
        {
            get
            { return _byteFile; }
        }

        public DataTable Hexadecimal {
            get {
                DataTable table = new DataTable();
                List<DataColumn> dataColumnList = new List<DataColumn>();

                //create columns
                for (int i = 0; i < 17; i++) {
                    dataColumnList.Add(new DataColumn());
                    dataColumnList.ElementAt(i).DataType = System.Type.GetType("System.String");

                    if (i == 0) {
                        dataColumnList.ElementAt(i).ColumnName = "Offset";
                    } else if (i > 10) {
                        switch (i) {
                            // all the cases are shifted by 1 because of the offset. This word takes position 0 and shift every number after it by one 
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
                        dataColumnList.ElementAt(i).ColumnName = (i - 1).ToString();
                    }

                    table.Columns.Add(dataColumnList.ElementAt(i));
                }

                double rawDivision = Convert.ToDouble(ByteFile.Length) / Convert.ToDouble(16);
                int lineNb = (int)rawDivision + (rawDivision.ToString().Contains('.') ? 1 : 0);

                string[] currentLine = new string[17];
                int modulo;
                int actualLine = -1;

                for (int i = 0, j = 0; i < ByteFile.Length + lineNb; i++, j++) { // + lineNb because i is also incremented in the loop (lineNb times) -> Would it be clearer to test j instead of i?
                    modulo = i % 17;
                    if (modulo == 0 && i != 0) { //new line
                        actualLine++;
                        table.Rows.Add(currentLine);
                        currentLine = new string[17];
                        currentLine[0] = String.Format("{0:X5}0", actualLine); //offset

                        // increment int so the modulo changes and the condition isn't met again
                        i++;
                        modulo = i % 17;
                    } else if (modulo == 0 && i == 0) { //first line of the file
                        actualLine++;
                        currentLine[0] = String.Format("{0:X5}0", actualLine); //offset

                        // increment int so the modulo changes and the condition isn't met again
                        i++;
                        modulo = i % 17;
                    }
                    currentLine[modulo] = String.Format("{0:X2}", Convert.ToInt32(ByteFile[j])); //Hexadecimal representation of this byte
                }

                table.Rows.Add(currentLine); 
                return table;
            }
        }
    }
}
