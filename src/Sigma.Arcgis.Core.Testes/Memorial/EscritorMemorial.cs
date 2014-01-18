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
            parser.Escrever(memorial);

            IFeatureClass featureClass = new FeatureClassMock();
            IDictionary<string, IMemorialDescritivo> memoriaisDescritivos;
            memoriaisDescritivos = ger.GerarMemoriais(featureClass);

            Core.Memorial.EscritorMemorial escritor = new Core.Memorial.EscritorMemorial(parser);
            escritor.Escrever(memoriaisDescritivos);



            //escritor = new Core.Memorial.EscritorMemorial(memorial, @"c:\memorial.txt");
            //Assert.IsNotNull(escritor);
        }

    }
}
