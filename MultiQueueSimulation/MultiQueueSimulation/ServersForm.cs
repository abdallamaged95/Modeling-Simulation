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
    public partial class ServersForm : Form
    {
        public List<Server> servers;
        private int idx;
        public ServersForm(List<Server> servers)
        {
            this.servers = servers;
            idx = 0;
            InitializeComponent();
        }
        public ServersForm()
        {
            InitializeComponent();
        }

        private void ServersForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servers[idx].TimeDistribution;
        }
        
        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (idx > 0)
            {
                idx--;
                dataGridView1.DataSource = servers[idx].TimeDistribution;
                dataGridView1.Refresh();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (idx < servers.Count - 1)
            {
                idx++;
                dataGridView1.DataSource = servers[idx].TimeDistribution;
                dataGridView1.Refresh();
            }
        }

    }
}
