using MultiQueueModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class Graph : Form
    {
        int serverIndex;
        List<SimulationCase> Customers;
        int simulationTime;
        public Graph(int serverIndex, List<SimulationCase> Customers, int simulationTime)
        {
            InitializeComponent();
            this.serverIndex = serverIndex;
            this.Customers = Customers;
            this.simulationTime = simulationTime;
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            serverChart.Series[0].Name = "Busy Time";
            serverChart.ChartAreas[0].AxisY.Minimum = 0;
            serverChart.ChartAreas[0].AxisY.Maximum = 1;
            serverChart.ChartAreas[0].AxisX.Minimum = 0;
            serverChart.ChartAreas[0].AxisX.Title = "Time";
            serverChart.ChartAreas[0].AxisY.Title = "Idle / Busy";
            if (simulationTime > 100)
                serverChart.ChartAreas[0].AxisX.Interval = 10;
            else
                serverChart.ChartAreas[0].AxisX.Interval = 1;
            serverChart.Series[0]["PointWidth"] = "0.9";

            for (int i = 0; i < Customers.Count; i++)
            {
                int startInterval = Customers[i].StartTime,
                    endInterval = Customers[i].EndTime;
                while (startInterval <= endInterval)
                {
                    serverChart.Series[0].Points.AddXY(startInterval, 1);
                    startInterval++;
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
