using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using IronXL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Words
{
    public partial class Words : Form
    {
        private List<string> en = new List<string>();
       
        WorkSheet sheet = WorkBook.Load("C:\\Users\\Nodirbek\\Desktop\\English for evolution\\Words\\words.xlsx").WorkSheets.First();
        int i = 1;
        List<string> uz = new List<string>();

        public Words()
        {
            InitializeComponent();
        }


        private void Words_Load(object sender, EventArgs e)
        {
            
            while (sheet["A" + i.ToString()].ToString() != null)
            {
                en.Add(sheet["A" + i.ToString()].ToString());
                uz.Add(sheet["B" + i.ToString()].ToString());
                i++;
            }
            label4.Text += en.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (first.Text != "" && second.Text != "" && en.Count >= Convert.ToInt32(first.Text) && en.Count >= Convert.ToInt32(second.Text) && Convert.ToInt32(first.Text) <= Convert.ToInt32(second.Text))
            {
                en_uz form = new en_uz(en);
                this.Hide();
                form.Show();
            }
            else MessageBox.Show("Oraliq xato kiritildi!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (first.Text != "" && second.Text != "" && en.Count >= Convert.ToInt32(first.Text) && en.Count >= Convert.ToInt32(second.Text) && Convert.ToInt32(first.Text) <= Convert.ToInt32(second.Text))
            {
                uz_en form = new uz_en();
                this.Hide();
                form.Show();
            }
            else MessageBox.Show("Oraliq xato kiritildi!");
        }

        private void Words_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void first_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void second_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
