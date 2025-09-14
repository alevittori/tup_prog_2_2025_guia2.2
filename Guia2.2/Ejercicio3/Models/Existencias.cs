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
            Producto aBuscar = productos.Find(p=>p.Codigo == codigo); // Find solo es para List<T>
            return aBuscar;

            /* Sino se peude usar FirstOrDefault
             * que esta disponible para cualquier que tenga IEnumerable<T>
             * Retorna lo mismo que Find, el elemento o null
             * Es un poco mas lento pero mas versatil
             * sintaxis 
             * productos.FirstOrDefault(p => p.Codigo == codigo);
             * */

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
                if(p.Nombre.ToUpper() == nombre.ToUpper())
                {
                    p.AgregarCantidad( cantidad);
                    return null;
                }
                    
                
                
            }

            //si no existe
            Producto nuevo = new Producto(nombre, cantidad);
            productos.Add(nuevo);
            return nuevo;

        }

        public Producto QuitarProductoPorIndice(int idx, out bool exito)
        {
            Producto aEliminar = BuscarPorIndice(idx);
            if (aEliminar != null) { productos.Remove(aEliminar); exito = true; return aEliminar; }
            exito = false;
            return null;
        }

        public bool EliminarProducto(Producto p)
        {
            if (p != null)
            {
                productos.Remove(p);
                return true;
            }
            return false;
        }
    }
}
