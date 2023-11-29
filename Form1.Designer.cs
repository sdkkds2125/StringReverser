namespace StringReverser
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
            richTextBox1 = new RichTextBox();
            OutputTextBox = new RichTextBox();
            Reverse_jokes = new Button();
            Reverse_input = new Button();
            InputTextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(52, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(672, 143);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new Point(260, 362);
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.Size = new Size(276, 48);
            OutputTextBox.TabIndex = 1;
            OutputTextBox.Text = "";
            // 
            // Reverse_jokes
            // 
            Reverse_jokes.Location = new Point(322, 161);
            Reverse_jokes.Name = "Reverse_jokes";
            Reverse_jokes.Size = new Size(138, 29);
            Reverse_jokes.TabIndex = 2;
            Reverse_jokes.Text = "Reverse Jokes";
            Reverse_jokes.UseVisualStyleBackColor = true;
            Reverse_jokes.Click += Reverse_jokes_Click;
            // 
            // Reverse_input
            // 
            Reverse_input.Location = new Point(322, 281);
            Reverse_input.Name = "Reverse_input";
            Reverse_input.Size = new Size(138, 29);
            Reverse_input.TabIndex = 3;
            Reverse_input.Text = "Reverse Input";
            Reverse_input.UseVisualStyleBackColor = true;
            Reverse_input.Click += Reverse_input_Click;
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(260, 227);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(276, 48);
            InputTextBox.TabIndex = 4;
            InputTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Location = new Point(366, 204);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Location = new Point(375, 339);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InputTextBox);
            Controls.Add(Reverse_input);
            Controls.Add(Reverse_jokes);
            Controls.Add(OutputTextBox);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox OutputTextBox;
        private Button Reverse_jokes;
        private Button Reverse_input;
        private RichTextBox InputTextBox;
        private Label label1;
        private Label label2;
    }
}