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

    }
}
