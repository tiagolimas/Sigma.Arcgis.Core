using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sigma.Arcgis.Core.Geometria;
using System.IO;
using System.Text.RegularExpressions;

namespace Sigma.Arcgis.Core.Memorial
{
    public class EscritorMemorial : IEscritorMemorial
    {
        private IParserAzimuteDistancia _parser;
        private bool _configurado;
        private string _caminho = string.Empty;
        private string _caminhoCompleto;

        //Construtor
        public EscritorMemorial(IParserAzimuteDistancia parser)
        {
            if (parser == null)
                throw new ArgumentNullException("parser");

            _parser = parser;
        }

        //Grava memorial em Disco
        private void EscreverImpl(IMemorialDescritivo memorial)
        {
            if (!_configurado)
            {
                throw new Exception("Escritor não configurado");
            }

            StreamWriter escritor = new StreamWriter(_caminhoCompleto);
            escritor.WriteLine(_parser.Escrever(memorial));
            escritor.Close();
            //_caminho = string.Empty;
        }
        
        public void Escrever(IMemorialDescritivo memorialDescritivo)
        {
            this.EscreverImpl(memorialDescritivo);
        }

        //Recebe um dicionário e envia um memorial para ser gravado
        public void Escrever(IDictionary<string, IMemorialDescritivo> memoriaisDescritivos)
        {
            foreach (KeyValuePair<string, IMemorialDescritivo> kvp in memoriaisDescritivos)
            {
                _caminhoCompleto = string.Format(@"{0}{1}.txt ", _caminho, kvp.Key);
                _configurado = this.Configurar(_caminhoCompleto);
                
                this.EscreverImpl(kvp.Value);   
            }
        }

        //Valida path
        public bool Configurar(string caminho)
        {
            var valido = true;

            if (String.IsNullOrEmpty(caminho))
            {
                valido = false;
            }

            if (Directory.Exists(caminho))
            {
                valido = false;
            }
    
            if (File.Exists(caminho))
            {
                Random random = new Random();
                int numeroRandom = random.Next(0, 1000000);
                _caminhoCompleto = string.Format(@"{0}{1}.txt ", _caminho, numeroRandom);
                return (Configurar(_caminhoCompleto));
            }

            if (Path.HasExtension(caminho))
            {
                valido = true;

                if (Path.GetExtension(caminho).Trim() != ".txt")
                {
                    valido = false;
                }
                if (File.Exists(caminho))
                {
                    valido = false;
                }
            }
            else
            {
                valido = false;
                _caminho = caminho;
            }
            
            if (valido)
            {
                _configurado = true;

                _caminhoCompleto = caminho;
            }

            return valido;
        }
    }
}