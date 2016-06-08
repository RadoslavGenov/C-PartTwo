using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class ReverseSentence
    {
        public static Dictionary<char, int> ContainsPunc(List<string> str)
        {
            Dictionary<char, int> indexPunctuation = new Dictionary<char, int>();
            for (int k = 0; k < str.Capacity; k++)
            {
                for (int i = 0; i < str[k].Length; i++)
                {
                    if (str[k][i] == '.' || str[k][i] == ',' || str[k][i] == '!' || str[k][i] == '?')
                    {
                        indexPunctuation.Add(str[k][i], k);
                        string fix = str[k].Remove(i, 1);
                        str.RemoveAt(k);
                        str.Insert(k, fix);
                    }
                }
            }
            return indexPunctuation;
        }

        public static List<string> Split(string input)
        {
            string[] arr = input.Split(null);
            List<string> listArr = new List<string>(arr);
            Dictionary<char, int> dictResult = ContainsPunc(listArr);
            listArr.Reverse();
            for (int i = 0; i < listArr.Capacity; i++)
            {
                foreach (var pair in dictResult)
                {
                    if (pair.Value == i)
                    {
                        listArr[i] += pair.Key;
                    }
                }
            }
            return listArr;
        }

        static void Main(string[] args)
        {
            string normal = "C# is not C++, not PHP and not Delphi!";
            foreach (var str in Split(normal))
            {
                Console.Write(" {0} ", str);
            }
            Console.WriteLine();
        }
    }
}
