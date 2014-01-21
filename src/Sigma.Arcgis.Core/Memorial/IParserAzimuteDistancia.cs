using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sigma.Arcgis.Core.Geometria;

namespace Sigma.Arcgis.Core.Memorial
{
    public interface IParserAzimuteDistancia
    {
        IAzimuteDistancia Ler(string azimute);
        IMemorialDescritivo Ler(StreamReader reader);

        string Escrever(IAzimuteDistancia azimute);
        string Escrever(IMemorialDescritivo memorial);

       // void Escrever(List<IAzimuteDistancia> list);

    }
}
