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
    public partial class FinalForm : Form
    {
       public int x { get; set; }
        public FinalForm(int f)
        {
            x = f;
            InitializeComponent();
            textBox1.Text = $"{x}%";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Заполните все поля");
            else
            {
                StreamWriter sw = new StreamWriter("1.txt", true);
                string line;
                line = $"FIO - {textBox2.Text}\nAge - {textBox3.Text}\nResult - {x}%\n\n";
                sw.WriteLine(line);
                sw.Close();
            } 
        }
    }
}
