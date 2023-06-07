namespace Portal.APP
{
    partial class Form4
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(588, 348);
            button1.Name = "button1";
            button1.Size = new Size(184, 75);
            button1.TabIndex = 0;
            button1.Text = "voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(196, 117);
            label1.Name = "label1";
            label1.Size = new Size(80, 35);
            label1.TabIndex = 1;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(292, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(196, 198);
            label2.Name = "label2";
            label2.Size = new Size(80, 35);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // button2
            // 
            button2.Location = new Point(255, 348);
            button2.Name = "button2";
            button2.Size = new Size(223, 75);
            button2.TabIndex = 5;
            button2.Text = "Logar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Form4_FormClosed;
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
    }
}