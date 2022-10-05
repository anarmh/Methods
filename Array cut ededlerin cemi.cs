using System;

namespace cut_ededlerin_cemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PairSum());
        }

        public static int PairSum()
        {
            int sum = 0;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 ==0) ;
                 sum += arr[i]; 
            }
            return sum;
        }

    }
}
