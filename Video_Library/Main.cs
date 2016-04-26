using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Video_Library
{
    public partial class Main : Form
    {
        static public string NameF;
        static public string YearO;
        static public string Dir;
        public Main(string frm)
        {
            InitializeComponent();
            label1.Text = "Привет, "+frm;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (comboBox1.Text.Equals("Биографии")) { str("Biographies.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Боевики")) { str("Militants.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Вестерны")) { str("Westerns.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Военные")) { str("Military.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Детективы")) { str("Detectives.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Мультфильмы")) { str("Cartoons.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Документальные")) { str("Documentary.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Драмы")) { str("Drama.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Исторические")) { str("History.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Комедии")) { str("Comady.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Криминал")) { str("Crime.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Мелодрамы")) { str("Melodrama.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Мюзиклы")) { str("Musicals.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Приключения")) { str("Adventure.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Семейные")) { str("Family.txt"); dataGridView1.Visible = true; }
            else if (comboBox1.Text.Equals("Спортивные")) { str("Sports.txt"); dataGridView1.Visible = true; }
            



        }
        public void str(string TXT)
        {
            StreamReader film = new StreamReader(TXT, Encoding.UTF8);
            while (true)
            {
                int t = 0;
                string str = film.ReadLine();
                if (str == null) break;
                int ind = str.IndexOf('*');
                string FN = str.Substring(0, ind);
                int ind1 = str.IndexOf('*', ind + 1);
                t = ind1 - ind;
                string Y = str.Substring(ind+1,t-1);
                int ind2 = str.IndexOf('*', ind1 + 1);
                t = ind2 - ind1;
                string D = str.Substring(ind1 + 1, t-1);
                int ind3 = str.IndexOf('*', ind2 + 1);
                t = ind3 - ind2;
                string A = str.Substring(ind2 + 1, t - 1);
                int ind4 = str.IndexOf('*', ind3 + 1);
                t = ind4 - ind3;
                string T = str.Substring(ind3 + 1, t - 1);
                int ind5 = str.IndexOf('*', ind4 + 1);
                t = ind5 - ind4;
                string O = str.Substring(ind4 + 1, t - 1);
                dataGridView1.Rows.Add(FN, Y, D, A, T, O);


            }
            film.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Search(textBox1.Text);
            
        }
        public void Search(string NM)
        {
            int counter = 0;
            SearchData("Biographies.txt", NM, ref counter);
            SearchData("Militants.txt", NM, ref counter);
            SearchData("Westerns.txt", NM, ref counter);
            SearchData("Military.txt", NM, ref counter);
            SearchData("Detectives.txt", NM, ref counter);
            SearchData("Cartoons.txt", NM, ref counter);
            SearchData("Documentary.txt", NM, ref counter);
            SearchData("Drama.txt", NM, ref counter);
            SearchData("History.txt", NM, ref counter);
            SearchData("Comady.txt", NM, ref counter);
            if (counter != 0)
            {
                dataGridView1.Visible = true;
            }
            else
            {
                dataGridView1.Visible = false;
                MessageBox.Show("Фильма с таким именем нет");
            }

        }
        public void SearchData(string way, string NM, ref int counter)
        {
            StreamReader film = new StreamReader(way, Encoding.UTF8);
            
            while (true)
            {
                
                string str = film.ReadLine();
                if (str == null) break;
                int l = NM.Length;
                NM = NM.ToUpper();
                int ind = str.IndexOf('*');
                string Name1 = str.Substring(0, l).ToUpper();
                if (NM.Equals(Name1))
                {
                    string Name = str.Substring(0, ind);
                    int t = 0;
                    int ind1 = str.IndexOf('*', ind + 1);
                    t = ind1 - ind;
                    string Y = str.Substring(ind + 1, t - 1);
                    int ind2 = str.IndexOf('*', ind1 + 1);
                    t = ind2 - ind1;
                    string D = str.Substring(ind1 + 1, t - 1);
                    int ind3 = str.IndexOf('*', ind2 + 1);
                    t = ind3 - ind2;
                    string A = str.Substring(ind2 + 1, t - 1);
                    int ind4 = str.IndexOf('*', ind3 + 1);
                    t = ind4 - ind3;
                    string T = str.Substring(ind3 + 1, t - 1);
                    int ind5 = str.IndexOf('*', ind4 + 1);
                    t = ind5 - ind4;
                    string O = str.Substring(ind4 + 1, t - 1);
                    dataGridView1.Rows.Add(Name, Y, D, A, T, O);
                    counter++;
                }
            }
           
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonalArea PA = new PersonalArea();
            PA.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignIn SI = new SignIn();
            SI.Show();
            this.Hide();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //testValue2 = (String)dataGridView1["Name", 4].Value;
        }
    }
}
