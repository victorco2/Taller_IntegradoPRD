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
   public class NAsignaturas
    {
        public static DataTable listar()
        {
            DAsignaturas Datos = new DAsignaturas();
            return Datos.listarAsignaturas();
        }

     
        public static string insertar(string nombre)
        {
            DAsignaturas Datos = new DAsignaturas();

            string Existe = Datos.Existe(nombre);
            if (Existe.Equals("1"))
            {
                return "La Asignatura ya existe";
            }

            else
            {

                Asignaturas Obj = new Asignaturas();
                Obj.nombre = nombre;

                return Datos.insertarAsignaturas(Obj);
            }
        }


        public static string Actualizar(int Id, string Nombre)
        {
            DAsignaturas Datos = new DAsignaturas();
            Asignaturas Obj = new Asignaturas();


            Obj.id = Id;
            Obj.nombre = Nombre;
           
            return Datos.Actualizar(Obj);            
        }

        public static string Eliminar(int Id)
        {
            DAsignaturas Datos = new DAsignaturas();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DAsignaturas Datos = new DAsignaturas();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DAsignaturas Datos = new DAsignaturas();
            return Datos.Desactivar(Id);
        }


    }
}
