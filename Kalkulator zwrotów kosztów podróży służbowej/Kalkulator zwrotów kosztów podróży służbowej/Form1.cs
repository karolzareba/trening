using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_zwrotów_kosztów_podróży_służbowej
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburdeRate = .39;
        double amountOwed;
        
        
            


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;

            if (startingMileage <= endingMileage)
            {             
                    milesTraveled = endingMileage - startingMileage;
                    amountOwed = milesTraveled * reimburdeRate;
                    label4.Text = amountOwed.ToString() + "zł";
                
            }
               
            else
            {
                MessageBox.Show("Nie mogę obliczyć odległości", "Poczatkowy stan licznika musi być mniejszy niż końcowy");
            }
        
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(milesTraveled + " kilometrów", "Przebyta odległość");
        }
    }
}
