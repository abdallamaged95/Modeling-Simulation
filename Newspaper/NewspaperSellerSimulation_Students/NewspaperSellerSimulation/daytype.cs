using System;
using NewspaperSellerModels;
using NewspaperSellerTesting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperSellerSimulation
{
    public partial class daytype : Form
    {
        public daytype()
        {
            InitializeComponent();
        }
        public daytype(List<DayTypeDistribution> daytypedest)
        {
            InitializeComponent();
            dataGridView2.DataSource = daytypedest;
        }

        private void daytype_Load(object sender, EventArgs e)
        {

        }
    }
}
