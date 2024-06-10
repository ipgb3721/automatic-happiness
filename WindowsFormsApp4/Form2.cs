using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace listboxTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // listBox1.Items.Count; // 항목 수 정수 반환
        // listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        // listBox1.Items.Clear();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int work = listBox1.Items.Count;
            label2.Text = "해야할 일 개수 : " + work.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
