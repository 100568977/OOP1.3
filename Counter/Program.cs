using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void PrintCounters(Counter[] counts)
        {
            foreach (Counter c in counts)
            {
                Console.WriteLine("{0} is {1}", c.Name, c.Value);
            }
        }
        static void Main(string[] args)
        {
            Counter[] myCounters = new Counter[3];
            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0];

            for(int i = 0; i < 5; i++)
            {
                myCounters[0].Increment();
            }
            for (int i = 0; i < 10; i++)
            {
                myCounters[1].Increment();
            }
            PrintCounters(myCounters);
            myCounters[2].Reset();
            PrintCounters(myCounters);
            Console.ReadLine();
        }
    }
}
