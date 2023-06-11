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
            sairButton = new Button();
            buttonButton = new Button();
            voltarButton = new Button();
            cadastrarButton = new Button();
            nomeLabel = new Label();
            emailLabel = new Label();
            telefoneLabel = new Label();
            naciLabel = new Label();
            senhaLabel = new Label();
            nomeTextBox = new TextBox();
            emailTextBox = new TextBox();
            telefoneTextBox = new TextBox();
            nacionalidadeTextBox = new TextBox();
            senhaTextBox = new TextBox();
            SuspendLayout();
            // 
            // voltarButton
            // 
            voltarButton.Location = new Point(564, 328);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(125, 70);
            voltarButton.TabIndex = 0;
            voltarButton.Text = "voltar";
            voltarButton.UseVisualStyleBackColor = true;
            voltarButton.Click += voltarButton_Click;
            // 
            // cadastrarButton
            // 
            cadastrarButton.Location = new Point(126, 332);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(180, 62);
            cadastrarButton.TabIndex = 1;
            cadastrarButton.Text = "cadastre-se";
            cadastrarButton.UseVisualStyleBackColor = true;
            cadastrarButton.Click += cadastrarButton_Click;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nomeLabel.Location = new Point(88, 92);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(63, 25);
            nomeLabel.TabIndex = 11;
            nomeLabel.Text = "Nome";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(93, 142);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(58, 25);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            telefoneLabel.Location = new Point(79, 195);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new Size(83, 25);
            telefoneLabel.TabIndex = 13;
            telefoneLabel.Text = "Telefone";
            // 
            // naciLabel
            // 
            naciLabel.AutoSize = true;
            naciLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            naciLabel.Location = new Point(50, 248);
            naciLabel.Name = "naciLabel";
            naciLabel.Size = new Size(134, 25);
            naciLabel.TabIndex = 14;
            naciLabel.Text = "Nacionalidade";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            senhaLabel.Location = new Point(424, 147);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(64, 25);
            senhaLabel.TabIndex = 15;
            senhaLabel.Text = "Senha";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(182, 97);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(170, 23);
            nomeTextBox.TabIndex = 16;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(182, 147);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(170, 23);
            emailTextBox.TabIndex = 17;
            // 
            // telefoneTextBox
            // 
            telefoneTextBox.Location = new Point(182, 197);
            telefoneTextBox.Name = "telefoneTextBox";
            telefoneTextBox.Size = new Size(170, 23);
            telefoneTextBox.TabIndex = 18;
            // 
            // nacionalidadeTextBox
            // 
            nacionalidadeTextBox.Location = new Point(190, 253);
            nacionalidadeTextBox.Name = "nacionalidadeTextBox";
            nacionalidadeTextBox.Size = new Size(170, 23);
            nacionalidadeTextBox.TabIndex = 19;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(494, 149);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.Size = new Size(170, 23);
            senhaTextBox.TabIndex = 20;
            // 
            // telaCadastroCorretor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(senhaTextBox);
            Controls.Add(nacionalidadeTextBox);
            Controls.Add(telefoneTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nomeTextBox);
            Controls.Add(senhaLabel);
            Controls.Add(naciLabel);
            Controls.Add(telefoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(nomeLabel);
            Controls.Add(cadastrarButton);
            Controls.Add(voltarButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "telaCadastroCorretor";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Corretor";
            FormClosed += Form2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button voltarButton;
        private Button cadastrarButton;
        private Label nomeLabel;
        private Label emailLabel;
        private Label telefoneLabel;
        private Label naciLabel;
        private Label senhaLabel;
        private TextBox nomeTextBox;
        private TextBox emailTextBox;
        private TextBox telefoneTextBox;
        private TextBox nacionalidadeTextBox;
        private TextBox senhaTextBox;
    }
}