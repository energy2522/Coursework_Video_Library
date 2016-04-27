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
    
    public partial class SignIn : Form
    {

        static public string name;
        static public string login;
        public SignIn()
        {
            InitializeComponent();
        }
     

        public void validation()
        {
            StreamReader fail = new StreamReader("users.txt", Encoding.UTF8);
            int counter = 0;
            while (true)
            {
                counter = 0;
                string str = fail.ReadLine();
                if (str == null) break;
                int ind = 0;
                int ind1 = 0;
                if (this.Login.Text.Equals("") || this.Password.Text.Equals("")) { label6.Text = "заполните поле"; counter = 3; break; }
                else {
                    ind = str.IndexOf(':');
                    if (ind < 0) { }
                    else {
                        if (str.Substring(0, ind).Equals(this.Login.Text)) { counter++; login = Login.Text; }
                        ind1 = str.IndexOf(':', ind + 1);
                        int t = ind1 - ind;
                        if (str.Substring(ind + 1, (t - 1)).Equals(this.Password.Text)) counter++;
                        int ind2 = str.IndexOf(':', ind1 + 1);
                        int t1 = ind2 - ind1;
                        name = str.Substring(ind1 + 1, (t1 - 1));
                    }
                    if (counter == 2) break;
                }
            }
            if (counter != 2 && counter != 3) { Password.Text = ""; label6.Text = "введен неверно \nлогин или пароль"; }
            else if (counter == 2) {
                Main m = new Main(name, login);
                
                m.Show();
                this.Hide();
            }
            fail.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validation();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Registration rg = new Registration();
            rg.Show();
            this.Hide();
        }
        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}


