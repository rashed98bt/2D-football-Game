using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsoleApp2
{
    public partial class Goalie : Form
    {
        public Goalie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile p1 = new Profile();
            p1.Type = "Goalie";
            p1.age = Convert.ToInt32(textBox3.Text);
            p1.Name = textBox1.Text;
            p1.pcount = count;
            if (radioButton3.Checked)
            {
                p1.Gender = "Male";
            }
            else if(radioButton4.Checked) {
                p1.Gender = "Female";
            }
            if (radioButton5.Checked)
            {
                p1.avt = "Hulk";
            }
            else if (radioButton6.Checked)
            {
                p1.avt = "Thanos";
            }
            else if (radioButton7.Checked)
            {
                p1.avt = "Frank";
            }
            else if (radioButton8.Checked) {
                p1.avt = "Terminator";
            }
            p1.profilecount++;
            Profile.Profiles.Add(p1);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu f3 = new Menu();
            f3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int count = 1;
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.madried1;
            }
            if (count == 2)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.barcelona;
            }
            if (count == 3)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.bayren;
            }
            if (count == 4)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.faisaly;
            }
            if (count == 5)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.united;
            }
            if (count == 6)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.milan;
                //count = 0;
            }
            if (count == 7)
            {
                count = 1;
                pictureBox5.Image = ConsoleApp2.Properties.Resources.madried1;
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (count > 1)
            {
                count--;

            }
            if (count == 1)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.madried1;
            }
            if (count == 2)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.barcelona;
            }
            if (count == 3)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.bayren;
            }
            if (count == 4)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.faisaly;
            }
            if (count == 5)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.united;
            }
            if (count == 6)
            {
                pictureBox5.Image = ConsoleApp2.Properties.Resources.milan;
                //count = 0;
            }
            if (count == 7)
            {
                count = 1;
                pictureBox5.Image = ConsoleApp2.Properties.Resources.madried1;
            }
        }
    }
    }
