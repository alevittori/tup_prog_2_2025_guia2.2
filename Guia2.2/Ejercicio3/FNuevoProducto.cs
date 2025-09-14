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
    public partial class FNuevoProducto : Form
    {
        public FNuevoProducto()
        {
            InitializeComponent();
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&(e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter)) 
            {
                e.Handled = true; // evita qe se escriba el caracter
            }
        }
    }
}
