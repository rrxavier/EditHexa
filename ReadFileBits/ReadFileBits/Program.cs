using System;
using System.Drawing;
using NUnit.Framework;

namespace ReadFileBits
{
    [TestFixture]
    class Program
    {
        [Test]
        static void Main(string[] args)
        {

            HexaEditModel _model = new HexaEditModel("C:\\Users\\durrenmatc_info\\Documents\\GitHub\\EditHexa\\TASKS.txt");

            // Hexa tests
            Assert.AreEqual(_model.Hexadecimal[0][1], "5A");
            Assert.AreEqual(_model.Hexadecimal[4][2], "73");

            // Ascii tests
            Assert.AreEqual(_model.GetAsciiDataTable().Rows[0].ItemArray[0], "Z");
            Assert.AreEqual(_model.GetAsciiDataTable().Rows[4].ItemArray[1], "s");

            // Binary tests
            Assert.AreEqual(_model.ConvertHexaToBinary(new Point(1, 0)), "1011010");
            Assert.AreEqual(_model.ConvertHexaToBinary(new Point(2, 4)), "1110011");

            // Octal tests
            Assert.AreEqual(_model.ConvertHexaToOctal(new Point(1, 0)), "132");
            Assert.AreEqual(_model.ConvertHexaToOctal(new Point(2, 4)), "163");

            // 8 bits signed tests
            Assert.AreEqual(_model.ConvertHexaTo8BitsSigned(new Point(1, 0)), "90");
            Assert.AreEqual(_model.ConvertHexaTo8BitsSigned(new Point(2, 4)), "115");

            // 8 bits unsigned tests
            Assert.AreEqual(_model.ConvertHexaTo8BitsUnsigned(new Point(1, 0)), "90");
            Assert.AreEqual(_model.ConvertHexaTo8BitsUnsigned(new Point(2, 4)), "115");

            // 16 bits signed tests
            Assert.AreEqual(_model.ConvertHexaTo16BitsSigned(new Point(1, 0)), "28506");
            Assert.AreEqual(_model.ConvertHexaTo16BitsSigned(new Point(2, 4)), "Données hors limite.");

            // 16 bits unsigned tests
            Assert.AreEqual(_model.ConvertHexaTo16BitsUnsigned(new Point(1, 0)), "28506");
            Assert.AreEqual(_model.ConvertHexaTo16BitsUnsigned(new Point(2, 4)), "Données hors limite.");

            // 32 bits signed tests
            Assert.AreEqual(_model.ConvertHexaTo32BitsSigned(new Point(1, 0)), "-1446809766");
            Assert.AreEqual(_model.ConvertHexaTo32BitsSigned(new Point(2, 4)), "Données hors limite.");

            // 32 bits unsigned tests
            Assert.AreEqual(_model.ConvertHexaTo32BitsUnsigned(new Point(1, 0)), "2848157530");
            Assert.AreEqual(_model.ConvertHexaTo32BitsUnsigned(new Point(2, 4)), "Données hors limite.");

            // 64 bits signed tests
            Assert.AreEqual(_model.ConvertHexaTo64BitsSigned(new Point(1, 0)), "5269275475985002330");
            Assert.AreEqual(_model.ConvertHexaTo64BitsSigned(new Point(2, 4)), "Données hors limite.");

            // Float tests
            Assert.AreEqual(_model.ConvertHexaToFloat(new Point(1, 0)), "-8.679056E-14");
            Assert.AreEqual(_model.ConvertHexaToFloat(new Point(2, 4)), "Données hors limite.");

            // Double tests
            Assert.AreEqual(_model.ConvertHexaToDouble(new Point(1, 0)), "1.80937775225281E+44");
            Assert.AreEqual(_model.ConvertHexaToDouble(new Point(2, 4)), "Données hors limite.");

            Console.WriteLine("TESTS COMPLETE WITH NO ERRORS !");

            Assert.AreEqual(_model.Hexadecimal[0][1], "5A");
            Assert.AreEqual(_model.GetAsciiDataTable().Rows[0].ItemArray[0], "Z");
            Assert.AreEqual(_model.ByteFile[0], Convert.ToByte('Z'));
            _model.ChangeValueHex(new Point(1, 0), "AA");
            Assert.AreEqual(_model.Hexadecimal[0][1], "AA");
            Assert.AreEqual(_model.GetAsciiDataTable().Rows[0].ItemArray[0], "ª");
            Assert.AreEqual(_model.ByteFile[0], Convert.ToByte('ª'));
            _model.ChangeValueAscii(new Point(1, 0), 'p');
            Assert.AreEqual(_model.Hexadecimal[0][1], "70");
            Assert.AreEqual(_model.GetAsciiDataTable().Rows[0].ItemArray[0], "p");
            Assert.AreEqual(_model.ByteFile[0], Convert.ToByte('p'));
            _model.UndoChange(new Point(1, 0));
            Assert.AreEqual(_model.Hexadecimal[0][1], "5A");
            Assert.AreEqual(_model.GetAsciiDataTable().Rows[0].ItemArray[0], "Z");
            Assert.AreEqual(_model.ByteFile[0], Convert.ToByte('Z'));

            Console.WriteLine("CHANGES COMPLETE WITH NO ERRORS !");
            Console.ReadLine();
        }
    }
}
