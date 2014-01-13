using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.ArcMap;

namespace Sigma.Arcgis.Core.Geometria
{
    public class CalculoAzimuteDistancia
    {
        public double CalculaDistanciaEntreDoisPontos(IPoint de, IPoint para)
        {            
            IPointCollection col = new PolylineClass();
            col.AddPoint(de, Type.Missing, Type.Missing);
            col.AddPoint(para, Type.Missing, Type.Missing);
            IPolyline poly = (IPolyline)col;
            
            return poly.Length;
        }

        public double CalculaAzimute(IPoint de, IPoint para)
        {
            IVector3D vector = new Vector3DClass();
            vector.ConstructDifference(para, de);
            return CalculaGraus(vector.Azimuth);
        }

        public double CalculaGraus(double rad)
        {
            return rad * (180 / Math.PI);
        }
    }
}
