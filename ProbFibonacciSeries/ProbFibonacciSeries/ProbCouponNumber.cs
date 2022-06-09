using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC-5
//a.Desc->Given N distinct Coupon Numbers, how many random numbers do you
//need to generate a distinct coupon number? This program simulates this random
//process.
//b. I/P -> N Distinct Coupon Number
//c. Logic -> repeatedly choose a random number and check whether it's a new one.
//d. O/P -> total random number needed to have all distinct numbers.
//e. Functions => Write Class Static Functions to generate random numbers and to process distinct coupons.

namespace LogicalProblem
{
    public class CouponNumber
    {
        public static void Coupon(int N)
        {
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Random random = new Random();
                int Random_generate = random.Next(999, 10000);
                if (i == 0)
                {
                    array[i] = Random_generate;
                }
                else
                {
                    int j = 0;
                    int check = 0;
                    while (j < i)
                    {
                        if (array[j] == Random_generate)
                            check = 1;
                        j++;
                    }
                    if (check == 0)
                        array[i] = Random_generate;
                    else
                        i--;
                }
            }
            Console.WriteLine("\tDistinct Coupons Are:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($" {array[i]}");
            }
            Console.WriteLine("\n==========================================================================");
        }
    }
}
       
            