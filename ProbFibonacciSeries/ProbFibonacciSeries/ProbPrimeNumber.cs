using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC-3
//Just like the Perfect number, the Prime number is also a special type of number. When
//the number is divided greater than 1 and divided by 1 or itself is referred to as the Prime
//number. 0 and 1 are not counted as prime numbers. All the even numbers can be
//divided by 2, so 2 is the only even prime minister.

namespace ProbFibonacciSeries
{
    internal class ProbPrimeNumber
    {
        public void PrimeNumbers()
        {
            Console.Write("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("{0} is a Prime number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime number", num);
            }
            Console.WriteLine("==========================================================================");
        }
    }
}
