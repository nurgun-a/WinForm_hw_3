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
    public partial class Edit_form : Form
    {
        public string T_name
        {
            get { return textBox_name.Text; }
            set { textBox_name.Text = value; }
        }

        public string T_counry
        {
            get { return comboBox_coutry_t.SelectedItem.ToString(); }
            set { comboBox_coutry_t.Text = value; }
        }
        public double T_price
        {
            get { return Convert.ToDouble(textBox_price.Text); }
            set { textBox_price.Text = Convert.ToString(value); }

        }


        public Edit_form()
        {
            InitializeComponent();
            comboBox_coutry_t.Items.AddRange(Cl.countries.ToArray());
            button_ok.Enabled = false;
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            Regex r_text1 = new Regex("[!@#$%^&*+/=(){}[_-]*");
            string str = r_text1.Replace(textBox_name.Text, "");
            textBox_name.Text = str;
        }

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {
            Regex r_text1 = new Regex("[A-Za-zА-Яа-я!@#$%^&*+/=(){}.[_-]*");
            string str = r_text1.Replace(textBox_price.Text, "");
            textBox_price.Text = str;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
        }

        private void textBox_name_MouseLeave(object sender, EventArgs e)
        {
            if (comboBox_coutry_t.Items.Contains(comboBox_coutry_t.Text)&& textBox_name.Text != string.Empty&& textBox_price.Text!=string.Empty)
            {
                button_ok.Enabled = true;
            }
            else button_ok.Enabled = false;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            textBox_name.Clear();
            textBox_price.Clear();            
        }
    }
}
