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
    public class NDocente
    {
        public static DataTable Listar()
        {
            DDocente Datos = new DDocente();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DDocente Datos = new DDocente();
            return Datos.Buscar(Valor);
        }

        public static DataTable BuscarDocenteJefe()
        {
            DDocente Datos = new DDocente();
            return Datos.BuscarDocenteJefe();
        }

        public static DataTable Seleccionar()
        {
            DDocente Datos = new DDocente();
            return Datos.Seleccionar();
        }

        public static string Insertar(string Nombre, string Apellido_Paterno, string Apellido_Materno, int Rut,int Sexo, string Direccion, int Telefono, string Email, string Imagen)
        {
            DDocente Datos = new DDocente();

            string Existe = Datos.Existe(Rut);
            if (Existe.Equals("1"))
            {
                return "El Docente ya existe";
            }
            else
            {
                Docente Obj = new Docente();

                Obj.Nombre = Nombre;
                Obj.Apellido_Paterno = Apellido_Paterno;
                Obj.Apellido_Materno = Apellido_Materno;
                Obj.Rut = Rut;
                Obj.Sexo = Sexo;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                Obj.Imagen = Imagen;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int Id, string NombreAnt, string Nombre, string Apellido_Paterno, string Apellido_Materno, int Rut, int Sexo, string Direccion, int Telefono, string Email, string Imagen)
        {
            DDocente Datos = new DDocente();
            Docente Obj = new Docente();

            if (NombreAnt.Equals(Nombre))
            {
                Obj.Id = Id;
                Obj.Nombre = Nombre;
                Obj.Apellido_Paterno = Apellido_Paterno;
                Obj.Apellido_Materno = Apellido_Materno;
                Obj.Rut = Rut;
                Obj.Sexo = Sexo;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                Obj.Imagen = Imagen;

                return Datos.Actualizar(Obj);
            }
            else
            {
              
                    Obj.Id = Id;
                    Obj.Nombre = Nombre;
                    Obj.Apellido_Paterno = Apellido_Paterno;
                    Obj.Apellido_Materno = Apellido_Materno;
                    Obj.Rut = Rut;
                    Obj.Sexo = Sexo;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    Obj.Imagen = Imagen;

                    return Datos.Actualizar(Obj);
                
            }

        }



        public static string Eliminar(int Id)
        {
            DDocente Datos = new DDocente();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DDocente Datos = new DDocente();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DDocente Datos = new DDocente();
            return Datos.Desactivar(Id);
        }

    }
}
