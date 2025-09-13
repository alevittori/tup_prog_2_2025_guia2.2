using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Moto
    {
        public int Modelo { get; set; }
        public double ValorDeFabrica {  get; set; }

        public int Antiguedad { get; private set; }

        public Moto(int añoFabricacion, double valorDeFabricacion)
        {
            Modelo = añoFabricacion;
            ValorDeFabrica = valorDeFabricacion;
        }

        public int CalculaAntiguedad(int añoActual)
        {
            Antiguedad= añoActual - Modelo;
            return Antiguedad;
        }
        public double CalcularValorActual(int añoActual)
        {
            int potencia = añoActual - Modelo;
            double valor = ValorDeFabrica * (Math.Pow((1 - 0.10), potencia));
            
            return valor;
        }
    }
}
