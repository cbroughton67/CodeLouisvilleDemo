using System;
using System.Text;

namespace AtoZ
{
    public class InterateAlphas
    {
        // Print ALL alphas A-Z
        public static void Main(string[] args)
        {
            PrintAtoZ();

            PrintEveryOtherAtoZ();

            PrintZtoA();

        }

        private static void PrintAtoZ()
        {
            string alphas = string.Empty;

            for (char c = 'A'; c <= 'Z'; c++)
            {
                alphas = alphas + c;
            }

            Console.WriteLine(alphas);

        }


        private static void PrintEveryOtherAtoZ()
        {
            string alphas = string.Empty;

            for (char c = 'A'; c <= 'Z'; c = Convert.ToChar(Convert.ToInt32(c) + 2))
            {
                alphas = alphas + c;
            }

            Console.WriteLine(alphas);

        }

        private static void PrintZtoA()
        {
            string alphas = string.Empty;

            for (char c = 'Z'; c >= 'A'; c--)
            {
                alphas = alphas + c;
            }

            Console.WriteLine(alphas);

        }
    }

}
