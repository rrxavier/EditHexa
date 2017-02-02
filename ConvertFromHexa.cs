using System;
using System.Collections.Generic;
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
    }
}
