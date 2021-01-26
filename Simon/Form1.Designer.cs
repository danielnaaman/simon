
namespace Simon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_Red = new System.Windows.Forms.PictureBox();
            this.pictureBox_Green = new System.Windows.Forms.PictureBox();
            this.pictureBox_Yellow = new System.Windows.Forms.PictureBox();
            this.pictureBox_Blue = new System.Windows.Forms.PictureBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Red
            // 
            this.pictureBox_Red.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox_Red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Red.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Red.Name = "pictureBox_Red";
            this.pictureBox_Red.Size = new System.Drawing.Size(123, 123);
            this.pictureBox_Red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Red.TabIndex = 0;
            this.pictureBox_Red.TabStop = false;
            this.pictureBox_Red.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox_Green
            // 
            this.pictureBox_Green.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox_Green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Green.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Green.Location = new System.Drawing.Point(142, 12);
            this.pictureBox_Green.Name = "pictureBox_Green";
            this.pictureBox_Green.Size = new System.Drawing.Size(123, 123);
            this.pictureBox_Green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Green.TabIndex = 1;
            this.pictureBox_Green.TabStop = false;
            this.pictureBox_Green.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox_Yellow
            // 
            this.pictureBox_Yellow.BackColor = System.Drawing.Color.Orange;
            this.pictureBox_Yellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Yellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Yellow.Location = new System.Drawing.Point(142, 144);
            this.pictureBox_Yellow.Name = "pictureBox_Yellow";
            this.pictureBox_Yellow.Size = new System.Drawing.Size(123, 123);
            this.pictureBox_Yellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Yellow.TabIndex = 2;
            this.pictureBox_Yellow.TabStop = false;
            this.pictureBox_Yellow.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox_Blue
            // 
            this.pictureBox_Blue.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox_Blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Blue.Location = new System.Drawing.Point(12, 144);
            this.pictureBox_Blue.Name = "pictureBox_Blue";
            this.pictureBox_Blue.Size = new System.Drawing.Size(123, 123);
            this.pictureBox_Blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Blue.TabIndex = 3;
            this.pictureBox_Blue.TabStop = false;
            this.pictureBox_Blue.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // button_Start
            // 
            this.button_Start.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Start.Location = new System.Drawing.Point(12, 277);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(253, 28);
            this.button_Start.TabIndex = 4;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 2000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 314);
            this.Controls.Add(this.pictureBox_Red);
            this.Controls.Add(this.pictureBox_Green);
            this.Controls.Add(this.pictureBox_Yellow);
            this.Controls.Add(this.pictureBox_Blue);
            this.Controls.Add(this.button_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simon by Daniel Naaman and Yonatan Shoshani";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Red;
        private System.Windows.Forms.PictureBox pictureBox_Green;
        private System.Windows.Forms.PictureBox pictureBox_Yellow;
        private System.Windows.Forms.PictureBox pictureBox_Blue;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

