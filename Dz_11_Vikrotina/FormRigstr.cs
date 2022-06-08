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


namespace Dz_11_Vikrotina
{

    public partial class FormRigstr : Form
    {  
        public FormRigstr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Заполните все поля");
            else if (Convert.ToInt32(textBox1.Text) < 18 && Convert.ToInt32(textBox1.Text) > 90)
                MessageBox.Show("Некоректный возраст");
            else if (textBox2.Text.Length < 6)
                MessageBox.Show("Маленький логин");
            else if (textBox3.Text.Length < 8)
                MessageBox.Show("Маленький пароль");
            else
            {
                StreamWriter sw = new StreamWriter($"User_{textBox2.Text}.txt", true);
                string line;
                line = $"login - {textBox2.Text}\nPassword - {textBox3.Text}\nAge - {textBox1.Text}\nMail - {textBox4.Text}\n\n";
                sw.WriteLine(line);
                sw.Close();

                StreamWriter sw1 = new StreamWriter($"Users.txt", true);
                string line1;
                line1 = $"{textBox2.Text}\n{textBox3.Text}\n";
                sw1.WriteLine(line1);
                sw1.Close();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l < 'A' || l > 'z')
                e.Handled = true; 
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l < 'A' || l > 'z')
                e.Handled = true;
        }
    }
}
