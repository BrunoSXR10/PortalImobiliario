using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Azure;
using System.Reflection.Metadata;
using System.Security.Policy;
using Portal.MODEL;

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

        private async void loginButton_Click(object sender, EventArgs e)
        {

            string apiUrl = "http://localhost:5205/api/Corretor";
            string cpf = loginTextBox.Text;
            string senha = senhaTextBox.Text;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{cpf}");
                try
                {
                    if (response.IsSuccessStatusCode)
                     {
                         string apiResponse = await response.Content.ReadAsStringAsync();
                         telaGerenciamento form5 = new telaGerenciamento();
                         form5.Show();
                         this.Hide();
                     }
                     else
                     {
                         MessageBox.Show("Não foi possivel logar, Login ou senha errados! " + response.StatusCode);
                     }
                }
                catch
                {
                    MessageBox.Show("Erro da API: " + response.StatusCode);
                }
            }

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public int getIdLogin { get; set; }

    }
}
