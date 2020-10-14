using Biblioteca;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class AeroportosForm : Form
    {
        Aeroporto aeroporto = new Aeroporto();
        VoosForm vooBindingSource;

        public AeroportosForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            LerInfoAeroporto(aeroportoBindingSource);
        }

        private void PbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbAdd_Click(object sender, EventArgs e)
        {
            Aeroporto novoAeroporto;

            if (ValidaForm())
            {
                novoAeroporto = new Aeroporto
                {
                    ID = GeraID(),
                    AeroportoNome = tbAeroporto.Text,
                    Cidade = tbCidade.Text,
                    País = tbPais.Text,

                };

                aeroportoBindingSource.Add(novoAeroporto);
            }
            tbAeroporto.Clear();
            tbCidade.Clear();
            tbPais.Clear();
        }

        private void PbApagar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridAeroportos.SelectedRows)
            {
                Aeroporto apagar = (Aeroporto)row.DataBoundItem;
                dataGridAeroportos.Rows.RemoveAt(row.Index);
                dataGridAeroportos.Refresh();
            }
        }

        private void AeroportosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GravaAeroportos();

        }


        /// 
        /// Métodos
        /// 

        //grava aeroporto no ficheiro txt
        private void GravaAeroportos()
        {
            StreamWriter sw = File.CreateText(Aeroporto.FicheiroAeroportos); //cria texto no ficheiro

            try
            {
                foreach (DataGridViewRow row in dataGridAeroportos.Rows) //volta a gravar todas as linhas da gridview
                {
                    Aeroporto aeroporto = (Aeroporto)row.DataBoundItem;

                    string linha = $"{aeroporto.ID},{aeroporto.AeroportoNome}," +
                    $"{aeroporto.Cidade},{aeroporto.País}";

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

        private void LerInfoAeroporto(BindingSource aeroportoBindingSource)
        {
            StreamReader sr;

            if (File.Exists(Aeroporto.FicheiroAeroportos)) //verifica se o ficheiro existe
            {
                sr = File.OpenText(Aeroporto.FicheiroAeroportos); //abre o txt

                string linha = string.Empty;
                try
                {
                    while ((linha = sr.ReadLine()) != null) // enquanto as linhas nao tiverem vazias
                    {
                        string[] colunas = linha.ToString().Split(','); //divide em colunas pelas virgulas

                        if (colunas.Length >= 4)
                        {
                            Aeroporto aeroporto = new Aeroporto
                            {
                                ID = colunas[0],
                                AeroportoNome = colunas[1],
                                Cidade = colunas[2],
                                País = colunas[3],
                            };
                            aeroportoBindingSource.Add(aeroporto);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro na gravação do ficheiro");
                }
                finally
                {
                    sr.Close(); //fecha o txt
                }
            }
        }

        //verifica se tbs estão preenchidas, se contêm digitos e se aeroporto já existe
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tbPais.Text) || !Regex.IsMatch(tbPais.Text, @"^[\p{L}]+$") || string.IsNullOrEmpty(tbAeroporto.Text) ||
                string.IsNullOrEmpty(tbCidade.Text) || !Regex.IsMatch(tbAeroporto.Text, @"^[\p{L}]+$")
                || !Regex.IsMatch(tbCidade.Text, @"^[\p{L}]+$"))
            {
                MessageBox.Show("Insira os dados corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }

            foreach (Aeroporto item in aeroportoBindingSource)
            {
                if (item.AeroportoNome == tbAeroporto.Text)
                {
                    MessageBox.Show("Aeroporto já existe", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    output = false;
                }
            }
            return output;
        }

        //gera id alfanumerico random, verifica se já existe
        private string GeraID()
        {
            string id = Path.GetRandomFileName();
            id = id.Replace(".", ""); // tira o ponto

            foreach (Aeroporto item in aeroportoBindingSource) //verifica se id já existe
            {
                if (id.ToString() == aeroporto.ID)
                {
                    id = Path.GetRandomFileName();
                    id = id.Replace(".", "");
                }
            }

            id = id.ToUpper();

            return id.Substring(0, 5);  // Retoma uma string de 5 caracteres 
        }
    }
}
