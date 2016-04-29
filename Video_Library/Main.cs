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
        public int index;
        public static List<Film> NewListFilm;
        public Main(int count, int index)
        {
            this.index = index;
        }
        public static List<Film> films;// оголошення списку
        public string log;//змінна для логіну
        public Main(string name, string login)
        {
            InitializeComponent();
            label1.Text = "Привет, " + name;//виводимо надпис з іменем
            this.log = login; // передаєм логін
        }
        //показ фільмів за жанром
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ShowFilms(GetGenreFilms(films, comboBox1.Items[comboBox1.SelectedIndex].ToString()));
            dataGridView1.Visible = true;
        }
        //метод, який розбиває дані з текстового файлу і записує у список
        public List<Film> str(string TXT, string genre)
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
        //метод який знаходить фільми по жанру
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
        //метод який записує фільми у dataGridView
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
        //подія для кнопки пошуку
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SearchData(textBox1.Text);

        }
        //метод який виводить знайденні фільми
        public void SearchData(string NM)
        {
            List<Film> list = new List<Film>();

            list.AddRange(SearchFilms(NM));
            comboBox1.Text = "";


            if (list.Count > 0)
            {
                ShowFilms(list);
            }
            else
            {
                MessageBox.Show("Фильма нет");
            }

        }
        //метод закриття форми
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //кнопка переходу в особистий кабінет
        private void button3_Click(object sender, EventArgs e)
        {
            PersonalArea PA = new PersonalArea(log);
            PA.ShowDialog();
        }
        //кнопка виходу з акаунта
        private void button2_Click(object sender, EventArgs e)
        {
            SignIn SI = new SignIn();
            SI.Show();
            this.Hide();
        }
        // метод який додає фільми в акаунт
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //  List<Film> f = GetGenreFilms(films, comboBox1.Items[comboBox1.SelectedIndex].ToString());

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
        //метод який виконується при загрузці форми
        private void Main_Load(object sender, EventArgs e)
        {
            AddFilms();
        }
        //метод який формує список по пошуку
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
        //подія переходу на форму додавання фільму
        private void button4_Click(object sender, EventArgs e)
        {
            AddFilm AF = new AddFilm();
            AF.ShowDialog(this);
            AddFilms();
        }
        //подія переходу на форму зміни фільму
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Выберите фильм", "Ошибка");
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            Film f = FieldsActions.ConvertRowToFilm(row);
            string OldGenre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            AddFilm AF = new AddFilm();
            AF.ChangFields(f);
            AF.ShowDialog(this);
            
            List<string> NewGenre = Film.ListBoxRus();
            if (NewGenre[index].Equals(OldGenre))
            {
                GetListFilms(index);
                SaveData(NewListFilm, index);

            }
            else if (!NewGenre.Equals(OldGenre))
            {
                GetListFilms(index);
                SaveData(NewListFilm, index);
                GetListFilms(GetIndexGenre(OldGenre, NewGenre));
                SaveData(NewListFilm, GetIndexGenre(OldGenre, NewGenre));
            }
        }
        //метод заміни фільму
        public void ChangeRowOfFilm(Film film)
        {
            int ind = films.FindIndex(key => key == FieldsActions.ConvertRowToFilm(dataGridView1.CurrentRow));
            films.RemoveAt(ind);
            films.Insert(ind, film);

            if (film.Genre != dataGridView1.CurrentRow.Cells[1].Value.ToString())
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                return;
            }

            dataGridView1.CurrentRow.Cells[0].Value = film.Name;
            dataGridView1.CurrentRow.Cells[1].Value = film.Genre;
            dataGridView1.CurrentRow.Cells[2].Value = film.YearOut;
            dataGridView1.CurrentRow.Cells[3].Value = film.Director;
            dataGridView1.CurrentRow.Cells[4].Value = film.Actors;
            dataGridView1.CurrentRow.Cells[5].Value = film.Time;
            dataGridView1.CurrentRow.Cells[6].Value = film.ShortView;
        }
        //метод зберігання зміненого фільму
        public void SaveData(List<Film> f, int ind)
        {
            List<string> genre = Film.listBox();
            string[,] s = new string[f.Count(), 6];
            StreamWriter write = new StreamWriter(genre[ind] + ".txt", false);
            for (int i = 0; i < f.Count(); i++)
            {
                if (i == f.Count() - 1)
                {
                    write.Write(f[i].Name + "*" + f[i].YearOut + "*" + f[i].Director + "*" + f[i].Actors + "*" + f[i].Time + "*" + f[i].ShortView + "*" + "\\n");
                }
                else
                {
                    write.WriteLine(f[i].Name + "*" + f[i].YearOut + "*" + f[i].Director + "*" + f[i].Actors + "*" + f[i].Time + "*" + f[i].ShortView + "*" + "\\n");
                }
            }
            write.Close();

        }
        //метод, що утворює список по жанру
        public void GetListFilms(int ind)
        {
            NewListFilm = new List<Film>();
            List<string> genre = Film.ListBoxRus();
            NewListFilm.AddRange(GetGenreFilms(films, genre[ind]));
        }
        //метод який повертає індекс жанра
        public int GetIndexGenre(string genre, List<string> ListGenre)
        {
            int ind = 0;
            for (int i = 0; i < ListGenre.Count; i++)
            {
                if (ListGenre[i] == genre)
                    ind = i;
            }
            return ind;
        }
        //метод  який записує фільми у список
        public void AddFilms()
        {
            films = new List<Film>();
            List<string> genre = Film.listBox();
            for (int i = 0; i < genre.Count; i++)
            {
                films.AddRange(str(genre[i] + ".txt", comboBox1.Items[i].ToString()));
            }
        }
    }
}
