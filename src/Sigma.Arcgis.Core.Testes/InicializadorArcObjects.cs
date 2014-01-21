using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ESRI.ArcGIS;
using ESRI.ArcGIS.esriSystem;

namespace Sigma.Arcgis.Core.Testes
{
    [SetUpFixture]
    public class InicializadorArcObjects
    {
        [SetUp]
        public void InicializarArcObjects()
        {
            RuntimeManager.BindLicense(ProductCode.EngineOrDesktop);
            IAoInitialize init = new AoInitializeClass();
            init.Initialize(esriLicenseProductCode.esriLicenseProductCodeAdvanced);
        }

        [TearDown]
        public void TearDown()
        { 
            
        }
    }
}
