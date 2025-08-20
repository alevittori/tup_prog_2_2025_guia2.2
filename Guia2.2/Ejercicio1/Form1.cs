using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        ProcesoEncuestas encuestador;
        public Form1()
        {
            InitializeComponent();
            encuestador = new ProcesoEncuestas();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FRegistroEncuesta VRegistrar = new FRegistroEncuesta();

            Encuesta unaEncuesta = new Encuesta();

        }
    }
}
