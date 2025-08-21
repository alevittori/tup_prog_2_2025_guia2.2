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

            if (VRegistrar.ShowDialog() == DialogResult.OK)
            {
                if(VRegistrar.cbBicicleta.Checked) {unaEncuesta.UsaBicicleta = true;}
                if(VRegistrar.cbAuto.Checked) {  unaEncuesta.UsaAuto = true;}
                if(VRegistrar.cbTp.Checked) { unaEncuesta.UsaTransportePublico = true;}


                // hace un control para que no entren cualquier cosa en la casilla de km
                unaEncuesta.DistanciaASuDestino = double.Parse(VRegistrar.tbKm.Text); 

                if (VRegistrar.cbContactable.Checked) { unaEncuesta.Email = VRegistrar.tbEmail.Text;}

                encuestador.RegistrarEncuesta(unaEncuesta, VRegistrar.cbContactable.Checked);

               VRegistrar.Dispose();
            }



            
        }

        private void bntListarContactables_Click(object sender, EventArgs e)
        {
            //3- Listar aquellos contactos disponibles ordenados por las distancia del recorrido declarada por el encuestado.
            FInforme VInforme = new FInforme();
            VInforme.lboxInforme.Items.Clear();


            encuestador.OrdenarContactablesPorDistancia(); //ordenamos 
            for (int i = 0; i < encuestador.CantContactables; i++)
            {
                VInforme.lboxInforme.Items.Add(encuestador.VerContactable(i).VerEncuesta()); // se va a llenar de objetos el list box, faltaria un ver detalles por encuesta
            }

            VInforme.ShowDialog();

            VInforme.Dispose();  
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            FInforme VResumen = new FInforme();

            VResumen.lboxInforme.Items.Clear ();
            VResumen.lboxInforme.Items.Add("Resumen de las Encuestas");
            VResumen.lboxInforme.Items.Add("------------------------");
            VResumen.lboxInforme.Items.Add($"Uso Bicicleta : {encuestador.PorcBicicleta}%");
            VResumen.lboxInforme.Items.Add($"Uso Automovil : {encuestador.PorcAuto}%");
            VResumen.lboxInforme.Items.Add($"Uso Transporte Publico : {encuestador.PorcTrasporteP}%");
            VResumen.lboxInforme.Items.Add("------------------------");

            VResumen.ShowDialog();
        }
    }
}
