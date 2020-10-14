using Biblioteca;
using System;
using System.IO;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class ListaBilhetesForm : Form
    {
        public ListaBilhetesForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            LerLista();
        }

        private void PbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        /// 
        /// Métodos
        /// 

        //exporta lista para excel
        private void ExportarExcel()
        {
            //seleciona toda a gridview e copia-a
            dataGridBilhetes.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridBilhetes.MultiSelect = true;
            dataGridBilhetes.SelectAll();
            DataObject dataObj = dataGridBilhetes.GetClipboardContent(); 
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

            //abre o excel e cola a lista
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            xlexcel.Columns.AutoFit();
            xlexcel.Rows.AutoFit();
            xlexcel.Visible = true;
        }

        //lê lista de bilhetes
        private void LerLista()
        {
            StreamReader sr;

            if (File.Exists(Bilhete.FicheiroBilhetes))
            {
                sr = File.OpenText(Bilhete.FicheiroBilhetes);

                string linha = string.Empty;
                try
                {
                    while ((linha = sr.ReadLine()) != null) // enquanto as linhas nao tiverem vazias
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
                            bilheteBindingSource.Add(bilhete);
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
    }
}
