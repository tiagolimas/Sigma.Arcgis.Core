﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sigma.Arcgis.Core.Geometria;

namespace Sigma.Arcgis.Core.Memorial
{
    public interface IMemorialDescritivo
    {
        List<IAzimuteDistancia> AzimuteDistancias {get;set;}
    }
}
