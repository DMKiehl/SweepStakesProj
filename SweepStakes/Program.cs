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
            CreateSweepstakesManager newManager = new CreateSweepstakesManager();
            ISweepstakesManager manager = newManager.CreateManager();
            MarketingFirm firm = new MarketingFirm(manager);
           

            firm.CreateSweepstakes();

            firm.CreateSweepstakes();
            firm.CreateSweepstakes();
            firm.GetSweepstakes();
            
            
        }
    }
}
