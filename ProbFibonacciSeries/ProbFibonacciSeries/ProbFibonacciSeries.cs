using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class FibonacciSeries
    {
        public void Fibonaaci()
        {
            int n, first = 0, second = 1, next, c;
            Console.WriteLine("Enter The Number Of Terms");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First {0} terms of Fibonacci series are");
            for (c = 0; c < n; c++)
            {
                if (c <= 1)
                    next = c;
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.WriteLine("{0}", next );
            }
        }
    }
}
