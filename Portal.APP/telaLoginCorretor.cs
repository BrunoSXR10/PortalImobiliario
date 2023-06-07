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
    public partial class telaLoginCorretor : Form
    {
        public telaLoginCorretor()
        {
            InitializeComponent();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            telaInicial form1 = new telaInicial();
            form1.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //logou
            telaGerenciamento form5 = new telaGerenciamento();
            form5.Show();
            this.Hide();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
