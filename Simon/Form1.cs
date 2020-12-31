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
        Random rnd = new Random();

        bool isClicked = false;
        int[] colorsArray = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        public void button_Start_Click(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                timer1.Start();
                isClicked = true;
                button_Start.Text = "Stop / Reset";
            }

            else
            {
                timer1.Stop();
                isClicked = false;
                button_Start.Text = "Start";

                pictureBox_Red.BackColor = Color.Red;
                pictureBox_Green.BackColor = Color.Green;
                pictureBox_Blue.BackColor = Color.Blue;
                pictureBox_Yellow.BackColor = Color.Yellow;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Red    - 1
            // Green  - 2
            // Blue   - 3
            // Yellow - 4

            for (int i = 0; i < colorsArray.Length; i++)
            {
                colorsArray[i] = rnd.Next(1, 9);

                if (i == 1)
                {
                    colorsArray[i + 1] = 2;
                }

                else if (i == 2)
                {
                    colorsArray[i + 2] = 3;
                }

                else if (i == 3)
                {
                    colorsArray[i + 3] = 4;
                }

                else if (i == 4)
                {
                    colorsArray[i + 4] = 5;
                }

                i++;
            }

            for (int i = 0; i < colorsArray.Length; i++)
            {
                switch (colorsArray[i])
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
            }
        }

        private void button_Instructions_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        private void Form1_HelpButtonClicked(Object sender, CancelEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
