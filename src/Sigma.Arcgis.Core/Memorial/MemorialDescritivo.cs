using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sigma.Arcgis.Core.Geometria;

namespace Sigma.Arcgis.Core.Memorial
{
    public class MemorialDescritivo : IMemorialDescritivo
    {
        public List<IAzimuteDistancia> AzimuteDistancias { get; set; }

        public MemorialDescritivo()
        {

        }

        public MemorialDescritivo(List<IAzimuteDistancia> _azimuteDistancias)
        {
            this.AzimuteDistancias = _azimuteDistancias;
        }
    }
}
