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
    public partial class PersonalArea : Form
    {
        public string log;
        public PersonalArea(string log)
        {
            
            InitializeComponent();
            this.log = log;
            cut();
        }
        public void cut()
        {
            StreamReader read = new StreamReader("users.txt");
            while (true)
            {
                
                string str = read.ReadLine();
                if (str == null) break;
                string[] s = str.Split('/');
                if(s[0] == log)
                {
                    dataGridView1.Rows.Add(s[1], s[2], s[3], s[4], s[5], s[6]);
                }

            }
        }
    }
}
