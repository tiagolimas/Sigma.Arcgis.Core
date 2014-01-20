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
using Sigma.Arcgis.Core.Testes.Geometria;
using Sigma.Arcgis.Core.Memorial;
using System.IO;

namespace Sigma.Arcgis.Core.Testes.Memorial
{
    [TestFixture]
    class EscritorMemorial
    {
        [Test]
        public void TesteGravacao()
        {
            Core.Geometria.GeradorMemorialDescritivo ger = new Core.Geometria.GeradorMemorialDescritivo();

            IFeature feature = new FeatureMock();
            IMemorialDescritivo memorial = new MemorialDescritivo();
            memorial = ger.GerarMemorial(feature);
            
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
          
            IFeatureClass featureClass = new FeatureClassMock();
            IDictionary<string, IMemorialDescritivo> memoriaisDescritivos;
            memoriaisDescritivos = ger.GerarMemoriais(featureClass);

            Core.Memorial.EscritorMemorial escritor = new Core.Memorial.EscritorMemorial(parser);
            escritor.Escrever(memoriaisDescritivos);
            //Assert.IsNotNull(escritor);
        }

        [Test]
        public void TesteLeitura()
        {
            Core.Geometria.GeradorMemorialDescritivo ger = new Core.Geometria.GeradorMemorialDescritivo();
            IFeature feature = new FeatureMock();
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
            var memorial = parser.Ler(new StreamReader(@"c:\2568.txt"));
            var memorialString = parser.Escrever(memorial);
            Assert.IsNotNullOrEmpty(memorialString);
        }

        [Test]
        public void TesteCaminho()
        {
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
            Core.Memorial.IEscritorMemorial escritor = new Core.Memorial.EscritorMemorial(parser);
            
            Assert.IsTrue(escritor.Configurar(@"C:\x.txt"));
        }
    }
}
