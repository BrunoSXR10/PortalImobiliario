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
using System.Net.Http;
using Newtonsoft.Json;
using Portal.MODEL;
using System.Threading.Tasks;
using Portal.BLLService;
using Portal.BLLService.Controllers;

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

        private async void cadastrarButton_Click(object sender, EventArgs e)
        {

            Imv i = new Imv();
            i.Local = localizacaoTextBox.Text;
            i.Descricao = descricaoTextBox.Text;
            i.Valor = float.Parse(valorTextBox.Text);

            string objetoJson = JsonConvert.SerializeObject(i);
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Definir a URL da API para a qual você deseja enviar os dados
                    string url = "http://localhost:5205/api/Imovel";

                    // Criar o conteúdo da solicitação HTTP com o objeto JSON
                    HttpContent content = new StringContent(objetoJson, Encoding.UTF8, "application/json");

                    // Enviar a solicitação POST para a API
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    // Verificar se a solicitação foi bem-sucedida
                    if (response.IsSuccessStatusCode)
                    {
                        // Cadastro realizado com sucesso
                        MessageBox.Show("Imovel cadastrado com sucesso!");
                    }
                    else
                    {
                        // Lidar com erros da API
                        MessageBox.Show("Erro ao cadastrar Imovel. Resposta da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    // Lidar com erros de conexão ou outros erros
                    MessageBox.Show("Erro ao cadastrar Imovel: " + ex.Message);
                }
            }

        }

        private void descricaoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
