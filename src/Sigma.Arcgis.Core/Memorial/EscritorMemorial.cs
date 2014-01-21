﻿using System;
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
        private string _caminho;

        //Construtor
        public EscritorMemorial(IParserAzimuteDistancia parser)
        {
            if (parser == null)
                throw new ArgumentNullException("parser");

            _parser = parser;
        }

        private void EscreverImpl(IMemorialDescritivo memorial)
        {
            if (!_configurado)
            {
                throw new Exception("Escritor não configurado");
            }
            
            StreamWriter escritor = new StreamWriter(_caminho);
            escritor.WriteLine(_parser.Escrever(memorial));
            escritor.Close();
        }
        
        public void Escrever(IMemorialDescritivo memorialDescritivo)
        {
            this.EscreverImpl(memorialDescritivo);
        }

        public void Escrever(IDictionary<string, IMemorialDescritivo> memoriaisDescritivos)
        {
            foreach (KeyValuePair<string, IMemorialDescritivo> kvp in memoriaisDescritivos)
            {
                _caminho = string.Format(@"c:\{0}.txt ", kvp.Key);
                _configurado = this.Configurar(_caminho);
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

            Regex r = new Regex(@"^(?:[\w]\:|\\)(\\[a-z_\-\s0-9\.]+)+\.(txt|xls)$");
            if (r.IsMatch(caminho))
            {
                valido = true;
            }
    
            if (File.Exists(caminho))
            {
                valido = false;
            }
            
            if (valido)
            {
                _configurado = true;
                _caminho = caminho;
            }

            return valido;
        }
    }
}