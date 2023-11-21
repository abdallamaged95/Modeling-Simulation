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

    public partial class demand : Form
    {
        public List<DemandDistribution> demandDis;
        private SimulationSystem system;
       
        public demand()
        {
            InitializeComponent();

            system = new SimulationSystem();
            int m = dataGridView1.Rows.Count;
            double cumlativeGoodDay = 0;
            double cumlativeFairDay = 0;
            double cumlativePoorDay = 0;

            for (int i = 0; i < m - 1; ++i)
            {
                cumlativeGoodDay += Math.Round(float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()), 5);
                cumlativeFairDay += Math.Round(float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()), 5);
                cumlativePoorDay += Math.Round(float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()), 5);


            }
            if (cumlativeFairDay == 1 && cumlativeGoodDay == 1 && cumlativePoorDay == 1)
            {

                for (int i = 0; i < m - 1; ++i)
                {

                    demandDis.Add(new DemandDistribution());
                    demandDis[i].Demand = Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    double test = demandDis[i].Demand % 10;

                    if (test != 0.0)
                    {
                        string error = "demand # : " + i + "is not multiple of 10";
                        MessageBox.Show(error);
                        demandDis.Clear();
                    }
                    else
                    {

                        demandDis[i].DayTypeDistributions.Add(new DayTypeDistribution());
                        demandDis[i].DayTypeDistributions[0].Probability = (decimal)Math.Round(float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()), 5);
                        demandDis[i].DayTypeDistributions[0].DayType = Enums.DayType.Good;
                        demandDis[i].DayTypeDistributions.Add(new DayTypeDistribution());

                        demandDis[i].DayTypeDistributions[1].Probability = (decimal)Math.Round(float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()), 5);
                        demandDis[i].DayTypeDistributions[1].DayType = Enums.DayType.Fair;

                        demandDis[i].DayTypeDistributions.Add(new DayTypeDistribution());
                        demandDis[i].DayTypeDistributions[2].Probability = (decimal)Math.Round(float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()), 5);
                        demandDis[i].DayTypeDistributions[2].DayType = Enums.DayType.Poor;

                    }

                }



            }
            else { MessageBox.Show("cumulative probability is NOT equal 1"); }
        }


        

    }
}
