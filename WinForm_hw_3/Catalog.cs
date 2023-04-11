using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WinForm_hw_3
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Edit_form Edit_form = new Edit_form();
            Edit_form.Text = "Добавить";
            if (Edit_form.ShowDialog() == DialogResult.OK)
            {                
                Tovar tmp = new Tovar() { Name = Edit_form.T_name, Country = Edit_form.T_counry, Price = Edit_form.T_price };
                listBox1.Items.Add(tmp);                
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Edit_form Edit_form = new Edit_form();
            Edit_form.Text = "Редактировать";
            if (listBox1.SelectedItem!=null)
            {               
                Tovar tmp2 = new Tovar();
                tmp2 = (Tovar) listBox1.SelectedItem;
               
                Edit_form.T_name = tmp2.Name;
                Edit_form.T_counry = tmp2.Country;
                Edit_form.T_price = tmp2.Price;
                if (Edit_form.ShowDialog() == DialogResult.OK)
                {
                    if (listBox1.SelectedIndex != -1) listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    Tovar tmp1 = new Tovar() { Name = Edit_form.T_name, Country = Edit_form.T_counry, Price = Edit_form.T_price };
                    listBox1.Items.Add(tmp1);
                }

            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1) listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Tovar>));
                SaveFileDialog save = new SaveFileDialog();
                try
                {
                    List<Tovar> tmp2 = new List<Tovar>();
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        tmp2.Add((Tovar)listBox1.Items[i]);
                    }
                    save.Filter = "Text Files(*.xml)|*.xml||";
                    if (save.ShowDialog() == DialogResult.OK) 
                    {
                        Stream fs = File.Create(save.FileName);
                        xs.Serialize(fs, tmp2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Спиок пуст");
            }     
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Tovar>));
            List<Tovar> p_new = null; 
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files(*.xml)|*.xml||";//All Files(*.*)|*.*| 
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (Stream fs = File.OpenRead(open.FileName))
                {
                    p_new = (List<Tovar>)xs.Deserialize(fs);
                }
                listBox1.Items.AddRange(p_new.ToArray());
            }

        }
    }
}
