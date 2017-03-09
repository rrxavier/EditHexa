using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;

namespace ReadFileBits
{
    class HexaEditModel
    {
        string _filePath;
        byte[] _byteFile;
        string[][] _hexaArray;
        DataTable _myDt;

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

        public string[][] Hexadecimal
        {
            get
            {
                if (_hexaArray == null)
                {
                    double rawDivision = Convert.ToDouble(ByteFile.Length) / Convert.ToDouble(16);
                    int lineNb = (int)rawDivision + (rawDivision.ToString().Contains('.') ? 1 : 0);

                    string[][] myArray = new string[lineNb][];

                    int actualLine = -1;

                    for (int i = 0, j = 0; i < ByteFile.Length + lineNb; i++, j++)
                    {
                        int modulo = i % 17;
                        if (modulo == 0)
                        {
                            actualLine++;
                            myArray[actualLine] = new string[17];
                            myArray[actualLine][0] = String.Format("{0:X5}0", actualLine);
                            i++;
                            modulo = i % 17;
                        }
                        myArray[actualLine][modulo] = String.Format("{0:X2}", Convert.ToInt32(ByteFile[j]));
                    }

                    _hexaArray = myArray;
                }

                return _hexaArray;
            }
        }

        public DataTable GetDataTable()
        {
            if (_myDt == null)
            {
                DataTable dt = new DataTable();

                // Create columns
                for (int i = 0; i < 17; i++)
                {
                    DataColumn dc = new DataColumn();
                    dc.DataType = System.Type.GetType("System.String");

                    if (i == 0)
                        dc.ColumnName = "Offset";
                    else
                        dc.ColumnName = (i - 1).ToString();

                    dt.Columns.Add(dc);
                }

                foreach (string[] line in this.Hexadecimal)
                    dt.Rows.Add(line);

                _myDt = dt;
            }

            return _myDt;
        }

        public DataTable GetDataTable(int startingRow, int nbRows)
        {
            IEnumerable<DataRow> rows = this.GetDataTable().AsEnumerable().Skip(startingRow - 1).Take(nbRows);
            return rows.CopyToDataTable();
        }

        public string ConvertHexaToBinary(Point coords)
        {
            return Convert.ToString(Convert.ToInt32(this.Hexadecimal[coords.X][coords.Y], 16), 2);
        }

        public string ConvertHexaToDecimal(Point coords)
        {
            return Convert.ToInt32(this.Hexadecimal[coords.X][coords.Y], 16).ToString();
        }

        public string ConvertHexaToOctal(Point coords)
        {
            return Convert.ToString(Convert.ToInt32(this.Hexadecimal[coords.X][coords.Y], 16), 8);
        }

        public string ConvertHexaTo8BitsSigned(Point coords)
        {
            return Convert.ToString(Convert.ToSByte(this.Hexadecimal[coords.X][coords.Y], 16)); // 8bits = 2 hexadecimal digits
        }

        public string ConvertHexaTo8BitsUnsigned(Point coords)
        {
            return Convert.ToString(Convert.ToByte(this.Hexadecimal[coords.X][coords.Y], 16)); // 8bits = 2 hexadecimal digits
        }

        public string ConvertHexaTo16BitsSigned(Point coords)
        {
            Point coords2;

            // If it is at the end of the line.
            if (coords.Y + 1 > 15)
                coords2 = new Point(coords.X + 1, 0);
            else
                coords2 = new Point(coords.X, coords.Y + 1);

            if (this.Hexadecimal[coords2.X][coords2.Y] != null && coords2.X * 16 + coords2.Y < ByteFile.Length)
                return Convert.ToString(Convert.ToInt16(this.Hexadecimal[coords2.X][coords2.Y] + this.Hexadecimal[coords.X][coords.Y], 16)); // 16bits = 4 hexadecimal digits
            else
                return "Données hors limite.";
        }

