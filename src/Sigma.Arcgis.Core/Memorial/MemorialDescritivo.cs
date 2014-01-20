using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sigma.Arcgis.Core.Geometria
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
