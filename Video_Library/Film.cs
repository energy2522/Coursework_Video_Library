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

        public static bool operator ==(Film f1, Film f2)
        {
            if (f1.Name == f2.Name && f1.Genre == f2.Genre && f1.Director == f2.Director && f1.Actors == f2.Actors && f1.Time == f2.Time &&
                f1.YearOut == f2.YearOut && f1.ShortView == f2.ShortView)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Film f1, Film f2)
        {
            if (f1.Name != f2.Name || f1.Genre != f2.Genre || f1.Director != f2.Director || f1.Actors != f2.Actors || f1.Time != f2.Time ||
                f1.YearOut != f2.YearOut || f1.ShortView != f2.ShortView)
            {
                return true;
            }
            return false;
        }
        //
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
    }
}
