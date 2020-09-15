using System;
using System.Collections.Generic;


namespace _2DList
{
    class Program
    {
        static void Print(List<List<int>> v)
        {
            Console.WriteLine("\n Printing 2D List element");
            for(int i = 0; i<v.Count; i++)
            {
                for (int j = 0; j < v[i].Count; j++)
                {
                    Console.Write(v[i][j]);
                    Console.Write(' ');
                }
                Console.Write('\n');
            }
        }

        static void Type1()
        {
            int row = Convert.ToInt32(Console.ReadLine());
            int col = Convert.ToInt32(Console.ReadLine());
            List<List<int>> vec2 = new List<List<int>>(row);

            for (int i = 0; i < row; i++)
            {
                var v = new List<int>(col); //  List<int> v = new List<int>(col);
                for (int j = 0; j < col; j++) 
                {
                    int temp = Convert.ToInt32(Console.ReadLine());
                    v.Add(temp);
                }
                vec2.Add(v);
            }
            Print(vec2);
        }



        static void Type2()
        {
            int row = Convert.ToInt32(Console.ReadLine());
            int col = Convert.ToInt32(Console.ReadLine());
            var graph = new List<int>[row];             // total row
            for (int i = 0; i < row; i++) graph[i] = new List<int>();  //graph[i] = new List<int>(col); is correct
            
            for (int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    graph[i].Add(Convert.ToInt32(Console.ReadLine()));
                }
            }
            Console.WriteLine("\n printing......");
            for(int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    Console.Write(graph[i][j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
           //Type1();
            Type2();
        }
    }
}

//input: 
//3
//5
//1
//2
//3
//4
//5
//10
//20
//30
//40
//50
//5
//6
//7
//8
//9

// Printing 2D List element
//1 2 3 4 5
//10 20 30 40 50
//5 6 7 8 9