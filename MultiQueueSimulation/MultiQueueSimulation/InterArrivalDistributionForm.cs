using MultiQueueModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class InterArrivalDistributionForm : Form
    {
        public InterArrivalDistributionForm(List<TimeDistribution> distributions)
        {
            InitializeComponent();
            dataGridView1.DataSource = distributions;
        }
        public InterArrivalDistributionForm()
        {
            InitializeComponent();
        }
    }
}
