using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geometry;

namespace Sigma.Arcgis.Core.Geometria
{
    public class AzimuteDistancia : IAzimuteDistancia
    {
        public IPoint DoPonto { get; set; }
        public IPoint AoPonto { get; set; }
        public double Azimute { get; set; }
        public double Distancia { get; set; }

        public AzimuteDistancia()
        {

        }

        public AzimuteDistancia(double Az, double Dist, IPoint Do, IPoint Ao)
        {
            Azimute = Az;
            Distancia = Dist;
            DoPonto = Do;
            AoPonto = Ao;
        }  
    }
}
