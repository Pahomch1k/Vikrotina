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
    public partial class FormVhod : Form
    {
        public FormVhod()
        {
            InitializeComponent();
        } 

        private void Registr_Click(object sender, EventArgs e)
        {
            FormRigstr f = new FormRigstr();
            f.ShowDialog();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                StreamReader sr = new StreamReader("Users.txt", true);
                string line; int x = 0;
                  
                while ((line = sr.ReadLine()) != null)
                {
                    if (textBox2.Text == line)
                    {
                        x++;
                        break;
                    } 
                }
                while ((line = sr.ReadLine()) != null)
                {
                    if (textBox3.Text == line)
                    {
                        x++;
                        break;
                    }
                } 
                sr.Close();

                if (x == 2)
                {
                    Form1 f = new Form1();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Логин илди пароль не верный\nПройдите регистрацию");
                    FormRigstr f = new FormRigstr();
                    f.ShowDialog();
                }
            }
        }
    }
}
