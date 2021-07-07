﻿namespace ConsoleApp2
{
    partial class Loading_screen_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading_screen_Form));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Loading_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Loading_Screen2 = new System.Windows.Forms.PictureBox();
            this.Loading_Screen3 = new System.Windows.Forms.PictureBox();
            this.Loading_screen1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Screen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Screen3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_screen1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Ball);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(25, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 31);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(14, 0);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(33, 28);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            this.Ball.Click += new System.EventHandler(this.Ball_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 29);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Loading_Timer
            // 
            this.Loading_Timer.Enabled = true;
            this.Loading_Timer.Interval = 20;
            this.Loading_Timer.Tick += new System.EventHandler(this.Loading_Timer_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Loading_screen1);
            this.panel3.Controls.Add(this.Loading_Screen2);
            this.panel3.Controls.Add(this.Loading_Screen3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 409);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(345, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hold Space to Power up the shot";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "UpArrow and DownArrow to aim";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Made by KyrzemGaming";
            // 
            // Loading_Screen2
            // 
            this.Loading_Screen2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loading_Screen2.Image = ((System.Drawing.Image)(resources.GetObject("Loading_Screen2.Image")));
            this.Loading_Screen2.Location = new System.Drawing.Point(0, 0);
            this.Loading_Screen2.Name = "Loading_Screen2";
            this.Loading_Screen2.Size = new System.Drawing.Size(764, 409);
            this.Loading_Screen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loading_Screen2.TabIndex = 0;
            this.Loading_Screen2.TabStop = false;
            // 
            // Loading_Screen3
            // 
            this.Loading_Screen3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loading_Screen3.Image = ((System.Drawing.Image)(resources.GetObject("Loading_Screen3.Image")));
            this.Loading_Screen3.Location = new System.Drawing.Point(0, 0);
            this.Loading_Screen3.Name = "Loading_Screen3";
            this.Loading_Screen3.Size = new System.Drawing.Size(764, 409);
            this.Loading_Screen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loading_Screen3.TabIndex = 0;
            this.Loading_Screen3.TabStop = false;
            this.Loading_Screen3.Visible = false;
            // 
            // Loading_screen1
            // 
            this.Loading_screen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loading_screen1.Image = ((System.Drawing.Image)(resources.GetObject("Loading_screen1.Image")));
            this.Loading_screen1.Location = new System.Drawing.Point(0, 0);
            this.Loading_screen1.Name = "Loading_screen1";
            this.Loading_screen1.Size = new System.Drawing.Size(764, 409);
            this.Loading_screen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loading_screen1.TabIndex = 0;
            this.Loading_screen1.TabStop = false;
            this.Loading_screen1.Click += new System.EventHandler(this.Loading_screen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Use W and S to move the GK";
            // 
            // Loading_screen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading_screen_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading_Screen_Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Screen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Screen3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_screen1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer Loading_Timer;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Loading_Screen2;
        private System.Windows.Forms.PictureBox Loading_Screen3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Loading_screen1;
        private System.Windows.Forms.Label label2;
    }
}