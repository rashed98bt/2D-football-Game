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
    public partial class Statistcs : Form
    {
        public Statistcs()
        {
            InitializeComponent();
            var q1 = from Profile p in Profile.Profiles
                    select p.profilecount;
             foreach(int x in q1) 
            {
                label10.Text = x.ToString();
            }
            var q2 = from History h in History.historyList
                     select h.gamescount;
            foreach(int x in q2) 
            {
                label9.Text = x.ToString();
            }
            var q3 = from History h in History.historyList
                     orderby h.player_score descending
                     select h.player_score;
                      
            foreach(int x in q3) 
            {
                label11.Text = x.ToString();
            }

            var q4 = from History his1 in History.historyList
                     where his1.player_score >= 0
                     orderby his1.player_score ascending
                     select his1.player_score;
            foreach (int x1 in q4) {
                label12.Text = x1.ToString();
            }
                
            var q5 = from History h2 in History.historyList
                     orderby h2.duration descending
                     select h2.duration;
            foreach (int x in q5)
            {
                label13.Text = x.ToString();
            }

            var q6 = from History h3 in History.historyList
                     orderby h3.duration ascending
                     select h3.duration;
            foreach (int x in q6)
            {
                label14.Text = x.ToString();
            }
            int sum = 0;
            var q7 = from History h in History.historyList
                     select sum += h.duration;
            foreach (int x in q7) {
                label15.Text = x.ToString();
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }
    }
}
