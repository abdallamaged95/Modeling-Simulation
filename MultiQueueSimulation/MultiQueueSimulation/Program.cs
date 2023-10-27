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
            //SimulationSystem system = new SimulationSystem();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //SimulationTableHandler handler = new SimulationTableHandler(system);
            //handler.Simulate();
            Form form1 = new Form1();
            Application.Run(form1);

            //string result = TestingManager.Test(system, Constants.FileNames.TestCase2);
            //MessageBox.Show(result);


           
        }
    }
}
