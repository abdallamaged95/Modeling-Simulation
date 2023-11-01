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


        
        /// /////////////
       
     



        public void CalculatePerformance(SimulationSystem MySystem)
        {
            decimal TotalTimeQueue = 0; 
            decimal TotalNoOfWaiter=0;  
            var MaxQ=new Queue<SimulationCase>();
            int maxL = 0;
            for (int i = 0; i < MySystem.SimulationTable.Count; i++)
            {
               if(MySystem.SimulationTable[i].TimeInQueue != 0)
                {
                    TotalNoOfWaiter = TotalNoOfWaiter + 1;
                }

                /////////////////////

              

                //////////////////////////


                TotalTimeQueue = TotalTimeQueue + MySystem.SimulationTable[i].TimeInQueue;
                


            }
            AverageWaitingTime = TotalTimeQueue / (decimal)(MySystem.SimulationTable.Count);
            WaitingProbability = TotalNoOfWaiter / (decimal)(MySystem.SimulationTable.Count);
            MaxQueueLength= maxL;




            // 2 3
            // 3 2
            // 0 0 1 2 2 2 0 0 0 0 0 0 0



    }

        public void maxqlnew(SimulationSystem system)
        {

            int maximumQueueLength = 0;

            for (int i = 0; i < system.SimulationTable.Count; i++)
            {
                int count = 0;
                for (int j = i; j < system.SimulationTable.Count; j++)
                {
                    if (system.SimulationTable[i].StartTime > system.SimulationTable[j].ArrivalTime)
                    {
                        count++;
                    }
                }
                if (count > maximumQueueLength) maximumQueueLength = count;

            }
            MaxQueueLength = maximumQueueLength;
        }



    }
}
