using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFileBits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*byte[] test = File.ReadAllBytes("C:\\Users\\nunesr_info\\Documents\\GitHub\\EditHexa\\TASKS.txt");

            foreach (byte item in test)
            {
                Console.WriteLine(String.Format("{0:X2}", Convert.ToInt32(item)));
            }*/

            string[][] test = new HexaEditModel("C:\\Users\\nunesr_info\\Documents\\GitHub\\EditHexa\\TASKS.txt").Hexadecimal;

            Console.ReadLine();
        }
    }
}
