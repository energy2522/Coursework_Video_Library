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
    public partial class Sports : Main
    {
        public Sports()
        {
            InitializeComponent();
        }

        private void Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration r = new Registration();
            r.Show();

        }

        private void Sign_in_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn si = new SignIn();
            si.Show();
        }

        private void биографииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Biographies b = new Biographies();
            b.Show();
            this.Hide();
        }

        private void боевикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Militants m = new Militants();
            m.Show();
            this.Hide();
        }

        private void вестерныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Westerns w = new Westerns();
            w.Show();
            this.Hide();
        }

        private void военныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Military m = new Military();
            m.Show();
            this.Hide();
        }

        private void детективыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detectives d = new Detectives();
            d.Show();
            this.Hide();
        }

        private void детскиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Babys c = new Babys();
            c.Show();
            this.Hide();
        }

        private void документальныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentary d = new Documentary();
            d.Show();
            this.Hide();
        }

        private void драмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drama d = new Drama();
            d.Show();
            this.Hide();
        }

        private void историческиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History h = new History();
            h.Show();
            this.Hide();
        }

        private void комедииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comedy c = new Comedy();
            c.Show();
            this.Hide();
        }

        private void криминалToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Crime c = new Crime();
            c.Show();
            this.Hide();
        }

        private void мелодрамыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Melodrama m = new Melodrama();
            m.Show();
            this.Hide();
        }

        private void мультифильмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartoons c = new Cartoons();
            c.Show();
            this.Hide();
        }

        private void мюзиклыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musicals m = new Musicals();
            m.Show();
            this.Hide();
        }

        private void приключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adventure a = new Adventure();
            a.Show();
            this.Hide();
        }

        private void семейныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Family f = new Family();
            f.Show();
            this.Hide();
        }

        private void спортивныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sports s = new Sports();
            s.Show();
            this.Hide();
        }

        private void триллерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thriller t = new Thriller();
            t.Show();
            this.Hide();
        }

        private void ужасыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Horror h = new Horror();
            h.Show();
            this.Hide();
        }

        private void фантатстикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fantastic f = new Fantastic();
            f.Show();
            this.Hide();
        }

        private void фэнтэзиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fantasy f = new Fantasy();
            f.Show();
            this.Hide();
        }

        private void сериалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Series s = new Series();
            s.Show();
            this.Hide();
        }

        private void Sports_Load(object sender, EventArgs e)
        {

        }
    }
}
