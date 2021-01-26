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
        private int[] colors = new int[10]; // Random values (1-4) that reflects the sequence of blinks
        private int placeInArray = 0; // The current place in the colors array (colors[placeInArray])
        private int blink; // The current color that should blink
        private int runtime = 0; // Amount of clicks total for this runtime
        private int click = 1; // 
        private int countClick = 1; // 
        private int currentLevel = 1;
        private bool currentLevelStatus = false;
        private PictureBox pictureBox;

        public Form1()
        {
            // Constructor: Initialize the form and trigger the "FillRandoms()" function
            InitializeComponent();
            FillRandoms();
        }

        private void FillRandoms()
        {
            Random rnd = new Random();

            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = rnd.Next(1, 5); // 1 - 4
            }

            blink = colors[0];
        }
        
        private void CheckWinner(bool isWinner)
        {
            // Checks if amount of total clicks is equal to size of colors array
            if (isWinner && countClick == colors.Length)
            {
                pictureBox_Red.Image = Simon.Properties.Resources.You;
                pictureBox_Green.Image = Simon.Properties.Resources.Have;
                pictureBox_Blue.Image = Simon.Properties.Resources.Gray;
                pictureBox_Yellow.Image = Simon.Properties.Resources.Hair;
                MessageBox.Show("Oh, and you've won! Ho.. Ho.. Ho..");
            }

            else if (countClick < runtime)
            {
                pictureBox_Red.Image = Simon.Properties.Resources.You;
                pictureBox_Green.Image = Simon.Properties.Resources.Have;
                pictureBox_Blue.Image = Simon.Properties.Resources.Gray;
                pictureBox_Yellow.Image = Simon.Properties.Resources.Hair;
                MessageBox.Show("Oh, and you've lost! You are worthless. Shimon is god. Praise shimon.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (placeInArray >= runtime)
            {
                timer1.Stop();
                placeInArray = 0;
                blink = colors[0];
                runtime++;
                currentLevel++;
            }

            else
            {
                switch (blink)
                {
                    // Red
                    case 1:
                        pictureBox_Red.BackColor = Color.Salmon;
                        break;
                    case 5:
                        pictureBox_Red.BackColor = Color.OrangeRed;
                        break;
                    // Green
                    case 2:
                        pictureBox_Green.BackColor = Color.GreenYellow;
                        break;
                    case 6:
                        pictureBox_Green.BackColor = Color.YellowGreen;
                        break;
                    // Blue
                    case 3:
                        pictureBox_Blue.BackColor = Color.DeepSkyBlue;
                        break;
                    case 7:
                        pictureBox_Blue.BackColor = Color.DodgerBlue;
                        break;
                    // Yellow
                    case 4:
                        pictureBox_Yellow.BackColor = Color.Gold;
                        break;
                    case 8:
                        pictureBox_Yellow.BackColor = Color.Orange;
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            int picture = ConvertToInteger(pictureBox);

            if (picture == colors[click-1])
            {
                countClick++;
                click++;

                if (countClick <= runtime)
                {
                    if (click == runtime)
                    {
                        click = 1;
                        timer1.Start();
                        CheckWinner(true); // Check if player won the game
                        countClick = 1;
                    }

                    timer2.Stop();
                }
            }

            else
            {
                timer2.Stop();
                CheckWinner(false); // Lost the game
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (currentLevelStatus == false)
                this.Text = "!!! YOU ARE IN LEVEL " + currentLevel + " / 10 !!!";
            if (currentLevelStatus == true)
                this.Text = "Simon by Daniel Naaman and Yonatan Shoshani";

            currentLevelStatus = !currentLevelStatus;
        }

        private int ConvertToInteger(PictureBox pictureBox)
        {
            // Converts a string to integer following the scheme on timer1_Tick switch()

            if (pictureBox.Name.EndsWith("Red"))
            {
                return 1;
            }

            else if (pictureBox.Name.EndsWith("Green"))
            {
                return 2;
            }

            else if (pictureBox.Name.EndsWith("Blue"))
            {
                return 3;
            }

            else // if (pictureBox.Name.EndsWith("Yellow"))
            {
                return 4;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            pictureBox = sender as PictureBox;
            timer2.Start();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            runtime = 1;
            timer1.Start();

            Form1 f1 = new Form1();
            f1.Text = "ani homo";
        } // Check level progress notify

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