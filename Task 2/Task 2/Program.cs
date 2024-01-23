
using System;

namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            List<int> list = new List<int>() { 1, 2, 3, 4 };

            double result = (double)list.Average();
            Console.WriteLine(result);


        }
    }
}