using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SplitController
    {
        static int idx;
        public static void readInput(SimulationSystem system, string inputText)
        {
            string[] input = inputText.Split('\n');
            input = input.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
            assignValues(system, input);
            IntervalDistribution(system, input);
            ServerDistributions(system, input);
            CalcRange.fillTimeDistribution(system.InterarrivalDistribution);
            for (int i = 0; i < system.Servers.Count; i++)
            {
                CalcRange.fillTimeDistribution(system.Servers[i].TimeDistribution);
            }
        }

        private static void IntervalDistribution(SimulationSystem system, string[] input)
        {
            idx = 9;
            while ((int)(input[idx][0]) >= '0' && (int)(input[idx][0]) <= '9')
            {
                string[] times = input[idx].Split(',', ' ');
                times = times.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
                TimeDistribution data = new TimeDistribution();
                data.Time = int.Parse(times[0]);
                data.Probability = Convert.ToDecimal(times[1]);
                system.InterarrivalDistribution.Add(data);
                idx++;
            }
        }
        private static void ServerDistributions(SimulationSystem system, string[] input)
        {
            int id = 0;
            Server server = null;
            while (idx < input.Length)
            {
                if (!((int)(input[idx][0]) >= '0' && (int)(input[idx][0]) <= '9'))
                {
                    if (server != null)
                        system.Servers.Add(server);
                    server = new Server();
                    id++;
                    idx++;
                }
                string[] times = input[idx].Split(',', ' ');
                times = times.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
                TimeDistribution data = new TimeDistribution();
                data.Time = int.Parse(times[0]);
                data.Probability = Convert.ToDecimal(times[1]);
                server.TimeDistribution.Add(data);
                server.ID = id;
                idx++;
            }
            system.Servers.Add(server);
        }
        private static void assignValues(SimulationSystem system, string[] input)
        {
            system.NumberOfServers = int.Parse(input[1]);

            system.StoppingNumber = int.Parse(input[3]);

            if (input[5] == "1")
                system.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            else system.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;


            if (int.Parse(input[7]) == 1)
                system.SelectionMethod = Enums.SelectionMethod.HighestPriority;
            else if (int.Parse(input[7]) == 2)
                system.SelectionMethod = Enums.SelectionMethod.Random;
            else if (int.Parse(input[7]) == 3)
                system.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
            else
                Console.WriteLine("error");
        }
    }
}
