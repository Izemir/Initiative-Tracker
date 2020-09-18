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
    public partial class Tracker : Form
    {

        int count = 0;

        ArrayList creatures = new ArrayList();

        Random rand = new Random();

        public Tracker()
        {
            InitializeComponent();

            

        }

        
        
        
        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        public void addNewCreature(String name, int bonus, int count, bool isMonster)
        {
            
            if (count > 1)
            {
                for (int i = 1; i <= count; i++)
                {
                    ListViewItem item = new ListViewItem(name+"_"+i.ToString());
                    item.SubItems.Add((rand.Next(20) + 1 + bonus).ToString());
                    item.SubItems.Add(bonus.ToString());
                    item.SubItems.Add(isMonster.ToString());
                    if (isMonster) item.ForeColor = Color.DarkRed;
                    else item.ForeColor = Color.DarkBlue;
                    CreatureTable.Items.Add(item);
                }
            }
            else
            {
                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add((rand.Next(20) + 1 + bonus).ToString());
                item.SubItems.Add(bonus.ToString());
                item.SubItems.Add(isMonster.ToString());
                if (isMonster) item.ForeColor = Color.DarkRed;
                else item.ForeColor = Color.DarkBlue;
                CreatureTable.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewCreature newForm = new AddNewCreature(this);
            newForm.Show();
            

        }

        private void CreatureTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = CreatureTable.SelectedItems.Count;
            if (CreatureTable.Items.Count > 0)
            {
                for (int i = 0; i < a; i++)
                {
                    CreatureTable.Items.Remove(CreatureTable.SelectedItems[0]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a;
            for(int i =0;i< CreatureTable.Items.Count; i++)
            {
                a = Convert.ToInt32(CreatureTable.Items[i].SubItems[2].Text);
                CreatureTable.Items[i].SubItems[1].Text = (rand.Next(20) + 1 + a).ToString();
            }
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            int a = CreatureTable.SelectedItems.Count;
            if (CreatureTable.Items.Count > 0 && CreatureTable.SelectedItems.Count>0)
            {
                SetInitiative newForm = new SetInitiative(this, CreatureTable.SelectedItems[0].SubItems[0].Text, CreatureTable.SelectedItems[0].SubItems[1].Text);
                newForm.Show();
                //this.Hide();
            }
            
        }

        public void changeInitiative(int n)
        {
            CreatureTable.SelectedItems[0].SubItems[1].Text = n.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = CreatureTable.SelectedItems.Count;
            int b;
            if (a>0)
            {
                for (int i = 0; i < a; i++)
                {
                    b = Convert.ToInt32(CreatureTable.SelectedItems[i].SubItems[2].Text);
                    CreatureTable.SelectedItems[i].SubItems[1].Text = (rand.Next(20) + 1 + b).ToString();
                }
            }

            
        }


        // The column we are currently using for sorting.
        private ColumnHeader SortingColumn = null;

        // Sort on this column.
        private void CreatureTable_ColumnClick(object sender,
            ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = CreatureTable.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn.Text.StartsWith("> "))
                    {
                        sort_order = SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // New column. Sort ascending.
                    sort_order = SortOrder.Ascending;
                }

                // Remove the old sort indicator.
                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn.Text = "> " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "< " + SortingColumn.Text;
            }

            // Create a comparer.
            CreatureTable.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            CreatureTable.Sort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            for (int i = 0; i < CreatureTable.Items.Count; i++)
            {
                if(CreatureTable.Items[i].SubItems[3].Text == true.ToString())
                {
                    a = Convert.ToInt32(CreatureTable.Items[i].SubItems[2].Text);
                    CreatureTable.Items[i].SubItems[1].Text = (rand.Next(20) + 1 + a).ToString();
                }
                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveList newForm = new SaveList(this);
            List<Creature> temp = new List<Creature>();
            int a;
            for (int i = 0; i < CreatureTable.Items.Count; i++)
            {
                if (CreatureTable.Items[i].SubItems[3].Text == true.ToString())
                {
                    temp.Add(new Creature(CreatureTable.Items[i].SubItems[0].Text, Convert.ToInt32(CreatureTable.Items[i].SubItems[2].Text), Convert.ToBoolean(CreatureTable.Items[i].SubItems[3].Text)));
                   
                }

            }
            newForm.fillTable(temp);
            newForm.Show();
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveList newForm = new SaveList(this);
            List<Creature> temp = new List<Creature>();
            int a;
            for (int i = 0; i < CreatureTable.Items.Count; i++)
            {
                if (CreatureTable.Items[i].SubItems[3].Text == false.ToString())
                {
                    temp.Add(new Creature(CreatureTable.Items[i].SubItems[0].Text, Convert.ToInt32(CreatureTable.Items[i].SubItems[2].Text), Convert.ToBoolean(CreatureTable.Items[i].SubItems[3].Text)));

                }

            }
            newForm.fillTable(temp);
            newForm.Show();
        }

        private void creaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadList newForm = new LoadList(this, true);
            newForm.Show();
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadList newForm = new LoadList(this, false);
            newForm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }

    // Compares two ListView items based on a selected column.
    public class ListViewComparer : System.Collections.IComparer
    {
        private int ColumnNumber;
        private SortOrder SortOrder;

        public ListViewComparer(int column_number,
            SortOrder sort_order)
        {
            ColumnNumber = column_number;
            SortOrder = sort_order;
        }

        // Compare two ListViewItems.
        public int Compare(object object_x, object object_y)
        {
            // Get the objects as ListViewItems.
            ListViewItem item_x = object_x as ListViewItem;
            ListViewItem item_y = object_y as ListViewItem;

            // Get the corresponding sub-item values.
            string string_x;
            if (item_x.SubItems.Count <= ColumnNumber)
            {
                string_x = "";
            }
            else
            {
                string_x = item_x.SubItems[ColumnNumber].Text;
            }

            string string_y;
            if (item_y.SubItems.Count <= ColumnNumber)
            {
                string_y = "";
            }
            else
            {
                string_y = item_y.SubItems[ColumnNumber].Text;
            }

            // Compare them.
            int result;
            double double_x, double_y;
            if (double.TryParse(string_x, out double_x) &&
                double.TryParse(string_y, out double_y))
            {
                // Treat as a number.
                result = double_x.CompareTo(double_y);
            }
            else
            {
                DateTime date_x, date_y;
                if (DateTime.TryParse(string_x, out date_x) &&
                    DateTime.TryParse(string_y, out date_y))
                {
                    // Treat as a date.
                    result = date_x.CompareTo(date_y);
                }
                else
                {
                    // Treat as a string.
                    result = string_x.CompareTo(string_y);
                }
            }

            // Return the correct result depending on whether
            // we're sorting ascending or descending.
            if (SortOrder == SortOrder.Ascending)
            {
                return result;
            }
            else
            {
                return -result;
            }
        }
    }
}
