using Biblioteca;
using System;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class EditarClienteForm : Form
    {
        Cliente cliente;
        ClientesForm form;

        public EditarClienteForm(ClientesForm form, Cliente cliente)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.cliente = cliente;
            this.form = form;
            InicilizaTBs();
        }

        private void PbSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O cliente não será editado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }

        //passa novos dados para o form principal
        private void PbOK_Click(object sender, EventArgs e)
        {
            if (ValidaForm()) 
            {
                cliente.Nome = tbNome.Text;
                cliente.Documento = tbID.Text;
                cliente.Email = tbEmail.Text;
                cliente.Telefone = tbTelefone.Text;
                cliente.DN = dataNascimento.Text;
                cliente.Genero = cbGenero.SelectedItem.ToString();

                form.InitLista();
                this.Close();
            }
        }

        ///
        ///Métodos
        ///

        //mostra dados do cliente selecionado
        private void InicilizaTBs()
        {
            tbID.Text = cliente.Documento.ToString();
            tbNome.Text = cliente.Nome.ToString();
            dataNascimento.Text = cliente.DN.ToString();
            dataNascimento.Enabled = false;
            cbGenero.Text = cliente.Genero.ToString();
            tbTelefone.Text = cliente.Telefone.ToString();
            tbEmail.Text = cliente.Email.ToString();
        }

        //verifica se os campos estão preenchidos
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tbNome.Text) || string.IsNullOrEmpty(tbID.Text) ||
                string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbTelefone.Text))
            {
                MessageBox.Show("Insira os dados", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }

            return output;
        }
    }
}
