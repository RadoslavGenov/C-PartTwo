using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int getIntegerComplement(int n)
        {
            string binary = Convert.ToString(n , 2);
            string reverse = "";
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    reverse = reverse + "0";
                }
                else if (binary[i] == '0')
                {
                    reverse = reverse + "1";
                }
            }
            int final = Convert.ToInt32(reverse, 2);

            return final;
        }
        static void Main(String[] args)
        {
            int res;
            int _n;
            _n = Convert.ToInt32(Console.ReadLine());

            res = getIntegerComplement(_n);
            Console.WriteLine(res);

        }
    }
}
