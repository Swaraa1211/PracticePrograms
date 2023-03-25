using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class ChFrontBack
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            var str = Console.ReadLine();
            int l = str.Length;
            char c = str[l-1];
            char last = str[l - 1];
            //char n = str[l];
            //str.Insert(0, n);

            Console.WriteLine(c + str + last);

        }
    }
}
