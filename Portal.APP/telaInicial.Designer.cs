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
            loginButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.BackColor = SystemColors.ActiveCaption;
            titulo.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            titulo.Location = new Point(238, 42);
            titulo.Name = "titulo";
            titulo.Size = new Size(341, 39);
            titulo.TabIndex = 0;
            titulo.Text = "Portal Imobiliario";
            // 
            // cadastrarButton
            // 
            cadastrarButton.BackColor = SystemColors.ActiveCaption;
            cadastrarButton.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cadastrarButton.Location = new Point(192, 221);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(151, 51);
            cadastrarButton.TabIndex = 1;
            cadastrarButton.Text = "cadastre-se";
            cadastrarButton.UseVisualStyleBackColor = false;
            cadastrarButton.Click += cadastrarButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ActiveCaption;
            loginButton.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(457, 221);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(175, 51);
            loginButton.TabIndex = 3;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // telaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(cadastrarButton);
            Controls.Add(titulo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "telaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Portal Imobiliario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label titulo;
        private Button cadastrarButton;
        private Button loginButton;
        private PictureBox pictureBox1;
    }
}