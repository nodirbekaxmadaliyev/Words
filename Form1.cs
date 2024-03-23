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
        
        List<string> uz = new List<string>();
        List<int> indexes = new List<int>();

        public Words()
        {
            InitializeComponent();
        }


        private void Words_Load(object sender, EventArgs e)
        {
            int i = 1;
            this.en.Add("en");
            this.uz.Add("uz");
            while (sheet["A" + i.ToString()].ToString() != null)
            {
                this.en.Add(sheet["A" + i.ToString()].ToString());
                this.uz.Add(sheet["B" + i.ToString()].ToString());
                i++;
            }
            label4.Text += en.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check(List<int> a, int x)
            {
                foreach (var f in a)
                    if (f == x) return false;
                return true;
            }
            if (first.Text != "" && second.Text != "" && en.Count >= Convert.ToInt32(first.Text) && en.Count >= Convert.ToInt32(second.Text) && Convert.ToInt32(first.Text) <= Convert.ToInt32(second.Text))
            {
                int l = Convert.ToInt32(first.Text), r = Convert.ToInt32(second.Text);
                Random rnd = new Random();
                while (indexes.Count < r - l + 1)
                {

                    int n = rnd.Next(l, r + 1);
                    if (check(indexes, n)) indexes.Add(n);
                }
                en_uz form = new en_uz(en, uz, indexes);
                this.Hide();
                form.Show();
            }
            else MessageBox.Show("Oraliq xato kiritildi!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check(List<int> a, int x)
            {
                foreach (var f in a)
                    if (f == x) return false;
                return true;
            }
            if (first.Text != "" && second.Text != "" && en.Count >= Convert.ToInt32(first.Text) && en.Count >= Convert.ToInt32(second.Text) && Convert.ToInt32(first.Text) <= Convert.ToInt32(second.Text))
            {
                int l = Convert.ToInt32(first.Text), r = Convert.ToInt32(second.Text);
                Random rnd = new Random();
                while (indexes.Count < r - l + 1)
                {

                    int n = rnd.Next(l, r + 1);
                    if (check(indexes, n)) indexes.Add(n);
                }
                uz_en form = new uz_en(en, uz, indexes);
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
