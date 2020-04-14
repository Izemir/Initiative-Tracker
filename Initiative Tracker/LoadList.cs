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
    public partial class LoadList : Form
    {
        public LoadList()
        {
            InitializeComponent();
        }

        Tracker f;
        List<Creature> cr;
        public LoadList(Tracker f, bool isMonster)
        {
            InitializeComponent();
            this.f = f;

            textBox1.Text = "1";
            JsonReader reader = new JsonReader();
            cr = reader.Read(0, isMonster);
            if (reader.error)
            {
                NoFileError form = new NoFileError();
                form.ShowDialog(this);
                
            }
            else
            {
                foreach (Creature creature in cr)
                {
                    ListViewItem item = new ListViewItem(creature.name);

                    listView1.Items.Add(item);


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n;
            if (int.TryParse(textBox1.Text, out n))
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Checked)
                    {
                        f.addNewCreature(cr[i].name, cr[i].bonus, Convert.ToInt32(textBox1.Text), cr[i].isMonster);
                    }
                }
            }
            else
            {
                BadNumberError f2 = new BadNumberError();
                f2.ShowDialog(this);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                this.Close();
            
        }
    }
}
