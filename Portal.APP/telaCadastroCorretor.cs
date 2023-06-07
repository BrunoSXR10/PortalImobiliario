using Portal.MODEL;
using Portal.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal.APP
{
    public partial class telaCadastroCorretor : Form
    {

        public telaCadastroCorretor()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            telaInicial form1 = new telaInicial();
            form1.Show();
            this.Hide();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            Corretor c = new Corretor();
            c.Nome = nomeTextBox.Text;
            c.Email = emailTextBox.Text;
            c.Deputado = naciTextBox.Text;
            CorretorRepository.Add(c);
            MessageBox.Show("Corretor Cadastrado com Sucesso!");

        }

    }
}
