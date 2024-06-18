using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPredicNumber
{
    public partial class Form1 : Form
    {
        byte numRandom;
        byte numPredic;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void laShow_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            numRandom = (byte)random.Next(1, 5);
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            numPredic = Convert.ToByte(tGetNumber.Text);
            if (numPredic == numRandom)
            {
                laShow.Text = "You win!!!";
                laShow.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                if (numPredic > numRandom)
                {
                    laShow.Text = "too much";
                    laShow.ForeColor = System.Drawing.Color.IndianRed;
                    tGetNumber.Text = String.Empty;
                    tGetNumber.Select();
                }
                else if (numPredic < numRandom)
                {
                    laShow.Text = "more";
                    laShow.ForeColor = System.Drawing.Color.IndianRed;
                    tGetNumber.Text = String.Empty;
                    tGetNumber.Select();
                }
            }
        }

        private void tGetNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void tGetNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void tGetNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                numPredic = Convert.ToByte(tGetNumber.Text);
                if (numPredic == numRandom)
                {
                    laShow.Text = "You win!!!";
                    laShow.ForeColor = System.Drawing.Color.DarkGreen;
                }
                else
                {
                   if(numPredic > numRandom)
                    {
                        laShow.Text = "too much";
                        laShow.ForeColor = System.Drawing.Color.IndianRed;
                        tGetNumber.Text = String.Empty;
                        tGetNumber.Select();
                    }else if (numPredic < numRandom)
                    {
                        laShow.Text = "more";
                        laShow.ForeColor = System.Drawing.Color.IndianRed;
                        tGetNumber.Text = String.Empty;
                        tGetNumber.Select();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

