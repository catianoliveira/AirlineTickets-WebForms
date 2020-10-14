using Biblioteca;
using System;
using System.IO;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class AparelhosForm : Form
    {
        Aparelho aparelho = new Aparelho();

        public AparelhosForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            LerInfoAparelhos(aparelhoBindingSource);
        }

        private void PbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbAdd_Click(object sender, EventArgs e)
        {
            Aparelho novoAparelho;

            if (ValidaForm())
            {
                novoAparelho = new Aparelho
                {
                    Id = GeraID(),
                    Modelo = tbModelo.Text,
                    Quantidade = Convert.ToInt32(tbQuantidade.Text),
                    LugaresEconomicos = Convert.ToInt32(tbLugaresEconomicos.Text),
                    LugaresExecutivos = Convert.ToInt32(tbLugaresExecutivos.Text),
                };

                this.aparelhoBindingSource.Add(novoAparelho);

                tbModelo.Clear();
                tbLugaresExecutivos.Clear();
                tbLugaresEconomicos.Clear();
                tbQuantidade.Clear();
            }
        }
        private void PbEditar_Click(object sender, EventArgs e)
        {
            Aparelho mostrar = (Aparelho)dataGridAparelhos.CurrentRow.DataBoundItem;
            EditarAparelhosForm editarAparelhosForms = new EditarAparelhosForm(this, mostrar);
            editarAparelhosForms.ShowDialog();
        }

        //grava aparelhos no txt quando o form é fechado
        private void AparelhosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GravaAparelhos();
        }

        private void PbApagar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridAparelhos.SelectedRows)
            {
                Aparelho apagar = (Aparelho)row.DataBoundItem;
                dataGridAparelhos.Rows.RemoveAt(row.Index);
                dataGridAparelhos.Refresh();
            }
        }

        /// 
        /// Métodos
        /// 
        private void LerInfoAparelhos(BindingSource aparelhoBindingSource)
        {
            StreamReader sr;

            if (File.Exists(Aparelho.FicheiroAparelhos)) //verifica se ficheiro existe
            {
                sr = File.OpenText(Aparelho.FicheiroAparelhos);

                string linha = string.Empty;
                try
                {
                    while ((linha = sr.ReadLine()) != null) // enquanto as linhas nao tiverem vazias
                    {
                        string[] colunas = linha.ToString().Split(',');

                        if (colunas.Length >= 5)
                        {
                            Aparelho aparelho = new Aparelho
                            {
                                Id = colunas[0],
                                Modelo = colunas[1],
                                LugaresEconomicos = Convert.ToInt32(colunas[2]),
                                LugaresExecutivos = Convert.ToInt32(colunas[3]),
                                Quantidade = Convert.ToInt32(colunas[4]),
                            };

                            aparelhoBindingSource.Add(aparelho);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro na gravação do ficheiro");
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        //grava aparelhos no txt
        private void GravaAparelhos()
        {
            StreamWriter sw = File.CreateText(Aparelho.FicheiroAparelhos); //cria um novo txt

            try
            {
                foreach (DataGridViewRow row in dataGridAparelhos.Rows)
                {
                    Aparelho aparelho = (Aparelho)row.DataBoundItem;

                    string linha = $"{aparelho.Id},{aparelho.Modelo},{aparelho.LugaresEconomicos}," +
                        $"{aparelho.LugaresExecutivos},{aparelho.Quantidade}";

                    //escreve linha no ficheiro.
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

        public void InitLista()
        {
            dataGridAparelhos.DataSource = null;
            dataGridAparelhos.DataSource = aparelhoBindingSource;
        }

        //verifica se campos estão preenchidos e se os lugares e quantidade são digitos antes de gravar
        private bool ValidaForm()
        {
            bool output = true;
            int numeros;

            if (string.IsNullOrEmpty(tbLugaresEconomicos.Text) || !int.TryParse(tbLugaresEconomicos.Text, out numeros) || !int.TryParse(tbLugaresExecutivos.Text, out numeros) || 
                !int.TryParse(tbQuantidade.Text, out numeros) || string.IsNullOrEmpty(tbModelo.Text) || 
                string.IsNullOrEmpty(tbLugaresExecutivos.Text) || string.IsNullOrEmpty(tbQuantidade.Text))
            {
                MessageBox.Show("Insira os dados", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }

        //Gera ID random
        private string GeraID()
        {
            string id = Path.GetRandomFileName();
            id = id.Replace(".", "");

            foreach (Aparelho item in aparelhoBindingSource)
            {
                if (id.ToString() == aparelho.Id) //verifica se id já existe
                {
                    id = Path.GetRandomFileName();
                    id = id.Replace(".", "");
                }
            }
            id = id.ToUpper();
            return id.Substring(0, 5);  // Retoma string de 5 caracteres
        }
    }
}
