using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void PbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //valida palavra-passe
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (tbPW.Text == "123")
            {
                Capa capa = new Capa(this);
                capa.Show();
            }

            else
            {
                lblErro.Text = "Palavra-passe incorreta";
            }
        }

    }
}
