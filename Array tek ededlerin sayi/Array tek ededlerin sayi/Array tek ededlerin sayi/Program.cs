using System;

namespace Array_tek_ededlerin_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayOdd());
        }

        public static int ArrayOdd()
        {
            int count = 0;
            int[] arr = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 0; i <arr.Length; i++)
            {
                if (i % 2 != 0)
                    count++;
            }
            return count;
        }

    }
}
