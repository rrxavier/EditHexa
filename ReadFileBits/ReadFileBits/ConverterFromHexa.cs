using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileBits
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
            return Convert.ToString(Convert.ToInt32(hexa, 16), 2);
        } // DONE

        public static int ConvertHexaToDecimal(string hexa)
        {
            return Convert.ToInt32(hexa, 16);
        } // DONE

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
        } // DONE

        public static string ConvertHexaToOctal(string hexa)
        {
            return ConvertDecimalToOctal(ConvertHexaToDecimal(hexa));
        } // DONE

        public static string ConvertHexaTo8BitsSigned(string hexa)
        {
            return Convert.ToString(Convert.ToSByte(hexa, 16)); //8bits = 2 chiffres hexadécimal
        } // DONE

        public static string ConvertHexaTo8BitsUnsigned(string hexa)
        {
            if (hexa.Length == 2)
                return Convert.ToString(Convert.ToByte(hexa, 16)); //8bits = 2 chiffres hexadécimal
            else
                return "Hexadécimal saisie incorrecte";
        } // DONE 

        public static string ConvertHexaTo16BitsSigned(string hexaNum1, string hexaNum2)
        {
            if (hexaNum1.Length == 2 && hexaNum2.Length == 2)
                return Convert.ToString(Convert.ToInt16(hexaNum2 + hexaNum1, 16)); //16bits = 4 chiffres hexadécimal
            else
                return "Hexadécimal saisies incorrectes";
        } // DONE

        public static string ConvertHexaTo16BitsUnsigned(string hexaNum1, string hexaNum2)
        {
            if (hexaNum1.Length == 2 && hexaNum2.Length == 2)
                return Convert.ToString(Convert.ToUInt16(hexaNum2 + hexaNum1, 16)); //16bits = 4 chiffres hexadécimal
            else
                return "Hexadécimal saisies incorrectes";
        } // DONE

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

                return BitConverter.ToSingle(BitConverter.GetBytes(num), 0).ToString();
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
                return BitConverter.ToDouble(BitConverter.GetBytes(bTemp), 0).ToString(); //Erreur
            }
            else
                return "Hexadécimal saisies incorrecte";
        }
    }
}
