using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal class Existencias
    {
        List<Producto> productos = new List<Producto>();

        public int CantidadDeProductos { get { return productos.Count; } private set { } }

        public Producto BuscarPorCodigo(int codigo)
        {
            Producto aBuscar = productos.Find(p=>p.Codigo == codigo);
            return aBuscar;
        }

        public Producto BuscarPorIndice(int idx)
        {
            if (idx <= 0 && idx < productos.Count)
            {
                return productos[idx];
                //return productos.ElementAt(idx)
            }
            return null;
        }

        public Producto AgregarProducto(string nombre , int cantidad )
        {
            /* agregar la existencia de un producto (cantidad ) , 
             * si no existe crearlo primero y luego de agregar ese se lo inicia con el valor de la cantidad ingresada
             */

            //primero controlar que no exista
            foreach (Producto p in productos)
            {
                if(p.Nombre == nombre)
                {
                    p.AgregarCantidad( cantidad);
                    return p;
                }
                
                
            }

            //si no existe
            Producto nuevo = new Producto(nombre, cantidad);
            productos.Add(nuevo);
            return nuevo;

        }

        public bool QuitarProducto(int idx)
        {
            Producto aEliminar = BuscarPorIndice(idx);
            if (aEliminar != null) { productos.Remove(aEliminar); return true; }
            return false;
        }
    }
}
