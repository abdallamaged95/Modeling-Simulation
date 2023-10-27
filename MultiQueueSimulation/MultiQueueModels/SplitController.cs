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
            string[] input = inputText.Split('\n').
                Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            assignValues(system, input);
            intervalDistribution(system, input);
            serverDistributions(system, input);

            CalcRange.fillTimeDistribution(system.InterarrivalDistribution);

            for (int i = 0; i < system.Servers.Count; i++)
                CalcRange.fillTimeDistribution(system.Servers[i].TimeDistribution);
        }

        private static void intervalDistribution(SimulationSystem system, string[] input)
        {
            idx = 9;
            while ((int)(input[idx][0]) >= '0' && (int)(input[idx][0]) <= '9')
            {
                string[] times = input[idx].Split(',', ' ').
                    Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
                addDistribution(system.InterarrivalDistribution, times);
            }
        }

        private static void addDistribution(List<TimeDistribution> list, string[] times)
        {
            TimeDistribution data = new TimeDistribution();
            data.Time = int.Parse(times[0]);
            data.Probability = Convert.ToDecimal(times[1]);
            idx++;
            if (data.Probability > 0)
                list.Add(data);
        }
        private static void serverDistributions(SimulationSystem system, string[] input)
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
                string[] times = input[idx].Split(',', ' ')
                    .Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
                
                addDistribution(server.TimeDistribution, times);
                server.ID = id;
            }
            system.Servers.Add(server);
        }
        private static void assignValues(SimulationSystem system, string[] input)
        {
            system.NumberOfServers = int.Parse(input[1]);

            system.StoppingNumber = int.Parse(input[3]);

            system.StoppingCriteria = (int.Parse(input[5]) == 1) ? Enums.StoppingCriteria.NumberOfCustomers
            : Enums.StoppingCriteria.SimulationEndTime;


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
