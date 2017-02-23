using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string[][] Hexadecimal {
            get {
                double rawDivision = Convert.ToDouble(ByteFile.Length) / Convert.ToDouble(16);
                int lineNb = (int)rawDivision + (rawDivision.ToString().Contains('.') ? 1 : 0);

                string[][] myArray = new string[lineNb][];

                int actualLine = -1;

                for (int i = 0, j = 0; i < ByteFile.Length + lineNb; i++, j++) {
                    int modulo = i % 17;
                    if (modulo == 0) {
                        actualLine++;
                        myArray[actualLine] = new string[17];
                        myArray[actualLine][0] = String.Format("{0:X5}0", actualLine);
                        i++;
                        modulo = i % 17;
                    }
                    myArray[actualLine][modulo] = String.Format("{0:X2}", Convert.ToInt32(ByteFile[j]));
                }

                return myArray;
            }
        }
    }
}
