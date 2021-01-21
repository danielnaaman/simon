
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Instructions = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Red
            // 
            this.pictureBox_Red.BackColor = System.Drawing.Color.Red;
            this.pictureBox_Red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Red.Location = new System.Drawing.Point(15, 19);
            this.pictureBox_Red.Name = "pictureBox_Red";
            this.pictureBox_Red.Size = new System.Drawing.Size(110, 110);
            this.pictureBox_Red.TabIndex = 0;
            this.pictureBox_Red.TabStop = false;
            this.pictureBox_Red.Click += new System.EventHandler(this.pictureBox_Green_Click);
            // 
            // pictureBox_Green
            // 
            this.pictureBox_Green.BackColor = System.Drawing.Color.Green;
            this.pictureBox_Green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Green.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Green.Location = new System.Drawing.Point(136, 19);
            this.pictureBox_Green.Name = "pictureBox_Green";
            this.pictureBox_Green.Size = new System.Drawing.Size(110, 110);
            this.pictureBox_Green.TabIndex = 1;
            this.pictureBox_Green.TabStop = false;
            this.pictureBox_Green.Click += new System.EventHandler(this.pictureBox_Green_Click);
            // 
            // pictureBox_Yellow
            // 
            this.pictureBox_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox_Yellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Yellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Yellow.Location = new System.Drawing.Point(137, 140);
            this.pictureBox_Yellow.Name = "pictureBox_Yellow";
            this.pictureBox_Yellow.Size = new System.Drawing.Size(110, 110);
            this.pictureBox_Yellow.TabIndex = 2;
            this.pictureBox_Yellow.TabStop = false;
            this.pictureBox_Yellow.Click += new System.EventHandler(this.pictureBox_Green_Click);
            // 
            // pictureBox_Blue
            // 
            this.pictureBox_Blue.BackColor = System.Drawing.Color.Blue;
            this.pictureBox_Blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Blue.Location = new System.Drawing.Point(15, 140);
            this.pictureBox_Blue.Name = "pictureBox_Blue";
            this.pictureBox_Blue.Size = new System.Drawing.Size(110, 110);
            this.pictureBox_Blue.TabIndex = 3;
            this.pictureBox_Blue.TabStop = false;
            this.pictureBox_Blue.Click += new System.EventHandler(this.pictureBox_Green_Click);
            // 
            // button_Start
            // 
            this.button_Start.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Start.Location = new System.Drawing.Point(12, 281);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(128, 28);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_Red);
            this.groupBox1.Controls.Add(this.pictureBox_Green);
            this.groupBox1.Controls.Add(this.pictureBox_Yellow);
            this.groupBox1.Controls.Add(this.pictureBox_Blue);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // button_Instructions
            // 
            this.button_Instructions.Cursor = System.Windows.Forms.Cursors.Help;
            this.button_Instructions.Location = new System.Drawing.Point(143, 281);
            this.button_Instructions.Name = "button_Instructions";
            this.button_Instructions.Size = new System.Drawing.Size(128, 28);
            this.button_Instructions.TabIndex = 6;
            this.button_Instructions.Text = "Instructions";
            this.button_Instructions.UseVisualStyleBackColor = true;
            this.button_Instructions.Click += new System.EventHandler(this.button_Instructions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 321);
            this.Controls.Add(this.button_Instructions);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Red;
        private System.Windows.Forms.PictureBox pictureBox_Green;
        private System.Windows.Forms.PictureBox pictureBox_Yellow;
        private System.Windows.Forms.PictureBox pictureBox_Blue;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Instructions;
        private System.Windows.Forms.Timer timer2;
    }
}

