﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace UppgiftNummer1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change title to "Inlämningsuppgift 1"
            Console.Title = "Inlämningsuppgift1";
            //Add a list for results
            List<double> myList = new List<double>();
            double res = 0;
            bool isRunning = true;

            while (isRunning)
            {

                Console.Write(">Enter first operator: ");//Ask for operators!            
                char ops1 = Console.ReadKey().KeyChar;//input from the user
                Console.Write("\n");
                Console.Write(">Enter first operator: ");//Ask for operators!
                char ops2 = Console.ReadKey().KeyChar;//input from the user
                Console.Write("\n");
                //Ask for terms
                Console.Write(">Enter first term: ");
                double firstTerm = double.Parse(Console.ReadLine());
                Console.Write(">Enter second term: ");
                double secondTerm = double.Parse(Console.ReadLine());
                Console.Write(">Enter third term: ");
                double thirdTerm = double.Parse(Console.ReadLine());


                if (ops1 == '+')
                {
                    if (ops2 == '+')
                    {
                        res = firstTerm + secondTerm + thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '-')
                    {
                        res = firstTerm + secondTerm - thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '*')
                    {
                        res = firstTerm + secondTerm * thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '/')
                    {
                        res = firstTerm + secondTerm / thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                }
                if (ops1 == '-')
                {
                    if (ops2 == '+')
                    {
                        res = firstTerm - secondTerm + thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '-')
                    {
                        res = firstTerm - secondTerm - thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '*')
                    {
                        res = firstTerm - secondTerm * thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '/')
                    {
                        res = firstTerm - secondTerm / thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                }
                if (ops1 == '*')
                {
                    if (ops2 == '+')
                    {
                        res = firstTerm * secondTerm + thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '-')
                    {
                        res = firstTerm * secondTerm - thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '*')
                    {
                        res = firstTerm * secondTerm * thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '/')
                    {
                        res = firstTerm * secondTerm / thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                }
                if (ops1 == '/')
                {
                    if (ops2 == '/')
                    {
                        res = firstTerm / secondTerm + thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '-')
                    {
                        res = firstTerm / secondTerm - thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '*')
                    {
                        res = firstTerm / secondTerm * thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                    else if (ops2 == '/')
                    {
                        res = firstTerm / secondTerm / thirdTerm;
                        Console.WriteLine($">{firstTerm} {ops1} {secondTerm} {ops2} {thirdTerm} = {res}");
                    }
                }
                myList.Add(res);

                //Display the outcome of the result
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
                
                Console.WriteLine(">Another try?");
                char goAgain = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (goAgain == 'y' || goAgain == 'Y')
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($" Thank you for playing. The sum of all round is: " + myList.Sum() + " ,Bye! ");
                    isRunning = false;
                    Console.ReadKey();
                }

            }
        }
    }
}
