using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolotoc_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string text = textBox1.Text;
            text.Trim();
            label1.Visible = true;
            label1.Text = text;   
            text = text.ToLower();

            int[] pocet_prvku = new int[123];
            int help = 0;
            foreach (int nuly in pocet_prvku)
            {
            pocet_prvku[help] += 0;
            help++;
            }
            // a == 97, z == 122
            char pismeno;
            int pomocna, pomocna1 = 97,pole_max;
            string nenachazi_se = "";
            for (int mimo_abecedu = 0; mimo_abecedu < text.Length; mimo_abecedu++)
            {
                pismeno = text[mimo_abecedu];
                pomocna = (int)pismeno;
                if (pomocna >= 97 && pomocna <= 122)
                {
                    pocet_prvku[pomocna] = pocet_prvku[pomocna] + 1;
                }
            }
            pole_max = pocet_prvku.Max();
            string maximum = "Max: ";
            for (int prvky = 97 ;prvky <= 122;prvky++)
            {
                listBox1.Items.Add((char)prvky + "   " + pocet_prvku[prvky].ToString());
                if ((pocet_prvku[prvky] == pole_max) && (pole_max != 0))
                {
                    label4.BackColor = Color.LightGreen;
                    maximum = maximum + (char)prvky +" ";
                    label4.Text = maximum;
                }
                else if (pole_max == 0)
                {
                    label4.Text = "Max: -";
                }
                if (pocet_prvku[prvky] == 0)
                {
                    label5.BackColor = Color.MistyRose;
                    nenachazi_se = nenachazi_se + " " +(char)prvky;
                    label5.Text = "Nenáchází se: " + nenachazi_se;
                }
            }



        }
    }
}
