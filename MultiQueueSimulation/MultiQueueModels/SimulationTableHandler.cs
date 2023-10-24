using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationTableHandler
    {
        SimulationSystem system;
        Queue<SimulationCase> waiting;
        public SimulationTableHandler(SimulationSystem system) 
        {
            this.system = system;
            waiting = new Queue<SimulationCase>();
        }
        private void fillTable()
        {
            switch(system.StoppingCriteria)
            {
                case Enums.StoppingCriteria.NumberOfCustomers:
                    fillByCustomersNum();
                    break;
                case Enums.StoppingCriteria.SimulationEndTime:
                    fillByEndTime();
                    break;
            }
        }
        private void fillByCustomersNum()
        {
            Random rand = new Random();
            for (int i = 1; i <= system.StoppingNumber; i++)
            {
                SimulationCase customer = new SimulationCase();
                customer.CustomerNumber = i;
                customer.RandomInterArrival = rand.Next(1, 101);
                customer.InterArrival = interArrivalTime(customer.RandomInterArrival);
                if (i == 0)
                    customer.ArrivalTime = 0;
                else
                    customer.ArrivalTime = system.SimulationTable[i-1].ArrivalTime + 
                        customer.InterArrival;
                customer.RandomService = rand.Next(1, 101);
                system.SimulationTable.Add(customer);
            }
        }
        private void fillByEndTime()
        {
            Random rand = new Random();
            int idx = 0;
            while (true)
            {
                SimulationCase customer = new SimulationCase();
                customer.CustomerNumber = idx + 1;
                customer.RandomInterArrival = rand.Next(1, 101);
                customer.InterArrival = interArrivalTime(customer.RandomInterArrival);
                if (idx == 0)
                    customer.ArrivalTime = 0;
                else
                    customer.ArrivalTime = system.SimulationTable[idx - 1].ArrivalTime +
                        customer.InterArrival;
                if (customer.ArrivalTime > system.StoppingNumber)
                    break;
                customer.RandomService = rand.Next(1, 101);
                system.SimulationTable.Add(customer);
                idx++;
            }
        }
        public void Simulate()
        {
            fillTable();
            int waitings = 0;
            int idx = 0;
            while (idx < system.SimulationTable.Count)
            {
                SimulationCase curr = system.SimulationTable[idx];
                curr.AssignedServer = ServerSelector.select(system, curr.ArrivalTime);
                if (curr.AssignedServer == null)
                {
                    waitings++;
                    curr.AssignedServer = nearestServer();
                    curr.StartTime = curr.AssignedServer.FinishTime;
                    curr.TimeInQueue = curr.AssignedServer.FinishTime - curr.ArrivalTime;
                    //if (curr.TimeInQueue > maxQueue)
                    //    maxqueue = curr.timeinqueue;
                }
                else
                {
                    curr.StartTime = curr.ArrivalTime;
                    curr.TimeInQueue = 0;
                }
                curr.ServiceTime = serverServiceTime(curr.RandomService, curr.AssignedServer);
                curr.AssignedServer.FinishTime = curr.StartTime + curr.ServiceTime;
                curr.EndTime = curr.AssignedServer.FinishTime;
                curr.AssignedServer.TotalWorkingTime += curr.ServiceTime;
                //curr.AssignedServer.Utilization = curr.AssignedServer.TotalWorkingTime /
                //    system.SimulationTable[system.SimulationTable.Count - 1].EndTime;
                idx++;
            }
            system.PerformanceMeasures.WaitingProbability = (decimal)waitings /
                system.SimulationTable.Count;
        }
        private Server nearestServer()
        {
            Server server = null;
            int min = int.MaxValue;
            for (int i = 0; i < system.Servers.Count; i++)
                if (system.Servers[i].FinishTime < min)
                {
                    server = system.Servers[i];
                    min = system.Servers[i].FinishTime;
                }
            return server;
        }
        private int interArrivalTime(int randomNum)
        {
            for (int i = 0; i < system.InterarrivalDistribution.Count; i++)
            {
                if (randomNum >= system.InterarrivalDistribution[i].MinRange &&
                    randomNum <= system.InterarrivalDistribution[i].MaxRange)
                    return system.InterarrivalDistribution[i].Time;
            }
            return -1;
        }
        private int serverServiceTime(int randomNum, Server server)
        {
            for (int i = 0; i < server.TimeDistribution.Count; i++)
            {
                if (randomNum >= server.TimeDistribution[i].MinRange &&
                    randomNum <= server.TimeDistribution[i].MaxRange)
                    return server.TimeDistribution[i].Time;
            }
            return -1;
        }
    }
}
