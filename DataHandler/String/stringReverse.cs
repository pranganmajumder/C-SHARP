using System;

namespace stringReverse
{
    class Program
    {
        static string REV(string st)
        {
            char[] charArr = st.ToCharArray();
            Array.Reverse(charArr);
            return string.Concat(charArr);
        }
        static void Main(string[] args)
        {
            string st = Convert.ToString(Console.ReadLine());
            st = REV(st);
            Console.WriteLine(st);
        }
    }
}
