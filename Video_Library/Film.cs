using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Library
{
    public class Film
    {
        public string Time;
        public string Name;
        public string YearOut;
        public string Actors;
        public string Director;
        public string ShortView;
        public string Genre;

        //конструктор, який заповнює всі данні про фільм
        public Film(string Name, string Genre, string YearOut, string Director, string Actors, string Time, string ShortView)
        {
            this.Genre = Genre;
            this.Name = Name;
            this.YearOut = YearOut;
            this.Time = Time;
            this.Actors = Actors;
            this.Director = Director;
            this.ShortView = ShortView;
        }
        //метод, який перевизначає ==
        public static bool operator ==(Film f1, Film f2)
        {
            if (f1.Name == f2.Name && f1.Genre == f2.Genre && f1.Director == f2.Director && f1.Actors == f2.Actors && f1.Time == f2.Time &&
                f1.YearOut == f2.YearOut && f1.ShortView == f2.ShortView)
            {
                return true;
            }
            return false;
        }
        //метод, який перевизначає !=
        public static bool operator !=(Film f1, Film f2)
        {
            if (f1.Name != f2.Name || f1.Genre != f2.Genre || f1.Director != f2.Director || f1.Actors != f2.Actors || f1.Time != f2.Time ||
                f1.YearOut != f2.YearOut || f1.ShortView != f2.ShortView)
            {
                return true;
            }
            return false;
        }
        //метод, який перевизначає Equals
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;

            Film f = (Film)obj;
            return (Name == f.Name && Genre == f.Genre && Director == f.Director && Actors == f.Actors && Time == f.Time &&
                YearOut == f.YearOut && ShortView == f.ShortView);
        }
        //
        public override int GetHashCode()
        {
            int hash = Name.GetHashCode();
            hash = hash * 10 + Genre.GetHashCode();
            hash = hash * 10 + Actors.GetHashCode();
            hash = hash * 10 + YearOut.GetHashCode();
            hash = hash * 10 + Director.GetHashCode();
            hash = hash * 10 + Time.GetHashCode();
            hash = hash * 10 + ShortView.GetHashCode();

            return hash;
        }
        //метод, який формує список посилань на файл з жанром
        public static List<string> listBox()
        {

            List<string> genre = new List<string>
            {

                "Biographies",
                "Militants",
                "Westerns",
                "Military",
                "Detectives",
                "Documentary",
                "Drama",
                "History",
                "Comady",
                "Crime",
                "Melodrama",
                "Cartoons",
                "Musicals",
                "Adventure",
                "Family",
                "Sports",
                "Thrillers",
                "Horrors",
                "Fantastic",
                "Fantasy"




            };
            return genre;
        }
        //метод, який формує список жанрів
        public static List<string> ListBoxRus()
        {
            List<string> GenreRus = new List<string>
            {

               "Биографии",
                "Боевики",
                "Вестерны",
                "Военные",
                "Детективы",
                "Документальные",
                "Драмы",
                "Исторические",
                "Комедии",
                "Криминал",
                "Мелодрамы",
                "Мультфильмы",
                "Мюзиклы",
                "Приключения",
                "Семейные",
                "Спортивные",
                "Трилеры",
                "Ужасы",
                "Фантастика",
                "Фэнтези"




            };
            return GenreRus;
        }
        }

}
