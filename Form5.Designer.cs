namespace iPocket
{
    partial class Form5
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
            backarrow = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // backarrow
            // 
            backarrow.BackColor = Color.Transparent;
            backarrow.Cursor = Cursors.Hand;
            backarrow.FlatAppearance.BorderSize = 0;
            backarrow.FlatStyle = FlatStyle.Flat;
            backarrow.Font = new Font("Broadway", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backarrow.ForeColor = Color.Black;
            backarrow.Location = new Point(-1, -3);
            backarrow.Name = "backarrow";
            backarrow.Size = new Size(84, 80);
            backarrow.TabIndex = 0;
            backarrow.Text = "←";
            backarrow.TextAlign = ContentAlignment.TopLeft;
            backarrow.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 151);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 1;
            label1.Text = "Enter Mobile Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 298);
            label2.Name = "label2";
            label2.Size = new Size(374, 32);
            label2.TabIndex = 2;
            label2.Text = "We'll send you a verification code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 391);
            label3.Name = "label3";
            label3.Size = new Size(184, 32);
            label3.TabIndex = 3;
            label3.Text = "Mobile Number";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(36, 443);
            textBox1.MaxLength = 11;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 39);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(55, 583);
            button1.Name = "button1";
            button1.Size = new Size(269, 46);
            button1.TabIndex = 5;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 874);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backarrow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backarrow;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
    }
}