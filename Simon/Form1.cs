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
        private int click = 1; // Click identifier
        private int countClick = 1; // Counts the numer of clicks the player has made in a level
        private int currentLevel = 1; // Incremented with runtime and clicks
        private bool currentLevelStatus = false; // Check whether or not the title is set to the current level
        private PictureBox pictureBox; // Contains the properties of a certain picturebox

        // Triggers form building and the fill random function
        public Form1()
        {
            InitializeComponent();
            FillRandoms();
            ShowInstructions();
        }

        // Fills an array with integers between 1-4 used to display the pictures
        private void FillRandoms()
        {
            Random rnd = new Random();

            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = rnd.Next(1, 5); // 1 - 4
            }

            blink = colors[0];
        }

        // Opens a message box with game instructions
        private void ShowInstructions()
        {
            string title = "Game Rules and Instructions";
            string content = "\"Simon\" by Daniel Naaman and Yonatan Shoshani\n\nThe game has ten levels, if you succeed level ten, you win. In any other case, you loose. If you wish to shorten the game, you can modify the size of the colors array declared at the top of the class.\n\n1) Press the Start button. Simon will give the first signal. Repeat the signal by pressing the same color lens.\n\n2) Simon will duplicate the first signal and add one. Repeat these two signals by pressing the same color lenses, in order.\n\n3) Simon will duplicate these first two signals and add one.\n\nYou can return to these instructions at any given point during the game by clicking the question mark icon at the top of the window.\n\nGood luck and have fun!";

            MessageBox.Show(content, title);
        }
        
        // Checks if player have won, receives boolean, if true then triggers winning actions, if false, trigger loosing actions
        private void CheckWinner(bool isWinner)
        {
            // Checks if amount of total clicks is equal to size of colors array
            if (isWinner && countClick > colors.Length)
            {
                currentLevel -= 2; // Fix lag
                pictureBox_Red.Image = Simon.Properties.Resources.You;
                pictureBox_Green.Image = Simon.Properties.Resources.Have;
                pictureBox_Blue.Image = Simon.Properties.Resources.Gray;
                pictureBox_Yellow.Image = Simon.Properties.Resources.Hair;
                MessageBox.Show("Oh, and you've won! Ho.. Ho.. Ho..");
                pictureBox_Red.Image = null;
                pictureBox_Green.Image = null;
                pictureBox_Blue.Image = null;
                pictureBox_Yellow.Image = null;
            }

            else if (countClick < runtime)
            {
                pictureBox_Red.Image = Simon.Properties.Resources.You;
                pictureBox_Green.Image = Simon.Properties.Resources.Have;
                pictureBox_Blue.Image = Simon.Properties.Resources.Gray;
                pictureBox_Yellow.Image = Simon.Properties.Resources.Hair;
                MessageBox.Show("Oh, and you've lost! You are worthless. Shimon is god. Praise shimon.");
                pictureBox_Red.Image = null;
                pictureBox_Green.Image = null;
                pictureBox_Blue.Image = null;
                pictureBox_Yellow.Image = null;
            }
        }

        // Performs blinks of colors according to the level that the player is currently at
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

        // Checks if the photo clicked by a user is one that blinked in the correct order
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

        // Sets title according to boolean "currentLevelStatus", every tick title is changed to either show current level or show general title
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (currentLevelStatus == false)
                this.Text = "!!! YOU ARE IN LEVEL " + currentLevel + " / " + (colors.Length) + " !!!";
            if (currentLevelStatus == true)
                this.Text = "Simon by Daniel Naaman and Yonatan Shoshani";

            currentLevelStatus = !currentLevelStatus;
        }

        // Receives a picture box and converts it do integer for easier processing
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

        // Triggers timer2 upon each picture click and sets the current pictureBox to the one clicked
        private void pictureBox_Click(object sender, EventArgs e)
        {
            pictureBox = sender as PictureBox;
            timer2.Start();
        }

        // Triggers timer1 and resets runtime and currentLevel
        private void button_Start_Click(object sender, EventArgs e)
        {
            runtime = 1;
            currentLevel = 1;
            timer1.Start();
        }

        // Triggers help button and opens rules and instructions dialog
        private void Form1_HelpButton_Click(Object sender, CancelEventArgs e)
        {
            ShowInstructions();
        }
    }
}