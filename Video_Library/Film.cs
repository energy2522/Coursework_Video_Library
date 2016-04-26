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
        //public string Genre;


        public Film(string Name, string YearOut, string Director, string Actors, string Time, string ShortView)
        {
           // this.Genre = Genre;
            this.Name = Name;
            this.YearOut = YearOut;
            this.Time = Time;
            this.Actors = Actors;
            this.Director = Director;
            this.ShortView = ShortView;
        }

    }
}
