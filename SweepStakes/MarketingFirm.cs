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
        public MarketingFirm(ISweepstakesManager Manager)
        {
            manager = Manager;
        }

        //member methods
        public void CreateSweepstakes()
        {
            Console.WriteLine("Please enter name of sweepstakes?");
            Sweepstakes sweepstakes = new Sweepstakes(Console.ReadLine());
            
            //AddContestants(sweepstakes);
            //InsertSweepstakes(sweepstakes);

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

        //Added additonally beyond the user requirements.

        //public void AddContestants(Sweepstakes sweepstakes)
        //{
        //    string input;
        //    do
        //    {
        //        Contestant contestant = new Contestant();
        //        sweepstakes.RegisterContestant(contestant);
        //        Console.WriteLine("Would you like to add another contestant?");
        //       input = Console.ReadLine();
        //    } while (input == "Yes");
        //}

        //public void PickAWinner()
        //{
        //    Sweepstakes newSweepstakes = GetSweepstakes();
        //    Contestant contestant = newSweepstakes.PickWinner();
        //    Console.WriteLine("The winner is: \n First Name: {0}\n Last Name: {1}\n Email Address: {2}\n Registrant Number: {3}", contestant.FirstName, contestant.LastName, contestant.EmailAddress, contestant.RegistNumber);
        //    newSweepstakes.dictionary.Remove(contestant.RegistNumber);
        //    manager.InsertSweepstakes(newSweepstakes);
        //}

    }
}
