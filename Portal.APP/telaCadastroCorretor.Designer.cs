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
            senhaLabel = new Label();
            nomeTextBox = new TextBox();
            cpfTextBox = new TextBox();
            senhaTextBox = new TextBox();
            cpfLabel = new Label();
            pictureBox1 = new PictureBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // voltarButton
            // 
            voltarButton.BackColor = Color.HotPink;
            voltarButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            voltarButton.Location = new Point(698, 400);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(91, 40);
            voltarButton.TabIndex = 0;
            voltarButton.Text = "voltar";
            voltarButton.UseVisualStyleBackColor = false;
            voltarButton.Click += voltarButton_Click;
            // 
            // cadastrarButton
            // 
            cadastrarButton.BackColor = Color.HotPink;
            cadastrarButton.Font = new Font("Consolas", 11F, FontStyle.Bold, GraphicsUnit.Point);
            cadastrarButton.Location = new Point(335, 307);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(116, 40);
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
            nomeLabel.Location = new Point(181, 114);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(50, 22);
            nomeLabel.TabIndex = 11;
            nomeLabel.Text = "Nome";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = Color.Pink;
            senhaLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            senhaLabel.Location = new Point(181, 261);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(60, 22);
            senhaLabel.TabIndex = 15;
            senhaLabel.Text = "Senha";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(315, 113);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(170, 23);
            nomeTextBox.TabIndex = 16;
            // 
            // cpfTextBox
            // 
            cpfTextBox.Location = new Point(315, 160);
            cpfTextBox.Name = "cpfTextBox";
            cpfTextBox.Size = new Size(170, 23);
            cpfTextBox.TabIndex = 17;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(315, 262);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.Size = new Size(170, 23);
            senhaTextBox.TabIndex = 19;
            senhaTextBox.UseSystemPasswordChar = true;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = Color.Pink;
            cpfLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            cpfLabel.Location = new Point(181, 159);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new Size(40, 22);
            cpfLabel.TabIndex = 12;
            cpfLabel.Text = "CPF";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-20, -9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(864, 487);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Pink;
            emailLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(181, 210);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(60, 22);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(315, 214);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(170, 23);
            emailTextBox.TabIndex = 23;
            // 
            // telaCadastroCorretor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(senhaTextBox);
            Controls.Add(cpfTextBox);
            Controls.Add(nomeTextBox);
            Controls.Add(senhaLabel);
            Controls.Add(cpfLabel);
            Controls.Add(nomeLabel);
            Controls.Add(cadastrarButton);
            Controls.Add(voltarButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "telaCadastroCorretor";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Corretor";
            FormClosed += Form2_FormClosed;
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
        private Label senhaLabel;
        private TextBox nomeTextBox;
        private TextBox cpfTextBox;
        private TextBox telefoneTextBox;
        private TextBox senhaTextBox;
        private Label cpfLabel;
        private PictureBox pictureBox1;
        private TextBox emailTextBox;
    }
}