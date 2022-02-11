using System;
using CodeLouisvilleLibrary;

namespace AtoZ_Week6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool doesThisMakeSense = CodeLouisvilleAppBase.Prompt4YesNo("Does this make sense? ");
            if (doesThisMakeSense)
                Console.WriteLine("I've got this!!!");
            else
                Console.WriteLine("Blame John");
        }
    }
}
