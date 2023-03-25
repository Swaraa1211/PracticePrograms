namespace PracticePrograms
{
    internal class ExhFirstLast
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            char temp;
            char[] ch = name.ToCharArray();
            int n = name.Length;
            //temp = name[0];
            //name[0] = name[n-1];
            temp = ch[0];
            ch[0] = ch[n - 1];
            ch[n - 1] = temp;

            Console.WriteLine(ch);
            /*for (int i=0; i < name.Length; i++)
            {
                temp = ch[i];
                ch[i] = ch[n - 1];
                ch[n-1] = temp;

            }*/
        }
    }
}