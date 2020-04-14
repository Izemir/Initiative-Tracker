using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initiative_Tracker
{
    public partial class AddNewCreature : Form
    {
        public AddNewCreature()
        {
            InitializeComponent();
        }

        Tracker f;
        public AddNewCreature(Tracker f)
        {
            InitializeComponent();
            this.f = f;
            textBox3.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox2.Text, out n)&& int.TryParse(textBox3.Text, out n))
            {
                f.addNewCreature(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), checkBox1.Checked);
                this.Close();
                f.Show();
            }
            else
            {
                BadNumberError f2 = new BadNumberError();
                f2.ShowDialog(this);
            }

            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
