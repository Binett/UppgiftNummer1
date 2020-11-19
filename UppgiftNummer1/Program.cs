using System;

namespace UppgiftNummer1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change title to "Inlämningsuppgift 1"
            Console.Title = "Inlämningsuppgift1";

            double result;

            Console.Write(">Enter first operator: ");//Ask for operators!            
            char ops1 = Console.ReadKey().KeyChar;//input from the user
            Console.Write("\n");
            Console.Write(">Enter first operator: ");//Ask for operators!
            char ops2 = Console.ReadKey().KeyChar;//input from the user
            Console.Write("\n");

            Console.Write(">Enter first term: ");
            double firstTerm = double.Parse(Console.ReadLine());
            Console.Write(">Enter second term: ");
            double secondTerm = double.Parse(Console.ReadLine());
            Console.Write("Enter third term: ");
            double thirdTerm = double.Parse(Console.ReadLine());

            

            }
        }
    }
}
