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
            voltarButton.Location = new Point(698, 400);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(91, 40);
            voltarButton.TabIndex = 0;
            voltarButton.Text = "voltar";
            voltarButton.UseVisualStyleBackColor = false;
            voltarButton.Click += voltarButton_Click;
            // 
            // descricaoLabel
            // 
            descricaoLabel.BackColor = SystemColors.ActiveCaption;
            descricaoLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            descricaoLabel.Location = new Point(143, 42);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new Size(101, 27);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "descricao";
            // 
            // valorLabel
            // 
            valorLabel.BackColor = SystemColors.ActiveCaption;
            valorLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            valorLabel.Location = new Point(174, 213);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(70, 23);
            valorLabel.TabIndex = 3;
            valorLabel.Text = "valor";
            // 
            // descricaoTextBox
            // 
            descricaoTextBox.Location = new Point(275, 42);
            descricaoTextBox.Multiline = true;
            descricaoTextBox.Name = "descricaoTextBox";
            descricaoTextBox.Size = new Size(282, 57);
            descricaoTextBox.TabIndex = 4;
            // 
            // valorTextBox
            // 
            valorTextBox.Location = new Point(275, 213);
            valorTextBox.Name = "valorTextBox";
            valorTextBox.Size = new Size(282, 23);
            valorTextBox.TabIndex = 6;
            // 
            // cadastrarButton
            // 
            cadastrarButton.BackColor = SystemColors.ActiveCaption;
            cadastrarButton.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cadastrarButton.Location = new Point(321, 350);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(192, 49);
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
            localizacaoLabel.Location = new Point(143, 132);
            localizacaoLabel.Name = "localizacaoLabel";
            localizacaoLabel.Size = new Size(120, 22);
            localizacaoLabel.TabIndex = 12;
            localizacaoLabel.Text = "Localização";
            // 
            // localizacaoTextBox
            // 
            localizacaoTextBox.Location = new Point(275, 132);
            localizacaoTextBox.Multiline = true;
            localizacaoTextBox.Name = "localizacaoTextBox";
            localizacaoTextBox.Size = new Size(282, 23);
            localizacaoTextBox.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-32, -31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(834, 483);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // telaCadastroImoveis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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