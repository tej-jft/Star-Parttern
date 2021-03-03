using System;

namespace Star_Parttern
{
    class Program
    {
        static void partern(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("*");
                return;
            }
            Line(n);
            Console.WriteLine("");
            int p = n - 1;
            partern(p);
            return;
        }
        static void Line(int l)
        {
            if (l > 0)
            {
                Console.Write("*");
                int t = l - 1;
                Line(t);
            }
            return;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            partern(n);
            
        }
    }
}
