using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_11_Vikrotina
{
    public partial class Form1 : Form
    {
        public int x { get; set; }

        public Form1()
        {
            InitializeComponent();
            FormVhod f = new FormVhod();
            f.ShowDialog();

        } 

        private void Next1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;  
        }
        private void Next2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }

        private void End_Click(object sender, EventArgs e)
        {
            x = 0;

            if (radioButton1.Checked == true) x++;
            if (radioButton4.Checked == true) x++; 
            if (radioButton8.Checked == true) x++; 
            if (radioButton12.Checked == true) x++; 
            if (radioButton14.Checked == true) x++; 
            if (radioButton18.Checked == true) x++; 
            if (radioButton34.Checked == true) x++; 
            if (radioButton31.Checked == true) x++; 
            if (radioButton29.Checked == true) x++; 
            if (radioButton27.Checked == true) x++; 
            if (radioButton23.Checked == true) x++; 
            if (radioButton21.Checked == true) x++;
            if (radioButton52.Checked == true) x++;
            if (radioButton49.Checked == true) x++;
            if (radioButton47.Checked == true) x++;
            if (radioButton45.Checked == true) x++;
            if (radioButton41.Checked == true) x++;
            if (radioButton39.Checked == true) x++;
             
            x = x * 100 / 18; 

            FinalForm f = new FinalForm(x);
            f.ShowDialog();
        } 
    }
}
