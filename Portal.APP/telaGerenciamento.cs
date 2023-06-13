using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Formatting;

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

        private async void telaGerenciamento_Load(object sender, EventArgs e)
        {
            string url = "http://localhost:5205/api/Imovel";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{url}/GetImovel");
                    if (response.IsSuccessStatusCode)
                    {
                        List<Imv> listaObjetos = await response.Content.ReadAsAsync<List<Imv>>();
                        dataGridView1.DataSource = listaObjetos;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao obter os imoveis");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao enviar a solicitação para a API: " + ex.Message);
                }
               
            }
           

        }
    }
}
