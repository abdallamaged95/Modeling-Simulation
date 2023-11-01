using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {
        
        public Server()
        {
            this.TimeDistribution = new List<TimeDistribution>();
        }

        public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; }
        public decimal Utilization { get; set; }

        public List<TimeDistribution> TimeDistribution;

        //optional if needed use them
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }
        
        public List<SimulationCase> Customers = new List<SimulationCase>();

        /// 
        decimal idleServerTime = 0;
        decimal totalServiceTime = 0;
        decimal counter=0;

        public void CalculateServerPerformance(SimulationSystem MySystem)
        {

            int systemEndTime = MySystem.CalcEndTime();

            //idleServerTime = MySystem.SimulationTable.Last().EndTime - TotalWorkingTime;
            idleServerTime = systemEndTime - TotalWorkingTime;

            IdleProbability = idleServerTime / systemEndTime;



            for (int i = 0; i < MySystem.SimulationTable.Count; i++)
            {

                if(ID== MySystem.SimulationTable[i].AssignedServer.ID)
                {
                    counter++;
                }

            }
            if (counter != 0)
            {
                AverageServiceTime = TotalWorkingTime / counter;

            }
            else
                AverageServiceTime = 0;


            Utilization = (decimal)TotalWorkingTime / (decimal)systemEndTime;

        }

    }
}
