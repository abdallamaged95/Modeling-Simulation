using System;
using System.Collections.Generic;
using System.Linq;

namespace NewspaperSellerModels
{
    public class SplitController
    {
        static int idx;
        public static void readInput(SimulationSystem system, string inputText)
        {
            string[] input = inputText.Split('\n').
                Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

           assignValues(system, input);
            DayDistribution(system, input);
            DemandDistributions(system, input);

            CalcRange.fillDayDistribution(system.DayTypeDistributions);

            for(int i=0; i<system.DemandDistributions.Count;i++)
               CalcRange.fillDayDistribution(system.DemandDistributions[i].DayTypeDistributions);
        }

        private static void DayDistribution(SimulationSystem system, string[] input)
        {
            idx = 11;
            if ((int)(input[idx][0]) >= '0' && (int)(input[idx][0]) <= '9')
            {
                string[] ProbOfDays = input[idx].Split(',', ' ').
                    Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
                addDistribution(system.DayTypeDistributions, ProbOfDays);
            }
        }

        private static void addDistribution(List<DayTypeDistribution> list, string[] times)
        {
            for (int i = 0; i < times.Length; i++)
            {
                DayTypeDistribution data = new DayTypeDistribution();
                data.DayType = (Enums.DayType) i;
                data.Probability = Convert.ToDecimal(times[i]);
                if (data.Probability > 0)
                    list.Add(data);
            }
        }
        private static void DemandDistributions(SimulationSystem system, string[] input)
        {
            idx = 13;
            DemandDistribution demand = null;
            while (idx < input.Length)
            {
                demand = new DemandDistribution();
                string[] times = input[idx].Split(',', ' ')
                    .Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
                demand.Demand = (int.Parse(times[0]));
                times = times.Skip(1).ToArray();
                addDistribution(demand.DayTypeDistributions, times);
                system.DemandDistributions.Add(demand);
                idx++;
            }
            
        }
        private static void assignValues(SimulationSystem system, string[] input)
        {
            system.NumOfNewspapers = int.Parse(input[1]);

            system.NumOfRecords = int.Parse(input[3]);

            system.ScrapPrice = Convert.ToDecimal(input[7]);

            system.PurchasePrice = Convert.ToDecimal(input[5]);
            
            system.SellingPrice = Convert.ToDecimal(input[9]);

        }
    }
}
