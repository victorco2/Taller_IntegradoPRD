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
   public class NEstudiantes
    {
        public static DataTable Listar()
        {
            DEstudiantes Datos = new DEstudiantes();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DEstudiantes Datos = new DEstudiantes();
            return Datos.Buscar(Valor);
        }

        public static DataTable Seleccionar()
        {
            DEstudiantes Datos = new DEstudiantes();
            return Datos.Seleccionar();
        }

        public static string Insertar(string nombre, string apellido_paterno, string apellido_materno, string rut,DateTime fecha_nacimiento,int sexo,string direccion,int telefono,string email, int id_curso, int id_seccion ,string Imagen)
        {
            DEstudiantes Datos = new DEstudiantes();

            string Existe = Datos.Existe(rut);
            if (Existe.Equals("1"))
            {
                return "El estudiante ya existe";
            }
            else
            {
                Estudiantes Obj = new Estudiantes();
                Obj.Nombre = nombre;
                Obj.Apellido_Paterno = apellido_paterno;
                Obj.Apellido_Materno = apellido_materno;  
                Obj.Rut = rut;
                Obj.Sexo = sexo;
                Obj.Fecha_Nacimiento = fecha_nacimiento;
                Obj.Direccion = direccion;
                Obj.Telefono = telefono;
                Obj.Email = email;
                Obj.Imagen = Imagen;
                Obj.id_curso = id_curso;
                Obj.id_seccion = id_seccion;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int Id,string NombreAnt, string Nombre, string Apellido_Paterno, string Apellido_Materno,string Rut, DateTime Fecha_Nacimiento, int Sexo, string Direccion, int Telefono, string Email,int id_curso, int id_seccion, string Imagen)
        {
            DEstudiantes Datos = new DEstudiantes();
            Estudiantes Obj = new Estudiantes();

            if (NombreAnt.Equals(Nombre))
            {
                Obj.Id = Id;
                Obj.Nombre = Nombre;
                Obj.Apellido_Paterno = Apellido_Paterno;
                Obj.Apellido_Materno = Apellido_Materno;
                Obj.Rut = Rut;
                Obj.Fecha_Nacimiento = Fecha_Nacimiento;
                Obj.Sexo = Sexo;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                Obj.id_curso = id_curso;
                Obj.id_seccion = id_seccion;
                Obj.Imagen = Imagen;
                
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(Convert.ToString(Rut));
                if (Existe.Equals("1"))
                {
                    return "el estudiante ya existe";
                }
                else
                {
                    Obj.Id = Id;
                    Obj.Nombre = Nombre;
                    Obj.Apellido_Paterno = Apellido_Paterno;
                    Obj.Apellido_Materno = Apellido_Materno;
                    Obj.Rut = Rut;
                    Obj.Fecha_Nacimiento = Fecha_Nacimiento;
                    Obj.Sexo = Sexo;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    Obj.id_curso = id_curso;
                    Obj.id_seccion = id_seccion;
                    Obj.Imagen = Imagen;

                    return Datos.Actualizar(Obj);
                }
            }

        }



        public static string Eliminar(int Id)
        {
            DEstudiantes Datos = new DEstudiantes();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DEstudiantes Datos = new DEstudiantes();
            return Datos.Activar(Id);
        }

        public static string Desactivar(int Id)
        {
            DEstudiantes Datos = new DEstudiantes();
            return Datos.Desactivar(Id);
        }
    
}
}
