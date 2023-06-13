namespace Portal.APP
{
    partial class telaGerenciamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaGerenciamento));
            cadastrarImovelButton = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cadastrarImovelButton
            // 
            cadastrarImovelButton.BackColor = Color.IndianRed;
            cadastrarImovelButton.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cadastrarImovelButton.Location = new Point(522, 178);
            cadastrarImovelButton.Name = "cadastrarImovelButton";
            cadastrarImovelButton.Size = new Size(227, 38);
            cadastrarImovelButton.TabIndex = 0;
            cadastrarImovelButton.Text = "cadastrar imovel";
            cadastrarImovelButton.UseVisualStyleBackColor = false;
            cadastrarImovelButton.Click += cadastrarImovelButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(126, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(361, 320);
            dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // telaGerenciamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(cadastrarImovelButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "telaGerenciamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento";
            FormClosed += Form5_FormClosed;
            Load += telaGerenciamento_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cadastrarImovelButton;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}