using System;
using Genericos_restricciones.interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos_restricciones.clases
{
    internal class AlmacenEmpleados <T> where T : IParaEmpleados
    {

        //CONSTRUCTOR
        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }

        //METODO AGREGAR 
        public void agregar( T obj)
        {

            datosEmpleado[i] = obj;

            i++;
        }

        //MUESTRA EL EMPLEADO SOLICITADO EN EL ARRAY
        public T getEmpleado(int i)
        {
            return datosEmpleado[i];
        }
        
        private int i = 0;//VARIABLE ENTERA i

        private T[] datosEmpleado;// ARRAY DE OBJ
    }
}
