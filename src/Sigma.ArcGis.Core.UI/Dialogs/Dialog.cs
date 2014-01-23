using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Catalog;
using ESRI.ArcGIS.CatalogUI;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;


namespace Sigma.Arcgis.Core.UI.Dialogs
{
    public class Dialog
    {

        public static IFeatureClass AbrirObjetos(int n)
        {
            IGxDialog gx = new GxDialogClass();
            gx.ObjectFilter = new GxFilterFeatureClassesClass();
            gx.AllowMultiSelect = false;
            IEnumGxObject featureClasses;
            IFeatureClass klass = null;

            if (gx.DoModalOpen(n, out featureClasses) && featureClasses != null)
            {
                IGxObject gxObj = featureClasses.Next();
                
                if (gxObj is IGxDataset)
                {
                    var gxDataset = (IGxDataset)gxObj;
                    IDataset ds = gxDataset.Dataset;
                    klass = (IFeatureClass)ds;
                }

                Marshal.FinalReleaseComObject(featureClasses);
            }

            gx.InternalCatalog.Close();
            Marshal.FinalReleaseComObject(gx);
            return klass;
        }
    }
}



