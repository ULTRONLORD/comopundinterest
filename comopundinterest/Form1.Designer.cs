namespace comopundinterest
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
            principalTextBox1 = new TextBox();
            rateTextBox2 = new TextBox();
            compoundingFrequencyTextBox3 = new TextBox();
            timeTextBox4 = new TextBox();
            button1 = new Button();
            resultTestBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // principalTextBox1
            // 
            principalTextBox1.Location = new Point(82, 58);
            principalTextBox1.Name = "principalTextBox1";
            principalTextBox1.PlaceholderText = "Principal Amount";
            principalTextBox1.Size = new Size(125, 27);
            principalTextBox1.TabIndex = 0;
            // 
            // rateTextBox2
            // 
            rateTextBox2.Location = new Point(287, 58);
            rateTextBox2.Name = "rateTextBox2";
            rateTextBox2.PlaceholderText = "Decimal format";
            rateTextBox2.Size = new Size(125, 27);
            rateTextBox2.TabIndex = 1;
            // 
            // compoundingFrequencyTextBox3
            // 
            compoundingFrequencyTextBox3.Location = new Point(82, 132);
            compoundingFrequencyTextBox3.Name = "compoundingFrequencyTextBox3";
            compoundingFrequencyTextBox3.PlaceholderText = "Compounding Frequency";
            compoundingFrequencyTextBox3.Size = new Size(125, 27);
            compoundingFrequencyTextBox3.TabIndex = 2;
            // 
            // timeTextBox4
            // 
            timeTextBox4.Location = new Point(287, 132);
            timeTextBox4.Name = "timeTextBox4";
            timeTextBox4.PlaceholderText = "Time(Years)";
            timeTextBox4.Size = new Size(125, 27);
            timeTextBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.DialogResult = DialogResult.Continue;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(197, 204);
            button1.Name = "button1";
            button1.Size = new Size(100, 76);
            button1.TabIndex = 4;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // resultTestBox5
            // 
            resultTestBox5.Location = new Point(589, 100);
            resultTestBox5.Name = "resultTestBox5";
            resultTestBox5.ReadOnly = true;
            resultTestBox5.Size = new Size(125, 27);
            resultTestBox5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(82, 35);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 6;
            label1.Text = "Principal Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 35);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 8;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(287, 109);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 12;
            label4.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 192);
            label5.Location = new Point(287, 35);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 13;
            label5.Text = "Annual Interest Rate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 255, 192);
            label6.Location = new Point(82, 109);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 15;
            label6.Text = "Compound Freq";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 255, 192);
            label7.Location = new Point(589, 77);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 16;
            label7.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultTestBox5);
            Controls.Add(button1);
            Controls.Add(timeTextBox4);
            Controls.Add(compoundingFrequencyTextBox3);
            Controls.Add(rateTextBox2);
            Controls.Add(principalTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox principalTextBox1;
        private TextBox rateTextBox2;
        private TextBox compoundingFrequencyTextBox3;
        private TextBox timeTextBox4;
        private Button button1;
        private TextBox resultTestBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