        public string ConvertHexaTo16BitsUnsigned(Point coords)
        {
            Point coords2;

            // If it is at the end of the line.
            if (coords.Y + 1 > 15)
                coords2 = new Point(coords.X + 1, 0);
            else
                coords2 = new Point(coords.X, coords.Y + 1);

            if (this.Hexadecimal[coords2.X][coords2.Y] != null && coords2.X * 16 + coords2.Y < ByteFile.Length)
                return Convert.ToString(Convert.ToUInt16(this.Hexadecimal[coords2.X][coords2.Y] + this.Hexadecimal[coords.X][coords.Y], 16)); // 16bits = 4 hexadecimal digits
            else
                return "Données hors limite.";
        }

        public string ConvertHexaTo32BitsSigned(Point coords)
        {
            Point coords2;
            Point coords3;
            Point coords4;


            // If it is at the end of the line.
            if (coords.Y + 1 > 15)
                coords2 = new Point(coords.X + 1, 0);
            else
                coords2 = new Point(coords.X, coords.Y + 1);

            if (this.Hexadecimal[coords2.X][coords2.Y] == null && coords2.X * 16 + coords2.Y > ByteFile.Length)
                return "Données hors limite.";


            // If it is at the end of the line.
            if (coords2.Y + 1 > 15)
                coords3 = new Point(coords2.X + 1, 0);
            else
                coords3 = new Point(coords2.X, coords2.Y + 1);

            if (this.Hexadecimal[coords3.X][coords3.Y] == null && coords3.X * 16 + coords3.Y > ByteFile.Length)
                return "Données hors limite.";

            // If it is at the end of the line.
            if (coords3.Y + 1 > 15)
                coords4 = new Point(coords3.X + 1, 0);
            else
                coords4 = new Point(coords3.X, coords3.Y + 1);

            if (this.Hexadecimal[coords4.X][coords4.Y] != null && coords4.X * 16 + coords4.Y < ByteFile.Length)
                return Convert.ToString(Convert.ToInt32(this.Hexadecimal[coords4.X][coords4.Y] + this.Hexadecimal[coords3.X][coords3.Y] + this.Hexadecimal[coords2.X][coords2.Y] + this.Hexadecimal[coords.X][coords.Y], 16)); //32bits = 8 hexadecimal digits
            else
                return "Données hors limite.";
        }

        public string ConvertHexaTo32BitsUnsigned(Point coords)
        {
            Point coords2;
            Point coords3;
            Point coords4;


            // If it is at the end of the line.
            if (coords.Y + 1 > 15)
                coords2 = new Point(coords.X + 1, 0);
            else
                coords2 = new Point(coords.X, coords.Y + 1);

            if (this.Hexadecimal[coords2.X][coords2.Y] == null && coords2.X * 16 + coords2.Y > ByteFile.Length)
                return "Données hors limite.";


            // If it is at the end of the line.
            if (coords2.Y + 1 > 15)
                coords3 = new Point(coords2.X + 1, 0);
            else
                coords3 = new Point(coords2.X, coords2.Y + 1);

            if (this.Hexadecimal[coords3.X][coords3.Y] == null && coords3.X * 16 + coords3.Y > ByteFile.Length)
                return "Données hors limite.";

            // If it is at the end of the line.
            if (coords3.Y + 1 > 15)
                coords4 = new Point(coords3.X + 1, 0);
            else
                coords4 = new Point(coords3.X, coords3.Y + 1);

            if (this.Hexadecimal[coords4.X][coords4.Y] != null && coords4.X * 16 + coords4.Y < ByteFile.Length)
                return Convert.ToString(Convert.ToUInt32(this.Hexadecimal[coords4.X][coords4.Y] + this.Hexadecimal[coords3.X][coords3.Y] + this.Hexadecimal[coords2.X][coords2.Y] + this.Hexadecimal[coords.X][coords.Y], 16)); //32bits = 8 hexadecimal digits
            else
                return "Données hors limite.";
        }

