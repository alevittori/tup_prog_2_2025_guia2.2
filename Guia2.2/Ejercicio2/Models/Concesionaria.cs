using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Concesionaria
    {
        public double PorcentajeDepreciacion { get; }
        public int AñoActual {  get; }
        public double ImporteEnEmbarque { get; }
        public  int CantidadEmbarques { get; private set; }
        public Embarque MayorCantidadMotos { get; }


        Embarque[] embarques;

        public Concesionaria(int añoActual) 
        { 
            AñoActual = añoActual;
            // iniciamos el vector embarque con un numero
            embarques = new Embarque[100];
        }

        public void IngresarEmbarque(Embarque nuevo) {
            embarques[CantidadEmbarques] = nuevo;
            CantidadEmbarques++;
        }
        public Embarque VerEmbarque(int idx) 
        {
            if (idx >= 0 && idx < embarques.Length)
            {
                return embarques[idx];
            }
            return null; 
        
        }
        public Embarque VerEmbarquePorNumero( int numero )
        {
            foreach (Embarque e in embarques)
            {
                if (e.Numero == numero) { return e; }
            }
            return null; 
        }
        public Embarque[] ListaOrdenadaEmbarques()

        {
            //Embarque[] embarqueOrdenado;
            Array.Sort(embarques);
            return embarques; 
        
        }


    }
}
