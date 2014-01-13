using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geometry;
using NUnit.Framework;
using Sigma.Arcgis.Core.Geometria;

namespace Sigma.Arcgis.Core.Testes.Geometria
{
    [TestFixture]
    class CalculadoraTeste
    {
        [Test]
        public void TestSoma1()
        {
            var c = new Calculadora();
            int resultado = c.Soma(2, 3);

            Assert.AreEqual(5, resultado);
        }


    }
}
