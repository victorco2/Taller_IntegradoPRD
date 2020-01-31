using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Seccion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ProfesorJefe { get; set; }
        public int Id_Curso { get; set; }
        public int Id_Docente { get; set; }
        public bool Estado { get; set; }

        
    }
}
