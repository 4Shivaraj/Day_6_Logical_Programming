using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
