using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Count(5,20));
        }

        public static int Count(int n,int m) 
        {
            int count = 0;
            if (n < m)
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 != 0)
                        count++;
                }


            }
            else
            {
                for (int i = m; i < n; i++)
                {
                    if (i % 2 != 0)
                        count++;
                }
            }

            return count;



        }








    }
}
