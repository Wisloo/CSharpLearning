namespace WindowsFormLearning
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            checkBox1 = new CheckBox();
            colorDialog1 = new ColorDialog();
            button2 = new Button();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button5 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button8 = new Button();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            label5 = new Label();
            button9 = new Button();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            groupBox2 = new GroupBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button10 = new Button();
            label6 = new Label();
            label7 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar4 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(106, 28);
            button1.TabIndex = 0;
            button1.Text = "Exit Button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(21, 58);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Check for exit";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(12, 93);
            button2.Name = "button2";
            button2.Size = new Size(201, 25);
            button2.TabIndex = 2;
            button2.Text = "Click to change background color";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tadej Pogacar", "Wout van Aert", "Tom Pidcock", "Jonas Vingeegard" });
            comboBox1.Location = new Point(12, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(28, 178);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Add Item";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(13, 207);
            button4.Name = "button4";
            button4.Size = new Size(105, 23);
            button4.TabIndex = 5;
            button4.Text = "Delete Item";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 243);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 6;
            label1.Text = "This is a label(press me)";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9.75F);
            dateTimePicker1.Location = new Point(21, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9.75F);
            button5.Location = new Point(7, 307);
            button5.Name = "button5";
            button5.Size = new Size(229, 31);
            button5.TabIndex = 8;
            button5.Text = "Press to display date and time";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(49, 354);
            label2.Name = "label2";
            label2.Size = new Size(109, 17);
            label2.TabIndex = 9;
            label2.Text = "dipslay date/time";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 398);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "Non-Modifiable";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 427);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            textBox2.Text = "Modifiable";
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(49, 456);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            textBox3.UseSystemPasswordChar = true;
            textBox3.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 499);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(393, 156);
            textBox4.TabIndex = 10;
            textBox4.Text = "This is a multiline comboBox";
            textBox4.UseSystemPasswordChar = true;
            textBox4.TextChanged += textBox1_TextChanged;
            // 
            // button6
            // 
            button6.Location = new Point(190, 427);
            button6.Name = "button6";
            button6.Size = new Size(142, 23);
            button6.TabIndex = 11;
            button6.Text = "Change Text Box 1";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(412, 472);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.Location = new Point(412, 695);
            button7.Name = "button7";
            button7.Size = new Size(157, 23);
            button7.TabIndex = 13;
            button7.Text = "Click to show image";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(401, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 19);
            radioButton1.TabIndex = 14;
            radioButton1.Text = "Choose one";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(401, 49);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 19);
            radioButton2.TabIndex = 14;
            radioButton2.Text = "Choose one";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(401, 74);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(88, 19);
            radioButton3.TabIndex = 14;
            radioButton3.Text = "Choose one";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(540, 25);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 19);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "Choose many";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(540, 49);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(99, 19);
            checkBox3.TabIndex = 15;
            checkBox3.Text = "Choose many";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(540, 74);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(99, 19);
            checkBox4.TabIndex = 15;
            checkBox4.Text = "Choose many";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(401, 107);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 16;
            button8.Text = "press me";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(388, 145);
            label3.Name = "label3";
            label3.Size = new Size(296, 15);
            label3.TabIndex = 17;
            label3.Text = "This will change depending on your chose radioButton";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(388, 192);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(332, 36);
            progressBar1.TabIndex = 18;
            progressBar1.Click += progressBar1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 140);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 19;
            label4.Text = "<- This is a combobox";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(388, 174);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 20;
            label5.Text = "Progress Bar:";
            label5.Click += label5_Click;
            // 
            // button9
            // 
            button9.Location = new Point(507, 336);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 21;
            button9.Text = "Progress Bar button";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(388, 234);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(332, 36);
            progressBar2.Style = ProgressBarStyle.Continuous;
            progressBar2.TabIndex = 18;
            progressBar2.Click += progressBar1_Click;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(388, 274);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(332, 36);
            progressBar3.Style = ProgressBarStyle.Marquee;
            progressBar3.TabIndex = 18;
            progressBar3.Click += progressBar1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Location = new Point(782, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(111, 106);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 44);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(94, 19);
            radioButton5.TabIndex = 23;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton4";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 19);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 23;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 69);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(94, 19);
            radioButton6.TabIndex = 23;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton4";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(15, 69);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(94, 19);
            radioButton7.TabIndex = 24;
            radioButton7.TabStop = true;
            radioButton7.Text = "radioButton4";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(15, 22);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(94, 19);
            radioButton8.TabIndex = 25;
            radioButton8.TabStop = true;
            radioButton8.Text = "radioButton4";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton8);
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Location = new Point(909, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(121, 100);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(822, 178);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(146, 23);
            textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(822, 220);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(146, 23);
            textBox6.TabIndex = 27;
            textBox6.UseSystemPasswordChar = true;
            // 
            // button10
            // 
            button10.Location = new Point(893, 260);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 28;
            button10.Text = "Submit";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(825, 207);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 29;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(825, 160);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 29;
            label7.Text = "Username";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(788, 336);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(205, 23);
            progressBar4.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 919);
            Controls.Add(progressBar4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button10);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(button8);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button7);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private ColorDialog colorDialog1;
        private Button button2;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button5;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button6;
        private PictureBox pictureBox1;
        private Button button7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button button8;
        private Label label3;
        private ProgressBar progressBar1;
        private Label label4;
        private Label label5;
        private Button button9;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private GroupBox groupBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button10;
        private Label label6;
        private Label label7;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ProgressBar progressBar4;
        private System.Windows.Forms.Timer timer1;
    }
}
