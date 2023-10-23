using MultiQueueModels;
using System;
using System.Data;
using System.IO;
using System.Linq;
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

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            string inputText = "";
            if (result == DialogResult.OK) // Test result.
            {
                try
                {
                    inputText = File.ReadAllText(openFileDialog1.FileName);
                }
                catch (IOException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

            SplitController.readInput(system, inputText);

            serverNum.Text = system.NumberOfServers.ToString();
            stoppingNumber.Text = system.StoppingNumber.ToString();
            stoppingCriteria.Text = system.StoppingCriteria.ToString();
            selectionMethod.Text = system.SelectionMethod.ToString();

        }
        

        private void interArrivalBtn_Click(object sender, EventArgs e)
        {
            if (system.InterarrivalDistribution.Count > 0)
            {
                InterArrivalDistributionForm form = new InterArrivalDistributionForm(system.InterarrivalDistribution);
                form.Show();
            }
        }

        private void serversDistributionBtn_Click(object sender, EventArgs e)
        {
            if (system.Servers.Count > 0)
            {
                ServersForm form = new ServersForm(system.Servers);
                form.Show();
            }
        }
    }
}
