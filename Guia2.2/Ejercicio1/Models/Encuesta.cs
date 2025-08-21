using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Encuesta
    {
        public bool UsaBicicleta { get; set; }
        public bool UsaAuto {  get; set; }
        public bool UsaTransportePublico { get; set; }
        public string Email { get; set; }
        public double DistanciaASuDestino { get; set; }

        public bool EsContactable { get; set; }

        public string VerEncuesta()
        {
            return $"Email: {Email} - Distancia Recorrida: {DistanciaASuDestino}";
        }

    }
}
