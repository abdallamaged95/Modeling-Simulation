using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class CalcRange
    {
        public static void fillDayDistribution(List<DayTypeDistribution> list)
        {

            decimal sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
               // list[i].DayType = Enums.DayType.Good;
                list[i].MinRange = (int)((sum + (decimal)0.01) * 100);
                sum += list[i].Probability;
                list[i].CummProbability = sum;
                list[i].MaxRange = (int)(sum*100);
            }
        }
        public static void filldemandDistribution(List<DemandDistribution> list)
        {
            decimal x= list[1].DayTypeDistributions[1].Probability;
            decimal sum1 = 0;
            decimal sum2 = 0;
            decimal sum3 = 0;
            for (int i = 0; i < list.Count; i++)
            {
                //sum = 0;
                for (int j = 0; j < list[i].DayTypeDistributions.Count; j++)
                {
                    if (j == 0)
                    {

                        list[i].DayTypeDistributions[j].DayType = Enums.DayType.Good;
                        list[i].DayTypeDistributions[j].MinRange = (int)((sum1 + (decimal)0.01) * 100);
                        sum1 += list[i].DayTypeDistributions[j].Probability;
                        list[i].DayTypeDistributions[j].CummProbability = sum1;
                        list[i].DayTypeDistributions[j].MaxRange = (int)(sum1 * 100);

                    }
                    else if (j == 1)
                    {
                        list[i].DayTypeDistributions[j].DayType = Enums.DayType.Fair;

                        list[i].DayTypeDistributions[j].MinRange = (int)((sum2 + (decimal)0.01) * 100);
                        sum2 += list[i].DayTypeDistributions[j].Probability;
                        list[i].DayTypeDistributions[j].CummProbability = sum2;
                        list[i].DayTypeDistributions[j].MaxRange = (int)(sum2 * 100);
                    }
                    else if (j == 2)
                    {
                        list[i].DayTypeDistributions[j].DayType = Enums.DayType.Poor;

                        list[i].DayTypeDistributions[j].MinRange = (int)((sum3 + (decimal)0.01) * 100);
                        sum3 += list[i].DayTypeDistributions[j].Probability;
                        list[i].DayTypeDistributions[j].CummProbability = sum3;
                        list[i].DayTypeDistributions[j].MaxRange = (int)(sum3 * 100);
                    }
                    


                }
            }
        }
    }
}
