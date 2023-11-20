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
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            smultionhandler handler = new smultionhandler(system);
            handler.Simulate();

        }
    }
}
