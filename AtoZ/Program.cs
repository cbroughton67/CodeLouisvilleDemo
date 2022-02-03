using System;
using System.Text;

namespace AtoZ
{
    public class InterateAlphas
    {
        // Print ALL alphas A-Z
        public static void Main(string[] args)
        {
            Console.WriteLine(PrintAtoZ());

            Console.WriteLine(PrintEveryOtherAtoZ());

            Console.WriteLine(PrintZtoA());

        }

        private static string PrintAtoZ()
        {
            string alphas = string.Empty;

            for (char c = 'A'; c <= 'Z'; c++)
            {
                alphas = alphas + c;
            }

            return alphas;

        }


        private static string PrintEveryOtherAtoZ()
        {
            string alphas = string.Empty;

            for (char c = 'A'; c <= 'Z'; c = Convert.ToChar(Convert.ToInt32(c) + 2))
            {
                alphas = alphas + c;
            }

            return alphas;

        }

        private static string PrintZtoA()
        {
            string alphas = string.Empty;

            for (char c = 'Z'; c >= 'A'; c--)
            {
                alphas = alphas + c;
            }

            return alphas;

        }
    }

}
