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
        
    public partial class Choose : Form
    {
        //Loading_screen_Form load1 = new Loading_screen_Form();
        public static string goaliemode;
        public static string playermode;
       public static Profile g1 = new Profile();
       public static Profile P1 = new Profile();
        Menu lll = new Menu();
        public Choose()
         {
            
            InitializeComponent();
            
            
            
             List<Profile> g = new List<Profile>();
            foreach (Profile e1 in Profile.Profiles)
            {
                if (e1.Type == "Goalie")
                {
                    g.Add(e1);
                }
            }
            comboBox1.Items.Add(g);
            comboBox1.DataSource = g;
            List<Profile> s = new List<Profile>();
            foreach (Profile e2 in Profile.Profiles)
            {
                if (e2.Type == "Player")
                {
                    s.Add(e2);
                }
            }
            comboBox2.Items.Add(s);
            comboBox2.DataSource = s;
            g1 = (Profile)comboBox1.SelectedValue;
            P1 = (Profile)comboBox2.SelectedValue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profile p1 = comboBox1.SelectedItem as Profile;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Program.stopplay();
            g1 = (Profile)comboBox1.SelectedValue;
            P1 = (Profile)comboBox2.SelectedValue;
           if(radioButton1.Checked)
            {
               
                playermode = "Cpu";
            }
            if (radioButton2.Checked)
            {
                playermode = "Human";

            }
            if (radioButton3.Checked)
            {
                goaliemode = "Cpu";
            }
            if (radioButton4.Checked)
            {
                goaliemode = "Human";
            }
            Form4 p = new Form4();
            p.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                button1.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void Choose_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
