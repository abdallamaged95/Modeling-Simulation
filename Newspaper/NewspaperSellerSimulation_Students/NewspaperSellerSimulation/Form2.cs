using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    public partial class table : Form
    {
        List<SimulationCase> simulationTable;
        public table(List<SimulationCase> simulationTable)
        {
            this.simulationTable = simulationTable;
            InitializeComponent();
        }

        private void table_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.simulationTable;
        }


    }
}
