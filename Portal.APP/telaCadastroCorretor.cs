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
using Newtonsoft.Json;

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

        private async void cadastrarButton_Click(object sender, EventArgs e)
        {
            TbCorretor c = new TbCorretor();
            c.Nome = nomeTextBox.Text;
            c.Cpf = int.Parse(cpfTextBox.Text);
            c.Deputado = nacionalidadeTextBox.Text;
            string objetoJson = JsonConvert.SerializeObject(c);
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Definir a URL da API para a qual você deseja enviar os dados
                    string url = "http://localhost:5205/api/Corretor";

                    // Criar o conteúdo da solicitação HTTP com o objeto JSON
                    HttpContent content = new StringContent(objetoJson, Encoding.UTF8, "application/json");

                    // Enviar a solicitação POST para a API
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    // Verificar se a solicitação foi bem-sucedida
                    if (response.IsSuccessStatusCode)
                    {
                        // Cadastro realizado com sucesso
                        MessageBox.Show("Corretor cadastrado com sucesso!");
                    }
                    else
                    {
                        // Lidar com erros da API
                        MessageBox.Show("Erro ao cadastrar o Corretor. Resposta da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    // Lidar com erros de conexão ou outros erros
                    MessageBox.Show("Erro ao cadastrar o Corretor: " + ex.Message);
                }
            }





        }



    }
}
