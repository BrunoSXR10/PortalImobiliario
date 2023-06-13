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
            nacionalidadeTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            senhaTextBox = new TextBox();
            cpfLabel = new Label();
            dataLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // voltarButton
            // 
            voltarButton.BackColor = Color.HotPink;
            voltarButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            voltarButton.Location = new Point(798, 533);
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
            cadastrarButton.Location = new Point(394, 477);
            cadastrarButton.Margin = new Padding(3, 4, 3, 4);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(133, 53);
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
            nomeLabel.Location = new Point(207, 152);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(60, 26);
            nomeLabel.TabIndex = 11;
            nomeLabel.Text = "Nome";
            // 
            // naciLabel
            // 
            naciLabel.AutoSize = true;
            naciLabel.BackColor = Color.Pink;
            naciLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            naciLabel.Location = new Point(144, 417);
            naciLabel.Name = "naciLabel";
            naciLabel.Size = new Size(168, 26);
            naciLabel.TabIndex = 14;
            naciLabel.Text = "Nacionalidade";
            naciLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = Color.Pink;
            senhaLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            senhaLabel.Location = new Point(195, 351);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(72, 26);
            senhaLabel.TabIndex = 15;
            senhaLabel.Text = "Senha";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(360, 151);
            nomeTextBox.Margin = new Padding(3, 4, 3, 4);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(194, 27);
            nomeTextBox.TabIndex = 16;
            // 
            // cpfTextBox
            // 
            cpfTextBox.Location = new Point(360, 213);
            cpfTextBox.Margin = new Padding(3, 4, 3, 4);
            cpfTextBox.Name = "cpfTextBox";
            cpfTextBox.Size = new Size(194, 27);
            cpfTextBox.TabIndex = 17;
            // 
            // nacionalidadeTextBox
            // 
            nacionalidadeTextBox.Location = new Point(360, 419);
            nacionalidadeTextBox.Margin = new Padding(3, 4, 3, 4);
            nacionalidadeTextBox.Name = "nacionalidadeTextBox";
            nacionalidadeTextBox.Size = new Size(194, 27);
            nacionalidadeTextBox.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-23, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(987, 649);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(360, 352);
            senhaTextBox.Margin = new Padding(3, 4, 3, 4);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.Size = new Size(194, 27);
            senhaTextBox.TabIndex = 19;
            senhaTextBox.UseSystemPasswordChar = true;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = Color.Pink;
            cpfLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            cpfLabel.Location = new Point(207, 212);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new Size(48, 26);
            cpfLabel.TabIndex = 12;
            cpfLabel.Text = "CPF";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.BackColor = Color.Pink;
            dataLabel.Font = new Font("Consolas", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataLabel.Location = new Point(123, 279);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new Size(228, 26);
            dataLabel.TabIndex = 22;
            dataLabel.Text = "Data de nascimento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(360, 279);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 27);
            dateTimePicker1.TabIndex = 23;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // telaCadastroCorretor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(914, 600);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataLabel);
            Controls.Add(nacionalidadeTextBox);
            Controls.Add(senhaTextBox);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
        private Label naciLabel;
        private Label senhaLabel;
        private TextBox nomeTextBox;
        private TextBox cpfTextBox;
        private TextBox telefoneTextBox;
        private TextBox nacionalidadeTextBox;
        private PictureBox pictureBox1;
        private TextBox senhaTextBox;
        private Label cpfLabel;
        private Label dataLabel;
        private DateTimePicker dateTimePicker1;
    }
}