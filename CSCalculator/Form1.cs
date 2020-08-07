using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void setVisibility()
        {
            if (AlbatobaText.Text != String.Empty&&int.Parse(AlbatobaText.Text)>0)

            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            {
                setVisibility();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (FsoniText.Text == String.Empty)
            {
                MessageBox.Show("შეავსეთ ცარიელი ველი");

                return;
            }
            

            int sxva = int.Parse(FsoniText.Text);

            int albatoba = int.Parse(AlbatobaText.Text);
            int sxvaResult = 0;
            for (int i = 0; i < albatoba; i++)
            {
                sxvaResult += sxva;
                sxva *= 2;
            }
            TanxaResultText.Text = (""+sxvaResult);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (TqveniTanxaText.Text == String.Empty)
            {
                MessageBox.Show("შეავსეთ ცარიელი ველი");
                return;

            }
            int a = int.Parse(TqveniTanxaText.Text);

            int albatoba = int.Parse(AlbatobaText.Text);
            int result = 0;
            int maxStavka = 10;
            int b = maxStavka;

            while (a >= result)
            {
                result = 0;
                for (int i = 0; i < albatoba ; i++)
                {
                    result += b;
                    b *= 2;

                }
                maxStavka += 1;
                b = maxStavka;
            }

            FsoniResultText.Text=(""+(maxStavka - 2));
            NextBetText.Text=("" + result);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TanxaResultText_TextChanged(object sender, EventArgs e)
        {

        }

        private void FsoniResultText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextBetText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TqveniTanxaText_TextChanged(object sender, EventArgs e)
        {
            
            
            

        }
    }
}
