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
        Random rnd = new Random(); // Utillizing Random Class
        int[] colors = new int[10]; // An Array Being Filled With Random Values for Colors (1-4)
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
            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = rnd.Next(1, 5); // 0 - 5
            }

            blink = colors[0];
        }

        // Starts The Game
        void StartGame()
        {
            timer1.Start();
        }

        // Operation Tick For Timer #1
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (placeInArray >= runtime && blink >= 5)
            {
                timer1.Stop();
                placeInArray = 0;
                blink = colors[0];
            }

            switch (blink)
            {
                case 1:
                    pictureBox_Red.BackColor = Color.Salmon;
                    blink += 4;
                    break;
                case 5:
                    pictureBox_Red.BackColor = Color.Red;
                    placeInArray++;
                    blink = colors[placeInArray];
                    break;
                case 2:
                    pictureBox_Green.BackColor = Color.LightGreen;
                    blink += 4;
                    break;
                case 6:
                    pictureBox_Green.BackColor = Color.Green;
                    placeInArray++;
                    blink = colors[placeInArray];
                    break;
                case 3:
                    pictureBox_Blue.BackColor = Color.LightBlue;
                    blink += 4;
                    break;
                case 7:
                    pictureBox_Blue.BackColor = Color.Blue;
                    placeInArray++;
                    blink = colors[placeInArray];
                    break;
                case 4:
                    pictureBox_Yellow.BackColor = Color.LightYellow;
                    blink += 4;
                    break;
                case 8:
                    pictureBox_Yellow.BackColor = Color.Yellow;
                    placeInArray++;
                    blink = colors[placeInArray];
                    break;
            }
        }

        // Button (Click): Call StartGame()
        public void button_Start_Click(object sender, EventArgs e)
        {
            StartGame();
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

        private void pictureBox_Green_Click(object sender, EventArgs e)
        {
            if (runtime < colors.Length)
            {
                runtime++;
                timer1.Start();
            }
        }
    }
}
