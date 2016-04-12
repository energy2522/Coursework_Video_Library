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
            if (Password.Text.Equals(CopyPassword.Text) && Names.Text != "" && Login.Text != "" && Password.Text != "" && CopyPassword.Text != "")
            {
                using (StreamWriter writen = new StreamWriter(@"D:/cursowa/Video_Library/Video_Library/users.txt", true, System.Text.Encoding.Default))
                {
                    writen.WriteLine(Login.Text + ":" + Password.Text + ":" + Names.Text + ":");


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
                label2.Text = "повторный пароль не совпадает"; Password.Text = ""; CopyPassword.Text = "";
            }
            }
        }
    }

