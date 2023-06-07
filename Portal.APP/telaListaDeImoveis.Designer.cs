namespace Portal.APP
{
    partial class telaListaDeImoveis
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
            components = new System.ComponentModel.Container();
            voltarButton = new Button();
            listarImoveisButton = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            localizacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imovelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imovelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // voltarButton
            // 
            voltarButton.Location = new Point(557, 319);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(125, 70);
            voltarButton.TabIndex = 1;
            voltarButton.Text = "voltar";
            voltarButton.UseVisualStyleBackColor = true;
            voltarButton.Click += voltarButton_Click;
            // 
            // listarImoveisButton
            // 
            listarImoveisButton.Location = new Point(237, 324);
            listarImoveisButton.Name = "listarImoveisButton";
            listarImoveisButton.Size = new Size(180, 65);
            listarImoveisButton.TabIndex = 2;
            listarImoveisButton.Text = "listar Imoveis";
            listarImoveisButton.UseVisualStyleBackColor = true;
            listarImoveisButton.Click += listarImoveisButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, valorDataGridViewTextBoxColumn, localizacaoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = imovelBindingSource;
            dataGridView1.Location = new Point(164, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(444, 212);
            dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // localizacaoDataGridViewTextBoxColumn
            // 
            localizacaoDataGridViewTextBoxColumn.DataPropertyName = "Localizacao";
            localizacaoDataGridViewTextBoxColumn.HeaderText = "Localizacao";
            localizacaoDataGridViewTextBoxColumn.Name = "localizacaoDataGridViewTextBoxColumn";
            // 
            // imovelBindingSource
            // 
            imovelBindingSource.DataSource = typeof(MODEL.Imovel);
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(listarImoveisButton);
            Controls.Add(voltarButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de imoveis";
            FormClosed += Form3_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imovelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button voltarButton;
        private Button listarImoveisButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn localizacaoDataGridViewTextBoxColumn;
        private BindingSource imovelBindingSource;
    }
}