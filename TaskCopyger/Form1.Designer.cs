namespace TaskCopyger
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(50, 61);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(479, 294);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(411, 26);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(547, 64);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 2;
            button1.Text = "View Processes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(547, 104);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 3;
            button2.Text = "Process info";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(547, 149);
            button3.Name = "button3";
            button3.Size = new Size(136, 23);
            button3.TabIndex = 4;
            button3.Text = "Close process";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(547, 198);
            button4.Name = "button4";
            button4.Size = new Size(136, 23);
            button4.TabIndex = 5;
            button4.Text = "Kill process";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(547, 249);
            button5.Name = "button5";
            button5.Size = new Size(136, 23);
            button5.TabIndex = 6;
            button5.Text = "Run App";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(547, 304);
            button6.Name = "button6";
            button6.Size = new Size(136, 23);
            button6.TabIndex = 7;
            button6.Text = "Starts with...";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}