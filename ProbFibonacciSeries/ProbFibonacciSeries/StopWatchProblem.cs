using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC-6
//a.Desc->Write a Stopwatch Program for measuring the time that elapses between
//the start and end clicks
//b. I/P -> Start the Stopwatch and End the Stopwatch
//c. Logic -> Measure the elapsed time between start and end
//d. O/P -> Print the elapsed time.


namespace LogicalProblem
{
    public class StopWatchProblem
    {
        public void StopWatch()
        {
            Console.WriteLine("press Enter to start");
            Console.ReadLine();
            DateTime Start = DateTime.Now;

            Console.WriteLine("press Enter to stop.");
            Console.ReadLine();
            DateTime Stop = DateTime.Now;

            Console.WriteLine("Elapsed Time =" + (Stop - Start));
        }
    }
}
 