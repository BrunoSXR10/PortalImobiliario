namespace Portal.APP
{
    partial class Form6
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            descricaoTextBox = new TextBox();
            localizacaoTextBox = new TextBox();
            valorTextBox = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(554, 331);
            button1.Name = "button1";
            button1.Size = new Size(187, 74);
            button1.TabIndex = 0;
            button1.Text = "voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 69);
            label1.Name = "label1";
            label1.Size = new Size(111, 27);
            label1.TabIndex = 1;
            label1.Text = "descricao";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 158);
            label2.Name = "label2";
            label2.Size = new Size(111, 27);
            label2.TabIndex = 2;
            label2.Text = "localizacao";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(94, 224);
            label3.Name = "label3";
            label3.Size = new Size(111, 27);
            label3.TabIndex = 3;
            label3.Text = "valor";
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
            // button2
            // 
            button2.Location = new Point(161, 327);
            button2.Name = "button2";
            button2.Size = new Size(260, 82);
            button2.TabIndex = 7;
            button2.Text = "cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(valorTextBox);
            Controls.Add(localizacaoTextBox);
            Controls.Add(descricaoTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de imoveis";
            FormClosed += Form6_FormClosed;
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox descricaoTextBox;
        private TextBox localizacaoTextBox;
        private TextBox valorTextBox;
        private Button button2;
    }
}