using Ejercicio3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        List<Producto> eliminados = new List<Producto>();
        List<Producto> enExistencia = new List<Producto>();
        Existencias kiosco;
        public Form1()
        {
            InitializeComponent();
            kiosco = new Existencias();
           // cbProductos.DisplayMember = "Codigo";

        }

        private void btnReponer_Click(object sender, EventArgs e)
        {
            FNuevoProducto VReponer = new FNuevoProducto();
            


            if(VReponer.ShowDialog() == DialogResult.OK)
            {

                string n = VReponer.tbNombre.Text;
                int cant = Convert.ToInt32(VReponer.tbCantidad.Text);
                Producto p = kiosco.AgregarProducto(n, cant);
                if(p != null)
                {
                    cbProductos.Items.Add(p);

                }
                
            }

           





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbExistencia.Items.Clear();
            Producto p = (Producto)cbProductos.SelectedItem;
            if(p != null) {lbExistencia.Items.Add($"{p} - Cantidad: {p.Cantidad}");}
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            Producto p = cbProductos.SelectedItem as Producto;

            if(p != null)
            {
                FNuevoProducto VExtraer = new FNuevoProducto();
                VExtraer.tbNombre.Text = p.Nombre;
                VExtraer.tbCantidad.Focus();
                
                if(VExtraer.ShowDialog() == DialogResult.OK)
                {
                    int cantExtraer = Convert.ToInt32(VExtraer.tbCantidad.Text); // hay que validar que no ponga otra cosa que no sea numero
                    int verificacion = p.ExtraerCantidad(cantExtraer); // aca lo ideal seria que agreguemos un metodo en la clase Existencias, que sea para descontar cantidad
                    if ( verificacion == -1 ) { MessageBox.Show($"No se puede Extraer una cantidad mayor a {p.Cantidad}"); }
                    //cbProductos.Items.Remove(p);
                    //cbProductos.Items.Add(p);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto", "Atencion");
            }
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Controla que solo ingrese numeros en el text box
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true; // evita qe se escriba el caracter
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool exito = false;
            Producto aBorrar = cbProductos.SelectedItem as Producto;

            if (aBorrar != null) 
            { 
                 exito = kiosco.EliminarProducto(aBorrar);
            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto", "Atencion");
            }

            if (exito) { cbProductos.Items.Remove(aBorrar); }
        }
    }
}
