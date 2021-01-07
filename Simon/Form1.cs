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

        // Builder
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
                colors[i] = rnd.Next(1, 5);
            }
        }

        // Starts The Game
        void StartGame()
        {
            timer1.Start();
        }

        // Operation Tick For Timer #1
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    pictureBox_Red.BackColor = Color.Salmon;
                    break;
                case 2:
                    pictureBox_Red.BackColor = Color.Red;
                    break;
                case 3:
                    pictureBox_Green.BackColor = Color.LightGreen;
                    break;
                case 4:
                    pictureBox_Green.BackColor = Color.Green;
                    break;
                case 5:
                    pictureBox_Blue.BackColor = Color.LightBlue;
                    break;
                case 6:
                    pictureBox_Blue.BackColor = Color.Blue;
                    break;
                case 7:
                    pictureBox_Yellow.BackColor = Color.LightYellow;
                    break;
                case 8:
                    pictureBox_Yellow.BackColor = Color.Yellow;
                    break;
            }

            count++;

            if (count == 9)
                count = 1;
        }

        public void button_Start_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void button_Instructions_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        private void Form1_HelpButton_Click(Object sender, CancelEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
