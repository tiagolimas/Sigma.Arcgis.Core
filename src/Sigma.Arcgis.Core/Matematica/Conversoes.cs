using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sigma.Arcgis.Core.Matematica
{
    public class Conversoes
    {

        public static double CalculaGraus(double rad)
        {
            return rad * (180 / Math.PI);
        }

        public static double CalculaRadianos(double grau)
        {
            return grau * (Math.PI / 180);
        }
    }
}
