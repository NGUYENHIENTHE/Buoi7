using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem subitem3 = new ListViewItem.ListViewSubItem();
            item.Text = textBox1.Text;
            subitem1.Text = textBox2.Text;
            if(radioButton1.Checked)
            {
                subitem2.Text = radioButton1.Text;
            }
            else
            {
                subitem2.Text = radioButton2.Text;
            }
            string msg = "";

            if (checkBox1.Checked == true)
            {
                msg = " " + checkBox1.Text;
            }

            if (checkBox2.Checked == true)
            {
                msg = msg + " " + checkBox2.Text;
            }

            if (checkBox3.Checked == true)
            {
                msg = msg + " " + checkBox3.Text;
            }
            if (msg.Length > 0)
            {
                subitem3.Text = msg;
            }
            item.SubItems.Add(subitem1);
            item.SubItems.Add(subitem2);
            item.SubItems.Add(subitem3);
            listView1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem l in listView1.SelectedItems)
            {
                l.Remove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.FocusedItem != null && listView1.FocusedItem.Index >= 0)
            {
                ListViewItem item = listView1.FocusedItem;
                item.SubItems[0].Text = textBox1.Text;
                item.SubItems[1].Text = textBox2.Text;

            }
        }
    }
}
