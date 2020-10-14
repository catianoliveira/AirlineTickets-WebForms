using Biblioteca;
using System;
using System.IO;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class VoosForm : Form
    {
        Voo voo;
        BindingSource aparelhoBindingSource;

        public VoosForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            LerInfoVoos(vooBindingSource);
            InicializaCalendario();
            LerInfoAparelhos(aparelhoBindingSource);
            LerInfoAeroportos();
        }
        private void PbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbApagar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridVoos.SelectedRows)
            {
                Voo apagar = (Voo)row.DataBoundItem;
                dataGridVoos.Rows.RemoveAt(row.Index);
                dataGridVoos.Refresh();
            }
        }

        //quando a origem muda, a lista dos destinos é atualizada
        private void CbOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDestino.Items.Clear();
            cbDestino.Enabled = true;

            string[] lineOfContents = File.ReadAllLines(Aeroporto.FicheiroAeroportos);
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');

                cbDestino.Items.Add($"{tokens[1]} {tokens[2]} {tokens[3]}");
            }
        }

        //verifica se a origem e o destino são os mesmos quando o destino é escolhido
        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDestino.Text == cbOrigem.Text)
            {
                MessageBox.Show("A origem e o destino não podem ser iguais", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //adiciona novo voo
        private void PbAdd_Click(object sender, EventArgs e) 
        {
            Voo novoVoo;

            if (ValidaForms())
            {
                novoVoo = new Voo
                {
                    Id = GeraID(voo),
                    AeroportoOrigem = new Aeroporto(cbOrigem.SelectedItem.ToString()),
                    AeroportoDestino = new Aeroporto(cbDestino.SelectedItem.ToString()),
                    Dia = monthCalendar1.SelectionRange.Start.ToShortDateString(),
                    Hora = dTPHora.Text,
                    Aparelho = new Aparelho(cbAparelho.SelectedItem.ToString()),
                };

                this.vooBindingSource.Add(novoVoo);
                GravarInfoVoos();
            }

            Limpar();
        }

        /// 
        /// Métodos
        /// 

        private void Limpar()
        {
            tbID.Clear();
            tbID.Text = GeraID(voo);
            cbOrigem.Text = "";
            cbDestino.Text = "";
            cbAparelho.Text = "";
        }

        //verifica se campos estão preenchidos e se a origem e o destino são iguais
        private bool ValidaForms()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tbID.Text) || cbDestino.Text == "" || cbOrigem.Text == ""
                || dTPHora.Text == null || cbAparelho.Text == "")
            {
                MessageBox.Show("Insira os dados", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }

            if (cbDestino.Text == cbOrigem.Text)
            {
                MessageBox.Show("A origem e o destino não podem ser iguais", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return output;
        }

        private void InicializaCalendario()
        {
            monthCalendar1.FirstDayOfWeek = Day.Monday;
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = DateTime.Today;
            dTPHora.Format = DateTimePickerFormat.Custom;
            dTPHora.CustomFormat = "HH:mm";
            tbID.Text = GeraID(voo);
        }

        private void LerInfoAeroportos()
        {
            cbOrigem.Items.Clear();
            cbOrigem.Enabled = true;

            string[] lineOfContents = File.ReadAllLines(Aeroporto.FicheiroAeroportos);
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                cbOrigem.Items.Add($"{tokens[1]} {tokens[2]} {tokens[3]}");
            }
        }

        private void LerInfoAparelhos(BindingSource aparelhoBindingSource)
        {
            string[] lineOfContents = File.ReadAllLines(Aparelho.FicheiroAparelhos);

            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                cbAparelho.Items.Add(tokens[1]);
            }
        }

        public void LerInfoVoos(BindingSource vooBindingSource)
        {
            StreamReader sr;

            if (File.Exists(Voo.FicheiroVoos))
            {
                sr = File.OpenText(Voo.FicheiroVoos);

                string linha = string.Empty;
                try
                {
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] colunas = linha.ToString().Split(',');

                        if (colunas.Length >= 6)
                        {
                            Voo voo = new Voo
                            {
                                Id = colunas[0],
                                AeroportoOrigem = new Aeroporto(colunas[1]),
                                AeroportoDestino = new Aeroporto(colunas[2]),
                                Dia = colunas[3],
                                Hora = colunas[4],
                                Aparelho = new Aparelho(colunas[5]),
                            };

                            this.vooBindingSource.Add(voo);
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

        //grava linhas da gridview no txt
        private void GravarInfoVoos()
        {
            StreamWriter sw = File.CreateText(Voo.FicheiroVoos);

            try
            {
                foreach (DataGridViewRow row in dataGridVoos.Rows)
                {
                    Voo voo = (Voo)row.DataBoundItem;

                    string linha = $"{voo.Id},{voo.AeroportoOrigem},{voo.AeroportoDestino},{voo.Dia},{voo.Hora},{voo.Aparelho}";

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

        //gera id random
        private string GeraID(Voo voo)
        {
            BindingSource _vooBindingSource;
            _vooBindingSource = vooBindingSource;
            this.voo = voo;

            string id = Path.GetRandomFileName();
            id = id.Replace(".", "");

            id = id.ToUpper();

            return id.Substring(0, 5);
        }
    }
}