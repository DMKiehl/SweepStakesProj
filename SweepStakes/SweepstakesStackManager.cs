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
            Sweepstakes[] array = new Sweepstakes[stack.Count];
            stack.CopyTo(array, 0);

            Console.WriteLine("What sweepstakes would you like?");
            string userInput = Console.ReadLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (userInput.Equals(array[i].Name))
                {
                    return array[i];

                }

            }
            Console.WriteLine("Entry you provided not valide. Returning default sweepstakes on file.");
            Sweepstakes sweepstakes = stack.Pop();
            return sweepstakes;
            //Sweepstakes sweepstakes = stack.Pop();
            //return sweepstakes;
        }

    }
}
