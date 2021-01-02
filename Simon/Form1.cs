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
        int[] colorsArray = new int[10];

        public Form1()
        {
            InitializeComponent();
            FillRandoms();
        }
        
        void FillRandoms()
        {
            for (int i = 0; i < colorsArray.Length; i++)
            {
                colorsArray[i] = rnd.Next(1, 5);
            }
        }

        public void Gadi()
        {
            for (int i = 0; i < colorsArray.Length; i++)
            {
                switch (colorsArray[i])
                {
                    case 1:
                        timer1.Start();
                        break;
                    case 2:
                        timer2.Start();
                        break;
                    case 3:
                        timer3.Start();
                        break;
                    case 4:
                        timer4.Start();
                        break;
                }
            }
        }

        // Timers

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox_Red.BackColor == Color.Red)
            {
                pictureBox_Red.BackColor = Color.Salmon;
            }
            else
            {
                pictureBox_Red.BackColor = Color.Red;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox_Green.BackColor == Color.Green)
            {
                pictureBox_Green.BackColor = Color.LightGreen;
            }
            else
            {
                pictureBox_Green.BackColor = Color.Green;
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox_Blue.BackColor == Color.Blue)
            {
                pictureBox_Blue.BackColor = Color.LightBlue;
            }
            else
            {
                pictureBox_Blue.BackColor = Color.Blue;
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pictureBox_Yellow.BackColor == Color.Yellow)
            {
                pictureBox_Yellow.BackColor = Color.LightYellow;
            }
            else
            {
                pictureBox_Yellow.BackColor = Color.Yellow;
                timer4.Stop();
            }
        }

        // Buttons

        public void button_Start_Click(object sender, EventArgs e)
        {
            Gadi();
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
