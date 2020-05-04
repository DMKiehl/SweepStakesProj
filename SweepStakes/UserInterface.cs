using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class UserInterface
    {
        public Contestant GetInformation()
        {
            Contestant newContestant = new Contestant();

            Console.WriteLine("Please enter first name.");
            newContestant.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter last name.");
            newContestant.LastName = Console.ReadLine();

            Console.WriteLine("Please enter email.");
            newContestant.EmailAddress = Console.ReadLine();

            Console.WriteLine("Please enter a registrant number.");
            newContestant.RegistNumber = Convert.ToInt32(Console.ReadLine());

            
            
           return newContestant;

            
        }
    }
}
