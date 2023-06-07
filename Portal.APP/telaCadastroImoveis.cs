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
    public partial class telaCadastroImoveis : Form
    {
        telaGerenciamento form5 = new telaGerenciamento();
        public telaCadastroImoveis()
        {
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            form5.Show();
            this.Hide();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            //falta ligacao com o corretor
            Imovel i = new Imovel();
            i.Descricao = descricaoTextBox.Text;
            i.Valor = float.Parse(valorTextBox.Text);
            i.Localizacao = localizacaoTextBox.Text;
            ImovelRepository.Add(i);
            MessageBox.Show("Imovel Cadastrado com Sucesso!");
        }

    }
}
