using System;
using NewspaperSellerModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem system = new SimulationSystem();
        public Form1()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
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
            smultionhandler handler = new smultionhandler(system);
            handler.Simulate();
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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            table newtable = new table(system.SimulationTable);
            newtable.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void whichday_Click(object sender, EventArgs e)
        {
            daytype day = new daytype(system.DayTypeDistributions);
            day.Show();
        }

        private void demandtable_Click(object sender, EventArgs e)
        {
            demand demands = new demand();
            demands.Show();
        }
    }
}
