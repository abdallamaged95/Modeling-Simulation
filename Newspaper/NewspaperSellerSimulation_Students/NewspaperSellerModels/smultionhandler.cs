using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class smultionhandler
    {
       public SimulationSystem system = new SimulationSystem();

        public smultionhandler(SimulationSystem system)
        {
            this.system = system;
        }

        public void Simulate()
        {
            int idx = 1;
            decimal purschprice = 0;
            Random random = new Random();
            for (int i=0;i<system.NumOfRecords;i++)
            {
                SimulationCase customer = new SimulationCase();
                customer.DayNo =idx;
                customer.RandomNewsDayType =random.Next(1,100);
                customer.NewsDayType = DayType(customer.RandomNewsDayType);
                customer.RandomDemand= random.Next(1, 100);
                customer.Demand = demandDetails(customer.RandomDemand, system.DemandDistributions[random.Next(0, 7)]);
                customer.DailyCost = system.NumOfNewspapers * system.SellingPrice;
                purschprice = system.NumOfNewspapers * system.PurchasePrice;
                // هتكمل بقا هنا باقي الحاجات اللي في table 
                if(system.NumOfNewspapers > customer.Demand)
                {
                    decimal scrapNewspaper = system.NumOfNewspapers - customer.Demand;
                    customer.LostProfit = 0;
                    customer.ScrapProfit = system.ScrapPrice * scrapNewspaper;

                }
                else if(system.NumOfNewspapers < customer.Demand)
                {
                    decimal lostNewspaper = customer.Demand- system.NumOfNewspapers;
                    customer.ScrapProfit = 0;
                    customer.LostProfit = lostNewspaper * system.SellingPrice;

                }
                else
                {
                    customer.ScrapProfit = 0;
                    customer.LostProfit = 0;

                }
                customer.SalesProfit = customer.Demand * system.SellingPrice;
                customer.DailyNetProfit = customer.SalesProfit- customer.DailyCost-customer.LostProfit+customer.ScrapProfit;


                idx++;
            }

        }






        private Enums.DayType DayType(int randomNum)
        {
            for (int i = 0; i < system.DayTypeDistributions.Count; i++)
            {
                if (randomNum >= system.DayTypeDistributions[i].MinRange &&
                    randomNum <= system.DayTypeDistributions[i].MaxRange)
                    return system.DayTypeDistributions[i].DayType;
            }
            return (Enums.DayType)(-1);
        }
        private int demandDetails(int randomNum,DemandDistribution Daydetails)
        {

            for (int i = 0; i < Daydetails.DayTypeDistributions.Count; i++)
            {
                if (Daydetails.DayTypeDistributions[i].DayType == DayType(randomNum))
                {
                    if (randomNum >= Daydetails.DayTypeDistributions[i].MinRange &&
                    randomNum <= Daydetails.DayTypeDistributions[i].MaxRange)
                        return Daydetails.Demand;
                }
            }
            return -1;
        }
    }
}