        public string ConvertHexaTo64BitsSigned(Point coords)
        {
            Point coords2;
            Point coords3;
            Point coords4;
            Point coords5;
            Point coords6;
            Point coords7;
            Point coords8;


            // If it is at the end of the line.
            if (coords.Y + 1 > 15)
                coords2 = new Point(coords.X + 1, 0);
            else
                coords2 = new Point(coords.X, coords.Y + 1);

            if (this.Hexadecimal[coords2.X][coords2.Y] == null && coords2.X * 16 + coords2.Y > ByteFile.Length)
                return "Données hors limite.";


            // If it is at the end of the line.
            if (coords2.Y + 1 > 15)
                coords3 = new Point(coords2.X + 1, 0);
            else
                coords3 = new Point(coords2.X, coords2.Y + 1);

            if (this.Hexadecimal[coords3.X][coords3.Y] == null && coords3.X * 16 + coords3.Y > ByteFile.Length)
                return "Données hors limite.";

            // If it is at the end of the line.
            if (coords3.Y + 1 > 15)
                coords4 = new Point(coords3.X + 1, 0);
            else
                coords4 = new Point(coords3.X, coords3.Y + 1);

            // If it is at the end of the line.
            if (coords4.Y + 1 > 15)
                coords5 = new Point(coords4.X + 1, 0);
            else
                coords5 = new Point(coords4.X, coords4.Y + 1);

            // If it is at the end of the line.
            if (coords5.Y + 1 > 15)
                coords6 = new Point(coords5.X + 1, 0);
            else
                coords6 = new Point(coords5.X, coords5.Y + 1);

            // If it is at the end of the line.
            if (coords6.Y + 1 > 15)
                coords7 = new Point(coords6.X + 1, 0);
            else
                coords7 = new Point(coords6.X, coords6.Y + 1);

            // If it is at the end of the line.
            if (coords7.Y + 1 > 15)
                coords8 = new Point(coords7.X + 1, 0);
            else
                coords8 = new Point(coords7.X, coords7.Y + 1);

            if (this.Hexadecimal[coords8.X][coords8.Y] != null && coords8.X * 16 + coords8.Y < ByteFile.Length)
                return Convert.ToString(Convert.ToInt64(this.Hexadecimal[coords8.X][coords8.Y] +
                    this.Hexadecimal[coords7.X][coords7.Y] +
                    this.Hexadecimal[coords6.X][coords6.Y] +
                    this.Hexadecimal[coords5.X][coords5.Y] +
                    this.Hexadecimal[coords4.X][coords4.Y] +
                    this.Hexadecimal[coords3.X][coords3.Y] +
                    this.Hexadecimal[coords2.X][coords2.Y] +
                    this.Hexadecimal[coords.X][coords.Y], 16)); //32bits = 8 hexadecimal digits
            else
                return "Données hors limite.";
        }

        public string ConvertHexaToFloat(Point coords)
        {
            Point coords2;
            Point coords3;
            Point coords4;


            // If it is at the end of the line.
            if (coords.Y + 1 > 15)
                coords2 = new Point(coords.X + 1, 0);
            else
                coords2 = new Point(coords.X, coords.Y + 1);

            if (this.Hexadecimal[coords2.X][coords2.Y] == null && coords2.X * 16 + coords2.Y > ByteFile.Length)
                return "Données hors limite.";


            // If it is at the end of the line.
            if (coords2.Y + 1 > 15)
                coords3 = new Point(coords2.X + 1, 0);
            else
                coords3 = new Point(coords2.X, coords2.Y + 1);

            if (this.Hexadecimal[coords3.X][coords3.Y] == null && coords3.X * 16 + coords3.Y > ByteFile.Length)
                return "Données hors limite.";

            // If it is at the end of the line.
            if (coords3.Y + 1 > 15)
                coords4 = new Point(coords3.X + 1, 0);
            else
                coords4 = new Point(coords3.X, coords3.Y + 1);

            if (this.Hexadecimal[coords4.X][coords4.Y] != null && coords4.X * 16 + coords4.Y < ByteFile.Length)
                return Convert.ToString(BitConverter.ToSingle(BitConverter.GetBytes(uint.Parse(this.Hexadecimal[coords4.X][coords4.Y] + this.Hexadecimal[coords3.X][coords3.Y] + this.Hexadecimal[coords2.X][coords2.Y] + this.Hexadecimal[coords.X][coords.Y], System.Globalization.NumberStyles.AllowHexSpecifier)), 0)); //32bits = 8 hexadecimal digits
            else
                return "Données hors limite.";
        }

