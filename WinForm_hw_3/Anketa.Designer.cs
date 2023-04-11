
namespace WinForm_hw_3
{
    partial class Anketa
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
            this.lb_Surname = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_pat = new System.Windows.Forms.Label();
            this.lb_country = new System.Windows.Forms.Label();
            this.lb_city = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_bd = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_patronymic = new System.Windows.Forms.TextBox();
            this.comboBox_country = new System.Windows.Forms.ComboBox();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.button_show = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Surname
            // 
            this.lb_Surname.AutoSize = true;
            this.lb_Surname.Location = new System.Drawing.Point(13, 13);
            this.lb_Surname.Name = "lb_Surname";
            this.lb_Surname.Size = new System.Drawing.Size(70, 17);
            this.lb_Surname.TabIndex = 0;
            this.lb_Surname.Text = "Фамилия";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(12, 40);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 17);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Имя";
            // 
            // lb_pat
            // 
            this.lb_pat.AutoSize = true;
            this.lb_pat.Location = new System.Drawing.Point(13, 69);
            this.lb_pat.Name = "lb_pat";
            this.lb_pat.Size = new System.Drawing.Size(71, 17);
            this.lb_pat.TabIndex = 0;
            this.lb_pat.Text = "Отчество";
            // 
            // lb_country
            // 
            this.lb_country.AutoSize = true;
            this.lb_country.Location = new System.Drawing.Point(13, 100);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(56, 17);
            this.lb_country.TabIndex = 0;
            this.lb_country.Text = "Страна";
            // 
            // lb_city
            // 
            this.lb_city.AutoSize = true;
            this.lb_city.Location = new System.Drawing.Point(12, 127);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(48, 17);
            this.lb_city.TabIndex = 0;
            this.lb_city.Text = "Город";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(13, 156);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(68, 17);
            this.lb_phone.TabIndex = 0;
            this.lb_phone.Text = "Телефон";
            // 
            // lb_bd
            // 
            this.lb_bd.AutoSize = true;
            this.lb_bd.Location = new System.Drawing.Point(13, 186);
            this.lb_bd.Name = "lb_bd";
            this.lb_bd.Size = new System.Drawing.Size(111, 17);
            this.lb_bd.TabIndex = 0;
            this.lb_bd.Text = "Дата рождения";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Location = new System.Drawing.Point(14, 215);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(34, 17);
            this.lb_gender.TabIndex = 0;
            this.lb_gender.Text = "Пол";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(141, 10);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(200, 22);
            this.textBox_surname.TabIndex = 1;
            this.textBox_surname.TextChanged += new System.EventHandler(this.textBox_surname_TextChanged);
            this.textBox_surname.Enter += new System.EventHandler(this.comboBox_country_Enter);
            this.textBox_surname.MouseLeave += new System.EventHandler(this.comboBox_country_MouseLeave);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(141, 37);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(200, 22);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_surname_TextChanged);
            this.textBox_name.Enter += new System.EventHandler(this.comboBox_country_Enter);
            this.textBox_name.MouseLeave += new System.EventHandler(this.comboBox_country_MouseLeave);
            // 
            // textBox_patronymic
            // 
            this.textBox_patronymic.Location = new System.Drawing.Point(141, 64);
            this.textBox_patronymic.Name = "textBox_patronymic";
            this.textBox_patronymic.Size = new System.Drawing.Size(200, 22);
            this.textBox_patronymic.TabIndex = 1;
            this.textBox_patronymic.TextChanged += new System.EventHandler(this.textBox_surname_TextChanged);
            this.textBox_patronymic.Enter += new System.EventHandler(this.comboBox_country_Enter);
            this.textBox_patronymic.MouseLeave += new System.EventHandler(this.comboBox_country_MouseLeave);
            // 
            // comboBox_country
            // 
            this.comboBox_country.AutoCompleteCustomSource.AddRange(new string[] {
            "Россия",
            "Китай",
            "Германия"});
            this.comboBox_country.FormattingEnabled = true;
            this.comboBox_country.Location = new System.Drawing.Point(141, 93);
            this.comboBox_country.Name = "comboBox_country";
            this.comboBox_country.Size = new System.Drawing.Size(200, 24);
            this.comboBox_country.TabIndex = 2;
            this.comboBox_country.SelectedIndexChanged += new System.EventHandler(this.comboBox_country_SelectedIndexChanged);
            this.comboBox_country.TextChanged += new System.EventHandler(this.comboBox_country_TextChanged);
            this.comboBox_country.Enter += new System.EventHandler(this.comboBox_country_Enter);
            this.comboBox_country.MouseLeave += new System.EventHandler(this.comboBox_country_MouseLeave);
            // 
            // comboBox_city
            // 
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Location = new System.Drawing.Point(141, 124);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(200, 24);
            this.comboBox_city.TabIndex = 2;
            this.comboBox_city.TextChanged += new System.EventHandler(this.comboBox_country_TextChanged);
            this.comboBox_city.Enter += new System.EventHandler(this.comboBox_country_Enter);
            this.comboBox_city.MouseLeave += new System.EventHandler(this.comboBox_country_MouseLeave);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(141, 150);
            this.maskedTextBox1.Mask = "+7 (999) - 000 - 00- 99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.Enter += new System.EventHandler(this.comboBox_country_Enter);
            this.maskedTextBox1.MouseLeave += new System.EventHandler(this.comboBox_country_MouseLeave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 181);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 4, 9, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 9, 0, 0, 0, 0);
            this.dateTimePicker1.Enter += new System.EventHandler(this.comboBox_country_Enter);
            this.dateTimePicker1.MouseLeave += new System.EventHandler(this.comboBox_country_MouseLeave);
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(141, 215);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(88, 21);
            this.radioButton_female.TabIndex = 5;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Женский";
            this.radioButton_female.UseVisualStyleBackColor = true;
            this.radioButton_female.Enter += new System.EventHandler(this.comboBox_country_Enter);
            this.radioButton_female.MouseLeave += new System.EventHandler(this.comboBox_country_MouseLeave);
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(258, 215);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(86, 21);
            this.radioButton_male.TabIndex = 6;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Мужской";
            this.radioButton_male.UseVisualStyleBackColor = true;
            this.radioButton_male.Enter += new System.EventHandler(this.comboBox_country_Enter);
            this.radioButton_male.MouseLeave += new System.EventHandler(this.comboBox_country_MouseLeave);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(16, 272);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(141, 39);
            this.button_show.TabIndex = 7;
            this.button_show.Text = "Просмотр";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(200, 272);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(141, 39);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Выход";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Anketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(364, 332);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox_city);
            this.Controls.Add(this.comboBox_country);
            this.Controls.Add(this.textBox_patronymic);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_bd);
            this.Controls.Add(this.lb_city);
            this.Controls.Add(this.lb_pat);
            this.Controls.Add(this.lb_country);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_Surname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Anketa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Surname;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_pat;
        private System.Windows.Forms.Label lb_country;
        private System.Windows.Forms.Label lb_city;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_bd;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_patronymic;
        private System.Windows.Forms.ComboBox comboBox_country;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_close;
    }
}