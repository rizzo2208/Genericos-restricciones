using Genericos_restricciones.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos_restricciones.clases
{
    internal class Director : IParaEmpleados

    {
        //CONSTRUCTOR
        public Director(double Salario)
        {
            this.Salario = Salario;
        }

        private double Salario;//VARIABLE SALARIO

        //METODO MUESTRA SALRIO
        public double getSalario()
        {
            return Salario;
        }

    }
}
