using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal class Producto
    {
        private static  int GenNum = 0;
        public int Codigo { get; private set; }
        public int Cantidad { get; private set; }
        public string Nombre { get; private set; }


        public Producto ( string nombre, int cantidad)
        {
            GenNum++;
            Nombre = nombre;
            Cantidad = cantidad;
            Codigo = GenNum;
        }

        public int AgregarCantidad(int reposicion)
        {
            Cantidad += reposicion;
            return Cantidad;
        }
        public int ExtraerCantidad(int extraccion)
        {
            if (extraccion < Cantidad) { return Cantidad - extraccion; }
            return -1;
        }

    }
}
