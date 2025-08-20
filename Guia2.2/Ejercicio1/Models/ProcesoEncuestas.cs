using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class ProcesoEncuestas
    {
        public int CantContactables { get; private set; }
        public double PorcBicicleta { get { return PorcBicicleta / contactables.Count; } private set { } }
        public double PorcAuto { get { return PorcAuto / contactables.Count; } private set { } }
        public double PorcTrasporteP { get { return PorcTrasporteP / contactables.Count; } private set { }}

        List<Encuesta> contactables = new List<Encuesta>();



        public void RegistrarEcuentas( Encuesta unaEncuesta , bool puedeSerContactado) {


            if (puedeSerContactado)
            {
                CantContactables++;
                
            }


            if (unaEncuesta.UsaBicicleta) PorcBicicleta++;
            if (unaEncuesta.UsaAuto) PorcAuto++;
            if (unaEncuesta.UsaTransportePublico) PorcTrasporteP++;



            contactables.Add(unaEncuesta );

        }

        public Encuesta VerContactable ( int index) { 
            
            if((index >= 0) && (index < contactables.Count))
            {
                
                return contactables[index];
            }

            return null; }
        
        public void OrdenarEncuestables () {
            //aca hay que ordenar segun los km registrados

            contactables.Sort();
        
        }



    }
}
