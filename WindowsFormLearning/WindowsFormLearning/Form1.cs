namespace WindowsFormLearning
{
    public partial class Form1 : Form
    {
        private int cnt = 4;
        private int progCounter = 0;
        private String userName = "admin123";
        private String passWord = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // exits the program
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // checks if the checkbox is checked
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = colorDialog1.ShowDialog(); // if the button is pressed then change the color
            if (DialogResult == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Item" + cnt); // items is a list
            cnt++;
        }
        private void button4_Click(Object sender, EventArgs e)
        {
            // comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "THIS IS A LABEL!";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // label2.Text = dateTimePicker1.Value.ToString(); // converts it to string and sets it to text
            label2.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // converts it to string and sets it to text
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Visual Studio 2022";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // pictureBox1.Load("unnamed.jpg");
            pictureBox1.Image = Image.FromFile("unnamed.jpg");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label3.Text = "Soy boy";
            }
            else if (radioButton2.Checked)
            {
                label3.Text = "N*gge*s";
            }
            else if (radioButton3.Checked)
            {
                label3.Text = "Chingus";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            timer1.Start();
            dataGridView1.Rows.Add("Louis", "Gwapo", "19", "Davao", "2006");
            dataGridView1.Rows.Add("Dei", "Maganda", "22", "Cavite", "2003");
            dataGridView1.Rows.Add("Dutch", "Seamanloloko", "22", "Davao", "2003");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                progressBar2.Value = i;

                System.Threading.Thread.Sleep(100);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Equals(userName) && textBox6.Text.Equals(passWord))
            {
                MessageBox.Show("Login Success!");
                errorProvider1.Clear();
                errorProvider2.Clear();
            }
            else
            {
                if (!textBox5.Text.Equals(userName))
                {
                    errorProvider1.SetError(textBox5, "Username is not correct");
                }
                else
                {
                    errorProvider1.Clear();
                }

                if (!textBox6.Text.Equals(passWord))
                {
                    errorProvider2.SetError(textBox6, "Password is not correct");
                }
                else
                {
                    errorProvider2.Clear();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar4.Value < 100)
            {
                progressBar4.Value += 1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
    }
}
