﻿namespace Portal.APP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            titulo = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            // button1
            // 
            button1.Location = new Point(12, 85);
            button1.Name = "button1";
            button1.Size = new Size(280, 108);
            button1.TabIndex = 1;
            button1.Text = "cadastre-se";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(326, 81);
            button2.Name = "button2";
            button2.Size = new Size(280, 116);
            button2.TabIndex = 2;
            button2.Text = "listar imoveis disponiveis";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(186, 247);
            button3.Name = "button3";
            button3.Size = new Size(319, 131);
            button3.TabIndex = 3;
            button3.Text = "login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(titulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Portal Imobiliario";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label titulo;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}