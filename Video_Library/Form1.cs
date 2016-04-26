using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Library
{
    public partial class Form1 : Form
    {
        public Film film;
        public string Genre;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Film f, string g)
        {
            this.film = f;
            this.Genre = g;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = film.Name + " " + Genre;
        }
    }
}
