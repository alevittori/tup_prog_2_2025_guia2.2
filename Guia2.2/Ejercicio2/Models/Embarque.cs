using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Embarque
    {
        double porcDepreciacionUsado;
        int añoEvaluacion;
        int _cantidadDeMotos;
        double _montoTotal;
        List<Moto> listaMotos;

        public int Numero { get; } //readonly
        //public int CantidadMotos { get => _cantidadDeMotos; private set => _cantidadDeMotos=value; }
        public int CantidadMotos { get => listaMotos.Count; }
        public double MontoTotal
        {
            get
            {

                foreach (Moto valor in listaMotos)
                {
                    _montoTotal += valor.CalcularValorActual(añoEvaluacion);
                }
                return _montoTotal;
            }
        }
            
        public double PromedioCosto
        {
            get 
            { 
                if(CantidadMotos > 0)
                {
                    return MontoTotal / CantidadMotos;

                }
                return 0;
            }
        }
        public double AntiguedadPromedio 
        {
            get 
            {
                int antiguedadTotal = 0;
                foreach(Moto m in listaMotos)
                {
                    antiguedadTotal += m.CalculaAntiguedad(añoEvaluacion);
                }

                return (antiguedadTotal/listaMotos.Count) *100 ;
            } 
        }

        public Embarque(int numero, int añoEvaluacion /* , double porcDepreciacion*/)  
        {
            listaMotos = new List<Moto>();
            this.añoEvaluacion = añoEvaluacion;
            Numero = numero;
            //porcDepreciacionUsado = porcDepreciacion;

        }

        public void RegistrarMoto(int añosFabricacion, double montoFabricacion) 
        {

            listaMotos.Add(new Moto(añosFabricacion, montoFabricacion));

            
        }

    }
}
