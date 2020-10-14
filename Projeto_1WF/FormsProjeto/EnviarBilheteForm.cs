using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class EnviarBilheteForm : Form
    {
        ComprarBilheteForm comprar;

        public EnviarBilheteForm(ComprarBilheteForm comprar)
        {
            this.comprar = comprar;
            InitializeComponent();
            this.CenterToScreen();
            InicializaLbls();
        }
        private void PbEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilhete enviado por e-mail com sucesso!", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //faz um print do form, cola-o num pdf, guarda o pdf e o print na pasta debug
        private void PbImprimir_Click(object sender, EventArgs e)
        {
            //escondo os botões para não aparecerem no print
            pbImprimir.Visible = false;
            pbEnviar.Visible = false;
            pbSair.Visible = false;

            Graphics g = this.CreateGraphics();
            Bitmap bmp = new Bitmap(this.Size.Width, this.Size.Height + 10, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X + 20, this.Location.Y + 25, 40, 47, this.Size);
            bmp.Save("Screenshot.png", ImageFormat.Png); //guarda o screenshot

            Document document = new Document();
            document.SetMargins(1, 1, 1, 1);

            //cria um pdf 
            using (var stream = new FileStream($"{lblVoo.Text}{lblDocumento.Text}{lblClasse.Text}{lblLugar.Text}.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                using (var imageStream = new FileStream("Screenshot.png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var image = iTextSharp.text.Image.GetInstance(imageStream);
                    float maxWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                    float maxHeight = document.PageSize.Height - document.TopMargin - document.BottomMargin;
                    if (image.Height > maxHeight || image.Width > maxWidth)
                        image.ScaleToFit(maxWidth, maxHeight);
                    document.Add(image);
                }
                document.Close();
            }

            pbImprimir.Visible = true;
            pbEnviar.Visible = true;
            pbSair.Visible = true;
        }

        ///
        ///Método
        ///

        //mostra dados do bilhete
        private void InicializaLbls()
        {
            lblVoo.Text = comprar.tbidvoo.Text; 
            lblIdBilhete.Text = comprar.tbidBilhete.Text;
            lblClasse.Text = comprar.cbClasse.Text;
            lblData.Text = comprar.cbData.Text;
            lblDestino.Text = comprar.cbDestino.Text;
            lblOrigem.Text = comprar.cbOrigem.Text;
            lblDocumento.Text = comprar.tbID.Text;
            lblNome.Text = comprar.labelid.Text;
            lblHora.Text = comprar.cbHora.Text;
            lblLugar.Text = comprar.cbLugar.Text;
        }
    }
}
