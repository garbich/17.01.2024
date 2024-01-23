
using System;

namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            int[] result = Array.FindAll(arr, (a) => a % 2 == 0);

            Array.ForEach(result, (a) => Console.Write(a + " "));





        }


    }
}