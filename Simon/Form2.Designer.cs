
namespace Simon
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_Instructions = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_Red = new System.Windows.Forms.PictureBox();
            this.pictureBox_Green = new System.Windows.Forms.PictureBox();
            this.pictureBox_Yellow = new System.Windows.Forms.PictureBox();
            this.pictureBox_Blue = new System.Windows.Forms.PictureBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.richTextBox1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(370, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(418, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button_Instructions
            // 
            this.button_Instructions.Cursor = System.Windows.Forms.Cursors.Help;
            this.button_Instructions.Location = new System.Drawing.Point(168, 391);
            this.button_Instructions.Name = "button_Instructions";
            this.button_Instructions.Size = new System.Drawing.Size(128, 28);
            this.button_Instructions.TabIndex = 9;
            this.button_Instructions.Text = "Instructions";
            this.button_Instructions.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_Red);
            this.groupBox1.Controls.Add(this.pictureBox_Green);
            this.groupBox1.Controls.Add(this.pictureBox_Yellow);
            this.groupBox1.Controls.Add(this.pictureBox_Blue);
            this.groupBox1.Location = new System.Drawing.Point(37, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 262);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
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
            // 
            // button_Start
            // 
            this.button_Start.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Start.Location = new System.Drawing.Point(37, 391);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(128, 28);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Simon Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "by Daniel Naaman and Yonatan Shoshani";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Instructions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Instructions";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_Instructions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_Red;
        private System.Windows.Forms.PictureBox pictureBox_Green;
        private System.Windows.Forms.PictureBox pictureBox_Yellow;
        private System.Windows.Forms.PictureBox pictureBox_Blue;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}