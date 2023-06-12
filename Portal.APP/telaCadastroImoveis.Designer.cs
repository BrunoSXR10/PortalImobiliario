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
            cepTextBox = new TextBox();
            cepLabel = new Label();
            logradouroLabel = new Label();
            numeroLabel = new Label();
            complementoLabel = new Label();
            complementoTextBox = new TextBox();
            logradouroTextBox = new TextBox();
            numeroTextBox = new TextBox();
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
            valorLabel.Location = new Point(157, 286);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(70, 23);
            valorLabel.TabIndex = 3;
            valorLabel.Text = "valor";
            // 
            // descricaoTextBox
            // 
            descricaoTextBox.Location = new Point(275, 12);
            descricaoTextBox.Multiline = true;
            descricaoTextBox.Name = "descricaoTextBox";
            descricaoTextBox.Size = new Size(282, 89);
            descricaoTextBox.TabIndex = 4;
            // 
            // valorTextBox
            // 
            valorTextBox.Location = new Point(275, 286);
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
            // cepTextBox
            // 
            cepTextBox.Location = new Point(275, 114);
            cepTextBox.Name = "cepTextBox";
            cepTextBox.Size = new Size(282, 23);
            cepTextBox.TabIndex = 8;
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.BackColor = SystemColors.ActiveCaption;
            cepLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cepLabel.Location = new Point(171, 114);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new Size(40, 22);
            cepLabel.TabIndex = 9;
            cepLabel.Text = "cep";
            // 
            // logradouroLabel
            // 
            logradouroLabel.AutoSize = true;
            logradouroLabel.BackColor = SystemColors.ActiveCaption;
            logradouroLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            logradouroLabel.Location = new Point(137, 157);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new Size(110, 22);
            logradouroLabel.TabIndex = 10;
            logradouroLabel.Text = "logradouro";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.BackColor = SystemColors.ActiveCaption;
            numeroLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numeroLabel.Location = new Point(157, 195);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new Size(70, 22);
            numeroLabel.TabIndex = 11;
            numeroLabel.Text = "numero";
            // 
            // complementoLabel
            // 
            complementoLabel.AutoSize = true;
            complementoLabel.BackColor = SystemColors.ActiveCaption;
            complementoLabel.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            complementoLabel.Location = new Point(137, 239);
            complementoLabel.Name = "complementoLabel";
            complementoLabel.Size = new Size(120, 22);
            complementoLabel.TabIndex = 12;
            complementoLabel.Text = "complemento";
            // 
            // complementoTextBox
            // 
            complementoTextBox.Location = new Point(275, 239);
            complementoTextBox.Name = "complementoTextBox";
            complementoTextBox.Size = new Size(282, 23);
            complementoTextBox.TabIndex = 13;
            // 
            // logradouroTextBox
            // 
            logradouroTextBox.Location = new Point(275, 159);
            logradouroTextBox.Name = "logradouroTextBox";
            logradouroTextBox.Size = new Size(282, 23);
            logradouroTextBox.TabIndex = 13;
            // 
            // numeroTextBox
            // 
            numeroTextBox.Location = new Point(275, 200);
            numeroTextBox.Name = "numeroTextBox";
            numeroTextBox.Size = new Size(282, 23);
            numeroTextBox.TabIndex = 14;
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
            Controls.Add(numeroTextBox);
            Controls.Add(logradouroTextBox);
            Controls.Add(complementoTextBox);
            Controls.Add(complementoLabel);
            Controls.Add(numeroLabel);
            Controls.Add(logradouroLabel);
            Controls.Add(cepLabel);
            Controls.Add(cepTextBox);
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
        private Label complementoLabel;
        private TextBox complementoTextBox;
        private TextBox logradouroTextBox;
        private TextBox numeroTextBox;
        private PictureBox pictureBox1;
    }
}