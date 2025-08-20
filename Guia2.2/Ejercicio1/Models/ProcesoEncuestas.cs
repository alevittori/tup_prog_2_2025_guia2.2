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
        public double PorcBicicleta { 
            
            get
            { 
                if(contactables.Count > 0)
                {
                    return PorcBicicleta / contactables.Count; 

                }
                return 0;

            } 
            private set { } }
        public double PorcAuto { get { if (contactables.Count > 0) { return PorcAuto / contactables.Count; } return 0;  } private set { } }
        public double PorcTrasporteP { get { if (contactables.Count > 0) { return PorcTrasporteP / contactables.Count; } return  0; } private set { }}

        List<Encuesta> contactables = new List<Encuesta>();



        public void RegistrarEcuentas( Encuesta unaEncuesta , bool puedeSerContactado) {




            if (unaEncuesta.UsaBicicleta) PorcBicicleta++;
            if (unaEncuesta.UsaAuto) PorcAuto++;
            if (unaEncuesta.UsaTransportePublico) PorcTrasporteP++;


            if (puedeSerContactado) // segun entiendo, solo agregamos a la lista lo que son contactables
            {

                CantContactables++;
                contactables.Add(unaEncuesta);
            }


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
