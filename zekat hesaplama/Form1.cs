using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zekat_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ZekatMiktari;
            double zekatAltinGr;
            zekatAltinGr = Convert.ToDouble(textBox2.Text)/975;
            if (zekatAltinGr >= 80.18)
            {
                ZekatMiktari = (zekatAltinGr / 40) * 975;
                label2.Text="zekat miktarı" + ZekatMiktari.ToString();
            }
            else
            {
                label2.Text="zekat vermek için paranız yeterli değil";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