        public string ConvertHexaToDouble(Point coords)
        {
            Point coords2;
            Point coords3;
            Point coords4;
            Point coords5;
            Point coords6;
            Point coords7;
            Point coords8;


            // If it is at the end of the line.
            if (coords.Y + 1 > 15)
                coords2 = new Point(coords.X + 1, 0);
            else
                coords2 = new Point(coords.X, coords.Y + 1);

            if (this.Hexadecimal[coords2.X][coords2.Y] == null && coords2.X * 16 + coords2.Y > ByteFile.Length)
                return "Données hors limite.";


            // If it is at the end of the line.
            if (coords2.Y + 1 > 15)
                coords3 = new Point(coords2.X + 1, 0);
            else
                coords3 = new Point(coords2.X, coords2.Y + 1);

            if (this.Hexadecimal[coords3.X][coords3.Y] == null && coords3.X * 16 + coords3.Y > ByteFile.Length)
                return "Données hors limite.";

            // If it is at the end of the line.
            if (coords3.Y + 1 > 15)
                coords4 = new Point(coords3.X + 1, 0);
            else
                coords4 = new Point(coords3.X, coords3.Y + 1);

            // If it is at the end of the line.
            if (coords4.Y + 1 > 15)
                coords5 = new Point(coords4.X + 1, 0);
            else
                coords5 = new Point(coords4.X, coords4.Y + 1);

            // If it is at the end of the line.
            if (coords5.Y + 1 > 15)
                coords6 = new Point(coords5.X + 1, 0);
            else
                coords6 = new Point(coords5.X, coords5.Y + 1);

            // If it is at the end of the line.
            if (coords6.Y + 1 > 15)
                coords7 = new Point(coords6.X + 1, 0);
            else
                coords7 = new Point(coords6.X, coords6.Y + 1);

            // If it is at the end of the line.
            if (coords7.Y + 1 > 15)
                coords8 = new Point(coords7.X + 1, 0);
            else
                coords8 = new Point(coords7.X, coords7.Y + 1);

            if (this.Hexadecimal[coords8.X][coords8.Y] != null && coords8.X * 16 + coords8.Y < ByteFile.Length)
                return Convert.ToString(BitConverter.ToDouble(BitConverter.GetBytes(Convert.ToInt64(this.Hexadecimal[coords8.X][coords8.Y] +
                    this.Hexadecimal[coords7.X][coords7.Y] +
                    this.Hexadecimal[coords6.X][coords6.Y] +
                    this.Hexadecimal[coords5.X][coords5.Y] +
                    this.Hexadecimal[coords4.X][coords4.Y] +
                    this.Hexadecimal[coords3.X][coords3.Y] +
                    this.Hexadecimal[coords2.X][coords2.Y] +
                    this.Hexadecimal[coords.X][coords.Y], 16)), 0)); //32bits = 8 hexadecimal digits
            else
                return "Données hors limite.";
        }

        private static class ModelUtilities
        {
            /*if (coords.Y + 1 > 15)
                coords2 = new Point(coords.X + 1, 0);
            else
                coords2 = new Point(coords.X, coords.Y + 1);

            if (this.Hexadecimal[coords2.X][coords2.Y] != null && coords2.X* 16 + coords2.Y<ByteFile.Length)
                return Convert.ToString(Convert.ToInt16(this.Hexadecimal[coords2.X][coords2.Y] + this.Hexadecimal[coords.X][coords.Y], 16)); // 16bits = 4 hexadecimal digits
            else
                return "Données hors limite.";*/

            private static Point SetNewCoords(Point previousPoint)
            {

                if (previousPoint.Y + 1 > 15)
                    return new Point(previousPoint.X + 1, 0);
                else
                    return new Point(previousPoint.X, previousPoint.Y + 1);
            }

            /// <summary>
            /// Retourne le string de conversion À FINIR
            /// </summary>
            /// <param name="model"></param>
            /// <param name="points"></param>
            /// <returns></returns>
            private static string ReturnConversionString(HexaEditModel model, params Point[] points)
            {
                if (model.Hexadecimal[points[points.Length - 1].X][points[points.Length - 1].Y] != null && points[points.Length - 1].X * 16 + points[points.Length - 1].Y < model.ByteFile.Length)
                {
                }

                return "LEL";
            }
        }
    }
}
