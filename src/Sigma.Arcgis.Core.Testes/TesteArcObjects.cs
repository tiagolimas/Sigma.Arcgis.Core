using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS;

namespace Sigma.Arcgis.Core.Testes
{
    [TestFixture]
    public class TesteArcObjects
    {
        [Test]
        public void TesteInicialGarantiaDeFuncionamentoArcObjects()
        {
            IPoint ponto = new PointClass();
            ponto.PutCoords(0,0);
            Assert.AreEqual(0, ponto.X);
            Assert.AreEqual(0, ponto.Y);
        }


    }
}
