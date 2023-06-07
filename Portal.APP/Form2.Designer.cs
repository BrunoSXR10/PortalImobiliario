namespace Portal.APP
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            nomeTextBox = new TextBox();
            label2 = new Label();
            emailTextBox = new TextBox();
            label3 = new Label();
            telTextBox = new TextBox();
            label4 = new Label();
            naciTextBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(630, 332);
            button1.Name = "button1";
            button1.Size = new Size(125, 70);
            button1.TabIndex = 0;
            button1.Text = "voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(273, 332);
            button2.Name = "button2";
            button2.Size = new Size(180, 62);
            button2.TabIndex = 1;
            button2.Text = "cadastre-se";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 78);
            label1.Name = "label1";
            label1.Size = new Size(95, 42);
            label1.TabIndex = 2;
            label1.Text = "nome";
            label1.Click += label1_Click;
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(181, 89);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(161, 23);
            nomeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 131);
            label2.Name = "label2";
            label2.Size = new Size(95, 42);
            label2.TabIndex = 4;
            label2.Text = "email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(181, 131);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(161, 23);
            emailTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 173);
            label3.Name = "label3";
            label3.Size = new Size(107, 42);
            label3.TabIndex = 6;
            label3.Text = "telefone";
            // 
            // telTextBox
            // 
            telTextBox.Location = new Point(181, 184);
            telTextBox.Name = "telTextBox";
            telTextBox.Size = new Size(161, 23);
            telTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 228);
            label4.Name = "label4";
            label4.Size = new Size(172, 41);
            label4.TabIndex = 8;
            label4.Text = "nacionalidade";
            // 
            // naciTextBox
            // 
            naciTextBox.Location = new Point(181, 239);
            naciTextBox.Name = "naciTextBox";
            naciTextBox.Size = new Size(161, 23);
            naciTextBox.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(naciTextBox);
            Controls.Add(label4);
            Controls.Add(telTextBox);
            Controls.Add(label3);
            Controls.Add(emailTextBox);
            Controls.Add(label2);
            Controls.Add(nomeTextBox);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form2";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox nomeTextBox;
        private Label label2;
        private TextBox emailTextBox;
        private Label label3;
        private TextBox telTextBox;
        private Label label4;
        private TextBox naciTextBox;
    }
}