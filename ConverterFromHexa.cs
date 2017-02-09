using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConversionHexadecimal_Others
{
    public static class ConvertFromHexa
    {
        /// <summary>
        /// Converts hexadecimal to binary
        /// </summary>
        /// <param name="hexa">a character string of hexadecimal</param>
        /// <returns>a character string of binary</returns>
        public static string ConvertHexaToBinary(string hexa)
        {
            string returnValue = "";
            foreach (char item in hexa)
            {
                switch (item)
                {
                    case '0':
                        returnValue += "0000";
                        //0	0000
                        break;
                    case '1':
                        returnValue += "0001";
                        //1	0001
                        break;
                    case '2':
                        returnValue += "0010";
                        //2	0010
                        break;
                    case '3':
                        returnValue += "0011";
                        //3	0011
                        break;
                    case '4':
                        returnValue += "0100";
                        //4	0100
                        break;
                    case '5':
                        returnValue += "0101";
                        //5	0101
                        break;
                    case '6':
                        returnValue += "0110";
                        //6	0110
                        break;
                    case '7':
                        returnValue += "0111";
                        //7	0111
                        break;
                    case '8':
                        returnValue += "1000";
                        //8	1000
                        break;
                    case '9':
                        returnValue += "1001";
                        //9	1001
                        break;
                    case 'A':
                        returnValue += "1010";
                        //A	1010
                        break;
                    case 'B':
                        returnValue += "1011";
                        //B	1011
                        break;
                    case 'C':
                        returnValue += "1100";
                        //C	1100
                        break;
                    case 'D':
                        returnValue += "1101";
                        //D	1101
                        break;
                    case 'E':
                        returnValue += "1110";
                        //E	1110
                        break;
                    case 'F':
                        returnValue += "1111";
                        //F	1111
                        break;
                    default:
                        break;
                }
            }
            return returnValue;
        }

        public static int ConvertHexaToDecimal(string hexa)
        {
            return Convert.ToInt32(hexa, 16);
        }

        /*public static int ConvertOctalToDecimal(string octal)
        {
            return Convert.ToInt32(octal, 8);
        }*/

        public static string ConvertDecimalToOctal(int numberDecimal)
        {
            string result = "";
            int reste = 0;
            try
            {
                while (numberDecimal > 0)
                {
                    reste = numberDecimal % 8;
                    numberDecimal = numberDecimal / 8;
                    result = reste.ToString() + result;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return result;
        }

        public static string ConvertHexaToOctal(string hexa)
        {
            return ConvertDecimalToOctal(ConvertHexaToDecimal(hexa));
        }

        public static string ConvertHexaTo8BitsSigned(string hexa)
        {
            return Convert.ToString(Convert.ToSByte(hexa, 16)); //8bits = 2 chiffres hexadécimal
        }

        public static string ConvertHexaTo8BitsUnsigned(string hexa)
        {
            if (hexa.Length == 2)
                return Convert.ToString(Convert.ToByte(hexa, 16)); //8bits = 2 chiffres hexadécimal
            else
                return "Hexadécimal saisie incorrecte";
        }

        public static string ConvertHexaTo16BitsSigned(string hexaNum1, string hexaNum2)
        {
            if (hexaNum1.Length == 2 && hexaNum2.Length == 2)
                return Convert.ToString(Convert.ToInt16(hexaNum2 + hexaNum1, 16)); //16bits = 4 chiffres hexadécimal
            else
                return "Hexadécimal saisies incorrectes";
        }

        public static string ConvertHexaTo16BitsUnsigned(string hexaNum1, string hexaNum2)
        {
            if (hexaNum1.Length == 2 && hexaNum2.Length == 2)
                return Convert.ToString(Convert.ToUInt16(hexaNum2 + hexaNum1, 16)); //16bits = 4 chiffres hexadécimal
            else
                return "Hexadécimal saisies incorrectes";
        }

        public static string ConvertHexaTo32BitsSigned(string hexaNum1, string hexaNum2, string hexaNum3, string hexaNum4)
        {
            if (hexaNum1.Length == 2 && hexaNum2.Length == 2 && hexaNum3.Length == 2 && hexaNum4.Length == 2)
                return Convert.ToString(Convert.ToInt32(hexaNum4 + hexaNum3 + hexaNum2 + hexaNum1, 16)); //32bits = 8 chiffres hexadécimal
            else
                return "Hexadécimal saisies incorrectes";
        }

        public static string ConvertHexaTo32BitsUnsigned(string hexaNum1, string hexaNum2, string hexaNum3, string hexaNum4)
        {
            if (hexaNum1.Length == 2 && hexaNum2.Length == 2 && hexaNum3.Length == 2 && hexaNum4.Length == 2)
                return Convert.ToString(Convert.ToUInt32(hexaNum4 + hexaNum3 + hexaNum2 + hexaNum1, 16)); //32bits = 8 chiffres hexadécimal
            else
                return "Hexadécimal saisies incorrectes";
        }

        public static string ConvertHexaTo64BitsSigned(string hexaNum1, string hexaNum2, string hexaNum3, string hexaNum4, string hexaNum5, string hexaNum6, string hexaNum7, string hexaNum8)
        {
            if (hexaNum1.Length == 2 && hexaNum2.Length == 2 && hexaNum3.Length == 2 && hexaNum4.Length == 2 && hexaNum5.Length == 2 && hexaNum6.Length == 2 && hexaNum7.Length == 2 && hexaNum8.Length == 2)
                return Convert.ToString(Convert.ToInt64(hexaNum8 + hexaNum7 + hexaNum6 + hexaNum5 + hexaNum4 + hexaNum3 + hexaNum2 + hexaNum1, 16)); //64bits = 16 chiffres hexadécimal
            else
                return "Hexadécimal saisies incorrectes";
        }

        public static string ConvertHexaToFloat(string hexaNum1, string hexaNum2, string hexaNum3, string hexaNum4)
        {
            if (hexaNum1.Length == 2 && hexaNum2.Length == 2 && hexaNum3.Length == 2 && hexaNum4.Length == 2)
            {
                uint num = uint.Parse(hexaNum4 + hexaNum3 + hexaNum2 + hexaNum1, System.Globalization.NumberStyles.AllowHexSpecifier);

                float f = BitConverter.ToSingle(BitConverter.GetBytes(num), 0);
                return f.ToString();
            }
            else
                return "Hexadécimal saisies incorrecte";
        }

        public static string ConvertHexaToDouble(string hexaNum1, string hexaNum2, string hexaNum3, string hexaNum4, string hexaNum5, string hexaNum6, string hexaNum7, string hexaNum8)
        {
            if (hexaNum1.Length == 2 && hexaNum2.Length == 2 && hexaNum3.Length == 2 && hexaNum4.Length == 2 && hexaNum5.Length == 2 && hexaNum6.Length == 2 && hexaNum7.Length == 2 && hexaNum8.Length == 2)
            {
                Int64 bTemp = Convert.ToInt64(hexaNum8 + hexaNum7 + hexaNum6 + hexaNum5 + hexaNum4 + hexaNum3 + hexaNum2 + hexaNum1, 16);
                //Double dbl = (double)bTemp;
                return Convert.ToDouble(bTemp).ToString(); //Erreur
            }
            else
                return "Hexadécimal saisies incorrecte";
        }
    }
}
