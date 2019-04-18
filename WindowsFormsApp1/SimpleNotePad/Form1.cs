using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Copy
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
        // Cut
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }
        //Paste
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }
        
    }
}
