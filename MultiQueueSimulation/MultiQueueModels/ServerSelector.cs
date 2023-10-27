using System;
using System.Collections.Generic;

namespace MultiQueueModels
{
    public abstract class ServerSelector
    {
        static Random rand = new Random();
        public static Server select(SimulationSystem system, int arrivalTime)
        {
            List<Server> availableServers = sieve(system.Servers, arrivalTime);
            if (availableServers.Count == 0)
                availableServers = nearestFinishServer(system.Servers);
            switch (system.SelectionMethod)
            {
                case Enums.SelectionMethod.HighestPriority:
                    return prioritySelect(availableServers);
                case Enums.SelectionMethod.Random:
                    return randomSelect(availableServers);
                case Enums.SelectionMethod.LeastUtilization:
                    return utilizationSelect(availableServers);
                default: 
                    return null;
            }
        }
        private static List<Server> sieve(List<Server> Servers, int arrivalTime)
        {
            List<Server> availableServers = new List<Server>();
            foreach (Server server in Servers)
            {
                if (server.FinishTime <= arrivalTime)
                    availableServers.Add(server);
            }
            return availableServers;
        }
        private static List<Server> nearestFinishServer(List<Server> Servers)
        {
            int time = int.MaxValue;
            int idx = -1;
            for (int i = 0; i < Servers.Count; i++)
            {
                if (time > Servers[i].FinishTime)
                {
                    time = Servers[i].FinishTime;
                    idx = i;
                }
            }
            List<Server> servers = new List<Server>();
            foreach (Server server in Servers)
            {
                if (server.FinishTime == time)
                    servers.Add(server);
            }
            return servers;
        }
        private static Server prioritySelect(List<Server> Servers)
        {
            Server server = null;
            int id = int.MaxValue;
            for (int i = 0; i < Servers.Count; i++) 
                if (Servers[i].ID < id)
                {
                    server = Servers[i];
                    id = server.ID;
                }

            return server;
        }
        private static Server randomSelect(List<Server> Servers)
        {
            return Servers[rand.Next(0, Servers.Count)];
        }

        private static Server utilizationSelect(List<Server> Servers)
        {
            List<Server> selected = new List<Server>();
            int workingTime = int.MaxValue;
            for (int i = 0; i < Servers.Count; i++)
                if (Servers[i].TotalWorkingTime <= workingTime)
                {
                    workingTime = Servers[i].TotalWorkingTime;
                }
            foreach (Server server in Servers)
            {
                if (server.TotalWorkingTime == workingTime)
                    selected.Add(server);
            }
            return prioritySelect(selected);
        }
    }
}
