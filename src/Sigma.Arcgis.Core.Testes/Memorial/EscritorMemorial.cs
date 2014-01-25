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
            Core.Memorial.GeradorMemorialDescritivo ger = new Core.Memorial.GeradorMemorialDescritivo();

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
            IFeature feature = new FeatureMock();
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
            var memorial = parser.Ler(new StreamReader(@"c:\4230.txt"));
            var memorialString = parser.Escrever(memorial);
            Assert.IsNotNullOrEmpty(memorialString);
        }

        [Test]
        public void TesteLeituraException()
        {
            IFeature feature = new FeatureMock();
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
            var memorial = parser.Ler(new StreamReader(@"c:\7963.txt"));
            var memorialString = parser.Escrever(memorial);
            Assert.IsNullOrEmpty(memorialString);
        }

        [Test]
        public void TesteCaminho()
        {
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
            Core.Memorial.IEscritorMemorial escritor = new Core.Memorial.EscritorMemorial(parser);
            
            Assert.IsTrue(escritor.Configurar(@"C:\teste45.txt"));
        }

        [Test]
        public void TesteCaminhoInvalidoExtensao()
        {
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
            Core.Memorial.IEscritorMemorial escritor = new Core.Memorial.EscritorMemorial(parser);

            Assert.IsFalse(escritor.Configurar(@"C:\teste45.tx"));
        }

        [Test]
        public void TesteCaminhoInvalidoSemExtensao()
        {
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
            Core.Memorial.IEscritorMemorial escritor = new Core.Memorial.EscritorMemorial(parser);

            Assert.IsFalse(escritor.Configurar(@"C:\xxx"));
        }

        [Test]
        public void TesteCaminhoInvalidoSemRoot()
        {
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
            Core.Memorial.IEscritorMemorial escritor = new Core.Memorial.EscritorMemorial(parser);

            Assert.IsFalse(escritor.Configurar(@"xxx"));
        }

        [Test]
        public void TesteCaminhoInvalidoArquivoExistente()
        {
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
            Core.Memorial.IEscritorMemorial escritor = new Core.Memorial.EscritorMemorial(parser);

            Assert.IsFalse(escritor.Configurar(@"C:\2568.txt"));
        }

        [Test]
        public void TesteComparacao()
        {
            Core.Memorial.GeradorMemorialDescritivo ger = new Core.Memorial.GeradorMemorialDescritivo();
            IFeature featureGrav = new FeatureMock();
            IMemorialDescritivo memorialGrav = new MemorialDescritivo();
            memorialGrav = ger.GerarMemorial(featureGrav);
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
            var lerMemorial = parser.Ler(new StreamReader(@"c:\2568.txt"));

            var stringMemorialGrav = parser.Escrever(memorialGrav);
            var stringLerMemorial = parser.Escrever(lerMemorial);
            
            bool comp = false;
            if (string.Compare(stringMemorialGrav, stringLerMemorial) == 0)
            {
                comp = true;
            }

            Console.Write("Resultado da comparação: " + string.Compare(stringMemorialGrav, stringLerMemorial));
            Assert.IsTrue(comp);
        }

        [Test]
        public void TesteComparacaoInvalido()
        {
            Core.Memorial.GeradorMemorialDescritivo ger = new Core.Memorial.GeradorMemorialDescritivo();
            IFeature featureGrav = new FeatureMock();
            IMemorialDescritivo memorialGrav = new MemorialDescritivo();
            memorialGrav = ger.GerarMemorial(featureGrav);
            IParserAzimuteDistancia parser = new ParserAzimuteDsitancia();
            var lerMemorial = parser.Ler(new StreamReader(@"c:\4230.txt"));

            var stringMemorialGrav = parser.Escrever(memorialGrav);
            var stringLerMemorial = parser.Escrever(lerMemorial);

            Console.Write("Resultado da comparação: " + string.Compare(stringMemorialGrav, stringLerMemorial));
            Assert.AreNotEqual(stringMemorialGrav, stringLerMemorial);
        }
    }
}
