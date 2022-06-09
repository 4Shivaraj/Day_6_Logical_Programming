using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC-2
//a.Just like the Armstrong number, the Perfect Number is also a special type of
//positive number. When the number is equal to the sum of its positive divisors
//excluding the number, it is called a Perfect Number. For example, 28 is the perfect
//number because when we sum the divisors of 28, it will result in the same number.
//The divisors of 28 are 1, 2, 4, 7, and 14. So,
//b. 28 = 1+2+4+7
//c. 28 = 28

namespace LogicalProblem
{
    public class PerfectNumberProblems
    {
        public void PerfectNumber()
        {
            int sum = 0;
            Console.Write("\tEnter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    Console.WriteLine("\t{0} ", i);
                }
            }
            if (sum == num)
            {
                Console.WriteLine("\tis a Perfect number" + num);
            }
            else
            {
                Console.WriteLine("\tis not a Perfect number" + num);
            }
            Console.WriteLine("==========================================================================");
        }
    }
}
