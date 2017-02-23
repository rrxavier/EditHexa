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

        public string[][] Hexadecimal
        {
            get
            {
                double rawDivision = Convert.ToDouble(ByteFile.Length) / Convert.ToDouble(15);
                int lineNb = Convert.ToInt32(rawDivision + (rawDivision.ToString().Contains('.') ? 1 : 0));

                string[][] myArray = new string[lineNb][];

                int actualLine = -1;
                for (int i = 0; i < ByteFile.Length; i++)
                {
                    int modulo = i % 16;
                    if (modulo == 0)
                    {
                        actualLine++;
                        myArray[actualLine] = new string[16];
                        //Console.WriteLine();
                    }
                    myArray[actualLine][modulo] = String.Format("{0:X2}", Convert.ToInt32(ByteFile[i]));
                    //Console.Write(String.Format("{0:X2}", Convert.ToInt32(ByteFile[i])));
                }

                /*foreach (string[] line in myArray)
                {
                    foreach (string item in line)
                    {
                        Console.Write(item);
                    }
                    Console.Write(Environment.NewLine);
                }*/

                return myArray;
            }
        }
    }
}
