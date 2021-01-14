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
        int count = 1; // Counting The Progress In-Game
        int countAhmed = 0; // How many ahmeds?
        bool gameStarted = false;
        int x = 9; // x

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
                colors[i] = rnd.Next(1, 5); // 1 - 4
            }
        }

        // Starts The Game
        void StartGame()
        {
            if (gameStarted)
            {
                button_Start.Text = "Stop / Reset";
                timer1.Start();
            }

            else
            {
                button_Start.Text = "Start";
                pictureBox_Red.BackColor = Color.Red;
                pictureBox_Green.BackColor = Color.Green;
                pictureBox_Yellow.BackColor = Color.Yellow;
                pictureBox_Blue.BackColor = Color.Blue;
            }
            timer1.Start();
        }

        // Operation Tick For Timer #1
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    pictureBox_Red.BackColor = Color.Salmon;
                    count += 4;
                    break;
                case 5:
                    pictureBox_Red.BackColor = Color.Red;
                    count = colors[countAhmed];
                    break;
                case 2:
                    pictureBox_Green.BackColor = Color.LightGreen;
                    count += 4;
                    break;
                case 6:
                    pictureBox_Green.BackColor = Color.Green;
                    count = colors[countAhmed];
                    break;
                case 3:
                    pictureBox_Blue.BackColor = Color.LightBlue;
                    count += 4;
                    break;
                case 7:
                    pictureBox_Blue.BackColor = Color.Blue;
                    count = colors[countAhmed];
                    break;
                case 4:
                    pictureBox_Yellow.BackColor = Color.LightYellow;
                    count += 4;
                    break;
                case 8:
                    pictureBox_Yellow.BackColor = Color.Yellow;
                    count = colors[countAhmed];
                    break;
            }

            if (countAhmed < 10)
            {
                countAhmed++;
            }

            else
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (countAhmed < colors.Length - x)
            {
                timer1.Start();
            }
            countAhmed++;
            x--;
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
    }
}
