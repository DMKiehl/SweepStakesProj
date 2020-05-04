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
        Dictionary<int, Contestant> dictionary = new Dictionary<int, Contestant>();
        Random myRandom = new Random();

        //constructor
        public Sweepstakes(string name)
        {
            Name = name;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            UserInterface user = new UserInterface();
            contestant = user.GetInformation();
            dictionary.Add(contestant.RegistNumber, contestant);
        }

        public Contestant PickWinner()
        {
            int index = myRandom.Next(dictionary.Count);
            KeyValuePair<int, Contestant> pair = dictionary.ElementAt(index);

            return pair.Value;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            foreach (KeyValuePair<int, Contestant> sweepList in dictionary)
            {
                Console.WriteLine("Registrant Number: {0} First Name: {1} Last Name: {2} Email Address: {3}", sweepList.Key, sweepList.Value.FirstName, sweepList.Value.LastName, sweepList.Value.EmailAddress);
                Console.ReadLine();
            }
        }
    }
}
