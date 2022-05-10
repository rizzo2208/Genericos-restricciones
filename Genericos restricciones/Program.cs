using Genericos_restricciones.clases;
using System;

namespace Genericos_restricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(3);

            empleados.agregar(new Director(4500));
            empleados.agregar(new Director(3500));
            empleados.agregar(new Director(1500));
            empleados.agregar(new Director(2500));

            //al ingresar instancias de empleados los guarda correctamente porque identifica que tiene salarios.

            AlmacenEmpleados<Estudiante> empleados = new AlmacenEmpleados<Estudiante>(3);

            empleados.agregar(new Estudiante(4500));
            empleados.agregar(new Estudiante(3500));
            empleados.agregar(new Estudiante(1500));
            empleados.agregar(new Estudiante(2500));

            //al ingresar instancias de estudiantes se generan conflictos pq no identidifaca argumento salario.
        }

        class Estudiante
        {

            //CONSTRUCTOR
            public Estudiante(double edad)
            {
                this.edad = edad;
            }

            //METODO MOSTRAR EDAD
            public double getEdad()
            {
                return edad();
            }

            private double edad;//variable edad
        }
    }
}
