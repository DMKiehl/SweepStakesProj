using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class CreateSweepstakesManager
    {
        //member variables

        //constructor

        //member methods
        public ISweepstakesManager CreateManager()
        {
            Console.WriteLine("Which manager would you like to use: Stack or Queue?");
            string input = Console.ReadLine();

            switch (input)
            {
                case "Stack":
                    return new SweepstakesStackManager();

                default:
                    return new SweepstakesQueueManager();
            }
        }

    }
}
