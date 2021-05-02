using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjSpazioTempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //New istance of SpazioTempo class
            SpazioTempo sp1 = new SpazioTempo();
            //Input
            //conversion from string to double of the input values
            sp1.Vauto1 = Convert.ToDouble(textBox1.Text);
            sp1.Vauto2 = Convert.ToDouble(textBox2.Text);
            sp1.distanzaAuto = Convert.ToDouble(textBox3.Text);
            //Output
            //output of calculated values and their conversion to string type
            textBox5.Text = Convert.ToString(Math.Round(sp1.tempoIncontro(),2));
            textBox4.Text = Convert.ToString(Math.Round(sp1.spazioIncontroA1(),2));
            textBox6.Text = Convert.ToString(Math.Round(sp1.spazioIncontroA2(),2));
        }
        //Reset button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
