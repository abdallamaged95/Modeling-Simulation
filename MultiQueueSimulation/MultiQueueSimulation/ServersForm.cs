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

        private void ServersForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servers[idx].TimeDistribution;
            serverID.Text = "Server ID: " + servers[idx].ID.ToString();

        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            idx =  (idx > 0) ? --idx : servers.Count - 1;
            
            dataGridView1.DataSource = servers[idx].TimeDistribution;
            serverID.Text = "Server ID: " + servers[idx].ID.ToString();

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            idx = (idx < servers.Count - 1) ? ++idx : 0;
           
            dataGridView1.DataSource = servers[idx].TimeDistribution;
            serverID.Text = "Server ID: " + servers[idx].ID.ToString();
        }
    }
}
