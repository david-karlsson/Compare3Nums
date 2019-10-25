using System;

namespace Compare3Nums
{
    class Program
    {
        static void Main(string[] args)
        {


            int bignumber = 7;

            int number = 5;

            int smallnumber = 0;

            string bigstring = bignumber.ToString();
            string Nstring = number.ToString();
            string Smallstring = smallnumber.ToString();


            if (bignumber > number && bignumber > smallnumber)
            {
             

                           Console.WriteLine(bigstring);
                           Console.WriteLine(" is the biggest number");

            }


            if (number > bignumber && number > smallnumber)
            {


                Console.WriteLine(Nstring);
                Console.WriteLine(" is the biggest number");

            }



            Console.ReadKey();
        }
    }
}
