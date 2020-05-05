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
            MarketingFirm firm = new MarketingFirm();
            firm.CreateAManager();
            firm.CreateSweepstakes();

            firm.CreateSweepstakes();
            firm.CreateSweepstakes();
            firm.GetSweepstakes();
            
            
        }
    }
}
