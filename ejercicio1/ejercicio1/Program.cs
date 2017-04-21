using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using ClassLibrary1;

namespace ejercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nombre1 = "Ricardo";
            var nombre2 = "Favio";

            var apellido1 = "Zapata";
            var apellido2 = "Gomez";
            //Persona obj = new Persona();
            //obj.apellidospa=apellido;
            //obj.nombres=nombre1;
            var Alumno = new Alumno();
            Alumno.Nombre(nombre1);
            Alumno.Apellido(apellido1);

            Alumno.Nombre(nombre2);
            Alumno.Apellido(apellido2);

        }
    }
}
