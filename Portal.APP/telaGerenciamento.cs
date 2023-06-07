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
    public partial class telaGerenciamento : Form
    {

        public telaGerenciamento()
        {
            InitializeComponent();
        }

        private void cadastrarImovelButton_Click(object sender, EventArgs e)
        {
            telaCadastroImoveis form6 = new telaCadastroImoveis();
            form6.Show();
            this.Hide();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
