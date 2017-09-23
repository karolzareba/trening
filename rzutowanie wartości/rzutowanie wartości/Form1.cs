using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rzutowanie_wartości
{
    public partial class Form1 : Form
    {
        private bool yesNo;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("123");
            
            
               
        }

        private string MyMethod(string v)
        {
            if (yesNo)
            {
                return "45";
            }
            else
            {
                return "61";
            }
        }

        
        }
    }


