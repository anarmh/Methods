using System;

namespace _3_e_ve_7_e_bolmek
{
    class Program
    {
        static void Main(string[] args)
        {


            Numb(22);

            
        }
        #region 3-e ve 7-e bolmek

        public static void Numb(int n)
        {
            int x = n;
            if (x % 3 == 0 || x % 7 == 0)
            {
                Console.WriteLine("bolunur");

                return;
            }
            else{
                Console.WriteLine("bolunmur");
            }










            #endregion






        }





    }
}
