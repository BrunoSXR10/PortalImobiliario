namespace Portal.APP
{
    partial class telaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInicial));
            titulo = new Label();
            cadastrarButton = new Button();
            listarImoveisButton = new Button();
            loginButton = new Button();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titulo.Location = new Point(288, 28);
            titulo.Name = "titulo";
            titulo.Size = new Size(204, 42);
            titulo.TabIndex = 0;
            titulo.Text = "Portal Imobiliario";
            // 
            // cadastrarButton
            // 
            cadastrarButton.Location = new Point(51, 85);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(280, 108);
            cadastrarButton.TabIndex = 1;
            cadastrarButton.Text = "cadastre-se";
            cadastrarButton.UseVisualStyleBackColor = true;
            cadastrarButton.Click += cadastrarButton_Click;
            // 
            // listarImoveisButton
            // 
            listarImoveisButton.Location = new Point(409, 81);
            listarImoveisButton.Name = "listarImoveisButton";
            listarImoveisButton.Size = new Size(280, 116);
            listarImoveisButton.TabIndex = 2;
            listarImoveisButton.Text = "listar imoveis disponiveis";
            listarImoveisButton.UseVisualStyleBackColor = true;
            listarImoveisButton.Click += listarImoveisButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(186, 247);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(319, 131);
            loginButton.TabIndex = 3;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(listarImoveisButton);
            Controls.Add(cadastrarButton);
            Controls.Add(titulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Portal Imobiliario";
            ResumeLayout(false);
        }

        #endregion

        private Label titulo;
        private Button cadastrarButton;
        private Button listarImoveisButton;
        private Button loginButton;
    }
}