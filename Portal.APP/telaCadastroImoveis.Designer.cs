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
            voltarButton = new Button();
            descricaoLabel = new Label();
            localizacaoLabel = new Label();
            valorLabel = new Label();
            descricaoTextBox = new TextBox();
            localizacaoTextBox = new TextBox();
            valorTextBox = new TextBox();
            cadastrarButton = new Button();
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
            descricaoLabel.Location = new Point(80, 69);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new Size(111, 27);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "descricao";
            // 
            // localizacaoLabel
            // 
            localizacaoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            localizacaoLabel.Location = new Point(80, 158);
            localizacaoLabel.Name = "localizacaoLabel";
            localizacaoLabel.Size = new Size(111, 27);
            localizacaoLabel.TabIndex = 2;
            localizacaoLabel.Text = "localizacao";
            // 
            // valorLabel
            // 
            valorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            valorLabel.Location = new Point(94, 224);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(111, 27);
            valorLabel.TabIndex = 3;
            valorLabel.Text = "valor";
            // 
            // descricaoTextBox
            // 
            descricaoTextBox.Location = new Point(211, 49);
            descricaoTextBox.Multiline = true;
            descricaoTextBox.Name = "descricaoTextBox";
            descricaoTextBox.Size = new Size(282, 89);
            descricaoTextBox.TabIndex = 4;
            // 
            // localizacaoTextBox
            // 
            localizacaoTextBox.Location = new Point(211, 158);
            localizacaoTextBox.Name = "localizacaoTextBox";
            localizacaoTextBox.Size = new Size(282, 23);
            localizacaoTextBox.TabIndex = 5;
            // 
            // valorTextBox
            // 
            valorTextBox.Location = new Point(211, 229);
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
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cadastrarButton);
            Controls.Add(valorTextBox);
            Controls.Add(localizacaoTextBox);
            Controls.Add(descricaoTextBox);
            Controls.Add(valorLabel);
            Controls.Add(localizacaoLabel);
            Controls.Add(descricaoLabel);
            Controls.Add(voltarButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de imoveis";
            FormClosed += Form6_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button voltarButton;
        private Label descricaoLabel;
        private Label localizacaoLabel;
        private Label valorLabel;
        private TextBox descricaoTextBox;
        private TextBox localizacaoTextBox;
        private TextBox valorTextBox;
        private Button cadastrarButton;
    }
}