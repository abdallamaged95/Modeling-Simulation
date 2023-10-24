using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueTesting;
using MultiQueueModels;

namespace MultiQueueSimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SimulationSystem system = new SimulationSystem();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form1 = new Form1(system);
            Application.Run(form1);

            SimulationTableHandler handler = new SimulationTableHandler(system);
            handler.Simulate();
            string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);


           
        }
    }
}
