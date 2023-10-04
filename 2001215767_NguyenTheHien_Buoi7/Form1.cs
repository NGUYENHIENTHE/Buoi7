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
    public partial class Form1 : Form
    {
        private List<String> textlist;
        public Form1()
        {
            InitializeComponent();
            textlist = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if(!string.IsNullOrEmpty(text))
            {
                textlist.Add(text);
                listBox1.Items.Add(text);
                textBox1.Text = string.Empty;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string selectedText = listBox1.SelectedItem.ToString();
                textlist.Remove(selectedText);
                listBox1.Items.Remove(selectedText);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
