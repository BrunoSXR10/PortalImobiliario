using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portal.BLL;
using Portal.MODEL;

namespace Portal.APP
{
    public partial class telaListaDeImoveis : Form
    {
        public telaListaDeImoveis()
        {
            InitializeComponent();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            telaInicial form1 = new telaInicial();
            form1.Show();
            this.Hide();
        }
        private void listarImoveisButton_Click(object sender, EventArgs e)
        {
            List<Imovel> imovel = ImovelRepository.GetAll();
            dataGridView1.DataSource = imovel;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
