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



        decimal TotalSalesF(SimulationCase customer)
        {
            return customer.SalesProfit;
        }
        decimal TotalCostF(SimulationCase customer)
        {
            return customer.DailyCost;
        }
        decimal TotalLostProfitF(SimulationCase customer)
        {
            return customer.LostProfit;
        }
        decimal TotalScrapProfitF(SimulationCase customer)
        {
            return customer.ScrapProfit;
        }
        decimal TotalNetProfitF(SimulationCase customer)
        {
            return customer.DailyNetProfit;
        }
        decimal DaysWithMoreDemandF(SimulationCase customer)
        {
            if (customer.Demand > 70)
                return 1;
            else return 0;

        }

        decimal DaysWithUnsoldPapersF(SimulationCase customer)
        {
            if (customer.Demand < 70)
                return 1;
            else return 0;

        }
    }

}
