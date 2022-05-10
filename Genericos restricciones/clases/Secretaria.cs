using System;
using Genericos_restricciones.interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos_restricciones.clases
{
    internal class Secretaria : IParaEmpleados
    {

        //CONSTRUCTOR 
        public Secretaria(double Salario)
        {
            this.Salario = Salario;
        }

        private double Salario;//VARIABLE SALARIO

        //METODO MUESTRA SALARIO
        public double getSalario()
        {
            return Salario;
        }
    }
}
