using Biblioteca;
using System;
using System.IO;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class ComprarBilheteForm : Form
    {
        Bilhete bilhete = new Bilhete();

        public ComprarBilheteForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            LerBilhetes();
            InicLabels();
            LerInfoVoos();
            LerInfoData();
            GeraID(bilhete);
        }

        private void PbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbConfirmar_Click(object sender, EventArgs e)
        {
            Bilhete novoBilhete;

            if (ValidaForm())
            {
                novoBilhete = new Bilhete
                {
                    Id = new Voo(tbidvoo.Text),
                    IdBilhete = tbidBilhete.Text,
                    Nome = labelid.Text,
                    Documento = tbID.Text,
                    Classe = cbClasse.SelectedItem.ToString(),
                    Lugar = cbLugar.SelectedItem.ToString(),
                };

                bilhetesBindingSource.Add(novoBilhete); //guarda bilhete e abre outro form
                GravarInfoBilhetes();
                EnviarBilheteForm enviar = new EnviarBilheteForm(this); 
                enviar.ShowDialog();
                Limpa();
            }
            tbidBilhete.Text = GeraID(bilhete);
        }

        private void PbConfirmaID_Click(object sender, EventArgs e)
        {
            LerInfoCliente();
        }

        private void CbOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            LerDestinos();
            AtualizaHora();
            LerInfoData();
        }

        private void CbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LerLugares();
            VerificaIDVoo();
        }

        private void CbClasse_DisplayMemberChanged(object sender, EventArgs e)
        {
            LerLugares();
            VerificaIDVoo();
        }

        private void CbClasse_TextUpdate(object sender, EventArgs e)
        {
            LerLugares();
            VerificaIDVoo();
        }


        private void CbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            LerInfoData();
            AtualizaHora();
        }

        private void CbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaHora();
        }

        //caso a hora selecionada mude, relê aparelho
        private void CbHora_SelectedIndexChanged(object sender, EventArgs e) 
        {
            cbClasse.Enabled = true;

            string[] lineOfContents = File.ReadAllLines(Voo.FicheiroVoos);
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');

                if (tokens[1] == cbOrigem.Text && tokens[2] == cbDestino.Text && tokens[3] == cbData.Text && tokens[4] == cbHora.Text)
                {
                    tbAparelho.Text = tokens[5];
                }
            }
        }

        //verifica se o lugar está disponivel
        private void CbLugar_SelectedIndexChanged(object sender, EventArgs e) 
        {
            foreach (Bilhete item in bilhetesBindingSource)
            {
                if (item.Classe == cbClasse.Text && item.Lugar == cbLugar.Text && item.Id.Id == tbidvoo.Text)
                {
                    MessageBox.Show("Lugar indisponivel", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            AtualizaOrigem();
        }
        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            AtualizaOrigem();
        }

        private void PbLimpar_Click(object sender, EventArgs e)
        {
            Limpa();
            LerInfoVoos();
        }

        /// 
        /// Métodos
        /// 

        public void LerBilhetes() 
        {
            StreamReader sr;

            if (File.Exists(Bilhete.FicheiroBilhetes))
            {
                sr = File.OpenText(Bilhete.FicheiroBilhetes);

                string linha = string.Empty;
                try
                {
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] colunas = linha.ToString().Split(',');

                        if (colunas.Length >= 6)
                        {
                            Bilhete bilhete = new Bilhete
                            {
                                Id = new Voo(colunas[0]),
                                IdBilhete = colunas[1],
                                Nome = colunas[2],
                                Documento = colunas[3],
                                Classe = colunas[4],
                                Lugar = colunas[5],
                            };

                            this.bilhetesBindingSource.Add(bilhete);
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

        //gera id random
        private string GeraID(Bilhete bilhete) 
        {
            string id = Path.GetRandomFileName();
            id = id.Replace(".", ""); 

            if (id.ToString() == bilhete.IdBilhete) //verifica se id já existe
            {
                id = Path.GetRandomFileName();
                id = id.Replace(".", "");
            }

            id = id.ToUpper();

            tbidBilhete.Text = id.Substring(0, 5);  //retoma uma string de 5 caracteres

            return tbidBilhete.Text;
        }

        //verifica horas disponiveis para o voo selecionado (origem, destino e data)
        private void AtualizaHora()
        {
            if (cbDestino.Text != null && cbData.Text != null && cbOrigem.Text != null)
            {
                cbHora.Items.Clear();
                cbHora.Enabled = true;

                string[] lineOfContents = File.ReadAllLines(Voo.FicheiroVoos);
                foreach (var line in lineOfContents)
                {
                    string[] tokens = line.Split(',');

                    if (tokens[1] == cbOrigem.Text && tokens[2] == cbDestino.Text && tokens[3] == cbData.Text)
                    {
                        if (cbHora.Items.ToString() != tokens[3])
                        {
                            cbHora.Items.Add(tokens[4]);
                        }
                    }
                }
            }
        }

        //verifica datas disponiveis para o voo selecionado (origem e destino)
        private void LerInfoData()
        {
            cbData.Items.Clear();

            string[] lineOfContents = File.ReadAllLines(Voo.FicheiroVoos);
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');

                if (tokens[1] == cbOrigem.Text && tokens[2] == cbDestino.Text)
                {
                    if (!cbData.Items.Contains(tokens[3]))
                    {
                        cbData.Items.Add(tokens[3]);
                    }
                }
            }
            AtualizaHora();
        }

        //passa todos os aeroportos para combobox
        private void LerInfoVoos()
        {
            //foreach (Voo item in vooBindingSource)
            //{
            //    cbOrigem.Items.Add(item.AeroportoOrigem);
            //}

            string[] lineOfContents = File.ReadAllLines(Aeroporto.FicheiroAeroportos);
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');

                cbOrigem.Items.Add($"{tokens[1]} {tokens[2]} {tokens[3]}");
            }

            AtualizaHora();
        }

        //inicializa monthCalendar
        private void InicLabels()
        {
            monthCalendar.MaxDate = DateTime.Now.AddMonths(6);
            monthCalendar.MinDate = DateTime.Today;
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.FirstDayOfWeek = Day.Monday;
            monthCalendar.ShowToday = false;
            monthCalendar.ShowTodayCircle = false;
        }

        private void GravarInfoBilhetes()
        {
            StreamWriter sw = File.CreateText(Bilhete.FicheiroBilhetes);

            try
            {
                foreach (DataGridViewRow row in dataGridViewBilhetes.Rows)
                {
                    Bilhete bilhete = (Bilhete)row.DataBoundItem;

                    string linha = $"{bilhete.Id},{bilhete.IdBilhete},{bilhete.Nome},{bilhete.Documento}," +
                            $"{bilhete.Classe},{bilhete.Lugar}";

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

        //verifica se os campos estão todos preenchidos e se o lugar está disponivel
        private bool ValidaForm()
        {
            bool output = true;

            if (cbOrigem.Text == "")
            {
                MessageBox.Show("Selecione uma origem", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }

            else if (cbDestino.Text == "")
            {
                MessageBox.Show("Selecione um destino", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }

            else if (tbID.Text == "")
            {
                MessageBox.Show("Indique o número do documento de identificação do cliente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }

            foreach (Bilhete item in bilhetesBindingSource)
            {
                if (item.Classe == cbClasse.Text && item.Lugar == cbLugar.Text && item.Id.Id == tbidvoo.Text)
                {
                    MessageBox.Show("Lugar indisponivel", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                    output = false;
                }
            }

            return output;
        }

        //verifica se o id colocado na tb é valido e preenche a label com o nome do cliente
        private void LerInfoCliente()
        {
            string[] lineOfContents = File.ReadAllLines(Cliente.FicheiroClientes);
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');

                if (tokens[3] == tbID.Text)
                {
                    labelid.Text = tokens[1];
                }
            }

            if (labelid.Text == "")
            {
                MessageBox.Show("Nº de identificação inválido", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //lê os destinos a partir de Voo.FicheiroVoos, verifica se a data do voo é >= ao dia de hoje 
        private void LerDestinos()
        {
            cbDestino.SelectedItem = null;
            cbDestino.Enabled = true;
            cbDestino.Items.Clear();
            cbHora.Items.Clear();
            cbHora.SelectedItem = null;
            cbData.Items.Clear();
            cbData.SelectedItem = null;


            string[] lineOfContents = File.ReadAllLines(Voo.FicheiroVoos);
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');

                if (Convert.ToDateTime(tokens[3]) >= DateTime.Today)
                {
                    if (cbData.Text == "")
                    {
                        if (tokens[1] == cbOrigem.Text)
                        {
                            if (!cbDestino.Items.Contains(tokens[2]))
                            {
                                cbDestino.Items.Add(tokens[2]);
                            }
                        }
                    }

                    else
                    {
                        if (tokens[1] == cbOrigem.Text && tokens[3] == cbData.Text)
                        {
                            cbDestino.Items.Add(tokens[2]);
                        }
                    }
                }
            }
        }

        //lê as classes, os lugares e se os mesmos estão disponiveis
        private void LerLugares()
        {
            cbLugar.Items.Clear();
            cbLugar.Enabled = true;

            if (cbClasse.SelectedItem.ToString() == "Económico")
            {
                cbLugar.Enabled = true;

                string[] lineOfContents = File.ReadAllLines(Aparelho.FicheiroAparelhos);
                foreach (var lines in lineOfContents)
                {
                    string[] tokens = lines.Split(',');

                    if (tokens[1] == tbAparelho.Text)
                    {
                        int lugares = Convert.ToInt32(tokens[2]);

                        for (int i = 1; i <= lugares; i++)
                        {
                            cbLugar.Items.Add(i);
                        }
                    }
                }

                foreach (Bilhete item in bilhetesBindingSource)
                {
                    if (item.Classe == cbClasse.Text && item.Lugar == cbLugar.Text && item.Id.Id == tbidvoo.Text)
                    {
                        MessageBox.Show("Lugar indisponivel", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if (cbClasse.SelectedItem.ToString() == "Executivo")
            {
                cbLugar.Enabled = true;

                string[] lineOfContents = File.ReadAllLines(Aparelho.FicheiroAparelhos);
                foreach (var lines in lineOfContents)
                {
                    string[] tokens = lines.Split(',');

                    if (tokens[1] == tbAparelho.Text)
                    {
                        int lugares = Convert.ToInt32(tokens[3]);

                        for (int i = 1; i <= lugares; i++)
                        {
                            cbLugar.Items.Add(i);
                        }
                    }
                }
                foreach (Bilhete item in bilhetesBindingSource)
                {
                    if (item.Classe == cbClasse.Text && item.Lugar == cbLugar.Text && item.Id.Id == tbidvoo.Text)
                    {
                        MessageBox.Show("Lugar indisponivel", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {

            }
        }

        //atualiza origem caso alguma data do monthcalendar seja selecionada
        private void AtualizaOrigem()
        {
            cbData.Enabled = false;
            cbData.Text = null;
            cbOrigem.SelectedItem = null;
            cbDestino.SelectedItem = null;
            cbHora.Text = null;
            cbClasse.SelectedItem = null;
            cbLugar.SelectedItem = null;
            tbAparelho.Text = null;

            cbOrigem.Items.Clear();
            string data = monthCalendar.SelectionRange.Start.ToShortDateString();
            cbData.Text = data;

            string[] lineOfContents = File.ReadAllLines(Voo.FicheiroVoos);
            foreach (var lines in lineOfContents)
            {
                string[] tokens = lines.Split(',');

                if (data == tokens[3])
                {
                    if (!cbOrigem.Items.Contains(tokens[1]))
                    {
                        cbOrigem.Items.Add(tokens[1]);
                    }
                }
            }

            AtualizaHora();
        }

        //limpa campos
        private void Limpa()
        {
            cbOrigem.Items.Clear();
            cbData.Enabled = true;
            cbData.Text = string.Empty;
            cbOrigem.SelectedText = string.Empty;
            cbDestino.SelectedText = string.Empty;
            cbHora.Text = string.Empty;
            cbClasse.SelectedItem = string.Empty;
            cbLugar.SelectedItem = string.Empty;
            tbAparelho.Text = string.Empty;
            labelid.Text = string.Empty;
            tbID.Text = string.Empty;
            tbidvoo.Text = string.Empty;
        }

        //verifica id do voo lendo todos os outros campos já escolhidos - origem, destino, data, hora
        private void VerificaIDVoo()
        {
            string[] lineOfContents = File.ReadAllLines(Voo.FicheiroVoos);
            foreach (var lines in lineOfContents)
            {
                string[] tokens = lines.Split(',');

                if (tokens[1] == cbOrigem.Text && tokens[2] == cbDestino.Text && tokens[3] == cbData.Text && tokens[4] == cbHora.Text)
                {
                    tbidvoo.Text = tokens[0];
                }
            }
        }
    }
}

