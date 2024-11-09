namespace DzMutexSemaphores
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            button1 = new Button();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            listBox7 = new ListBox();
            listBox8 = new ListBox();
            listBox9 = new ListBox();
            listBox10 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(94, 324);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(112, 21);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(91, 324);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(209, 21);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(97, 324);
            listBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(59, 409);
            button1.Name = "button1";
            button1.Size = new Size(207, 29);
            button1.TabIndex = 3;
            button1.Text = "Запустить потоки";
            button1.UseVisualStyleBackColor = true;
            button1.Click += StartThreads;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(312, 21);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(97, 324);
            listBox4.TabIndex = 4;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.Location = new Point(415, 21);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(97, 324);
            listBox5.TabIndex = 5;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.Location = new Point(518, 21);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(97, 324);
            listBox6.TabIndex = 6;
            // 
            // listBox7
            // 
            listBox7.FormattingEnabled = true;
            listBox7.Location = new Point(621, 21);
            listBox7.Name = "listBox7";
            listBox7.Size = new Size(97, 324);
            listBox7.TabIndex = 7;
            // 
            // listBox8
            // 
            listBox8.FormattingEnabled = true;
            listBox8.Location = new Point(724, 21);
            listBox8.Name = "listBox8";
            listBox8.Size = new Size(97, 324);
            listBox8.TabIndex = 8;
            // 
            // listBox9
            // 
            listBox9.FormattingEnabled = true;
            listBox9.Location = new Point(827, 21);
            listBox9.Name = "listBox9";
            listBox9.Size = new Size(97, 324);
            listBox9.TabIndex = 9;
            // 
            // listBox10
            // 
            listBox10.FormattingEnabled = true;
            listBox10.Location = new Point(930, 21);
            listBox10.Name = "listBox10";
            listBox10.Size = new Size(97, 324);
            listBox10.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 450);
            Controls.Add(listBox10);
            Controls.Add(listBox9);
            Controls.Add(listBox8);
            Controls.Add(listBox7);
            Controls.Add(listBox6);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(button1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button button1;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private ListBox listBox7;
        private ListBox listBox8;
        private ListBox listBox9;
        private ListBox listBox10;
    }
}
