namespace Portal.APP
{
    partial class telaCadastroImoveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaCadastroImoveis));
            voltarButton = new Button();
            descricaoLabel = new Label();
            valorLabel = new Label();
            descricaoTextBox = new TextBox();
            valorTextBox = new TextBox();
            cadastrarButton = new Button();
            localizacaoLabel = new Label();
            localizacaoTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // voltarButton
            // 
            voltarButton.BackColor = SystemColors.ActiveCaption;
            voltarButton.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            voltarButton.Location = new Point(798, 533);
            voltarButton.Margin = new Padding(3, 4, 3, 4);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(104, 53);
            voltarButton.TabIndex = 0;
            voltarButton.Text = "voltar";
            voltarButton.UseVisualStyleBackColor = false;
            voltarButton.Click += voltarButton_Click;
            // 
            // descricaoLabel
            // 
            descricaoLabel.BackColor = SystemColors.ActiveCaption;
            descricaoLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            descricaoLabel.Location = new Point(165, 65);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new Size(129, 36);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "descrição";
            descricaoLabel.Click += descricaoLabel_Click;
            // 
            // valorLabel
            // 
            valorLabel.BackColor = SystemColors.ActiveCaption;
            valorLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            valorLabel.Location = new Point(189, 284);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(80, 31);
            valorLabel.TabIndex = 3;
            valorLabel.Text = "valor";
            // 
            // descricaoTextBox
            // 
            descricaoTextBox.Location = new Point(324, 46);
            descricaoTextBox.Margin = new Padding(3, 4, 3, 4);
            descricaoTextBox.Multiline = true;
            descricaoTextBox.Name = "descricaoTextBox";
            descricaoTextBox.Size = new Size(322, 75);
            descricaoTextBox.TabIndex = 4;
            // 
            // valorTextBox
            // 
            valorTextBox.Location = new Point(324, 284);
            valorTextBox.Margin = new Padding(3, 4, 3, 4);
            valorTextBox.Name = "valorTextBox";
            valorTextBox.Size = new Size(322, 27);
            valorTextBox.TabIndex = 6;
            // 
            // cadastrarButton
            // 
            cadastrarButton.BackColor = SystemColors.ActiveCaption;
            cadastrarButton.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cadastrarButton.Location = new Point(367, 467);
            cadastrarButton.Margin = new Padding(3, 4, 3, 4);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(219, 65);
            cadastrarButton.TabIndex = 7;
            cadastrarButton.Text = "cadastrar";
            cadastrarButton.UseVisualStyleBackColor = false;
            cadastrarButton.Click += cadastrarButton_Click;
            // 
            // localizacaoLabel
            // 
            localizacaoLabel.AutoSize = true;
            localizacaoLabel.BackColor = SystemColors.ActiveCaption;
            localizacaoLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            localizacaoLabel.Location = new Point(153, 176);
            localizacaoLabel.Name = "localizacaoLabel";
            localizacaoLabel.Size = new Size(155, 28);
            localizacaoLabel.TabIndex = 12;
            localizacaoLabel.Text = "Localização";
            // 
            // localizacaoTextBox
            // 
            localizacaoTextBox.Location = new Point(324, 175);
            localizacaoTextBox.Margin = new Padding(3, 4, 3, 4);
            localizacaoTextBox.Multiline = true;
            localizacaoTextBox.Name = "localizacaoTextBox";
            localizacaoTextBox.Size = new Size(322, 29);
            localizacaoTextBox.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-37, -41);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(953, 644);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // telaCadastroImoveis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(localizacaoTextBox);
            Controls.Add(localizacaoLabel);
            Controls.Add(cadastrarButton);
            Controls.Add(valorTextBox);
            Controls.Add(descricaoTextBox);
            Controls.Add(valorLabel);
            Controls.Add(descricaoLabel);
            Controls.Add(voltarButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "telaCadastroImoveis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de imoveis";
            FormClosed += Form6_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button voltarButton;
        private Label descricaoLabel;
        private Label valorLabel;
        private TextBox descricaoTextBox;
        private TextBox valorTextBox;
        private Button cadastrarButton;
        private TextBox cepTextBox;
        private Label cepLabel;
        private Label logradouroLabel;
        private Label numeroLabel;
        private Label localizacaoLabel;
        private TextBox localizacaoTextBox;
        private PictureBox pictureBox1;
        private TextBox logradouroTextBox;
        private TextBox numeroTextBox;
    }
}