using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sigma.Arcgis.Core.Geometria;
using ESRI.ArcGIS.Geometry;
using System.Windows.Forms;

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
                    
                    if(memorialSeparado.Count() != 6)
                    {
                        throw new InvalidDataException("O memorial não está no formato correto \r\n");
                        
                    }

                    IPoint Do = new Point();
                    IPoint Ao = new Point();
                    double x=0, y=0, az=0, dist=0;
                    
                    if (!Double.TryParse(memorialSeparado[0], out x) && Double.TryParse(memorialSeparado[1], out y))
                    {
                        throw new InvalidCastException("Não foi possível converter as coordenadas do memorial \n");
                    }

                    Do.PutCoords(x, y);
                    azimutes.DoPonto = Do;

                    if (!Double.TryParse(memorialSeparado[2], out x) && Double.TryParse(memorialSeparado[3], out y))
                    {
                        throw new InvalidCastException("Não foi possível converter as coordenadas do memorial \n");
                    }

                    Ao.PutCoords(x, y);
                    azimutes.AoPonto = Ao;

                    if (!Double.TryParse(memorialSeparado[4], out az))
                    {
                        throw new InvalidCastException("Não foi possível converter o azimute do memorial \n");
                    }

                    azimutes.Azimute = az;

                    if (!Double.TryParse(memorialSeparado[5], out dist))
                    {
                        throw new InvalidCastException("Não foi possível converter a distância do memorial\n");
                    }

                    azimutes.Distancia = dist;

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
