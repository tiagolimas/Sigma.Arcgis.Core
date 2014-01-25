using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sigma.Arcgis.Core.Memorial;
using Sigma.Arcgis.Core.UI.Dialogs;
using ESRI.ArcGIS.Geodatabase;


namespace Sigma.Arcgis.Core.UI.Forms.Memorial
{
    public partial class frmMemorial : Form
    {
        private IFeatureClass FClasse;

        public frmMemorial()
        {
            InitializeComponent();
        }

        private void btnAbrirFeature_Click(object sender, EventArgs e)
        {
            try
            {

                Dialog _dialog = new Dialog();
                string resultado = string.Empty;
                IFeatureClass klass = Dialog.AbrirObjetos(0);
                if (klass != null)
                {
                    textEntrada.Text = klass.FeatureDataset.Workspace.PathName;
                    lblFeature.Text = klass.AliasName;
                    FClasse = klass;
                }

            }catch(Exception ex)
            {
                var erro = string.Format("Não foi possível carregar o arquivo: {0} \r\n", ex);
                MessageBox.Show(erro);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirPasta_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            textDestino.Text = folderDialog.SelectedPath.ToString().Trim();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textEntrada.Text) && !string.IsNullOrEmpty(textDestino.Text))
                {
                    Sigma.Arcgis.Core.Memorial.GeradorMemorialDescritivo ger = new Core.Memorial.GeradorMemorialDescritivo();
                    IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();

                    IDictionary<string, IMemorialDescritivo> memoriaisDescritivos;
                    memoriaisDescritivos = ger.GerarMemoriais(FClasse);
                    Core.Memorial.EscritorMemorial escritor = new Core.Memorial.EscritorMemorial(parser);
                    escritor.Configurar(textDestino.Text.Trim());
                    escritor.Escrever(memoriaisDescritivos);
                    MessageBox.Show("Memorial Descritivo gerado com sucesso!");
                    
                }
            }
            catch(Exception ex)
            {
                var erro = string.Format("Não foi possível gerar o memorial: {0}", ex);
                MessageBox.Show(erro);
            }

        }
    }
}
