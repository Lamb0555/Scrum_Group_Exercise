using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scrum_Group_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************** Aufgabe 5 (Partitionierung) ********************");
            int[] zahl55 = new int[] { 5, 4, 1, 3, 8, 9, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
            Console.WriteLine("Erste  5 Zahlen");
            var part1 = zahl55.Take(5);
            foreach (var h in part1)
            {
                Console.WriteLine(h);
            }
            int[] zahl66 = new int[] { 5, 4, 1, 3, 8, 9, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
            Console.WriteLine("Letzte  5 Zahlen");
            var part2 = zahl66.Skip(12);
            foreach (var h in part2)
            {
                Console.WriteLine(h);
            }
            int[] zahl77 = new int[] { 5, 4, 1, 3, 8, 9, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };

            Console.WriteLine("erstez3 und letztes 3");
            var part3 = zahl77.Take(5);
            foreach (var h in part3)
            {
                Console.WriteLine(h);
            }
            var part4 = zahl77.Skip(14);
            foreach (var h in part4)
            {
                Console.WriteLine(h);
            }
            int[] zahl88 = new int[] { 5, 4, 1, 3, 8, 9, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
            Console.WriteLine("große als 0");
            var part5 = from h in zahl88 where h > 0 select h;
            foreach (int item in part5)
            {
                Console.WriteLine(item);
            }
            int[] zahl99 = new int[] { 5, 4, 1, 3, 8, 9, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };
            Console.WriteLine("nach 12");
            var part6 = zahl99.Skip(12);
            foreach (var h in part6)
            {
                Console.WriteLine(h);
            }
            Console.WriteLine("DirectoryInfo");
            DirectoryInfo info = new DirectoryInfo(@"C:\Users\Administrator\source\repos\Filteroperation\Filteroperation\obj\Debug");
            var dir = info.GetFiles().Reverse();
            foreach (var item in dir)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();

        }
    }
}
