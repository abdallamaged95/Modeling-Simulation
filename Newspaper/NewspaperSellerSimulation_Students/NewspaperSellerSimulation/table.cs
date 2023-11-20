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
        public table()
        {
            InitializeComponent();
        }
        public table(List<SimulationCase> system)
        {
            InitializeComponent();
            dataGridView1.DataSource = system;
        }
        private void table_Load(object sender, EventArgs e)
        {

        }
    }
}
