using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    class Cuenta:IComparable
    {
        
        public string Nombre;
        public int DNI;
        public double Importe;

        public Cuenta (string nombre,int dni,double importe)
        {
            Nombre = nombre;
            DNI= dni;
            Importe= importe;
              
        }

        public override string ToString()
        {
            return $"Cuenta : {Nombre} - {DNI} - {Importe} ";
        }

        public int CompareTo(object otherObject)
        {
            Cuenta other = otherObject as Cuenta;

            if(other == null)
            {
                return this.DNI.CompareTo(other.DNI);
               


            }
            return -1;

        }
      
    }
}
