using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class RemOK
    {
        public string word(string str)
        {
            //Console.WriteLine("OK Present");
            string strf = "";
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == 'o' && str[i+1] =='k')
                {
                    i += 1;
                }
                else
                {
                    strf += str[i];
                }
                
            }
            return strf;

        }
        public static void Main(string[] arg)
        {
            Console.Write("Enter String: ");
            string str = Console.ReadLine();
            RemOK n = new RemOK();
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'o' && str[i + 1] == 'k')
                {
                    str1 = n.word(str);
                    i = 0;
                    str = str1;
                }
                else
                {
                    str1 = str;
                }
                
            }
            Console.WriteLine("Output: " + str1);
        }
    }
}
