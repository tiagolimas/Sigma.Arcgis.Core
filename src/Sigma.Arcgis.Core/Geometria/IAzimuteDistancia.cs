using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.Geometry;

namespace Sigma.Arcgis.Core.Geometria
{
    public interface IAzimuteDistancia
    {
        IPoint DoPonto {get; set;}
        IPoint AoPonto { get; set; }
        double Azimute { get; set; }
        double Distancia { get; set; }
    }
}
