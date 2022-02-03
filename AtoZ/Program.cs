using System;
using System.Text;

namespace AtoZ
{
    public class InterateAlphas
    {
        // Print ALL alphas A-Z
        public static void Main(string[] args)
        {
            bool doItAgain = true;

            do
            {

                string selection = CreateMenu();

                switch (selection)
                {
                    case "1":
                        Console.WriteLine("\n" + PrintAtoZ());
                        doItAgain = true;
                        break;

                    case "2":
                        Console.WriteLine("\n" + PrintEveryOtherAtoZ());
                        doItAgain = true;
                        break;

                    case "3":
                        Console.WriteLine("\n" + PrintZtoA());
                        doItAgain = true;
                        break;

                    case "X": case "x":
                         doItAgain = false;
                        break;

                    default:
                        doItAgain = true;
                        break;
                }

                if (doItAgain == true)
                {   Console.WriteLine("Press a key to continue...");
                    Console.ReadKey();
                }

            }
            while (doItAgain == true);
            
         }

        public static string CreateMenu()
        {
            string valueEntered;

            do   //do until valid menu selection entered
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Display Alphabet A-Z");
                Console.WriteLine("2) Skip a number of letters in A-Z");
                Console.WriteLine("3) Display Alphabet In Reverse Z-A");
                Console.WriteLine("X) Exit Program");
                Console.Write("\r\nSelect an option: ");

                valueEntered = Convert.ToString(Console.ReadKey().KeyChar);
            }
            while (valueEntered != "1" &&
                   valueEntered != "2" &&
                   valueEntered != "3" &&
                   valueEntered != "X" &&
                   valueEntered != "x");

            return valueEntered;
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
                Console.Clear();
                Console.WriteLine("Enter a number: ");
                valueEntered = Convert.ToString(Console.ReadKey().KeyChar);
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
