using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sigma.Arcgis.Core.Geometria;

namespace Sigma.Arcgis.Core.Memorial
{
    public class ParserAzimuteDsitancia : IParserAzimuteDistancia
    {
        /// <summary>
        /// Escreve conteúdo em string
        /// </summary>
        /// <param name="memorial"></param>
        /// <returns></returns>
        public string Escrever(IAzimuteDistancia azimuteDistancia)
        {
            return String.Format("{0};{1};{2};{3};{4};{5}",
                                 azimuteDistancia.DoPonto.X,
                                 azimuteDistancia.DoPonto.Y,
                                 azimuteDistancia.AoPonto.X,
                                 azimuteDistancia.DoPonto.Y,
                                 azimuteDistancia.Azimute,
                                 azimuteDistancia.Distancia);
        }

        public string Escrever(IMemorialDescritivo memorial)
        {
            StringBuilder builder = new StringBuilder();
            foreach (IAzimuteDistancia azDistancia in memorial.AzimuteDistancias)
            {
                builder.AppendLine(this.Escrever(azDistancia));
            }

            return builder.ToString();
        }

        public IAzimuteDistancia Ler(string azimuteDistancia)
        {
            return new AzimuteDistancia();
        }

        public IMemorialDescritivo Ler(StreamReader reader)
        {
            List<IAzimuteDistancia> azimutes = new List<IAzimuteDistancia>();
            while (!(reader.EndOfStream))
            {
                azimutes.Add(this.Ler(reader.ReadLine()));
            }

            return new MemorialDescritivo(azimutes);
        }
    }      
}
