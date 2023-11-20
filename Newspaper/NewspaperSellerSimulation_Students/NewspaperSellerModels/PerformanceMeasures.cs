using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class PerformanceMeasures
    {
        public decimal TotalSalesProfit { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalLostProfit { get; set; }
        public decimal TotalScrapProfit { get; set; }
        public decimal TotalNetProfit { get; set; }
        public int DaysWithMoreDemand { get; set; }
        public int DaysWithUnsoldPapers { get; set; }



         public decimal TotalSalesF(SimulationCase customer)
        {
            return customer.SalesProfit;
        }
        public decimal TotalCostF(SimulationCase customer)
        {
            return customer.DailyCost;
        }
       public  decimal TotalLostProfitF(SimulationCase customer)
        {
            return customer.LostProfit;
        }
       public  decimal TotalScrapProfitF(SimulationCase customer)
        {
            return customer.ScrapProfit;
        }
       public  decimal TotalNetProfitF(SimulationCase customer)
        {
            return customer.DailyNetProfit;
        }
        public int DaysWithMoreDemandF(SimulationCase customer,int x)
        {
            if (customer.Demand >x)
                return 1;
            else return 0;

        }

        public int DaysWithUnsoldPapersF(SimulationCase customer,int x)
        {
            if (customer.Demand < x)
                return 1;
            else return 0;

        }
    }

}
