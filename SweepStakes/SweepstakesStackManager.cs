using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //member variables
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();

        //constructor
        public SweepstakesStackManager()
        {

        }

        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return;
        }

    }
}
