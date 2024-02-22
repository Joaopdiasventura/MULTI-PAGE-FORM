using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MULTI_PAGE_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutBox1 np = new AboutBox1();
            np.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controls nt = new controls();
            nt.Show();
            this.Hide();
        }
    }
}
