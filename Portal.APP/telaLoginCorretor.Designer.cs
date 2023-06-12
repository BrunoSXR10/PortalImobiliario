namespace Portal.APP
{
    partial class telaLoginCorretor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLoginCorretor));
            voltarButton = new Button();
            loginLabel = new Label();
            loginTextBox = new TextBox();
            senhaTextBox = new TextBox();
            senhaLabel = new Label();
            loginButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // voltarButton
            // 
            voltarButton.BackColor = Color.PapayaWhip;
            voltarButton.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            voltarButton.Location = new Point(698, 400);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(91, 40);
            voltarButton.TabIndex = 0;
            voltarButton.Text = "voltar";
            voltarButton.UseVisualStyleBackColor = false;
            voltarButton.Click += voltarButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.BackColor = Color.PapayaWhip;
            loginLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.Location = new Point(226, 117);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(70, 28);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Login";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(318, 122);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(226, 23);
            loginTextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(318, 203);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.Size = new Size(226, 23);
            senhaTextBox.TabIndex = 3;
            senhaTextBox.UseSystemPasswordChar = true;
            // 
            // senhaLabel
            // 
            senhaLabel.BackColor = Color.PapayaWhip;
            senhaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            senhaLabel.Location = new Point(226, 198);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(70, 28);
            senhaLabel.TabIndex = 4;
            senhaLabel.Text = "Senha";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.PapayaWhip;
            loginButton.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(347, 281);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(116, 40);
            loginButton.TabIndex = 5;
            loginButton.Text = "Logar";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // telaLoginCorretor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(senhaLabel);
            Controls.Add(senhaTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(loginLabel);
            Controls.Add(voltarButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "telaLoginCorretor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Form4_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button voltarButton;
        private Label loginLabel;
        private TextBox loginTextBox;
        private TextBox senhaTextBox;
        private Label senhaLabel;
        private Button loginButton;
        private PictureBox pictureBox1;
    }
}