using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Simon
{
    public partial class Form1 : Form
    {
        int[] colors = new int[3]; // An Array Being Filled With Random Values for Colors (1-4)
        int blink; // The blink
        int placeInArray = 0; // Current place in array progress
        int runtime = 0; // Counts the clicks on each picturebox

        // Constructor
        public Form1()
        {
            InitializeComponent();
            FillRandoms();
        }

        // Fills Random Values (1-4) In Array "colors" type integer.
        void FillRandoms()
        {
            Random rnd = new Random();

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    colors[i] = rnd.Next(1, 5); // 1 - 4
            //}

            colors[0] = 1;
            colors[1] = 2;
            colors[2] = 3;
            blink = colors[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Blink according to [] in array "colors" 

            if (placeInArray >= runtime)
            {
                timer1.Stop();
                placeInArray = 0;
                blink = colors[0];
                runtime++;
            }

            else
            {
                switch (blink)
                {
                    case 1:
                        pictureBox_Red.BackColor = Color.Salmon;
                        break;
                    case 5:
                        pictureBox_Red.BackColor = Color.Red;
                        break;
                    case 2:
                        pictureBox_Green.BackColor = Color.LightGreen;
                        break;
                    case 6:
                        pictureBox_Green.BackColor = Color.Green;
                        break;
                    case 3:
                        pictureBox_Blue.BackColor = Color.LightBlue;
                        break;
                    case 7:
                        pictureBox_Blue.BackColor = Color.Blue;
                        break;
                    case 4:
                        pictureBox_Yellow.BackColor = Color.LightYellow;
                        break;
                    case 8:
                        pictureBox_Yellow.BackColor = Color.Yellow;
                        break;
                }
                if (blink > 4)
                {
                    placeInArray++;
                    if (placeInArray < colors.Length)
                        blink = colors[placeInArray];
                }
                else
                    blink += 4;
            }
        }

        // Button (Click): Call StartGame()
        public void button_Start_Click(object sender, EventArgs e)
        {
            runtime = 1;
            timer1.Start();
        }

        // Button (Click): Open Form #2
        private void button_Instructions_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        // HelpButton (Click): Open Form #2
        private void Form1_HelpButton_Click(Object sender, CancelEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            timer1.Start();
            // if game started


            //if (runtime < colors.Length)
            //{
            //    runtime++;
            //    timer1.Start();
            //}
        }
    }
}
