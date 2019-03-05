namespace String_Calculations
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alphabet = new System.Windows.Forms.Label();
            this.spaceCounttxt = new System.Windows.Forms.Label();
            this.wordCounttxt = new System.Windows.Forms.Label();
            this.characterCounttxt = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Count of Each Letter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Number of Spaces:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Number of Words:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Number of Characters: ";
            // 
            // alphabet
            // 
            this.alphabet.AutoSize = true;
            this.alphabet.Location = new System.Drawing.Point(478, 216);
            this.alphabet.Name = "alphabet";
            this.alphabet.Size = new System.Drawing.Size(16, 17);
            this.alphabet.TabIndex = 5;
            this.alphabet.Text = "0";
            // 
            // spaceCounttxt
            // 
            this.spaceCounttxt.AutoSize = true;
            this.spaceCounttxt.Location = new System.Drawing.Point(464, 244);
            this.spaceCounttxt.Name = "spaceCounttxt";
            this.spaceCounttxt.Size = new System.Drawing.Size(16, 17);
            this.spaceCounttxt.TabIndex = 6;
            this.spaceCounttxt.Text = "0";
            // 
            // wordCounttxt
            // 
            this.wordCounttxt.AutoSize = true;
            this.wordCounttxt.Location = new System.Drawing.Point(458, 272);
            this.wordCounttxt.Name = "wordCounttxt";
            this.wordCounttxt.Size = new System.Drawing.Size(16, 17);
            this.wordCounttxt.TabIndex = 7;
            this.wordCounttxt.Text = "0";
            // 
            // characterCounttxt
            // 
            this.characterCounttxt.AutoSize = true;
            this.characterCounttxt.Location = new System.Drawing.Point(490, 299);
            this.characterCounttxt.Name = "characterCounttxt";
            this.characterCounttxt.Size = new System.Drawing.Size(16, 17);
            this.characterCounttxt.TabIndex = 8;
            this.characterCounttxt.Text = "0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(240, 92);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(378, 108);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.characterCounttxt);
            this.Controls.Add(this.wordCounttxt);
            this.Controls.Add(this.spaceCounttxt);
            this.Controls.Add(this.alphabet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label alphabet;
        private System.Windows.Forms.Label spaceCounttxt;
        private System.Windows.Forms.Label wordCounttxt;
        private System.Windows.Forms.Label characterCounttxt;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

