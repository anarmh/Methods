using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumbMultiply());
        }
        public static int NumbMultiply()
        {
            int mult = 1;
            int[] arr = { 1, 3, 55, 6, 33, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]>1 && arr[i] < 20)
                {
                    mult *= arr[i];
                }
            }
            return mult;





        }
    }
}
