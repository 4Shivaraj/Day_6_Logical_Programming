using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC-4
//In C#, we can reverse a number either by using for loop, while loop, or using recursion.
//The simplest way to reverse a number is by using for loop or while loop.In order to
//reverse a number, we have to follow the following steps:
//a.We need to calculate the remainder of the number using the modulo
//b.After that, we need to multiply the variable reverse by 10 and add the remainder into it.
//c. We then divide the number by 10 and repeat steps until the number becomes 0.

namespace LogicalProblem
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            int n, reverse = 0;
            Console.WriteLine("Enter a number to reverse");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + n % 10;
                n = n / 10;
            }
            Console.WriteLine("Revese of entered number is = {0}", reverse);
        }
        
    }
    
}
