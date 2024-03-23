using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Words;
using IronXL;

namespace Words
{
    public partial class en_uz : Form
    {
        List<string> en;
        List<string> uz;
        List<int> indexes;
        int i = 0, wrong = 0;
        public en_uz()
        {
            InitializeComponent();
        }
        public en_uz(List<string> en, List<string> uz, List<int>indexes)
        {
            InitializeComponent();
            this.en = en;
            this.uz = uz;
            this.indexes = indexes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Words form = new Words();
            this.Hide();
            form.Show();
        }

        private void en_uz_Load(object sender, EventArgs e)
        {
            label1.Text = en[indexes[i]];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == uz[indexes[i]])
            {
                i++;
                if (i == indexes.Count)
                {
                    MessageBox.Show("Number of wrong answer : " + wrong.ToString());
                    Words form = new Words();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    label1.Text = en[indexes[i]];
                    textBox1.Text = "";
                }
            }
            else
            {
                wrong++;
                MessageBox.Show("WRONG!");
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wrong++;
            textBox1.Text = uz[indexes[i]];
   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void en_uz_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
