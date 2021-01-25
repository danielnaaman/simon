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
        private int[] colors = new int[3];
        private int blink;
        private int placeInArray = 0;
        private int runtime = 0;
        private int click = 0;
        private PictureBox pictureBox;

        public Form1()
        {
            InitializeComponent();
            FillRandoms();
        }

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

        public void button_Start_Click(object sender, EventArgs e)
        {
            runtime = 1;
            timer1.Start();
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

        private void pictureBox_Click(object sender, EventArgs e)
        {
            pictureBox = sender as PictureBox;

            timer2.Start();

            //if (runtime < colors.Length)
            //{
            //    runtime++;
            //    timer1.Start();
            //}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int picture = ConvertToInteger(pictureBox);

            if (picture == colors[click])
            {
                click++;
            }

            else
            {
                timer2.Stop();
                timer1.Start();
                MessageBox.Show("You are fat and you suck"); // Change comment ^backlog
                click = 0;
            }
        }

    private int ConvertToInteger(PictureBox pictureBox)
        {
            // Converts a string to integer following the scheme on timer1_Tick switch()

            if (pictureBox.Name.EndsWith("Red"))
            {
                return 1;
            }

            else if (pictureBox.Name.EndsWith("Yellow"))
            {
                return 4;
            }

            else if (pictureBox.Name.EndsWith("Green"))
            {
                return 2;
            }

            else // Blue
            {
                return 3;
            }
        }
    }
}