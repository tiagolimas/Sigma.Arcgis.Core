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
    class CalculoAzimuteDistancia
    {
        [Test]
        public void TesteCalculaAzimute0()
        {
            IPoint de = new PointClass();
            IPoint para = new PointClass();
            de.PutCoords(0, 0);
            para.PutCoords(0, 0);
            Sigma.Arcgis.Core.Geometria.CalculoAzimuteDistancia c = new Sigma.Arcgis.Core.Geometria.CalculoAzimuteDistancia();
            double resultado = c.CalculaAzimute(de, para);

            Assert.AreEqual(0, resultado);
        }

        [Test]
        public void TesteCalculaAzimute90()
        {
            IPoint de = new PointClass();
            IPoint para = new PointClass();
            de.PutCoords(0, 1);
            para.PutCoords(1, 1);
            Sigma.Arcgis.Core.Geometria.CalculoAzimuteDistancia c = new Sigma.Arcgis.Core.Geometria.CalculoAzimuteDistancia();
            double resultado = c.CalculaAzimute(de, para);
            Console.WriteLine("Azimute para 90 graus: " + resultado);
            Assert.AreEqual(90, resultado);
        }

        [Test]
        public void TesteCalculaAzimute180()
        {
            IPoint de = new PointClass();
            IPoint para = new PointClass();
            de.PutCoords(0, 1);
            para.PutCoords(0, -1);
            Sigma.Arcgis.Core.Geometria.CalculoAzimuteDistancia c = new Sigma.Arcgis.Core.Geometria.CalculoAzimuteDistancia();
            double resultado = c.CalculaAzimute(de, para);
            Console.WriteLine("Azimute para 180 graus: " + resultado);
            Assert.AreEqual(180, resultado);
        }


        [Test]
        public void TesteCalculaAzimute270()
        {
            IPoint de = new PointClass();
            IPoint para = new PointClass();
            de.PutCoords(0, 0);
            para.PutCoords(-1, 0);
            Sigma.Arcgis.Core.Geometria.CalculoAzimuteDistancia c = new Sigma.Arcgis.Core.Geometria.CalculoAzimuteDistancia();
            double resultado = c.CalculaAzimute(de, para);
            Console.WriteLine("Azimute para 270 graus: " + resultado);
            Assert.AreEqual(270, resultado);
        }

        [Test]
        public void TesteCalculaDistancia()
        {
            IPoint de = new PointClass();
            IPoint para = new PointClass();
            de.PutCoords(0, 0);
            para.PutCoords(1, 1);
            Sigma.Arcgis.Core.Geometria.CalculoAzimuteDistancia c = new Sigma.Arcgis.Core.Geometria.CalculoAzimuteDistancia();
            double resultado = c.CalculaDistanciaEntreDoisPontos(de, para);
            Console.WriteLine(resultado);
            Assert.AreEqual(Math.Sqrt(2), resultado);
        }
    }
}
