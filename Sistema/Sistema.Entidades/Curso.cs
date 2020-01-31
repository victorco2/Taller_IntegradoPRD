using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre_Curso { get; set; }
        public int Cupo { get; set; }
        public int Id_Docente { get; set; }
        public int Id_periodo { get; set; }
        public int Id_alumnos { get; set; }
        public bool Estado { get; set; }
    }
}
