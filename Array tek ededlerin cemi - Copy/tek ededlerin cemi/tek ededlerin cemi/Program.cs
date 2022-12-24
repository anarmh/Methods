using System;

namespace tek_ededlerin_cemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OddSum(7,20));
        }

        public static int OddSum(int n,int m)
        {
            int sum = 0;
            if(n<m)
            for (int i = n; i < m; i++)
            {
                if (i % 2 != 0)
                    sum += i;
            }
            else
            {
                for (int i = m; i < n; i++)
                {
                    if (i % 2 != 0)
                        sum += i;
                }
            }
            return sum;






        }








    }
}
