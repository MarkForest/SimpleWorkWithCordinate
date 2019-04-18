using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"{e.X}, {e.Y}";
            if (e.X > button1.Location.X)
            {
                button1.Location = new Point(button1.Location.X + 10, button1.Location.Y);
            }
            button1.Text = $"{button1.Location.X}, {button1.Location.Y}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> lists = new List<string>();
            foreach (var item in textBox1.Text.Split(';'))
            {
                lists.Add(item);
            }
            listBox1.Items.AddRange(lists.ToArray());
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!listBox2.Items.Contains(listBox1.SelectedItem)) {
                listBox2.Items.Add(listBox1.SelectedItem);
            } else
            {
                MessageBox.Show("Бяша не тупите пожалуйста!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
