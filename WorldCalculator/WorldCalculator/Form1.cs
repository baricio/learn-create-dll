using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldDomination;

namespace WorldCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = 0;
            int value2 = 0;
            value1 = int.Parse(string.IsNullOrEmpty(textBox1.Text.Trim()) ? "0" : textBox1.Text.Trim());
            value2 = int.Parse(string.IsNullOrEmpty(textBox2.Text.Trim()) ? "0" : textBox2.Text.Trim());

            textBox3.Text = Convert.ToString(Operation.Sum(value1, value2));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                
           
        }
    }
}
