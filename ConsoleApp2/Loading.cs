using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ConsoleApp2
{

    public partial class Loading_screen_Form : Form
    {
        

        public Loading_screen_Form()
        {
            InitializeComponent();


           Program.play();
            label1.Parent = Loading_screen1;
            label2.Parent = Loading_screen1;
            label2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            pictureBox1.Parent = Loading_screen1;
            pictureBox1.BackColor = Color.Transparent;
          
            
            panel1.Controls.Add(Ball);
          
            
            Ball.BackColor = Color.Transparent;
           

        }

        private void Loading_screen_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loading_Timer_Tick(object sender, EventArgs e)
        {
            Ball.Visible = true;
            panel2.Width += 2;
            Ball.Location = new Point(Ball.Location.X + 2, Ball.Location.Y);
            if(panel2.Width==panel1.Width)
            {
                Loading_Timer.Stop();
                this.Visible = false;
                Menu form2 = new Menu();
                form2.Visible = true;

            }
            if (panel2.Width == 100)
            {
                label3.Parent = Loading_Screen2;
                label3.BackColor = Color.Transparent;
                label3.Visible = true;
                label1.Parent = Loading_screen1;
                label2.Parent = Loading_screen1;
                label2.BackColor = Color.Transparent;
                label1.BackColor = Color.Transparent;
              
              
                
            }

                if (panel2.Width==300)
            {

                pictureBox1.Visible = false;
                pictureBox2.Parent = Loading_screen1;
                pictureBox2.BackColor = Color.Transparent;

                pictureBox2.Visible = true;
                Loading_screen1.Visible = false;
                Loading_Screen2.Visible = true;
                label3.BackColor = Color.Transparent;
                label2.BackColor = Color.Transparent;
                label1.BackColor = Color.Transparent;
                label3.Visible = true;
                label1.Parent = Loading_Screen2;
                label2.Parent = Loading_Screen2;
                label3.Parent = Loading_Screen2;
              
               
                pictureBox2.Parent = Loading_Screen2;
                pictureBox2.BackColor = Color.Transparent;
                

                
               
               
                





            }
           
                if (panel2.Width > 380)
            {
               
                label1.Parent = Loading_Screen3;
                label2.Parent = Loading_Screen3;
                pictureBox2.Parent = Loading_Screen3;
                pictureBox2.BackColor = Color.Transparent;

                label2.BackColor = Color.Transparent;
                label1.BackColor = Color.Transparent;
                label3.Parent = Loading_Screen3;
                label3.BackColor = Color.Transparent;
                label3.Visible = true;
                
               
                Loading_screen1.Visible = false;
                Loading_Screen2.Visible = false;
                Loading_Screen3.Visible = true;


            }
            if (panel2.Width > 420)
            {
                label1.Parent = Loading_Screen3;
                label2.Parent = Loading_Screen3;
                label3.Parent = Loading_Screen3;
                label1.BackColor = Color.Transparent;
                label2.BackColor = Color.Transparent;
                label2.BackColor = Color.Transparent;
                label4.Parent = Loading_Screen3;
                label4.BackColor = Color.Transparent;
                label4.Visible = true;
            }
        }

        private void Ball_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
