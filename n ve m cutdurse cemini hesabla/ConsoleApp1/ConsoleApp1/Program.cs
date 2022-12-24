using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cemi:"+ Sum(2,10));
      
        
        }

        public static int Sum(int numb1,int numb2)
        {
            
            int Sum = 0;

            if (numb1 >= numb2)
            {
                for (int i = numb2; i < numb1; i++)
                {
                    if (i % 2 == 0)
                        Sum += i;

                }
            }
            else
            {
                for (int i = numb1; i < numb2; i++)
                {
                    if (i % 2 == 0)
                        Sum += i;

                }
            }
            
            return Sum;
        
        }

    }
}
