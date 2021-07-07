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
    public partial class Current : Form
    {
        public Current()
        {
            InitializeComponent();
            foreach (Profile e in Profile.Profiles) {
                textBox1.Text += "\n";
                textBox1.AppendText(e.ToString());
                textBox1.Text += "\n______________________________________________________________________";
                    }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu f2 = new Menu();
            f2.Show();
        }
       
        
    }
}
