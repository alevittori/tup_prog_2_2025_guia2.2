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
    public partial class FConsesionaria : Form
    {
        public FConsesionaria()
        {
            InitializeComponent();
        }

        private void tbNumEmbarque_KeyPress(object sender, KeyPressEventArgs e)
        {
            //para que solo entre numero
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void btnAltaEmbarque_Click(object sender, EventArgs e)
        {

            //declarar e instancia la ventana manejadora del ingreso de embarques
            //deberia pasarle todo lo que necesita 
            Embarque nuevoEmbarque;
            FIngresoEmbarque VManejadorEmbaruqes = new FIngresoEmbarque();

        
            
            

        }
    }
}
