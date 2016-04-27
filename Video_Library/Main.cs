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
        public Class1 films;
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
            switch (comboBox1.Text) { 
            
                 case "Биографии": {
                films = new Class1("Биографии", str("Biographies.txt"));
                ShowFilms();
                dataGridView1.Visible = true;
                    } break;

                case "Боевики": {
                        films = new Class1("Боевики", str("Militants.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }break;
                case "Вестерны":
                    {
                        films = new Class1("Вестерны", str("Westerns.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Военные":
                    {
                        films = new Class1("Военные", str("Military.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Детективы":
                    {
                        films = new Class1("Детективы", str("Detectives.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Мультфильмы":
                    {
                        films = new Class1("Мультфильмы", str("Cartoons.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Документальные":
                    {
                        films = new Class1("Документальные", str("Documentary.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Драмы":
                    {
                        films = new Class1("Драмы", str("Drama.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Исторические":
                    {
                        films = new Class1("Исторические", str("History.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Комедии":
                    {
                        films = new Class1("Комедии", str("Comady.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Криминал":
                    {
                        films = new Class1("Криминал", str("Crime.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Мелодрамы":
                    {
                        films = new Class1("Мелодрамы", str("Melodrama.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Мюзиклы":
                    {
                        films = new Class1("Мюзиклы", str("Musicals.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Приключения":
                    {
                        films = new Class1("Приключения", str("Adventure.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Семейные":
                    {
                        films = new Class1("Семейные", str("Family.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
                case "Спортивные":
                    {
                        films = new Class1("Спортивные", str("Sports.txt"));
                        ShowFilms();
                        dataGridView1.Visible = true;
                    }
                    break;
        }
            



        }
        private List<Film> str(string TXT)
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
                    List.Add(new Film(s[0], s[1], s[2], s[3], s[4], s[5]));
                }

            }
            film.Close();

            return List;
        }

        public void ShowFilms()
        {

            dataGridView1.RowCount = films.FilmList.Count;

            for (int i = 0; i < films.FilmList.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = films.FilmList[i].Name;
              //  dataGridView1.Rows[i].Cells[1].Value = films.FilmList[i].Genre;
                dataGridView1.Rows[i].Cells[1].Value = films.FilmList[i].YearOut;
                dataGridView1.Rows[i].Cells[2].Value = films.FilmList[i].Director;
                dataGridView1.Rows[i].Cells[3].Value = films.FilmList[i].Actors;
                dataGridView1.Rows[i].Cells[4].Value = films.FilmList[i].Time;
                dataGridView1.Rows[i].Cells[5].Value = films.FilmList[i].ShortView;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Search(textBox1.Text);
            
        }
        public void Search(string NM)
        {
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

           

            int counter = 0;
            foreach (string genre in genres)
            {
                SearchData(genre + ".txt", NM, ref counter);
            }
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
            if (dataGridView1.SelectedCells.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Вы хотите заказать этот фильм?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DateTime dt = DateTime.Now;
                    ;
                    string dat = dt.Date.ToString("dd.MM.yyyy");
                    DateTime dl = dt.AddDays(30);
                    string dal = dl.Date.ToString("dd.MM.yyyy");
                    StreamWriter write = new StreamWriter("users.txt", true);
                    write.WriteLine(log + "/" + films.FilmList[dataGridView1.CurrentRow.Index].Name + "/" + films.FilmList[dataGridView1.CurrentRow.Index].YearOut + "/" + films.FilmList[dataGridView1.CurrentRow.Index].Director + "/" + films.Genre + "/" + dat + "/" + dal + "/");
                    write.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }

            }


        }

        
    }
}
