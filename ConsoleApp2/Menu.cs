
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace ConsoleApp2
{
    public partial class Menu : Form
    {

        //static System.Media.SoundPlayer music = new System.Media.SoundPlayer();
       

        public Menu()
        {
            
            InitializeComponent();
            //Program.play();
            pictureBox4.Parent = panel1;
            pictureBox4.BackColor = Color.Transparent;   
        }
        
        private void hideMenus()
        {
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
            if (panel5.Visible == true)
            {
                panel5.Visible = false;
            }
            if (panel3.Visible == true)
            {
                panel3.Visible = false;
            }
        }
        private void showMenu(Panel p)
        {

            if (p.Visible == false)
            {
                p.Visible = true;
            }
            else
                p.Visible = false;

        }
        private void BackgroundTimer_Tick(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            hideMenus();
            showMenu(panel3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideMenus();
            showMenu(panel4);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Choose c1 = new Choose();
            this.Hide();
            c1.Show();

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                hideMenus();


                showMenu(panel5);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

         
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button12.Visible = true;
            button11.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
            //music.PlayLooping();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
            button11.Visible = true;
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;

            //music.Stop();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Player f = new Player();
            f.Visible = true;      }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Goalie f1 = new Goalie();
            f1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            Current f7 = new Current();
            f7.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Historyform h = new Historyform();
            h.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Statistcs s = new Statistcs();
            s.Show();
            this.Hide();
        }
    }
}
   
