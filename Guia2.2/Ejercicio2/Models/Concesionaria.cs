using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Concesionaria
    {
        public double PorcentajeDepreciacion { get; }
        public int AñoActual {  get; }
        public double ImporteEnEmbarque { get; }
        public  double CantidadEmbarques { get; }
        public Embarque MayorCantidadMotos { get; }


        Embarque[] embarques;

        public Concesionaria(int añoActual) { }

        public void IngresarEmbarque(Embarque nuevo) { }
        public Embarque VerEmbarque(int idx) {  return null; }
        public Embarque VerEmbarquePorNumero( int numero ) { return null; }
        public Embarque[] ListaOrdenadaEmbarques() { return null; }


    }
}
