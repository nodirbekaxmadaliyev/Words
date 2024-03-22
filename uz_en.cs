using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronXL;
using Words;

namespace Words
{
    public partial class uz_en : Form
    {
        public uz_en()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Words form = new Words();
            this.Hide();
            form.Show();
        }

        private void uz_en_Load(object sender, EventArgs e)
        {

        }

        private void uz_en_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
