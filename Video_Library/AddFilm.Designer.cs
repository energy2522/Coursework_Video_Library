namespace Video_Library
{
    partial class AddFilm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFilm));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.ActorsBox = new System.Windows.Forms.TextBox();
            this.DirectorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ShortBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Eror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 93);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(143, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(12, 141);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(143, 20);
            this.YearBox.TabIndex = 1;
            this.YearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YearBox_KeyPress);
            // 
            // ActorsBox
            // 
            this.ActorsBox.Location = new System.Drawing.Point(182, 94);
            this.ActorsBox.Name = "ActorsBox";
            this.ActorsBox.Size = new System.Drawing.Size(171, 20);
            this.ActorsBox.TabIndex = 2;
            this.ActorsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ActorsBox_KeyPress);
            // 
            // DirectorBox
            // 
            this.DirectorBox.Location = new System.Drawing.Point(12, 186);
            this.DirectorBox.Name = "DirectorBox";
            this.DirectorBox.Size = new System.Drawing.Size(143, 20);
            this.DirectorBox.TabIndex = 3;
            this.DirectorBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DirectorBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Год выхода";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Items.AddRange(new object[] {
            "Биографии",
            "Боевики",
            "Вестерны",
            "Военные",
            "Детективы",
            "Документальные",
            "Драмы",
            "Исторические",
            "Комедии",
            "Криминал",
            "Мелодрамы",
            "Мультфильмы",
            "Мюзиклы",
            "Приключения",
            "Семейные",
            "Спортивные",
            "Трилеры",
            "Ужасы",
            "Фантастика",
            "Фэнтези"});
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Режисер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Актеры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Длительность";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(182, 141);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(171, 20);
            this.TimeBox.TabIndex = 10;
            this.TimeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Краткое описание";
            // 
            // ShortBox
            // 
            this.ShortBox.Location = new System.Drawing.Point(182, 186);
            this.ShortBox.Name = "ShortBox";
            this.ShortBox.Size = new System.Drawing.Size(171, 20);
            this.ShortBox.TabIndex = 12;
            this.ShortBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShortBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eror
            // 
            this.Eror.AutoSize = true;
            this.Eror.Location = new System.Drawing.Point(221, 32);
            this.Eror.Name = "Eror";
            this.Eror.Size = new System.Drawing.Size(0, 13);
            this.Eror.TabIndex = 15;
            // 
            // AddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(409, 280);
            this.Controls.Add(this.Eror);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ShortBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirectorBox);
            this.Controls.Add(this.ActorsBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.NameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 319);
            this.MinimumSize = new System.Drawing.Size(425, 319);
            this.Name = "AddFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox ActorsBox;
        private System.Windows.Forms.TextBox DirectorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ShortBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Eror;
    }
}