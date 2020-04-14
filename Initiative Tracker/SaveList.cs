using System;
using System.Collections;
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
    public partial class SaveList : Form
    {
        public SaveList()
        {
            InitializeComponent();
        }

        Tracker f;
        public SaveList(Tracker f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        List<Creature> cr = new List<Creature>();

        internal void fillTable(List<Creature> cr)
        {
            this.cr = cr;
            foreach (Creature creature in cr)
            {
                ListViewItem item = new ListViewItem(creature.name);

                listView1.Items.Add(item);

                
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JsonWriter wr = new JsonWriter();

            for(int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Checked)
                {
                    wr.Write(cr[i]);
                }
            }

            DataSaved form = new DataSaved();
            form.ShowDialog(this);
            this.Close();
        }

        
    }
}
