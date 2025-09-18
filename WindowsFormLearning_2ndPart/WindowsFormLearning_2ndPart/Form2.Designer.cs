namespace WindowsFormLearning_2ndPart
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            somethingToolStripMenuItem = new ToolStripMenuItem();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ContextMenuStrip = contextMenuStrip1;
            textBox1.Location = new Point(12, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, somethingToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(156, 92);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(155, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(155, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(155, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // somethingToolStripMenuItem
            // 
            somethingToolStripMenuItem.Name = "somethingToolStripMenuItem";
            somethingToolStripMenuItem.Size = new Size(155, 22);
            somethingToolStripMenuItem.Text = "Something else";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(364, 50);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 1;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(364, 79);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 1;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 27);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 2;
            label1.Text = "Masked Text Box";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Right Click!";
            // 
            // button1
            // 
            button1.Location = new Point(389, 108);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem somethingToolStripMenuItem;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}