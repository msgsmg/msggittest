using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintExcelColumn
{
    class ExcelColumnPrint
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Excel column of given numer {0},{1}", 702, PrintColumn(1));
            PrintColumnsUptoN(702);
            Console.ReadKey();
        }

        private static String PrintColumn(int p)
        {
            char[] str = new char[10];
            int i = 0;

            while (p > 0)
            {
                int rem = p % 26;
                if (rem == 0)
                {
                    str[i] = 'Z';
                    p = (p / 26) - 1;
                }
                else
                {
                    str[i] =(char)( (rem - 1) + 'A');
                    p = p / 26;
                }
                i++;
            }
            return new String(str);
        }

        private static void PrintColumnsUptoN(int n)
        {
            if (n <= 0)
                return;
            for (int i = 1; i <= n; ++i)
            {
                Console.Write(""+","+PrintColumn(i));
            }
        }
    }
}
