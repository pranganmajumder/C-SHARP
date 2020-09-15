using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics.CodeAnalysis;




namespace map
{
    public class SortBy : IComparer<KeyValuePair<string, int>>
    {
        public int Compare(KeyValuePair<string, int> a1, KeyValuePair<string, int> a2)
        {
            if (a1.Key.Length == a2.Key.Length)
            {
                if (a1.Value > a2.Value) return -1; // zake samne tar jonno -1
                else return 1; // pore rakhte hole -1
            }
            else
            {
                if (a1.Key.Length > a2.Key.Length) return -1;
                else return 1;
            }
        }



    }

    class Program
    {
        static void Print(List<int> v)
        {
            foreach (var elem in v)
                Console.WriteLine(elem);
        }



        static void Pri(List<KeyValuePair<string, int>> v)
        {
            Console.WriteLine("after sorting");
            foreach (var it in v)
            {
                Console.WriteLine(it.Key, ' ', it.Value);
            }
        }

        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());
            List<KeyValuePair<string, int>> v = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string temp = Convert.ToString(Console.ReadLine());
                v.Add(new KeyValuePair<string, int>(temp, i));
            }

            SortBy ob = new SortBy(); // obj create kore neya lagbe
            v.Sort(ob);
            Pri(v);

        }

    }
}

//input
//6
//prangan
//kire
//kbi
//haha
//just
//kbi


//output:
//prangan
//just
//haha
//kire
//kbr
//kbi