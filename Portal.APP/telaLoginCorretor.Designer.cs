namespace Portal.APP
{
    partial class telaLoginCorretor
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
            voltarButton = new Button();
            loginLabel = new Label();
            loginTextBox = new TextBox();
            senhaTextBox = new TextBox();
            senhaLabel = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // voltarButton
            // 
            voltarButton.Location = new Point(588, 348);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(184, 75);
            voltarButton.TabIndex = 0;
            voltarButton.Text = "voltar";
            voltarButton.UseVisualStyleBackColor = true;
            voltarButton.Click += voltarButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.Location = new Point(196, 117);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(80, 35);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Login";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(292, 122);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(226, 23);
            loginTextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(292, 198);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.Size = new Size(226, 23);
            senhaTextBox.TabIndex = 3;
            senhaTextBox.UseSystemPasswordChar = true;
            // 
            // senhaLabel
            // 
            senhaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            senhaLabel.Location = new Point(196, 198);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(80, 35);
            senhaLabel.TabIndex = 4;
            senhaLabel.Text = "Senha";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(255, 348);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(223, 75);
            loginButton.TabIndex = 5;
            loginButton.Text = "Logar";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // telaLoginCorretor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(senhaLabel);
            Controls.Add(senhaTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(loginLabel);
            Controls.Add(voltarButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "telaLoginCorretor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Form4_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button voltarButton;
        private Label loginLabel;
        private TextBox loginTextBox;
        private TextBox senhaTextBox;
        private Label senhaLabel;
        private Button loginButton;
    }
}