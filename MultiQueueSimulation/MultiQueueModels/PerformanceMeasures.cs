using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MultiQueueModels
{
    public class PerformanceMeasures
    {
        
        public decimal AverageWaitingTime { get; set; }
        public int MaxQueueLength { get; set; }
        public decimal WaitingProbability { get; set; }


        public void CalculatePerformance(SimulationSystem MySystem)
        {
            decimal TotalTimeQueue = 0; 
            decimal TotalNoOfWaiter=0;  
            var MaxQ=new Queue<SimulationCase>();
            for (int i = 0; i < MySystem.SimulationTable.Count; i++)
            {
                if(MySystem.SimulationTable[i].TimeInQueue != 0)
                {
                    TotalNoOfWaiter++;
                }

                TotalTimeQueue += MySystem.SimulationTable[i].TimeInQueue;

            }
            AverageWaitingTime = TotalTimeQueue / (decimal)(MySystem.SimulationTable.Count);
            WaitingProbability = TotalNoOfWaiter / (decimal)(MySystem.SimulationTable.Count);

        }

        public void MaxQueue(SimulationSystem MySystem)
        {
            int[] timeArray = new int[MySystem.CalcEndTime()];
            foreach(SimulationCase customer in MySystem.SimulationTable)
            {
                if (customer.TimeInQueue != 0)
                {
                    timeArray[customer.ArrivalTime]++;
                    timeArray[customer.StartTime]--;
                }
            }
            int maxLength = 0, sum = 0;
            for (int i = 0; i < timeArray.Length; i++)
            {
                sum += timeArray[i];
                maxLength = Math.Max(maxLength, sum);
            }
            MaxQueueLength =  maxLength;
        }

    }
}
