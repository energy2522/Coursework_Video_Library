using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Library
{
    public class Class1
    {
        public string Genre;
        public List<Film> FilmList;

        public Class1(string g, List<Film> f)
        {
            Genre = g;
            FilmList = f;
        }
    }
}
