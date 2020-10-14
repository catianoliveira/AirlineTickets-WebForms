using Biblioteca;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class ClientesForm : Form
    {
        Capa capa;
        Cliente cliente = new Cliente();

        public ClientesForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            LerClientes(clienteBindingSource);
            dataNascimento.MaxDate = DateTime.Today;
            dataNascimento.Text = DateTime.Today.ToShortDateString();
        }

        private void PbEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)dataGridClientes.CurrentRow.DataBoundItem;

            EditarClienteForm editar = new EditarClienteForm(this, cliente);
            editar.ShowDialog();
        }

        private void PbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbApagar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridClientes.SelectedRows)
            {
                Cliente apagar = (Cliente)row.DataBoundItem;
                dataGridClientes.Rows.RemoveAt(row.Index);
                dataGridClientes.Refresh();
            }
        }

        private void PbAdd_Click(object sender, EventArgs e)
        {
            AdicionaCliente();
        }

        private void ClientesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GravaClientes(); //quando o form é fechado
        }

        /// 
        /// Métodos
        /// 

        public void LerClientes(BindingSource clienteBindingSource)
        {
            StreamReader sr;

            if (File.Exists(Cliente.FicheiroClientes)) //verifica se o ficheiro existe
            {
                sr = File.OpenText(Cliente.FicheiroClientes);

                string linha = string.Empty;
                try
                {
                    while ((linha = sr.ReadLine()) != null) // enquanto as linhas nao tiverem vazias
                    {
                        string[] colunas = linha.ToString().Split(',');

                        if (colunas.Length >= 7)
                        {
                            Cliente cliente = new Cliente
                            {
                                Id = colunas[0],
                                Nome = colunas[1],
                                DN = colunas[2],
                                Documento = colunas[3],
                                Genero = colunas[4],
                                Telefone = colunas[5],
                                Email = colunas[6],
                            };
                            clienteBindingSource.Add(cliente);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao ler o ficheiro");
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        // Adiciona cliente à bindingsource e datagridview, limpa os campos
        private void AdicionaCliente()
        {
            Cliente novoCliente;

            if (ValidaForm())
            {
                novoCliente = new Cliente
                {
                    Id = GeraID(),
                    Nome = tbNome.Text,
                    DN = dataNascimento.Text,
                    Documento = tbID.Text,
                    Genero = cbGenero.SelectedItem.ToString(),
                    Telefone = tbTelefone.Text,
                    Email = tbEmail.Text,
                };

                this.clienteBindingSource.Add(novoCliente);
                tbNome.Text = null;
                dataNascimento.Text = DateTime.Today.ToShortDateString();
                tbID.Text = null;
                tbTelefone.Text = null;
                tbEmail.Text = null;
            }
        }

        //Verifica se campos estão preenchidos e se id já existe
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tbNome.Text) || string.IsNullOrEmpty(tbID.Text) ||
                string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbTelefone.Text) || cbGenero.SelectedItem == null)
            {
                MessageBox.Show("Insira os dados corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }

            foreach (Cliente item in clienteBindingSource)
            {
                if (tbID.Text == item.Id)
                {
                    MessageBox.Show("Cliente já existe", "Erro",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tbID.Text = string.Empty;

                    output = false;
                }
            }

            return output;
        }

        //Gera ID random e verifica se já existe
        private string GeraID()
        {
            string id = Path.GetRandomFileName();
            id = id.Replace(".", ""); // Remove o ponto

            foreach (Cliente item in clienteBindingSource)
            {
                if (id.ToString() == cliente.Id)
                {
                    id = Path.GetRandomFileName();
                    id = id.Replace(".", "");
                }
            }

            id = id.ToUpper();

            return id.Substring(0, 5);  // Retoma uma string de 5 caracteres
        }
        
        private void GravaClientes() //grava txt com dados da datagridview
        {
            StreamWriter sw = File.CreateText(Cliente.FicheiroClientes);
            try
            {
                foreach (DataGridViewRow row in dataGridClientes.Rows)
                {
                    Cliente cliente = (Cliente)row.DataBoundItem;

                    string linha = $"{cliente.Id},{cliente.Nome},{cliente.DN},{cliente.Documento}," +
                        $"{cliente.Genero},{cliente.Telefone},{cliente.Email}";

                    sw.WriteLine(linha);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro na gravação do ficheiro");
            }
            finally
            {
                sw.Close();
            }
        }

        public void InitLista() //
        {
            dataGridClientes.DataSource = null;
            dataGridClientes.DataSource = clienteBindingSource;
        }
    }
}
