using System;

namespace cut_olanlarin_ceminin_kvadrati
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumSquare());
        }
       
        public static int SumSquare()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int i = 0; i <= arr.Length; i++)
            {
                if (i % 2 == 0)
                    sum += i;

            }
            return sum*sum;


        }
        

        



    }
}
