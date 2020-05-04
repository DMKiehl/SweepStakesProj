using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant contestant = new Contestant();
            //contestant.AddContestant();
            Sweepstakes sweepstakes = new Sweepstakes("lottery");
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PrintContestantInfo(contestant);
            
        }
    }
}
