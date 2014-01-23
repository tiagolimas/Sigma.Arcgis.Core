using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sigma.Arcgis.Core.Geometria;
using ESRI.ArcGIS.Geometry;

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
                                 azimuteDistancia.Distancia).Trim();
        }

        public string Escrever(IMemorialDescritivo memorial)
        {
            StringBuilder builder = new StringBuilder();
            foreach (IAzimuteDistancia azDistancia in memorial.AzimuteDistancias)
            {
                builder.AppendLine(this.Escrever(azDistancia));
            }

            return builder.ToString().Trim();
        }

        //Recebe uma string de AzimuteDistancia e retorna Objeto AzimuteDistancia
        public IAzimuteDistancia Ler(string azimuteDistancia)
        {
            if (!string.IsNullOrEmpty(azimuteDistancia))
            {
                IAzimuteDistancia azimutes = new AzimuteDistancia();
                string[] memorialSeparado = azimuteDistancia.Split(';');
                IPoint Do = new Point();
                IPoint Ao = new Point();
                Do.PutCoords(Convert.ToDouble(memorialSeparado[0]), Convert.ToDouble(memorialSeparado[1]));
                Ao.PutCoords(Convert.ToDouble(memorialSeparado[2]), Convert.ToDouble(memorialSeparado[3]));
                azimutes.DoPonto = Do;
                azimutes.AoPonto = Ao;
                azimutes.Azimute = Convert.ToDouble(memorialSeparado[4]);
                azimutes.Distancia = Convert.ToDouble(memorialSeparado[5]);

                return azimutes;
            }

            return new AzimuteDistancia();
        }

        //Recebe um reader e retorna um MemorialDescritivo
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
