using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class RemoveOK
    {
        
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            RemoveOK n = new RemoveOK();
            string strnew = "";
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == 'o' && str[i+1] == 'k')
                {
                    i += 1;
                }
                else
                {
                    strnew += str[i];
                }
            }
            Console.WriteLine(strnew);
        }

        /*
         * //str1 = n.removing(str);
                    //i += 2;
         RemoveOK cl = new RemoveOK();
            string str1 = "";
            //string str2 = "";
            var str = Console.ReadLine();
            for(int i=0; i < str.Length; i++)
            {
                foreach (char c in str.ToCharArray())
                {
                    if (str[i] == 'o' || str[i + 1] == 'k')
                    {
                        //str1 = cl.removing(str);
                        continue;
                    }
                    str1 += str[i];
                }
                str = str1;
            }
            Console.WriteLine(str1);

        public removing(string str)
        {
            
        }
        char[] str1;
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str2.Length >= 1)
                {

                }
            }
            return str1;
        //char[] ch = str.ToCharArray();
            //var str1 = "";
            //char[] str1 = {};
         */
    }
}
