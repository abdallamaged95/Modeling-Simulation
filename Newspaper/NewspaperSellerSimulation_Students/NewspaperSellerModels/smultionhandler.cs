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
            PerformanceMeasures p = new PerformanceMeasures();
            for (int i=0;i<system.NumOfRecords;i++)
            {
                SimulationCase customer = new SimulationCase();
                customer.DayNo =idx;
                customer.RandomNewsDayType =random.Next(1,100);
                customer.NewsDayType = DayType(customer.RandomNewsDayType);
                customer.RandomDemand= random.Next(1, 100);
                customer.Demand = demandDetails(customer.RandomDemand, system.DemandDistributions,customer.NewsDayType);
                customer.DailyCost = system.NumOfNewspapers * system.PurchasePrice;
                if(customer.Demand>=system.NumOfNewspapers)
                {
                    customer.SalesProfit = system.NumOfNewspapers * system.SellingPrice;
                }
                else
                {
                    customer.SalesProfit = customer.Demand * system.SellingPrice;
                }
                
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
                    customer.LostProfit =  lostNewspaper * (system.SellingPrice-system.PurchasePrice);

                }
                else
                {
                    customer.ScrapProfit = 0;
                    customer.LostProfit = 0;

                }
                
                customer.DailyNetProfit = customer.SalesProfit- customer.DailyCost-customer.LostProfit+customer.ScrapProfit;
                system.SimulationTable.Add(customer);

                idx++;
                ////////////////////////////
                
                p.TotalSalesProfit += p.TotalSalesF(customer);
                p.TotalCost += p.TotalCostF(customer);
                p.TotalLostProfit += p.TotalLostProfitF(customer);
                p.TotalScrapProfit += p.TotalScrapProfitF(customer);
                p.TotalNetProfit += p.TotalNetProfitF(customer);
                p.DaysWithMoreDemand += p.DaysWithMoreDemandF(customer,system.NumOfNewspapers);
                p.DaysWithUnsoldPapers += p.DaysWithUnsoldPapersF(customer, system.NumOfNewspapers);


            }
            system.PerformanceMeasures = p;

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
        private int demandDetails(int randomNum,List<DemandDistribution> Daydetails,Enums.DayType day)
        {
            //for () {
                for (int i = 0; i < Daydetails.Count; i++)
                {
                   // if (Daydetails[i].DayTypeDistributions[i].DayType == day)
                    {
                        if (randomNum >= Daydetails[i].DayTypeDistributions[(int)day].MinRange &&
                        randomNum <= Daydetails[i].DayTypeDistributions[(int)day].MaxRange)
                            return Daydetails[i].Demand;
                    }
                }
            //}
            return -1;
        }
    }
}
