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
        List<string> words;
        public en_uz()
        {
            InitializeComponent();
        }
        public en_uz(List<string> words)
        {
            InitializeComponent();
            this.words = words;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Words form = new Words();
            this.Hide();
            form.Show();
        }

        private void en_uz_Load(object sender, EventArgs e)
        {
            label1.Text = words.ToString();
            bool check(List<int> a, int x)
            {
                foreach(var f in a)
                    if (f == x) return false;
                return true;
            }
            WorkSheet sheet = WorkBook.Load("C:\\Users\\Nodirbek\\Desktop\\English for evolution\\Words\\words.xlsx").WorkSheets.First();
            int i = 1;
            List<string> en = new List<string>();
            List<string> uz = new List<string>();
            while (sheet["A" + i.ToString()].ToString() != null)
            {
                en.Add(sheet["A" + i.ToString()].ToString());
                uz.Add(sheet["B" + i.ToString()].ToString());
                i++;
            }
            Words form = new Words();
            int l = Convert.ToInt32(form.first.Text), r = l = Convert.ToInt32(form.second.Text), wrong = 0;
            List <int> indexes = new List<int>();
            Random rnd = new Random();
            while (indexes.Count < r - l + 1)
            {

                int n = rnd.Next(l, r + 1);
                if (check(indexes, n)) indexes.Add(n);
            }
            i = 0;

        }
        private void en_uz_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
