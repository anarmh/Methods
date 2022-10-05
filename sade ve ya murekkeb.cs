using System;

namespace sade_ve_ya_murekkeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrimeOrcomplex(0));
        }
        public static String PrimeOrcomplex(int n)
        {
            String result = "";

            int num = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    num++;
                    break;
                }
            }
           
            if (num > 0)
            {
                result = "Number is complex";
            }
            else
            {
                result = "Number is prime";
            }
            return result;



        }




    }
}
