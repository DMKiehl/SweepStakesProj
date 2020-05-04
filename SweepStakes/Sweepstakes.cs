using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        //member variables
        public string Name;
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        //constructor
        public Sweepstakes(string name)
        {
            Name = name;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            dictionary.Add(contestant.RegistNumber, contestant.LastName);
        }

        public Contestant PickWinner()
        {
            return Contestant;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
