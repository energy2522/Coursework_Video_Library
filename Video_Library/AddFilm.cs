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
        public int index;//змінна для передачі індексу в comboBox
        public static List<Film> films;//оголошення списку
        public string TXT;//поле для рядка
        //метод, який робить посилання на файл
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> genre = Film.listBox();
            int ind = comboBox1.SelectedIndex;

            TXT = genre[ind] + ".txt";

        }
        //подія нажаття на кнопку
        private void button1_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || TimeBox.Text == "" || YearBox.Text == "" || DirectorBox.Text == "" || ActorsBox.Text == "" || ShortBox.Text == "" || comboBox1.Text == "") { Eror.Text = "не все поля заполены"; }
            else {
                Eror.Text = "";
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
                    Close();



                }
                else
                {
                    Film f = new Film(NameBox.Text, comboBox1.SelectedItem.ToString(), YearBox.Text, DirectorBox.Text, ActorsBox.Text, TimeBox.Text, ShortBox.Text);

                    if (Main.films.Contains(f))
                    {
                        MessageBox.Show("Фильм уже существует", "Ошибка");
                        return;
                    }

                    Main m = (Main)Owner;

                    m.ChangeRowOfFilm(f);
                    m.index = comboBox1.SelectedIndex;
                    Close();
                }
            }
        }
        //метод, який виводить в поля данні про фільм
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

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsPunctuation(ch)  || ch=='*' || ch == '\'' || Char.IsSymbol(ch))
            {
                e.Handled = true;
            }
        }

        private void YearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void DirectorBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsPunctuation(ch) || Char.IsDigit(ch) || Char.IsSeparator(ch) || Char.IsSymbol(ch))
            {
                e.Handled = true;
            }
        }

        private void ActorsBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsPunctuation(ch) || Char.IsDigit(ch) || Char.IsSeparator(ch) || Char.IsSymbol(ch))
            {
                e.Handled = true;
            }
        }

        private void TimeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Eror.Text = "";
            char ch = e.KeyChar;
            if (Char.IsPunctuation(ch)  || Char.IsSeparator(ch) || Char.IsSymbol(ch))
            {
                e.Handled = true;
            }
        }

        private void ShortBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsPunctuation(ch) || ch == '*' || ch == '\'' || Char.IsSymbol(ch))
            {
                e.Handled = true;
            }
        }
    }
}
