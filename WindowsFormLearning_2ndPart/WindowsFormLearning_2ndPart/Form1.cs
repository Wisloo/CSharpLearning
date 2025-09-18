namespace WindowsFormLearning_2ndPart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String fileName = openFileDialog1.FileName;
                textBox1.Text = System.IO.File.ReadAllText(fileName);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String fileName = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(fileName, textBox1.Text);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String fileName = openFileDialog1.FileName;
                textBox1.Text = System.IO.File.ReadAllText(fileName);


            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String fileName = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(fileName, textBox1.Text);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }
    }
}
