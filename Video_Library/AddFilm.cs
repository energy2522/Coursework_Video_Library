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
    public partial class AddFilm : Form
    {
        public AddFilm()
        {
            InitializeComponent();
        }
        public string TXT;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Биографии":
                    {
                        TXT = "Biographies.txt";
                    }
                    break;
                case "Боевики":
                    {
                        TXT = "Militants.txt";
                    }
                    break;
                case "Вестерны":
                    {
                        TXT = "Westerns.txt";
                    }
                    break;
                case "Военные":
                    {
                        TXT = "Military.txt";
                    }
                    break;
                case "Детективы":
                    {
                        TXT = "Detectives.txt";
                    }
                    break;
                case "Документальные":
                    {
                        TXT = "Documentary.txt";
                    }
                    break;
                case "Драмы":
                    {
                        TXT = "Drama.txt";
                    }
                    break;
                case "Исторические":
                    {
                        TXT = "History.txt";
                    }
                    break;
                case "Комедии":
                    {
                        TXT = "Comady.txt";
                    }
                    break;
                case "Криминал":
                    {

                    }
                    break;
                case "Мелодрамы":
                    {

                    }
                    break;
                case "Мультфильмы":
                    {

                    }
                    break;
                case "Мюзиклы":
                    {

                    }
                    break;
                case "Приключения":
                    {

                    }
                    break;
                case "Семейные":
                    {

                    }
                    break;
                case "Спортивные":
                    {

                    }
                    break;
                case "Трилеры":
                    {

                    }
                    break;
                case "Ужасы":
                    {

                    }
                    break;
                case "Фантастика":
                    {

                    }
                    break;
                case "Фэнтези":
                    {

                    }
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Добавить")
            {
                StreamWriter write = new StreamWriter(TXT, true);
                write.WriteLine();
                write.Write(NameBox.Text + "*" + YearBox.Text + "*" + DirectorBox.Text + "*" + ActorsBox.Text + "*" + TimeBox.Text + "*" + ShortBox.Text + "*" + "\\n");
                write.Close();
                NameBox.Text = "";
                YearBox.Text = "";
                DirectorBox.Text = "";
                ActorsBox.Text = "";
                TimeBox.Text = "";
                ShortBox.Text = "";
            }
            else
            {
                Film f = new Film(NameBox.Text, comboBox1.SelectedItem.ToString(), YearBox.Text, DirectorBox.Text, ActorsBox.Text, TimeBox.Text, ShortBox.Text);

                if(Main.films.Contains(f))
                {
                    MessageBox.Show("Фильм уже существует", "Ошибка");
                    return;
                }

                Main m = (Main)Owner;

                m.ChangeRowOfFilm(f);
                Close();
            }
        }
        public void ChangFields(Film film)
        {
            NameBox.Text = film.Name;
            YearBox.Text = film.YearOut;
            DirectorBox.Text = film.Director;
            ActorsBox.Text = film.Actors;
            TimeBox.Text = film.Time;
            ShortBox.Text = film.ShortView;
            comboBox1.Text = film.Genre;

            button1.Text = "Изменить";
            this.Text = "Редактировать фильм";
        }
    }
}
