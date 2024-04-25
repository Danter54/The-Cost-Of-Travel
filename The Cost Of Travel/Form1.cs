using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Cost_Of_Travel
{
    public partial class Form1 : Form
    {
        private bool dayAndNightTem = true;
        private Image sunImage = Image.FromFile(@"C:\Users\38067\Documents\GitHub\The-Cost-Of-Travel\The Cost Of Travel\images\sun.png");
        private Image moonImage = Image.FromFile(@"C:\Users\38067\Documents\GitHub\The-Cost-Of-Travel\The Cost Of Travel\images\moon.png");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)&& !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                string commaAndPeriod = textBox1.Text.Replace('.',',');
                string commaAndPeriod2 = textBox2.Text.Replace('.',',');
                string commaAndPeriod3 = textBox3.Text.Replace('.',',');
                if (double.TryParse(commaAndPeriod, out double distance) && double.TryParse(commaAndPeriod2, out double middleFuelOut) && double.TryParse(commaAndPeriod3, out double priceFuelBy1L))
                {
                    if (distance > 0)
                    {
                        double howNeedAllFuel = (distance / 100) * middleFuelOut;
                        double priceAllTrabel = howNeedAllFuel * priceFuelBy1L;

                        textBox6.Text = howNeedAllFuel.ToString("0");
                        textBox5.Text = priceAllTrabel.ToString("0");
                    }
                    else
                    {
                        MessageBox.Show("Please enter correct your distance");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, fill empty fields");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dayAndNightTem)
            {
                this.BackColor = Color.LightGray;

                button2.Image = moonImage;
            }
            else
            {
                this.BackColor = Color.LightYellow;

                button2.Image = sunImage;
            }

            dayAndNightTem = !dayAndNightTem;
        }
    }
}
