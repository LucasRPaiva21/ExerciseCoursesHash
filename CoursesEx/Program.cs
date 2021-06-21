using System;
using System.Collections.Generic;

namespace CoursesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int iD = int.Parse(Console.ReadLine());
                courseA.Add(iD);
            }

            Console.Write("How many students for course B? ");
            int o = int.Parse(Console.ReadLine());
            for (int i = 0; i < o; i++)
            {
                int iD = int.Parse(Console.ReadLine());
                courseB.Add(iD);
            }

            Console.Write("How many students for course C? ");
            int p = int.Parse(Console.ReadLine());
            for (int i = 0; i < p; i++)
            {
                int iD = int.Parse(Console.ReadLine());
                courseC.Add(iD);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);



        }
    }
}
