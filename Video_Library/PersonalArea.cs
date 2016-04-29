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
        public string log;//поле для логіну
        public PersonalArea(string log)
        {
            
            InitializeComponent();
            this.log = log;
            cut();
        }
        //метод, який розрізає рядок
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
            read.Close();
        }
        //подія для кнопки видалити
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Выберите фильм", "Ошибка");
                return;
            }
            else {
                StreamReader read = new StreamReader("users.txt");
                List<string> line = new List<string>();
                
                int counter = 0;
                while (true)
                {
                    string str = read.ReadLine();
                    if (str == null) break;

                    line.Add(str);
                    counter++;

                }
                read.Close();
                string l = dataGridView1.SelectedCells[0].Value.ToString();
                string l1 = log + "/" + l + "/";
                int length = l.Length / 2;
                string lMain = l1.Substring(0, 10 + length);
                for (int i = 0; i < line.Count(); i++)
                {
                    string n = line[i].Substring(0, 10+length);

                    if (n.Equals(lMain)) { counter = i; break; }
                }
                line.RemoveAt(counter);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                SaveData(line);
            }
            
            }
        //метод який перезаписує файл
        public void SaveData(List<string> line)
        {
            StreamWriter write = new StreamWriter("users.txt",false);
            for(int i = 0; i < line.Count(); i++)
            {
                if(i == line.Count() - 1)
                {
                    write.Write(line[i]);
                }
                else
                {
                    write.WriteLine(line[i]);
                }
               
            }
            write.Close();
        }

    }
}
