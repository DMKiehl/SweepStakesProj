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
        public MarketingFirm()
        {
            
        }

        //member methods
        public void CreateSweepstakes()
        {
            Console.WriteLine("Please enter name of sweepstakes?");
            string input = Console.ReadLine();
            Sweepstakes sweepstakes = new Sweepstakes(input);
            AddContestants(sweepstakes);
            InsertSweepstakes(sweepstakes);

        }

        public void AddContestants(Sweepstakes sweepstakes)
        {
            string input;
            do
            {
                Contestant contestant = new Contestant();
                sweepstakes.RegisterContestant(contestant);
                Console.WriteLine("Would you like to add another contestant?");
               input = Console.ReadLine();
            } while (input == "Yes");
        }

        public void CreateAManager()
        {
            CreateSweepstakesManager newManager = new CreateSweepstakesManager();
            manager = newManager.CreateManager();
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
