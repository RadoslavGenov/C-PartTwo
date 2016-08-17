using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDecimal
{
    class ReverseD
    {
        static decimal Reverse(decimal num)
        {
            string immutable = num.ToString();
            StringBuilder mutable = new StringBuilder(immutable);
            for (int i = 0, j = mutable.Length - 1; i < mutable.Length / 2; i++, j--)
            {
                char temp = mutable[j];
                mutable[j] = mutable[i];
                mutable[i] = temp;
            }
            return Convert.ToDecimal(mutable.ToString());
        }
        static void Main(string[] args)
        {
            decimal d = 123.4534M;
            decimal reversed = Reverse(d);
            Console.WriteLine(reversed);
        }
    }
}
