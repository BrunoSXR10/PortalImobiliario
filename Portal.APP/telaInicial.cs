namespace Portal.APP
{
    public partial class telaInicial : Form
    {

        public telaInicial()
        {
            InitializeComponent();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            telaCadastroCorretor form2 = new telaCadastroCorretor();
            form2.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            telaLoginCorretor form4 = new telaLoginCorretor();
            form4.Show();
            this.Hide();
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }
    }
}