using MultiQueueModels;
using MultiQueueTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        public SimulationSystem system;
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            this.system = new SimulationSystem();
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
            SimulationTableHandler handler = new SimulationTableHandler(system);
            handler.Simulate();
            /////////////////
            system.PerformanceMeasures.CalculatePerformance(system);
            for (int i = 0; i < system.Servers.Count; i++)
            {
                system.Servers[i].CalculateServerPerformance(system);
            }
           
            system.PerformanceMeasures.maxqlnew(system);
            //////////////
            comboBox1.Items.Clear();
            for (int i = 1; i <= system.Servers.Count; i++)
            {
                comboBox1.Items.Add(i).ToString();
            }
            //////////////////



            string tstResult = "";
            switch (openFileDialog1.FileName[openFileDialog1.FileName.Length - 5])
            {
                case '1':
                    tstResult = TestingManager.Test(system, Constants.FileNames.TestCase1);
                    break;
                case '2':
                    tstResult = TestingManager.Test(system, Constants.FileNames.TestCase2);
                    break;
                case '3':
                    tstResult = TestingManager.Test(system, Constants.FileNames.TestCase3);
                    break;
            }
            MessageBox.Show(tstResult);

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

        private void simulationTableBtn_Click(object sender, EventArgs e)
        {
            SimulationTableForm form = new SimulationTableForm(system.SimulationTable);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graph form2 = new Graph();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
    }
}
