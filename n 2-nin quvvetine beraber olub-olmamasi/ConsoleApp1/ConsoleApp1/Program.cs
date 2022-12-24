using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(8));
        }

        public static string Square(int n)
        {
            string result = "";
            int i = 2;
            if (n < 1)
            {
                return "please add correct number";
            }     
            
            while (i < n)
            {
                i *= 2;

                if (i==n)
                {
                    result = "yes";
                }
                else
                {
                    result = "no";
                }
            }

            return result;
        }





    }
}
