using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormLearning_2ndPart
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cut your peen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, maskedTextBox1.Text);
            MessageBox.Show(this, maskedTextBox2.Text);
        }
    }
}
