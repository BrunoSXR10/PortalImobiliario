namespace Portal.APP
{
    partial class telaCadastroCorretor
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
            cadastrarButton = new Button();
            nomeLabel = new Label();
            nomeTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            telefoneLabel = new Label();
            telTextBox = new TextBox();
            nacionalidadeLabel = new Label();
            naciTextBox = new TextBox();
            SuspendLayout();
            // 
            // voltarButton
            // 
            voltarButton.Location = new Point(630, 332);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(125, 70);
            voltarButton.TabIndex = 0;
            voltarButton.Text = "voltar";
            voltarButton.UseVisualStyleBackColor = true;
            voltarButton.Click += voltarButton_Click;
            // 
            // cadastrarButton
            // 
            cadastrarButton.Location = new Point(273, 332);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(180, 62);
            cadastrarButton.TabIndex = 1;
            cadastrarButton.Text = "cadastre-se";
            cadastrarButton.UseVisualStyleBackColor = true;
            cadastrarButton.Click += cadastrarButton_Click;
            // 
            // nomeLabel
            // 
            nomeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nomeLabel.Location = new Point(47, 78);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(95, 42);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "nome";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(190, 89);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(161, 23);
            nomeTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(47, 131);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(95, 42);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(190, 131);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(161, 23);
            emailTextBox.TabIndex = 5;
            // 
            // telefoneLabel
            // 
            telefoneLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            telefoneLabel.Location = new Point(47, 173);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new Size(107, 42);
            telefoneLabel.TabIndex = 6;
            telefoneLabel.Text = "telefone";
            // 
            // telTextBox
            // 
            telTextBox.Location = new Point(190, 184);
            telTextBox.Name = "telTextBox";
            telTextBox.Size = new Size(161, 23);
            telTextBox.TabIndex = 7;
            // 
            // nacionalidadeLabel
            // 
            nacionalidadeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nacionalidadeLabel.Location = new Point(12, 228);
            nacionalidadeLabel.Name = "nacionalidadeLabel";
            nacionalidadeLabel.Size = new Size(172, 41);
            nacionalidadeLabel.TabIndex = 8;
            nacionalidadeLabel.Text = "nacionalidade";
            // 
            // naciTextBox
            // 
            naciTextBox.Location = new Point(190, 239);
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
            Controls.Add(nacionalidadeLabel);
            Controls.Add(telTextBox);
            Controls.Add(telefoneLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(nomeTextBox);
            Controls.Add(nomeLabel);
            Controls.Add(cadastrarButton);
            Controls.Add(voltarButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form2";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button voltarButton;
        private Button cadastrarButton;
        private Label nomeLabel;
        private TextBox nomeTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label telefoneLabel;
        private TextBox telTextBox;
        private Label nacionalidadeLabel;
        private TextBox naciTextBox;
    }
}