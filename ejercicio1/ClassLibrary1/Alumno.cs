using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Alumno : Persona
    {
        public Padre Padre { get; set; }
        public Alumno()
        {

        }
        public Alumno(Padre padre)
        {
            Padre = padre;
        }
        public string Nombre(string nombres)
        {
            Console.WriteLine("Mi nombre es:" + nombres);
            return nombres;
        }
        public void Apellido(string apellidospa)
        {
            Console.WriteLine("Mi Apellido es:" + apellidospa);
        }
        public List<Curso> _cursos;
        public List<Curso> Cursos
        {
            get
            {
                return _cursos;

            }
            set
            {
                if(value.Count ==4)
                {
                    _cursos = value;
                }
            }
        }
        public Alumno(List<Curso> cursos)
        {
            Cursos = cursos;
        }
    }
}
