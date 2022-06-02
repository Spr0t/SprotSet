using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var easyset1 = new EasySet<int>(new int[] { 1, 2, 3, 4, 5 });
            var easyset2 = new EasySet<int>(new int[] { 4, 5, 6, 7, 8 });
            var easyset3 = new EasySet<int>(new int[] { 3, 4, 5 });

            Console.Write("Union ");
            foreach (var item in easyset1.Union(easyset2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Intersection ");
            foreach (var item in easyset1.Intersection(easyset2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Difference A \\ B ");
            foreach (var item in easyset1.Difference(easyset2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Difference B \\ A ");
            foreach (var item in easyset2.Difference(easyset1))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("A Subset C ");
            Console.Write(easyset1.Subset(easyset3));
            Console.WriteLine();


            Console.WriteLine("C Subset A ");
            Console.Write(easyset3.Subset(easyset1));
            Console.WriteLine();


            Console.WriteLine("C Subset B ");
            Console.Write(easyset3.Subset(easyset2));
            Console.WriteLine();


            Console.Write("SymmetricDifference ");
            foreach (var item in easyset1.SymmetricDifference(easyset2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();


        }
    }
}
