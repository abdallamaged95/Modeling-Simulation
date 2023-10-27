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
            for (int i = 0; i < system.StoppingNumber; i++)
            {
                SimulationCase customer = new SimulationCase();
                customer.CustomerNumber = i+1;
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
            int totalWaitingTime = 0, totalCustomersWaited = 0;
            int idx = 0;
            Random random = new Random();
            foreach (SimulationCase customer in system.SimulationTable)
            {
                customer.AssignedServer = ServerSelector.select(system, customer.ArrivalTime);
                customer.StartTime = Math.Max(customer.ArrivalTime, customer.AssignedServer.FinishTime);
                customer.TimeInQueue = customer.StartTime - customer.ArrivalTime;
                totalWaitingTime += customer.TimeInQueue;
                totalCustomersWaited += (customer.TimeInQueue != 0)? 1 : 0;
                customer.RandomService = random.Next(1, 101);
                customer.ServiceTime = serverServiceTime(customer.RandomService, customer.AssignedServer);
                customer.EndTime = customer.StartTime + customer.ServiceTime;
                customer.AssignedServer.FinishTime = customer.EndTime;
                customer.AssignedServer.TotalWorkingTime += customer.ServiceTime;
                idx++;
            }

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
