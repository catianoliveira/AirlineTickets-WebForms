using Biblioteca;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class Capa : Form
    {
        Login login;
        Timer timer = new Timer();

        public Capa(Login login)
        {
            InitializeComponent();
            this.CenterToScreen();
            login.Hide();
            this.login = login;
            lblNome.Text = $"Olá, {login.tbUser.Text}";
            timer.Tick += new EventHandler(timer_Tick); // Sempre que o cronometro muda, o timer.Tick é chamado
            timer.Interval = 1000;              // Timer muda todos os segundos
            timer.Enabled = true;                       
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            ClientesForm clientes = new ClientesForm();
            clientes.Show();
        }

        private void PbAparelhos_Click(object sender, EventArgs e)
        {
            AparelhosForm aparelhos = new AparelhosForm();
            aparelhos.ShowDialog();
        }

        private void PbAeroportos_Click(object sender, EventArgs e)
        {
            AeroportosForm aeroportos = new AeroportosForm();
            aeroportos.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            AeroportosForm aeroportos = new AeroportosForm();
            aeroportos.Show();
        }
        private void PbVoos_Click(object sender, EventArgs e)
        {
            VoosForm voos = new VoosForm();
            voos.Show();
        }

        private void PbBilhetes_Click(object sender, EventArgs e)
        {
            ListaBilhetesForm lista = new ListaBilhetesForm();
            lista.Show();
        }

        private void PbComprar_Click(object sender, EventArgs e)
        {
            ComprarBilheteForm comprar = new ComprarBilheteForm();
            comprar.Show();
        }

        private void PbCredito_Click(object sender, EventArgs e)
        {
            CreditoForm credito = new CreditoForm();
            credito.Show();
        }
    }
}
