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
            SuspendLayout();
            // 
            // voltarButton
            // 
            voltarButton.Location = new Point(554, 331);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(187, 74);
            voltarButton.TabIndex = 0;
            voltarButton.Text = "voltar";
            voltarButton.UseVisualStyleBackColor = true;
            voltarButton.Click += voltarButton_Click;
            // 
            // descricaoLabel
            // 
            descricaoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            descricaoLabel.Location = new Point(82, 45);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new Size(111, 27);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "descricao";
            // 
            // valorLabel
            // 
            valorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            valorLabel.Location = new Point(94, 275);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(111, 27);
            valorLabel.TabIndex = 3;
            valorLabel.Text = "valor";
            // 
            // descricaoTextBox
            // 
            descricaoTextBox.Location = new Point(211, 12);
            descricaoTextBox.Multiline = true;
            descricaoTextBox.Name = "descricaoTextBox";
            descricaoTextBox.Size = new Size(282, 89);
            descricaoTextBox.TabIndex = 4;
            // 
            // valorTextBox
            // 
            valorTextBox.Location = new Point(211, 279);
            valorTextBox.Name = "valorTextBox";
            valorTextBox.Size = new Size(282, 23);
            valorTextBox.TabIndex = 6;
            // 
            // cadastrarButton
            // 
            cadastrarButton.Location = new Point(161, 327);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(260, 82);
            cadastrarButton.TabIndex = 7;
            cadastrarButton.Text = "cadastrar";
            cadastrarButton.UseVisualStyleBackColor = true;
            cadastrarButton.Click += cadastrarButton_Click;
            // 
            // cepTextBox
            // 
            cepTextBox.Location = new Point(211, 114);
            cepTextBox.Name = "cepTextBox";
            cepTextBox.Size = new Size(282, 23);
            cepTextBox.TabIndex = 8;
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cepLabel.Location = new Point(94, 114);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new Size(42, 25);
            cepLabel.TabIndex = 9;
            cepLabel.Text = "cep";
            // 
            // logradouroLabel
            // 
            logradouroLabel.AutoSize = true;
            logradouroLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            logradouroLabel.Location = new Point(94, 159);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new Size(107, 25);
            logradouroLabel.TabIndex = 10;
            logradouroLabel.Text = "logradouro";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numeroLabel.Location = new Point(94, 200);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new Size(78, 25);
            numeroLabel.TabIndex = 11;
            numeroLabel.Text = "numero";
            // 
            // complementoLabel
            // 
            complementoLabel.AutoSize = true;
            complementoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            complementoLabel.Location = new Point(77, 234);
            complementoLabel.Name = "complementoLabel";
            complementoLabel.Size = new Size(128, 25);
            complementoLabel.TabIndex = 12;
            complementoLabel.Text = "complemento";
            // 
            // complementoTextBox
            // 
            complementoTextBox.Location = new Point(211, 239);
            complementoTextBox.Name = "complementoTextBox";
            complementoTextBox.Size = new Size(282, 23);
            complementoTextBox.TabIndex = 13;
            // 
            // logradouroTextBox
            // 
            logradouroTextBox.Location = new Point(211, 161);
            logradouroTextBox.Name = "logradouroTextBox";
            logradouroTextBox.Size = new Size(282, 23);
            logradouroTextBox.TabIndex = 13;
            // 
            // numeroTextBox
            // 
            numeroTextBox.Location = new Point(211, 202);
            numeroTextBox.Name = "numeroTextBox";
            numeroTextBox.Size = new Size(282, 23);
            numeroTextBox.TabIndex = 14;
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "telaCadastroImoveis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de imoveis";
            FormClosed += Form6_FormClosed;
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
    }
}