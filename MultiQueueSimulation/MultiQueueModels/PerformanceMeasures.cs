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







    }
       public void maxqlnew(SimulationSystem MySystem)
        {
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();
            int final = 0;
            foreach (SimulationCase var in MySystem.SimulationTable)
            {
                if (var.TimeInQueue > 0)
                {
                    for (int k = 0; k < var.TimeInQueue; k++)
                    {
                        l1.Add(var.ArrivalTime + k);
                        l2.Add(var.ArrivalTime + k);
                    }
                }
            }
            foreach (int l in l1)
            {
                int counter = 0;
                foreach (int ln in l2)
                {
                    if (l == ln)
                    {
                        counter = counter + 1;
                    }
                }
                if (counter > final)
                {
                    final = counter;
                }
            }
            MaxQueueLength= final;
        }






    }
}
