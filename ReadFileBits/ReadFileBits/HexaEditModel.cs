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
        DataTable _myAsciiDt;
        Dictionary<Point, string> _changes;
        FileData _myFileData;

        /// <summary>
        /// Main and only constructor.
        /// </summary>
        /// <param name="filePath">File path.</param>
        public HexaEditModel(string filePath)
        {
            this._filePath = filePath;
            this._byteFile = File.ReadAllBytes(_filePath);
            this._changes = new Dictionary<Point, string>();
            this._myFileData = new FileData(this._filePath);
        }

        /// <summary>
        /// File path.
        /// </summary>
        public string FilePath
        {
            get
            { return _filePath; }
        }

        /// <summary>
        /// Bytes of each individual char in the file.
        /// </summary>
        public byte[] ByteFile
        {
            get
            { return _byteFile; }
        }

        /// <summary>
        /// The ByteFile Array converted to Hexadecimal.
        /// </summary>
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

        /// <summary>
        /// The object that contains all file metadata.
        /// </summary>
        public FileData MyFileData
        {
            get { return this._myFileData; }
        }

        /// <summary>
        /// Returns the Hexadecimal Array in a datatable.
        /// </summary>
        /// <returns></returns>
        public DataTable GetHexaDataTable()
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

        /// <summary>
        /// Returns a page of the Hexadecimal Array.
        /// </summary>
        /// <param name="startingRow">Starting row.</param>
        /// <param name="nbRows">Number of rows to take.</param>
        /// <returns></returns>
        public DataTable GetHexaDataTable(int startingRow, int nbRows)
        {
            IEnumerable<DataRow> rows = this.GetHexaDataTable().AsEnumerable().Skip(startingRow).Take(nbRows);
            return rows.CopyToDataTable();
        }

        /// <summary>
        /// Returns the Hexadecimal Array in a datatable.
        /// </summary>
        /// <returns></returns>
        public DataTable GetAsciiDataTable()
        {
            if (_myAsciiDt == null)
            {
                DataTable dt = new DataTable();

                for (int i = 0; i < 16; i++)
                    dt.Columns.Add(new DataColumn());

                foreach (string[] line in this.Hexadecimal)
                {
                    object[] convertedLine = new object[16];
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != null && !(line[i].Length > 2))
                            convertedLine[i - 1] = Convert.ToChar(Convert.ToUInt32(line[i], 16));
                    }
                    dt.Rows.Add(convertedLine);
                }
                _myAsciiDt = dt;
            }
            return _myAsciiDt;
        }

        /// <summary>
        /// Returns a page of the Hexadecimal Array.
        /// </summary>
        /// <param name="startingRow">Starting row.</param>
        /// <param name="nbRows">Number of rows to take.</param>
        /// <returns></returns>
        public DataTable GetAsciiDataTable(int startingRow, int nbRows)
        {
            IEnumerable<DataRow> rows = this.GetAsciiDataTable().AsEnumerable().Skip(startingRow).Take(nbRows);
            return rows.CopyToDataTable();
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to binary.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaToBinary(Point coords)
        {
            return Convert.ToString(Convert.ToInt32(this.Hexadecimal[coords.Y][coords.X], 16), 2);
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to decimal.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaToDecimal(Point coords)
        {
            return Convert.ToInt32(this.Hexadecimal[coords.Y][coords.X], 16).ToString();
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to octal.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaToOctal(Point coords)
        {
            return Convert.ToString(Convert.ToInt32(this.Hexadecimal[coords.Y][coords.X], 16), 8);
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to 8 bits signed.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaTo8BitsSigned(Point coords)
        {
            return Convert.ToString(Convert.ToSByte(this.Hexadecimal[coords.Y][coords.X], 16)); // 8bits = 2 hexadecimal digits
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to 8 bits unsigned.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaTo8BitsUnsigned(Point coords)
        {
            return Convert.ToString(Convert.ToByte(this.Hexadecimal[coords.Y][coords.X], 16)); // 8bits = 2 hexadecimal digits
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to 16 bits signed.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaTo16BitsSigned(Point coords)
        {
            Point coords2;

            coords2 = GetNewCoords(coords);

            if (this.Hexadecimal[coords2.Y][coords2.X] != null && coords2.Y * 16 + coords2.X < ByteFile.Length)
                return Convert.ToString(Convert.ToInt16(this.Hexadecimal[coords2.Y][coords2.X] + this.Hexadecimal[coords.Y][coords.X], 16)); // 16bits = 4 hexadecimal digits
            else
                return "Données hors limite.";
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to 16 bits unsigned.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaTo16BitsUnsigned(Point coords)
        {
            Point coords2;

            coords2 = GetNewCoords(coords);

            if (this.Hexadecimal[coords2.Y][coords2.X] != null && coords2.Y * 16 + coords2.X < ByteFile.Length)
                return Convert.ToString(Convert.ToUInt16(this.Hexadecimal[coords2.Y][coords2.X] + this.Hexadecimal[coords.Y][coords.X], 16)); // 16bits = 4 hexadecimal digits
            else
                return "Données hors limite.";
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to 32 bits signed.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaTo32BitsSigned(Point coords)
        {
            Point coords2;
            Point coords3;
            Point coords4;

            coords2 = GetNewCoords(coords);
            coords3 = GetNewCoords(coords2);
            coords4 = GetNewCoords(coords3);

            if (this.Hexadecimal[coords4.Y][coords4.X] != null && coords4.Y * 16 + coords4.X < ByteFile.Length)
                return Convert.ToString(Convert.ToInt32(this.Hexadecimal[coords4.Y][coords4.X] + this.Hexadecimal[coords3.Y][coords3.X] + this.Hexadecimal[coords2.Y][coords2.X] + this.Hexadecimal[coords.Y][coords.X], 16)); //32bits = 8 hexadecimal digits
            else
                return "Données hors limite.";
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to 32 bits unsigned.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaTo32BitsUnsigned(Point coords)
        {
            Point coords2;
            Point coords3;
            Point coords4;

            coords2 = GetNewCoords(coords);
            coords3 = GetNewCoords(coords2);
            coords4 = GetNewCoords(coords3);

            if (this.Hexadecimal[coords4.Y][coords4.X] != null && coords4.Y * 16 + coords4.X < ByteFile.Length)
                return Convert.ToString(Convert.ToUInt32(this.Hexadecimal[coords4.Y][coords4.X] + this.Hexadecimal[coords3.Y][coords3.X] + this.Hexadecimal[coords2.Y][coords2.X] + this.Hexadecimal[coords.Y][coords.X], 16)); //32bits = 8 hexadecimal digits
            else
                return "Données hors limite.";
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to 64 bits signed.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaTo64BitsSigned(Point coords)
        {
            Point coords2;
            Point coords3;
            Point coords4;
            Point coords5;
            Point coords6;
            Point coords7;
            Point coords8;

            coords2 = GetNewCoords(coords);
            coords3 = GetNewCoords(coords2);
            coords4 = GetNewCoords(coords3);
            coords5 = GetNewCoords(coords4);
            coords6 = GetNewCoords(coords5);
            coords7 = GetNewCoords(coords6);
            coords8 = GetNewCoords(coords7);

            if (this.Hexadecimal[coords8.Y][coords8.X] != null && coords8.Y * 16 + coords8.X < ByteFile.Length)
                return Convert.ToString(Convert.ToInt64(this.Hexadecimal[coords8.Y][coords8.X] +
                    this.Hexadecimal[coords7.Y][coords7.X] +
                    this.Hexadecimal[coords6.Y][coords6.X] +
                    this.Hexadecimal[coords5.Y][coords5.X] +
                    this.Hexadecimal[coords4.Y][coords4.X] +
                    this.Hexadecimal[coords3.Y][coords3.X] +
                    this.Hexadecimal[coords2.Y][coords2.X] +
                    this.Hexadecimal[coords.Y][coords.X], 16)); //32bits = 8 hexadecimal digits
            else
                return "Données hors limite.";
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to Float.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaToFloat(Point coords)
        {
            Point coords2;
            Point coords3;
            Point coords4;

            coords2 = GetNewCoords(coords);
            coords3 = GetNewCoords(coords2);
            coords4 = GetNewCoords(coords3);

            if (this.Hexadecimal[coords4.Y][coords4.X] != null && coords4.Y * 16 + coords4.X < ByteFile.Length)
                return Convert.ToString(BitConverter.ToSingle(BitConverter.GetBytes(uint.Parse(this.Hexadecimal[coords4.Y][coords4.X] + this.Hexadecimal[coords3.Y][coords3.X] + this.Hexadecimal[coords2.Y][coords2.X] + this.Hexadecimal[coords.Y][coords.X], System.Globalization.NumberStyles.AllowHexSpecifier)), 0)); //32bits = 8 hexadecimal digits
            else
                return "Données hors limite.";
        }

        /// <summary>
        /// Converts the chosen Hexadecimal to Double.
        /// </summary>
        /// <param name="coords">Coords of the first point.</param>
        /// <returns></returns>
        public string ConvertHexaToDouble(Point coords)
        {
            Point coords2;
            Point coords3;
            Point coords4;
            Point coords5;
            Point coords6;
            Point coords7;
            Point coords8;

            coords2 = GetNewCoords(coords);
            coords3 = GetNewCoords(coords2);
            coords4 = GetNewCoords(coords3);
            coords5 = GetNewCoords(coords4);
            coords6 = GetNewCoords(coords5);
            coords7 = GetNewCoords(coords6);
            coords8 = GetNewCoords(coords7);

            if (this.Hexadecimal[coords8.Y][coords8.X] != null && coords8.Y * 16 + coords8.X < ByteFile.Length)
                return Convert.ToString(BitConverter.ToDouble(BitConverter.GetBytes(Convert.ToInt64(this.Hexadecimal[coords8.Y][coords8.X] +
                    this.Hexadecimal[coords7.Y][coords7.X] +
                    this.Hexadecimal[coords6.Y][coords6.X] +
                    this.Hexadecimal[coords5.Y][coords5.X] +
                    this.Hexadecimal[coords4.Y][coords4.X] +
                    this.Hexadecimal[coords3.Y][coords3.X] +
                    this.Hexadecimal[coords2.Y][coords2.X] +
                    this.Hexadecimal[coords.Y][coords.X], 16)), 0)); // 64bits = 8 hexadecimal digits
            else
                return "Données hors limite.";
        }

        /// <summary>
        /// Return the next point after the "previousPoint".
        /// </summary>
        /// <param name="previousPoint">Starting point.</param>
        /// <returns>Next point.</returns>
        private static Point GetNewCoords(Point previousPoint)
        {
            if (previousPoint.X + 1 > 15)
                return new Point(1, previousPoint.Y + 1);
            else
                return new Point(previousPoint.X + 1, previousPoint.Y);
        }

        /// <summary>
        /// Change the value of a point
        /// </summary>
        /// <param name="selectedPoint">Point has changed</param>
        /// <param name="newValue">The new value (hexadecimal)</param>
        public void ChangeValueHex(Point selectedPoint, string newValue)
        {
            if (selectedPoint.X >= 1) //Offset
                if (newValue != Hexadecimal[selectedPoint.Y][selectedPoint.X])
                {
                    if (!_changes.ContainsKey(selectedPoint))
                        _changes.Add(selectedPoint, Hexadecimal[selectedPoint.Y][selectedPoint.X]);
                    Hexadecimal[selectedPoint.Y][selectedPoint.X] = newValue; //Pas de "-1" car il contient l'offset
                    _myDt.Rows[selectedPoint.Y][selectedPoint.X] = newValue; //Pas de "-1" car il contient l'offset
                    _myAsciiDt.Rows[selectedPoint.Y][selectedPoint.X - 1] = Convert.ToChar(Convert.ToUInt32(newValue, 16));
                    _byteFile[selectedPoint.Y * 16 + selectedPoint.X - 1] = Convert.ToByte(Convert.ToChar(Convert.ToUInt32(newValue, 16)));
                }
        }

        /// <summary>
        /// Change the value of a point
        /// </summary>
        /// <param name="selectedPoint">Point has changed</param>
        /// <param name="newValue">The new value (ascii)</param>
        public void ChangeValueAscii(Point selectedPoint, char newValue)
        {
            if (selectedPoint.X >= 1) //Offset
                if (newValue.ToString() != _myAsciiDt.Rows[selectedPoint.Y].ItemArray[selectedPoint.X].ToString())
                {
                    if (!_changes.ContainsKey(selectedPoint))
                        _changes.Add(selectedPoint, Hexadecimal[selectedPoint.Y][selectedPoint.X]);
                    _myAsciiDt.Rows[selectedPoint.Y][selectedPoint.X] = newValue;
                    Hexadecimal[selectedPoint.Y][selectedPoint.X + 1] = String.Format("{0:X}", Convert.ToInt32(newValue)); //Pas de "-1" car il contient l'offset
                    _myDt.Rows[selectedPoint.Y][selectedPoint.X + 1] = String.Format("{0:X}", Convert.ToInt32(newValue)); //Pas de "-1" car il contient l'offset
                    _byteFile[selectedPoint.Y * 16 + selectedPoint.X] = Convert.ToByte(newValue);
                }
        }

        /// <summary>
        /// Returns to the state before the changes
        /// </summary>
        /// <param name="selectedPoint">Point changed</param>
        public void UndoChange(Point selectedPoint)
        {
            if (selectedPoint.X >= 1) //Offset
                if (_changes.ContainsKey(selectedPoint))
                {
                    Hexadecimal[selectedPoint.Y][selectedPoint.X] = _changes[selectedPoint]; //Pas de "-1" car il contient l'offset
                    _myDt.Rows[selectedPoint.Y][selectedPoint.X] = _changes[selectedPoint]; //Pas de "-1" car il contient l'offset
                    _myAsciiDt.Rows[selectedPoint.Y][selectedPoint.X - 1] = Convert.ToChar(Convert.ToUInt32(_changes[selectedPoint], 16));
                    _byteFile[selectedPoint.Y * 16 + selectedPoint.X - 1] = Convert.ToByte(Convert.ToChar(Convert.ToUInt32(_changes[selectedPoint], 16)));
                    _changes.Remove(selectedPoint);
                }
        }

        public class FileData
        {
            #region Variables

            private FileInfo _fileInfo;
            private string _name;
            private DateTime _creationTime;
            private DateTime _lastWriteTime;
            private DateTime _lastAccessTime;
            private string _shortName;
            private string _attributes;
            private long _fileSize;

            #endregion

            #region Properties

            /// <summary>
            /// File name without
            /// </summary>
            public string Name
            {
                get
                {
                    return _name;
                }
            }

            /// <summary>
            /// File's creation date.
            /// </summary>
            public DateTime CreationTime
            {
                get
                {
                    return _creationTime;
                }
            }

            /// <summary>
            /// Last time the file has been modified.
            /// </summary>
            public DateTime LastWriteTime
            {
                get
                {
                    return _lastWriteTime;
                }
            }

            /// <summary>
            /// Last time the fils has been accessed.
            /// </summary>
            public DateTime LastAccessTime
            {
                get
                {
                    return _lastAccessTime;
                }
            }

            /// <summary>
            /// File attributes.
            /// </summary>
            public string Attributs
            {
                get
                {
                    return _attributes;
                }
            }

            /// <summary>
            /// File size. 
            /// </summary>
            public long FileSize
            {
                get
                {
                    return _fileSize;
                }
            }

            /// <summary>
            /// File name in DOS.
            /// </summary>
            public string ShortName
            {
                get { return _shortName; }
            }

            #endregion

            #region Methods

            /// <summary>
            /// Constructeur de l'object.
            /// </summary>
            /// <param name="filePath">Chemin d'accès au fichier.</param>
            public FileData(string filePath)
            {
                _fileInfo = new FileInfo(filePath);
                _name = _fileInfo.Name;
                int tmpHoursToAdd = TimeZoneInfo.Local.BaseUtcOffset.Hours;
                _creationTime = _fileInfo.CreationTimeUtc.AddHours(tmpHoursToAdd);
                _lastWriteTime = _fileInfo.LastWriteTimeUtc.AddHours(tmpHoursToAdd);
                _lastAccessTime = _fileInfo.LastAccessTimeUtc.AddHours(tmpHoursToAdd);
                _attributes = GetLetterOfAttributs(_fileInfo.Attributes.ToString().Split(','));
                _fileSize = _fileInfo.Length;
                _shortName = ConvertToDOSFileName(this._name).ToUpper();
            }

            /// <summary>
            /// Racourcis le nom du fichier s'il est trop court.
            /// </summary>
            /// <param name="myStr"></param>
            /// <returns></returns>
            private static string ConvertToDOSFileName(string myStr)
            {
                string[] tempStr = myStr.Split('.');
                if (tempStr[0].Length > 7)
                    return tempStr[0].Substring(0, 6) + "~1." + tempStr[1];
                return myStr;
            }

            /// <summary>
            /// Récupère les lettres correspondants à l'attribut du fichier.
            /// </summary>
            /// <param name="listAttributs"></param>
            /// <returns>Les lettres correspondants à l'attribut du fichier.</returns>
            private static string GetLetterOfAttributs(string[] listAttributs)
            {
                string returnValue = "";
                string temp;
                foreach (string item in listAttributs)
                {
                    temp = item.Trim();
                    if (temp == "NotContentIndexed")
                        returnValue += "NCI ";
                    else if (temp == "SparseFile")
                        returnValue += "SF ";
                    else if (temp == "ReparsePoint")
                        returnValue += "RP ";
                    else
                        returnValue += temp[0] + " ";
                }
                return returnValue;
            }

            #endregion
        }
    }
}