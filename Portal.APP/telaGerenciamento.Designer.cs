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
            cadastrarImovelButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cadastrarImovelButton
            // 
            cadastrarImovelButton.Location = new Point(512, 177);
            cadastrarImovelButton.Name = "cadastrarImovelButton";
            cadastrarImovelButton.Size = new Size(232, 68);
            cadastrarImovelButton.TabIndex = 0;
            cadastrarImovelButton.Text = "cadastrar imovel";
            cadastrarImovelButton.UseVisualStyleBackColor = true;
            cadastrarImovelButton.Click += cadastrarImovelButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(157, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(310, 325);
            dataGridView1.TabIndex = 1;
            // 
            // telaGerenciamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(cadastrarImovelButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "telaGerenciamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento";
            FormClosed += Form5_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cadastrarImovelButton;
        private DataGridView dataGridView1;
    }
}