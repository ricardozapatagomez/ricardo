using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Curso
    {
        public string nombrecurso { get; set; }


        public List<Notas> _Notas;
        public List<Notas> Notas
        {
            get { return _Notas; }
            set { _Notas = value; }
        }
        public Curso()
        {
            Notas = new List<Notas>();
        }



    }
}
