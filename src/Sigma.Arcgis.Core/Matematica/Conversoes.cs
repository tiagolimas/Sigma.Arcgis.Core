using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sigma.Arcgis.Core.Matematica
{
    public static class Conversoes
    {

        public static double CalculaGraus(this double rad)
        {
            return rad * (180 / Math.PI);
        }

        public static double CalculaRadianos(this double grau)
        {
            return grau * (Math.PI / 180);
        }
    }
}
