using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.ArcMap;
using ESRI.ArcGIS.Geodatabase;

namespace Sigma.Arcgis.Core.Geometria
{
    public class GeradorMemorialDescritivo
    {
        public GeradorMemorialDescritivo()
        {

        }

        public IMemorialDescritivo GerarMemorial(IFeature feature)
        {
            var geometria = feature.ShapeCopy as IPointCollection;
            var lista = new List<IAzimuteDistancia>();

            CalculoAzimuteDistancia azimuteDistancia = new CalculoAzimuteDistancia();

            if (geometria.get_Point(geometria.PointCount - 1).X == geometria.get_Point(0).X &&
                geometria.get_Point(geometria.PointCount - 1).Y == geometria.get_Point(0).Y)
            {
                for (int i = 0; i < geometria.PointCount - 1; i++)
                {
                    var doPonto = geometria.get_Point(i);
                    var aoPonto = geometria.get_Point(i + 1);
                    var _az = azimuteDistancia.CalculaAzimute(doPonto, aoPonto);
                    var d = azimuteDistancia.CalculaDistanciaEntreDoisPontos(doPonto, aoPonto);
                    var ListaAzimuteDistancia = new AzimuteDistancia(_az, d, doPonto, aoPonto);
                    lista.Add(ListaAzimuteDistancia);
                }
            }
            return new MemorialDescritivo(lista);
        }

        public Dictionary<string, IMemorialDescritivo> GerarMemoriais(IFeatureCursor cursor)
        {
            var feature = cursor.NextFeature();
            var dictMemoriais = new Dictionary<string, IMemorialDescritivo>();

            while (feature != null)
            {
                var id = feature.OID.ToString();
                var memorial = this.GerarMemorial(feature);
                dictMemoriais.Add(id, memorial);
                
                feature = cursor.NextFeature();
            }
            
            return dictMemoriais;
        }

        public Dictionary<string, IMemorialDescritivo> GerarMemoriais(IFeatureClass klass)
        {
            var cursor = klass.Search(null, false);
            
            return this.GerarMemoriais(cursor);
        }
    }
}
