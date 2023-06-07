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
    public partial class Form6 : Form
    {
        Form5 form5 = new Form5();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //falta ligacao com o corretor
            Imovel i = new Imovel();
            i.Descricao = descricaoTextBox.Text;
            i.Valor = float.Parse(valorTextBox.Text);
            i.Localizacao = localizacaoTextBox.Text;
            ImovelRepository.Add(i);
            MessageBox.Show("Imovel Cadastrado com Sucesso!");
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
