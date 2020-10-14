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
    public partial class CreditoForm : Form
    {
        public CreditoForm()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void PbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
