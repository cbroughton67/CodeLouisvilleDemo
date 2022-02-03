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
            int skip;
            string valueEntered;

            do   //Ask for number until a number is entered
            {
                Console.WriteLine("Enter a number: ");
                valueEntered = Convert.ToString(Console.ReadLine());
            }
            while (int.TryParse(valueEntered, out skip) == false);

            // Generate output, skipping number of letters based on input
            for (char c = 'A'; c <= 'Z'; c = Convert.ToChar(Convert.ToInt32(c) + skip))
            {
                alphas += c;
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
