using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geometry;

namespace Sigma.Arcgis.Core.Geometria
{
    public class AzimuteDistancia : IAzimuteDistancia
    {
        IPoint DoPonto; 
        IPoint AoPonto; 
        double Azimute;
        double Distancia;

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
