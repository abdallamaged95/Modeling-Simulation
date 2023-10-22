using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class CalcRange
    {
        public static void fillTimeDistribution(List<TimeDistribution> list)
        {
            decimal sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                list[i].MinRange = (int)((sum + (decimal)0.01) * 100);
                //if (i > 0)
                //    list[i].MinRange = list[i - 1].MaxRange + 1;
                //else list[i].MinRange = 1;
                sum += list[i].Probability;
                list[i].CummProbability = sum;
                list[i].MaxRange = (int)(sum*100);
            }
        }

    }
}
