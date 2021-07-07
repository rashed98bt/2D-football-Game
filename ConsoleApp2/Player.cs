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
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile p2 = new Profile();
            p2.Type = "Player";
            p2.Name = textBox1.Text;
            p2.age = Convert.ToInt32(textBox3.Text);
            p2.pcount = count;
            if (radioButton3.Checked)
            {
                p2.Gender = "Male";
            }
            else if (radioButton4.Checked) {
                p2.Gender = "Female"; 
            }
            if (radioButton3.Checked)
            {
                p2.Gender = "Male";
            }
            else if (radioButton4.Checked)
            {
                p2.Gender = "Female";
            }
            if (radioButton5.Checked)
            {
                p2.avt = "Batman";
            }
            else if (radioButton6.Checked)
            {
                p2.avt = "Deadpool";
            }
            else if (radioButton8.Checked)
            {
                p2.avt = "Thor";
            }
            else if (radioButton7.Checked)
            {
                p2.avt = "Ironman";
            }
            Profile.Profiles.Add(p2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu f4 = new Menu();
            f4.Visible = true;
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
               
            }
            if (count == 7) 
            {
                count = 1;
                pictureBox5.Image= ConsoleApp2.Properties.Resources.madried1;
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
