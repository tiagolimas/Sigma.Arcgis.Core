using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Editor;
using ESRI.ArcGIS.Controls;
using System.Windows.Forms;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.ArcMap;
using ESRI.ArcGIS.Geodatabase;
using Sigma.Arcgis.Core.Geometria;
using Sigma.Arcgis.Core.Memorial;
using System.IO;
using Sigma.Arcgis.Core.UI.Dialog;

namespace Sigma.Arcgis.Core.UI.Command.Meta
{

    public class OpenMemorialDescritivo : BaseCommand
    {
        private IHookHelper m_hookHelper = null;
        private IApplication m_application;

        public OpenMemorialDescritivo()
        {
                base.m_category = "Memorial Descritivo"; //localizable text
                base.m_caption = "Abrir Memorial Descritivo";  //localizable text 
                base.m_message = "Permite ao usuário obter informações sobre o Memrial Descritivo";
                base.m_toolTip = "Permite ao usuário obter informações sobre o Memrial Descritivo";
                base.m_name = "Meta_OpenMemorialDescritivo";   //unique id, non-localizable (e.g. "MyCategory_MyCommand")

                try
                {
                    string bitmapResourceName = GetType().Name + ".bmp";
                    base.m_bitmap = new Bitmap(GetType(), bitmapResourceName);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap");
                }
        }

            /// <summary>
            /// Occurs when this command is created
            /// </summary>
            /// <param name="hook">Instance of the application</param>
            public override void OnCreate(object hook)
            {
                if (hook == null)
                    return;

                try
                {
                    m_application = hook as IApplication;

                    m_hookHelper = new HookHelperClass();
                    m_hookHelper.Hook = hook;
                    if (m_hookHelper.ActiveView == null)
                        m_hookHelper = null;
                }
                catch
                {
                    m_hookHelper = null;
                }

                if (m_hookHelper == null)
                    base.m_enabled = false;
                else
                    base.m_enabled = true;
            }

            public override void OnClick()
            {
                Dialog.Dialog _dialog = new Dialog.Dialog();
                string resultado = string.Empty;
                IFeatureClass klass = Dialog.Dialog.AbrirObjetos(0);

                Core.Memorial.GeradorMemorialDescritivo ger = new Core.Memorial.GeradorMemorialDescritivo();
                IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
                IDictionary<string, IMemorialDescritivo> memoriaisDescritivos;
                memoriaisDescritivos = ger.GerarMemoriais(klass);

                Core.Memorial.EscritorMemorial escritor = new Core.Memorial.EscritorMemorial(parser);
                escritor.Escrever(memoriaisDescritivos);
            }
    }
}
