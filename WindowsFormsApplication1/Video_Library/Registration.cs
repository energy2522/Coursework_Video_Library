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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        
        private void revise()
        {
            


        }

        

        private void button1_Click(object sender, EventArgs e)
            
        {
            int counter = 0;
            StreamReader fail = new StreamReader(@"D:/cursowa/Video_Library/Video_Library/users.txt");

            while (true)
            {
                string str = fail.ReadLine();
                if (str == null) break;
                int ind = str.IndexOf(':');
                if (Login.Text.Equals(str.Substring(0, ind))) counter++; break;

            }
            fail.Close();
            if(counter != 0) { label2.Text = "такой логин уже есть"; }
           else if (Password.Text.Equals(CopyPassword.Text) && Names.Text != "" && Login.Text != "" && Password.Text != "" && CopyPassword.Text != "" && Names.Text.Length >= 3 && Login.Text.Length >= 4 && Password.Text.Length >= 4)
            {
                

                using (StreamWriter writen = new StreamWriter(@"D:/cursowa/Video_Library/Video_Library/users.txt", true, System.Text.Encoding.Default))
                {
                    writen.WriteLine(Login.Text + ":" + Password.Text + ":" + Names.Text + ":");

                    writen.Close();
                    SignIn si = new SignIn();
                    si.Show();
                    this.Hide();
                    
                }
            }
            else if( Names.Text.Equals("")||Login.Text.Equals("")) {
                label2.Text = "не все поля заполнены";
               
            }
            else if(Password.Text.Equals("") | CopyPassword.Text.Equals("") )
            {
                label2.Text = "поле с паролем пустое"; 
            }
            else if(Password.Text != CopyPassword.Text)
            {
                label2.Text = "повторный пароль\nне совпадает"; Password.Text = ""; CopyPassword.Text = "";
            }
            else if(Names.Text.Length < 3) { label2.Text = "Слишком короткое имя!\nМнимум 3 буквы"; }
            else if(Login.Text.Length < 4) { label2.Text = "Слишком короткий логин!\nМинимум 4 буквы"; }
            else if(Password.Text.Length < 4) { label2.Text = "Слишком короткий пароль!\nМинимум 4 буквы"; }
            }
        }
    }

