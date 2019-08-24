using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class ПО : Form
    {
        public ПО()
        {
            InitializeComponent();
        }

        struct Price
        {
            public string tovar;
            public string magazin;
            public string rubli;
            public Price(string tovar, string magazin, string rubli)
            {
                this.tovar = tovar;
                this.magazin = magazin;
                this.rubli = rubli;
            }
        }
        Price[] price = new Price[8];
        int i = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Кнопка добавить
            i++;
                price[i].tovar = textBox1.Text;
                price[i].magazin = textBox2.Text;
                price[i].rubli = textBox3.Text;
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //кнопка найти
            bool flag = false;
            string name = textBox4.Text;
            for (int i = 0; i < price.Length; i++)
            {
                if (name == price[i].tovar)
                {
                    dataGridView2.Rows.Add(price[i].tovar,price[i].magazin,price[i].rubli);
                    flag = true;
                }
            }
            if (!flag)
                MessageBox.Show("Товара нет");
        }
    }
    }