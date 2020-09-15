using System;
using System.Collections.Generic;


namespace map
{
    

    class Program
    {
        
        static void MapwithList()
        {
            var map = new Dictionary<int, List<int>>(); //key , vector
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                int u = Convert.ToInt32(Console.ReadLine());
                int v = Convert.ToInt32(Console.ReadLine());

                if (!map.ContainsKey(u)) map.Add(u, new List<int>());
                map[u].Add(v);

                if (!map.ContainsKey(v)) map.Add(v, new List<int>());
                map[v].Add(u);
            }

            foreach (KeyValuePair<int,List<int>> D in map)//print dictionary
            {
                Console.Write("key is  ");
                Console.WriteLine(D.Key);       // unique key
                Console.Write("value are   ");
            
                for(int i=0; i<D.Value.Count; i++) // List Values
                {
                    Console.Write(D.Value[i]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

        }




        static void mapBasic()
        {
            int cnt = 1;
            var map = new Dictionary<string, KeyValuePair<int,int>>(); // name , roll , id

            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
               string name = Convert.ToString(Console.ReadLine());
               int roll = Convert.ToInt32(Console.ReadLine());

               if (!map.ContainsKey(name)) // key na thakle 
                   map.Add(name, new KeyValuePair<int, int>(roll, cnt++));
            }

            Console.WriteLine("how many operation do you want?");
            int tot = Convert.ToInt32(Console.ReadLine());
            while(tot-->=1)
            {
               string k = Convert.ToString(Console.ReadLine());
               if (map.ContainsKey(k))
               {
                   Console.WriteLine(map[k].Key);
                   Console.WriteLine(map[k].Value);
               }
            }
        }

        static void Main(string[] args)
        {
            //mapBasic() ;
            MapwithList();


        }

    }
}


//input :
//3 (total edge)
//3
//2
//3
//45
//3
//51
