using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        //declaramos una consesionaria para ser accedida por el sistema
       static  Concesionaria laConsesioanria;
       
        

        public Form1()
        {
            InitializeComponent();
        }

        private void tbAnioActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            //para que solo entre numero
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAnioActual.Text)) { MessageBox.Show("Ingre el año para iniciar", "Antencion"); return; }
            int a = Convert.ToInt32(tbAnioActual.Text);
            laConsesioanria = new Concesionaria(a); // instancio la concesionaria con el año de inico

            //ahora declaro, instancio y muestro la ventana de manejo

            FConsesionaria VManejo = new FConsesionaria();
            // la muestro

            // como modal para que siga hasta que cierre la carga
            VManejo.ShowDialog();
        }
    }
}
