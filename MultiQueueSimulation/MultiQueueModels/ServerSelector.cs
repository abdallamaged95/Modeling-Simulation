using System;
using System.Collections.Generic;

namespace MultiQueueModels
{
    public abstract class ServerSelector
    {
        public static Server select(SimulationSystem system, int arrivalTime)
        {
            switch (system.SelectionMethod)
            {
                case Enums.SelectionMethod.HighestPriority:
                    return prioritySelect(system, arrivalTime);
                case Enums.SelectionMethod.Random:
                    return randomSelect(system, arrivalTime);
                case Enums.SelectionMethod.LeastUtilization:
                    return utilizationSelect(system, arrivalTime);
                default:
                    return null;
            }
        }
        private static Server prioritySelect(SimulationSystem system, int arrivalTime)
        {
            Server server = null;
            int id = int.MaxValue;
            for (int i = 0; i < system.Servers.Count; i++) 
                if (system.Servers[i].FinishTime <= arrivalTime && 
                    system.Servers[i].ID < id)
                {
                    server = system.Servers[i];
                    id = server.ID;
                }

            return server;
        }
        private static Server randomSelect(SimulationSystem system, int arrivalTime)
        {
            List<Server> availableServers = new List<Server>();
            for (int i = 0; i < system.Servers.Count; i++)
                if (system.Servers[i].FinishTime <= arrivalTime)
                {
                    availableServers.Add(system.Servers[i]);
                }
            if (availableServers.Count == 0)
                return null;
            Random rand = new Random();
            return availableServers[rand.Next(0, availableServers.Count)];
        }

        private static Server utilizationSelect(SimulationSystem system, int arrivalTime)
        {
            Server server = null;
            int workingTime = 0;
            for (int i = 0; i < system.Servers.Count; i++)
                if (system.Servers[i].FinishTime <= arrivalTime &&
                    system.Servers[i].TotalWorkingTime < workingTime)
                {
                    server = system.Servers[i];
                    workingTime = server.TotalWorkingTime;
                }
            return server;
        }
    }
}
