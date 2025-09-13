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
    public partial class FIngresoEmbarque : Form
    {
        Embarque nuevo;
       public  Embarque Nuevo {  get { return nuevo; } private set { } }
        public FIngresoEmbarque()
        {
            InitializeComponent();
           
            
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //para que solo entre numero
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tbNEmbarque.Text);

            nuevo = new Embarque(num,);
        }
    }
}
