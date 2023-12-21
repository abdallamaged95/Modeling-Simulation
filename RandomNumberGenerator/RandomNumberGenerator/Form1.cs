using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        Main generator = new Main();    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if(Multiplier.Text.Equals(string.Empty) || Seed.Text.Equals(string.Empty) || Increment.Text.Equals(string.Empty)
                || Modulus.Text.Equals(string.Empty) || Iterations.Text.Equals(string.Empty))
                MessageBox.Show("Enter Valid Inputs");
            else
            {
                double multiplier, seed, increment, modulus, iterations, cycleLength;
                List<double> randomNumbers;

                multiplier = double.Parse(Multiplier.Text);
                seed = double.Parse(Seed.Text);
                increment = double.Parse(Increment.Text);
                modulus = double.Parse(Modulus.Text);
                iterations = double.Parse(Iterations.Text);
            
                if (modulus > 0 && modulus > seed && modulus > multiplier && modulus > increment)
                {
                    (randomNumbers, cycleLength) = generator.Genertate(multiplier, seed, increment, modulus, iterations);
                    if (cycleLength == -1)
                        MessageBox.Show("There is Duplicates in one cycle");
                    else
                    {
                        PeriodValue.Text = cycleLength.ToString();

                        dataGridView1.Rows.Add(1, randomNumbers[0], "_______");
                        for (int i = 1; i < randomNumbers.Count; i++)
                            dataGridView1.Rows.Add(i + 1, randomNumbers[i], randomNumbers[i] / cycleLength);
                    }
                }
                else
                    MessageBox.Show("Invalid Modulus");
            }
        }
    }
}
