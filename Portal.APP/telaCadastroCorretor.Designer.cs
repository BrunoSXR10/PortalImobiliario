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
            naciLabel = new Label();
            senhaLabel = new Label();
            nomeTextBox = new TextBox();
            cpfTextBox = new TextBox();
            senhaTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            nacionalidadeTextBox = new TextBox();
            cpfLabel = new Label();
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
            cadastrarButton.Location = new Point(347, 322);
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
            nomeLabel.Location = new Point(171, 113);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(50, 22);
            nomeLabel.TabIndex = 11;
            nomeLabel.Text = "Nome";
            nomeLabel.Click += nomeLabel_Click;
            // 
            // naciLabel
            // 
            naciLabel.AutoSize = true;
            naciLabel.BackColor = Color.Pink;
            naciLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            naciLabel.Location = new Point(122, 267);
            naciLabel.Name = "naciLabel";
            naciLabel.Size = new Size(140, 22);
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
            senhaLabel.Location = new Point(161, 212);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(60, 22);
            senhaLabel.TabIndex = 15;
            senhaLabel.Text = "Senha";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(315, 112);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(170, 23);
            nomeTextBox.TabIndex = 16;
            // 
            // cpfTextBox
            // 
            cpfTextBox.Location = new Point(315, 157);
            cpfTextBox.Name = "cpfTextBox";
            cpfTextBox.Size = new Size(170, 23);
            cpfTextBox.TabIndex = 17;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(315, 267);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.Size = new Size(170, 23);
            senhaTextBox.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(864, 487);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // nacionalidadeTextBox
            // 
            nacionalidadeTextBox.Location = new Point(315, 213);
            nacionalidadeTextBox.Name = "nacionalidadeTextBox";
            nacionalidadeTextBox.Size = new Size(170, 23);
            nacionalidadeTextBox.TabIndex = 19;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = Color.Pink;
            cpfLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            cpfLabel.Location = new Point(171, 167);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new Size(40, 22);
            cpfLabel.TabIndex = 12;
            cpfLabel.Text = "CPF";
            cpfLabel.Click += emailLabel_Click;
            // 
            // telaCadastroCorretor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(senhaTextBox);
            Controls.Add(nacionalidadeTextBox);
            Controls.Add(cpfTextBox);
            Controls.Add(nomeTextBox);
            Controls.Add(senhaLabel);
            Controls.Add(naciLabel);
            Controls.Add(cpfLabel);
            Controls.Add(nomeLabel);
            Controls.Add(cadastrarButton);
            Controls.Add(voltarButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private TextBox cpfTextBox;
        private TextBox telefoneTextBox;
        private TextBox senhaTextBox;
        private PictureBox pictureBox1;
        private TextBox nacionalidadeTextBox;
        private Label cpfLabel;
    }
}