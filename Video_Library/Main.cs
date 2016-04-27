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

        public List<Film> films;
        public string log;
        public Main(string frm, string log)
        {
            InitializeComponent();
            label1.Text = "Привет, "+frm;
            this.log = log;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ShowFilms(GetGenreFilms(films, comboBox1.Items[comboBox1.SelectedIndex].ToString()));
            dataGridView1.Visible = true;



        }

        private List<Film> str(string TXT, string genre)
        {
            List<Film> List = new List<Film>();

            StreamReader film = new StreamReader(TXT, Encoding.UTF8);
            while (true)
            {
                string str = film.ReadLine();
                if (str == null) break;

                string[] s1 = film.ReadToEnd().Split('\n');

                for (int i = 0; i < s1.Length; i++)
                {
                    string[] s = s1[i].Split('*');
                    List.Add(new Film(s[0], genre, s[1], s[2], s[3], s[4], s[5]));
                }

            }
            film.Close();

            return List;
        }


        public List<Film> GetGenreFilms(List<Film> films, string genre)
        {
            List<Film> res = new List<Film>();

            if (genre == "")
                res = films;
            else
            {
                for (int i = 0; i < films.Count; i++)
                {
                    if (films[i].Genre == genre)
                        res.Add(films[i]);
                }
            }

            return res;
        }



        public void ShowFilms(List<Film> films)
        {

            dataGridView1.RowCount = films.Count;

            for (int i = 0; i < films.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = films[i].Name;
                dataGridView1.Rows[i].Cells[1].Value = films[i].Genre;
                dataGridView1.Rows[i].Cells[2].Value = films[i].YearOut;
                dataGridView1.Rows[i].Cells[3].Value = films[i].Director;
                dataGridView1.Rows[i].Cells[4].Value = films[i].Actors;
                dataGridView1.Rows[i].Cells[5].Value = films[i].Time;
                dataGridView1.Rows[i].Cells[6].Value = films[i].ShortView;
            }

            dataGridView1.Visible = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SearchData(textBox1.Text);
            
        }
        
        public void SearchData(string NM)
        {
            List<Film> list = new List<Film>(); 

            list.AddRange(SearchFilms(NM));
            comboBox1.Text = "";


            if(list.Count > 0)
            {
                ShowFilms(list);
            }
            else
            {
                MessageBox.Show("Фильма нет");
            }

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonalArea PA = new PersonalArea( log);
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
            List<Film> f = GetGenreFilms(films, comboBox1.Items[comboBox1.SelectedIndex].ToString());

            if (dataGridView1.SelectedCells.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Вы хотите заказать этот фильм?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DateTime dt = DateTime.Now;
                    
                    string dat = dt.Date.ToString("dd.MM.yyyy");
                    DateTime dl = dt.AddDays(30);
                    string dal = dl.Date.ToString("dd.MM.yyyy");
                    StreamWriter write = new StreamWriter("users.txt", true);
                    write.WriteLine(log + "/" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value + "/" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value + "/" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value + "/" + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value + "/" + dat + "/" + dal + "/");
                    write.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }

            }


        }

        private void Main_Load(object sender, EventArgs e)
        {
            films = new List<Film>();
            List<string> genres = new List<string>()
            {
                "Biographies",
                "Militants",
                "Westerns",
                "Military",
                "Detectives",
                "Cartoons",
                "Documentary",
                "Drama",
                "History",
                "Comady"
            };
            for (int i = 0; i < genres.Count; i++)
            {
                films.AddRange(str(genres[i] + ".txt", comboBox1.Items[i].ToString()));
            }
        }

        public List<Film> SearchFilms(string key)
        {
            List<Film> move = new List<Film>();
            for (int i = 0; i < films.Count; i++)
            {
                if (films[i].Name.ToLower().Contains(key.ToLower()))
                    move.Add(films[i]);
            }
            return move;
        }
    }
}
