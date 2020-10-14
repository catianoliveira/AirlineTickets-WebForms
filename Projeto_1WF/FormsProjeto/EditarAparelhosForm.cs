using Biblioteca;
using System;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class EditarAparelhosForm : Form
    {
        Aparelho aparelho;
        AparelhosForm form;

        public EditarAparelhosForm(AparelhosForm form, Aparelho aparelho)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.aparelho = aparelho;
            this.form = form;
            DadosAparelho();
        }
       
        private void PbSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O aparelho não será editado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }

        //passa novos dados para o form principal
        private void PbOK_Click(object sender, EventArgs e)
        {
            if (ValidaForm()) 
            {
                aparelho.LugaresEconomicos = Convert.ToInt32(tbLugaresEconomicos.Text);
                aparelho.LugaresExecutivos = Convert.ToInt32(tbLugaresExecutivos.Text);
                aparelho.Quantidade = Convert.ToInt32(tbQuantidade.Text);
                form.InitLista();
                this.Close();
            }
        }

        ///
        /// Métodos
        /// 

        //mostra labels com dados do aparelho selecionado
        private void DadosAparelho()
        {
            tbLugaresEconomicos.Text = aparelho.LugaresEconomicos.ToString();
            tbLugaresExecutivos.Text = aparelho.LugaresExecutivos.ToString();
            tbModelo.Text = aparelho.Modelo.ToString();
            tbQuantidade.Text = aparelho.Quantidade.ToString();
        }

        //verifica se os campos estão todos preenchidos e se os lugares e quantidade são inteiros
        private bool ValidaForm()
        {
            bool output = true;
            int numeros;

            if (string.IsNullOrEmpty(tbLugaresEconomicos.Text) || !int.TryParse(tbLugaresEconomicos.Text, out numeros) 
                || string.IsNullOrEmpty(tbLugaresExecutivos.Text) || !int.TryParse(tbLugaresExecutivos.Text, out numeros)
                || !int.TryParse(tbQuantidade.Text, out numeros) || string.IsNullOrEmpty(tbQuantidade.Text))
            {
                MessageBox.Show("Insira os dados corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }
    }
}
