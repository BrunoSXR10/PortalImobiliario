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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaCadastroCorretor));
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // voltarButton
            // 
            voltarButton.BackColor = Color.HotPink;
            voltarButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            voltarButton.Location = new Point(798, 534);
            voltarButton.Margin = new Padding(3, 4, 3, 4);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(104, 53);
            voltarButton.TabIndex = 0;
            voltarButton.Text = "voltar";
            voltarButton.UseVisualStyleBackColor = false;
            voltarButton.Click += voltarButton_Click;
            // 
            // cadastrarButton
            // 
            cadastrarButton.BackColor = Color.HotPink;
            cadastrarButton.Font = new Font("Consolas", 11F, FontStyle.Bold, GraphicsUnit.Point);
            cadastrarButton.Location = new Point(397, 429);
            cadastrarButton.Margin = new Padding(3, 4, 3, 4);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(132, 54);
            cadastrarButton.TabIndex = 1;
            cadastrarButton.Text = "cadastre-se";
            cadastrarButton.UseVisualStyleBackColor = false;
            cadastrarButton.Click += cadastrarButton_Click;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = Color.Pink;
            nomeLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            nomeLabel.Location = new Point(184, 122);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(60, 26);
            nomeLabel.TabIndex = 11;
            nomeLabel.Text = "Nome";
            nomeLabel.Click += nomeLabel_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Pink;
            emailLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(184, 178);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(72, 26);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email";
            emailLabel.Click += emailLabel_Click;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = Color.Pink;
            telefoneLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            telefoneLabel.Location = new Point(167, 300);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new Size(108, 26);
            telefoneLabel.TabIndex = 13;
            telefoneLabel.Text = "Telefone";
            telefoneLabel.TextAlign = ContentAlignment.TopCenter;
            telefoneLabel.Click += telefoneLabel_Click;
            // 
            // naciLabel
            // 
            naciLabel.AutoSize = true;
            naciLabel.BackColor = Color.Pink;
            naciLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            naciLabel.Location = new Point(139, 356);
            naciLabel.Name = "naciLabel";
            naciLabel.Size = new Size(168, 26);
            naciLabel.TabIndex = 14;
            naciLabel.Text = "Nacionalidade";
            naciLabel.TextAlign = ContentAlignment.TopCenter;
            naciLabel.Click += naciLabel_Click;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = Color.Pink;
            senhaLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            senhaLabel.Location = new Point(184, 236);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(72, 26);
            senhaLabel.TabIndex = 15;
            senhaLabel.Text = "Senha";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(360, 122);
            nomeTextBox.Margin = new Padding(3, 4, 3, 4);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(194, 27);
            nomeTextBox.TabIndex = 16;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(360, 178);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(194, 27);
            emailTextBox.TabIndex = 17;
            // 
            // telefoneTextBox
            // 
            telefoneTextBox.Location = new Point(360, 236);
            telefoneTextBox.Margin = new Padding(3, 4, 3, 4);
            telefoneTextBox.Name = "telefoneTextBox";
            telefoneTextBox.Size = new Size(194, 27);
            telefoneTextBox.TabIndex = 18;
            // 
            // nacionalidadeTextBox
            // 
            nacionalidadeTextBox.Location = new Point(360, 300);
            nacionalidadeTextBox.Margin = new Padding(3, 4, 3, 4);
            nacionalidadeTextBox.Name = "nacionalidadeTextBox";
            nacionalidadeTextBox.Size = new Size(194, 27);
            nacionalidadeTextBox.TabIndex = 19;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(360, 356);
            senhaTextBox.Margin = new Padding(3, 4, 3, 4);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.Size = new Size(194, 27);
            senhaTextBox.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(987, 649);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // telaCadastroCorretor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(914, 600);
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
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "telaCadastroCorretor";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Corretor";
            FormClosed += Form2_FormClosed;
            Load += telaCadastroCorretor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}