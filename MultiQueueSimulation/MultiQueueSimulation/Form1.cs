using MultiQueueModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        public SimulationSystem system;
        public Form1(SimulationSystem system)
        {
            InitializeComponent();
            this.system = system;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            string file = "", inputText = "";
            if (result == DialogResult.OK) // Test result.
            {
                file = openFileDialog1.FileName;
                try
                {
                    inputText = File.ReadAllText(file);
                }
                catch (IOException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            //textBox1.Text = inputText;
            Spliting(inputText);


        }
        private void Spliting(string inputText)
        {
            string[] input = inputText.Split('\n');
            input = input.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            this.system.NumberOfServers = int.Parse(input[1]);

            this.system.StoppingNumber = int.Parse(input[3]);

            if (input[5] == "1")
                this.system.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            else this.system.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;
            
            
            if (int.Parse(input[7]) == 1)
                this.system.SelectionMethod = Enums.SelectionMethod.HighestPriority;
            else if (int.Parse(input[7]) == 2)
                this.system.SelectionMethod = Enums.SelectionMethod.Random;
            else if (int.Parse(input[7]) == 3)
                this.system.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
            else
                MessageBox.Show("Error");


            int idx = 9;
            while ((int)(input[idx][0]) >= '0' && (int)(input[idx][0]) <= '9')
            {
                string[] times = input[idx].Split(',', ' ');
                times = times.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
                TimeDistribution data = new TimeDistribution();
                data.Time = int.Parse(times[0]);
                data.Probability = Convert.ToDecimal(times[1]);
                this.system.InterarrivalDistribution.Add(data);
                idx++;
            }
            int id = 0;
            Server server = null;
            while (idx < input.Length)
            {
                if (!((int)(input[idx][0]) >= '0' && (int)(input[idx][0]) <= '9'))
                {
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
                this.system.Servers.Add(server);
                idx++;
            }
        }
    }
}
