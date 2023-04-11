using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_hw_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_anketa_MouseLeave(object sender, EventArgs e)
        {
            Text = "Д/з № 3";
        }

        private void button_anketa_MouseEnter(object sender, EventArgs e)
        {
            Text = button_anketa.Text;
        }

        private void button_tovar_MouseEnter(object sender, EventArgs e)
        {
            Text = button_tovar.Text;
        }

        private void button_close_MouseEnter(object sender, EventArgs e)
        {
            Text = button_close.Text;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_anketa_Click(object sender, EventArgs e)
        {
            Anketa Anketa = new Anketa();
            Anketa.ShowDialog();
        }

        private void button_tovar_Click(object sender, EventArgs e)
        {
            Catalog Catalog = new Catalog();
            Catalog.ShowDialog();
        }
    }
}
