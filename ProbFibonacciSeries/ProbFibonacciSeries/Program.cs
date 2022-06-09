// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome to Logical programming computation problem");

using ProbFibonacciSeries;
using System;

namespace LogicalProblem

{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Logical Problems");
            Console.WriteLine("1 for Fibonacci Series Problem");
            Console.WriteLine("2 for Perfect Number Problem");
            Console.WriteLine("3 for Prime Number Problem");
            Console.WriteLine("4 for Reverse Number Problem");




            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.Fibonaaci();
                    break;
                case 2:
                    PerfectNumberProblems perfectNumberProblems = new PerfectNumberProblems();
                    perfectNumberProblems.PerfectNumber();
                    break;
                case 3:
                    ProbPrimeNumber prob = new ProbPrimeNumber();
                    prob.PrimeNumbers();
                    break;
                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.Reverse();
                    break;

            }
        }
    }
}

