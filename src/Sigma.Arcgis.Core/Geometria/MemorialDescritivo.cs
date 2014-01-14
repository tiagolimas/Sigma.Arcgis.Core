﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sigma.Arcgis.Core.Geometria
{
    public class MemorialDescritivo : IMemorialDescritivo
    {
        public List<IAzimuteDistancia> AzimuteDistancias;

        public MemorialDescritivo(List<IAzimuteDistancia> _azimuteDistancias)
        {
            this.AzimuteDistancias = _azimuteDistancias;
        }
    }
}