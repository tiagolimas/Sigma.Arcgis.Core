using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sigma.Arcgis.Core.Geometria;

namespace Sigma.Arcgis.Core.Memorial
{
    public interface IEscritorMemorial
    {
       
        void Escrever(IMemorialDescritivo memorialDescritivo);
               
        //void Escrever(List<IMemorialDescritivo> memorialDescritivo);

        void Escrever(IDictionary<string, IMemorialDescritivo> memoriaisDescritivos);
    }
}
