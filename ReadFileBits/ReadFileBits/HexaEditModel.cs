using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ReadFileBits
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

        public string[][] Hexadecimal
        {
            get
            {
                double rawDivision = Convert.ToDouble(ByteFile.Length) / Convert.ToDouble(16);
                int lineNb = (int)rawDivision + (rawDivision.ToString().Contains('.') ?  1 : 0);

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
                        //Console.WriteLine();
                    }
                    myArray[actualLine][modulo] = String.Format("{0:X2}", Convert.ToInt32(ByteFile[j]));
                    //Console.Write(String.Format("{0:X2}", Convert.ToInt32(ByteFile[j])));
                }

                return myArray;
            }
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

        /*public string ConvertHexaTo32BitsSigned(Point coords)
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

            if (this.Hexadecimal[coords4.X][coords4.Y] == null && coords4.X * 16 + coords4.Y > ByteFile.Length)
                return Convert.ToString(Convert.ToInt32(this.Hexadecimal[coords4.X][coords4.Y] + this.Hexadecimal[coords3.X][coords3.Y] + this.Hexadecimal[coords2.X][coords2.Y] + this.Hexadecimal[coords.X][coords.Y], 16)); //32bits = 8 hexadecimal digits
            else
                return "Données hors limite.";
        }*/
    }
}
