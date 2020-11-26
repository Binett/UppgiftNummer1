using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace UppgiftNummer1
{
    class Program
    {
        //Add a list to sum the results
        static List<double> myList = new List<double>();
        static void Main(string[] args)
        {
            //Change title to "Inlämningsuppgift 1"
            Console.Title = "Inlämningsuppgift1";
            Run();           
        }

        static void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Write(">Enter first operator: ");//Ask for operators!            
                char ops1 = AskYourOperator();
                Console.Write(">Enter first operator: ");//Ask for operators!
                char ops2 = AskYourOperator();
                Console.Write(">Enter first term: ");
                double firstTerm = AskNum();//Call the method to get all three terms 
                Console.Write(">Enter second term: ");
                double secondTerm = AskNum();
                Console.Write(">Enter third term: ");
                double thirdTerm = AskNum();
                double res = Calculate(firstTerm, ops1, secondTerm, ops2, thirdTerm);
                myList.Add(res);

                if (res < 100)
                {
                    Console.WriteLine(">Less then a hundred");
                }
                else if (res > 100)
                {
                    Console.WriteLine(">More the a hundred");
                }
                else if (res == 100)
                {
                    Console.WriteLine(">Cool, now you have a hundred, clap clap");
                }
                Console.WriteLine(">Another try? Y/N");
                char goAgain = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (char.ToLower(goAgain) == 'y')
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine($" Thank you for playing. The sum of all round is: " + myList.Sum() + " ,Bye! ");
                    isRunning = false;
                    Thread.Sleep(2000);
                }
            }
        }
        private static double Calculate(double firstTerm, char ops1, double secondTerm, char ops2, double thirdTerm)
        {
            double res = 0;
            if (ops1 == '+')
            {
                if (ops2 == '+')
                {
                    res = firstTerm + secondTerm + thirdTerm;                   
                }
                else if (ops2 == '-')
                {
                    res = firstTerm + secondTerm - thirdTerm;
                }
                else if (ops2 == '*')
                {
                    res = firstTerm + secondTerm * thirdTerm;
                }
                else if (ops2 == '/')
                {
                    res = firstTerm + secondTerm / thirdTerm;
                }
            }
            if (ops1 == '-')
            {
                if (ops2 == '+')
                {
                    res = firstTerm - secondTerm + thirdTerm;
                }
                else if (ops2 == '-')
                {
                    res = firstTerm - secondTerm - thirdTerm;
                }
                else if (ops2 == '*')
                {
                    res = firstTerm - secondTerm * thirdTerm;
                }
                else if (ops2 == '/')
                {
                    res = firstTerm - secondTerm / thirdTerm;
                }
            }
            if (ops1 == '*')
            {
                if (ops2 == '+')
                {
                    res = firstTerm * secondTerm + thirdTerm;                    
                }
                else if (ops2 == '-')
                {
                    res = firstTerm * secondTerm - thirdTerm;                    
                }
                else if (ops2 == '*')
                {
                    res = firstTerm * secondTerm * thirdTerm;                   
                }
                else if (ops2 == '/')
                {
                    res = firstTerm * secondTerm / thirdTerm;                    
                }
            }
            if (ops1 == '/')
            {
                if (ops2 == '/')
                {
                    res = firstTerm / secondTerm + thirdTerm;                    
                }
                else if (ops2 == '-')
                {
                    res = firstTerm / secondTerm - thirdTerm;                    
                }
                else if (ops2 == '*')
                {
                    res = firstTerm / secondTerm * thirdTerm;                    
                }
                else if (ops2 == '/')
                {
                    res = firstTerm / secondTerm / thirdTerm;                    
                }               
            }
            Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
            return res;
        }

        private static char AskYourOperator()
        {
            char input = Console.ReadKey().KeyChar;
            if (input == '+' || input == '-' || input == '*' || input == '/')
            {
                Console.WriteLine();
                return input;
            }
            else
            {
                Console.WriteLine("Wrong input! Try again |+|-|*|/|");
                return AskYourOperator();
            }
        }
        private static double AskNum()
        {
            string input = Console.ReadLine();
            bool success = double.TryParse(input, out double number);
            if (success)
            {
                return number;
            }
            else
            {
                return AskNum();
            }
        }

    }
}
