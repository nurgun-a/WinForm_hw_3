using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinForm_hw_3
{
    class Cl
    {
        static public List<string> countries = new List<string> { "Россия", "Китай", "Канада", "Германия" };
    }
    
    public partial class Anketa : Form
    {
       
        public Anketa()
        {
            InitializeComponent();
            comboBox_country.Items.AddRange(Cl.countries.ToArray());
            button_show.Enabled = false;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        public List<string> City(string str)
        {
            List <string> Russia = new List<string> {"Москва","Санкт-Петербург","Адлер","Анапа","Якутск","Владивосток","Новосибирск","" };
            List<string> China = new List<string> { "Гонконг","Гуанчжоу","Гуйян","Макао","Пекин","Сиань","Тяньцзынь"};
            List<string> Germany = new List<string> {"Берлин","Бонн","Бохум","Гамбург","Ганновер","Дрезден","Кёльн","Мюнхен","Эрфут" };
            List<string> Canada = new List<string> { "Ванкувер", "Виннипег","Квебек","Монреаль","Оттава", "Торонто"};

            if (str=="Россия")
            {
                return Russia;
            }
            else if (str == "Китай")
            {
                return China;
            }
            else if (str == "Канада")
            {
                return Canada;
            }
            else if (str == "Германия")
            {
                return Germany;
            }
            else return null;
        }

        private void comboBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_city.Items.Clear();
            comboBox_city.Text = null;
            comboBox_city.Items.AddRange(City(comboBox_country.Text).ToArray());
        }
        private void button_show_Click(object sender, EventArgs e)
        {
                string str = "Анкета:\n---------------\n";
                str += $"{lb_Surname.Text}: {textBox_surname.Text}\n";
                str += $"{lb_name.Text}: {textBox_name.Text}\n";
                str += $"{lb_pat.Text}: {textBox_patronymic.Text}\n";
                str += $"{lb_country.Text}: {comboBox_country.Text}\n";
                str += $"{lb_city.Text}: {comboBox_city.Text}\n";
                str += $"{lb_phone.Text}: {maskedTextBox1.Text}\n";
                str += $"{lb_gender.Text}: {(radioButton_male.Checked? radioButton_male.Text : radioButton_female.Text)}\n";
                MessageBox.Show(str);            
        }
        private void textBox_surname_TextChanged(object sender, EventArgs e)
        {
           // DataTable d = new DataTable();
            Regex r_text1 = new Regex("[a-zA-Z0-9!@#$%^&*+/=(){}[_-]*");
            string str = r_text1.Replace(textBox_surname.Text, "");
            textBox_surname.Text = str;
            str = r_text1.Replace(textBox_name.Text, "");
            textBox_name.Text = str;
            str = r_text1.Replace(textBox_patronymic.Text, "");
            textBox_patronymic.Text = str;
        }
        private void comboBox_country_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_country.Items.Contains(comboBox_country.Text)){}
            else comboBox_country.Text = "";
            if (comboBox_city.Items.Contains(comboBox_city.Text)){}
            else comboBox_city.Text = "";
        }
        private void comboBox_country_Enter(object sender, EventArgs e)
        {
            if (textBox_name.Text != string.Empty && textBox_surname.Text != string.Empty &&
               textBox_patronymic.Text != string.Empty && comboBox_country.Items.Contains(comboBox_country.Text) &&
               comboBox_city.Items.Contains(comboBox_city.Text) && maskedTextBox1.MaskCompleted
               && maskedTextBox1.MaskFull && (radioButton_male.Checked || radioButton_female.Checked))
            {

                button_show.Enabled = true;
            }
            else
            {
                button_show.Enabled = false;
            }
        }
        private void comboBox_country_MouseLeave(object sender, EventArgs e)
        {
            if (textBox_name.Text != string.Empty && textBox_surname.Text != string.Empty &&
              textBox_patronymic.Text != string.Empty && comboBox_country.Items.Contains(comboBox_country.Text) &&
              comboBox_city.Items.Contains(comboBox_city.Text) && maskedTextBox1.MaskCompleted
              && maskedTextBox1.MaskFull && (radioButton_male.Checked || radioButton_female.Checked))
            {

                button_show.Enabled = true;
            }
            else
            {
                button_show.Enabled = false;
            }
        }
    }
}
