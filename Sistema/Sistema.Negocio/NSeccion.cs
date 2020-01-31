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
   public class NSeccion
    {
        public static DataTable Listar (int Valor)
        {
            DSeccion Datos = new DSeccion();
            return Datos.Listar(Valor);
        }
        public static string insertar(string nombre,int id_docente, int id_Curso)
        {
            DSeccion Datos = new DSeccion();

            Seccion Obj = new Seccion();

            Obj.Nombre = nombre;
            Obj.ProfesorJefe = id_docente;
            Obj.Id_Curso = id_Curso;
        
            return Datos.Insertar(Obj);

        }
        public static string Actualizar(int Id, string Nombre, int Id_Docente, int Id_Curso)
        {
            DSeccion Datos = new DSeccion();
            Seccion Obj = new Seccion();


            Obj.Id = Id;
            Obj.Nombre = Nombre;
            Obj.Id_Docente = Id_Docente;
            Obj.Id_Curso = Id_Curso;


            return Datos.Actualizar(Obj);


        }

        public static string Eliminar(int Id)
        {
            DSeccion Datos = new DSeccion();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DSeccion Datos = new DSeccion();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DSeccion Datos = new DSeccion();
            return Datos.Desactivar(Id);
        }


    }
}
