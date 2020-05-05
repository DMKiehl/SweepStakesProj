using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //member variables
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>();

        //constructor

        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            
            Sweepstakes[] array = new Sweepstakes[queue.Count];
            queue.CopyTo(array, 0);

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
            Sweepstakes sweepstakes = queue.Dequeue();
            return sweepstakes;
            //return;
        }
    }

}
