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
    public partial class SetInitiative : Form
    {
        public SetInitiative()
        {
            InitializeComponent();
        }

        Tracker f;
        public SetInitiative(Tracker f, String name, String initiative)
        {
            InitializeComponent();
            this.f = f;
            label1.Text = name;
            textBox1.Text = initiative;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox1.Text, out n))
            {
                f.changeInitiative(Convert.ToInt32(textBox1.Text));
                this.Close();
                f.Show();
            }
            else
            {
                BadNumberError f2 = new BadNumberError();
                f2.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Close();
        }
    }
}
