using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geometry;
using NUnit.Framework;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.ArcMap;
using ESRI.ArcGIS.Geodatabase;
using Sigma.Arcgis.Core.Geometria;

namespace Sigma.Arcgis.Core.Testes.Geometria
{
    [TestFixture]
    class GeradorMemorialDescritivo
    {
        [Test]
        public void TesteGeraMemorialFeature()
        {
            Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo ger = new Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo();
            IFeature feature = new FeatureMock();
            var listaResultado = new List<IMemorialDescritivo>();
            IMemorialDescritivo memorial = new MemorialDescritivo();

            memorial =  ger.GerarMemorial(feature);

            Assert.AreEqual(4 , memorial.AzimuteDistancias.Count);
        }

        [Test]
        public void TesteGeraMemorialFeatureAzimute360()
        {
            Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo ger = new Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo();
            IFeature feature = new FeatureMock();
            var listaResultado = new List<IMemorialDescritivo>();
            IMemorialDescritivo memorial = new MemorialDescritivo();

            memorial = ger.GerarMemorial(feature);

            Console.WriteLine("Azimute: " + memorial.AzimuteDistancias[0].Azimute);
            Assert.AreEqual(360, memorial.AzimuteDistancias[0].Azimute);
        }

        [Test]
        public void TesteGeraMemorialFeatureAzimute90()
        {
            Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo ger = new Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo();
            IFeature feature = new FeatureMock();
            var listaResultado = new List<IMemorialDescritivo>();
            IMemorialDescritivo memorial = new MemorialDescritivo();

            memorial = ger.GerarMemorial(feature);

            Console.WriteLine("Azimute: " + memorial.AzimuteDistancias[1].Azimute);
            Assert.AreEqual(90, memorial.AzimuteDistancias[1].Azimute);
        }

        [Test]
        public void TesteGeraMemorialFeatureAzimute180()
        {
            Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo ger = new Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo();
            IFeature feature = new FeatureMock();
            var listaResultado = new List<IMemorialDescritivo>();
            IMemorialDescritivo memorial = new MemorialDescritivo();

            memorial = ger.GerarMemorial(feature);

            Console.WriteLine("Azimute: " + memorial.AzimuteDistancias[2].Azimute);
            Assert.AreEqual(180, memorial.AzimuteDistancias[2].Azimute);
        }

        [Test]
        public void TesteGeraMemorialFeatureAzimute270()
        {
            Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo ger = new Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo();
            IFeature feature = new FeatureMock();
            var listaResultado = new List<IMemorialDescritivo>();
            IMemorialDescritivo memorial = new MemorialDescritivo();

            memorial = ger.GerarMemorial(feature);

            Console.WriteLine("Azimute: " + memorial.AzimuteDistancias[3].Azimute);
            Assert.AreEqual(270, memorial.AzimuteDistancias[3].Azimute);
        }

        [Test]
        public void TesteGeraMemorialFeatureDistancia360()
        {
            Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo ger = new Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo();
            IFeature feature = new FeatureMock();
            var listaResultado = new List<IMemorialDescritivo>();
            IMemorialDescritivo memorial = new MemorialDescritivo();

            memorial = ger.GerarMemorial(feature);

            Console.WriteLine("Distancia: " + memorial.AzimuteDistancias[0].Distancia);
            Assert.AreEqual(1, memorial.AzimuteDistancias[0].Distancia);
        }

        [Test]
        public void TesteGeraMemorialFeatureDistancia90()
        {
            Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo ger = new Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo();
            IFeature feature = new FeatureMock();
            var listaResultado = new List<IMemorialDescritivo>();
            IMemorialDescritivo memorial = new MemorialDescritivo();

            memorial = ger.GerarMemorial(feature);

            Console.WriteLine("Distancia: " + memorial.AzimuteDistancias[1].Distancia);
            Assert.AreEqual(1, memorial.AzimuteDistancias[1].Distancia);
        }

        [Test]
        public void TesteGerarMemoriaisFeatureClass()
        {
            //Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo ger = new Sigma.Arcgis.Core.Geometria.GeradorMemorialDescritivo();
            //IFeatureClass featureClass = new FeatureClassMock();

            //IDictionary<string, IMemorialDescritivo> memoriaisDescritivos;
            //memoriaisDescritivos = ger.GerarMemoriais(featureClass);

            //Core.Memorial.EscritorMemorial escritor = new Core.Memorial.EscritorMemorial();
            //escritor.Equals(memoriaisDescritivos);

            //Console.WriteLine("Dictionary: " + memoriaisDescritivos.Values.ToString());
            //Assert.AreEqual(2, memoriaisDescritivos.Count);
        }
    }
}


