using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        //member variables
        public ISweepstakesManager manager;

        //constructor
        public MarketingFirm(ISweepstakesManager newManager)
        {
            manager = newManager;
        }

        //member methods
        public void CreateSweepstakes()
        {
            Console.WriteLine("Please enter name of sweepstakes?");
            string input = Console.ReadLine();
            Sweepstakes sweepstakes = new Sweepstakes(input);

        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            manager.InsertSweepstakes(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes newSweepstakes = manager.GetSweepstakes();
            return newSweepstakes;
        }

    }
}
