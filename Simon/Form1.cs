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
        public Form1()
        {
            InitializeComponent();
        }

        // Red    - 1
        // Green  - 2
        // Blue   - 3
        // Yellow - 4

        public void button_Start_Click(object sender, EventArgs e)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            int num = 1;

            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(1, 5);
            }

            Thread.Sleep(3000);

            for (int i = 0; i < array.Length; i++)
            {
                while (num <= i)
                {
                    if (array[num] == 1)
                    {
                        pictureBox_Red.BackColor = Color.DarkRed;
                        num++;
                    }
                    
                    else if (array[num] == 2)
                    {
                        pictureBox_Green.BackColor = Color.DarkGreen;
                        num++;
                    }

                    else if (array[num] == 3)
                    {
                        pictureBox_Blue.BackColor = Color.DarkBlue;
                        num++;
                    }

                    else if (array[num] == 4)
                    {
                        pictureBox_Yellow.BackColor = Color.DarkOrange;
                        num++;
                    }
                    Thread.Sleep(3000);
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
