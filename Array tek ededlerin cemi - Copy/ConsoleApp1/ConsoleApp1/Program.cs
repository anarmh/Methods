using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SumArray());
        }


        public static int SumArray()
        {
            int Sum = 0;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) {
                   Sum += arr[i];
                }
                    
            }
            return Sum;

        }






    }
}
