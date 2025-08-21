using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Embarque
    {
        double porcDepreciacionUsado;
        int añoEvaluacion;

        public int Numero { get; } //readonly
        public int CantidadMotos { get; }
        public int MontoTotal { get; }
        public double PromedioCosto { get; }
        public double AntiguedadPromedio {  get; }

        public Embarque(int numero, double porcDepreciacion, int añoEvaluacion) { }

        public double RegistrarMoto(int añosFabricacion, double montoFabricacion) {  return 0; }

    }
}
