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
    public partial class Historyform : Form
    {
        public Historyform()
        {
            
            InitializeComponent();
            foreach (History h in History.historyList)
            {
                textBox1.AppendText(h.ToString());
                textBox1.Text += Environment.NewLine;
            }
           

        }

        private void Historyform_Load(object sender, EventArgs e)
        {

           



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
