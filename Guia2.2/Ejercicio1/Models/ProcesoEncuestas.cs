using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class ProcesoEncuestas
    {
        int _cantBici = 0, _cantAuto = 0, _cantTp = 0;
       // int _cantContactables = 0;
        public int CantContactables => contactables.Count; // Si bien get { return contactables.Count; } es totalmente válido, la sintaxis de expresión de cuerpo (=>) es la convención moderna de C# para propiedades de una sola línea, lo que hace el código más conciso.
        public double PorcBicicleta => contactables.Count > 0 ? ((double)_cantBici / contactables.Count) * 100 : 0; 
        public double PorcAuto { get { if (contactables.Count > 0) { return ((double)_cantAuto / contactables.Count) * 100; } return 0; } }
        public double PorcTrasporteP { get { if (contactables.Count > 0) { return ((double)_cantTp / contactables.Count) * 100; } return 0; }  } 

        List<Encuesta> contactables = new List<Encuesta>();



        public void RegistrarEncuesta( Encuesta unaEncuesta , bool puedeSerContactado) {

            if (unaEncuesta.UsaBicicleta) _cantBici++;
            if (unaEncuesta.UsaAuto) _cantAuto++;
            if (unaEncuesta.UsaTransportePublico) _cantTp++;


            if (puedeSerContactado) 
            {
                unaEncuesta.EsContactable = true;  
                //_cantContactables++;
                contactables.Add(unaEncuesta);
            }else 
            { 
                unaEncuesta.EsContactable = false;

            }
               
                


        }

        public Encuesta VerContactable ( int index) { 
            
            if((index >= 0) && (index < contactables.Count)) { return contactables[index]; }

            return null; 

        }
        
        public void OrdenarContactablesPorDistancia () {
            //aca hay que ordenar segun los km registrados y que sean contactables?

            contactables.Sort((e1,e2)=> e1.DistanciaASuDestino.CompareTo(e2.DistanciaASuDestino));
        
        }



    }
}
