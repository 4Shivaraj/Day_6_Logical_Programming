using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
