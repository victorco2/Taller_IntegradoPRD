using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NCursos

    {
        public static DataTable Listar()
        {
            DCurso Datos = new DCurso( );
            return Datos.Listar();
        }
       
        public static DataTable Buscar(string Valor)
        {
            DCurso Datos = new DCurso();
            return Datos.Buscar(Valor);
        }
        public static string insertar(string Nombre_Curso, int Cupo)
        {
            DCurso Datos = new DCurso();

            string Existe = Datos.Existe(Nombre_Curso);
            if (Existe.Equals("1"))
            {
                return "El curso ya existe";
            }
            else
            {

                Curso Obj = new Curso();

                Obj.Nombre_Curso = Nombre_Curso;
                Obj.Cupo = Cupo;
              


                return Datos.Insertar(Obj);

            }
        }

        public static string Actualizar(int Id, string Nombre,int Cupo)
        {
            DCurso Datos = new DCurso();
            Curso Obj = new Curso();

         
                Obj.Id = Id;
                Obj.Nombre_Curso = Nombre;
                Obj.Cupo = Cupo;
                

                return Datos.Actualizar(Obj);
                 
            
        }

        public static string Eliminar(int Id)
        {
            DCurso Datos = new DCurso();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DCurso Datos = new DCurso();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DCurso Datos = new DCurso();
            return Datos.Desactivar(Id);
        }

    }               
}          