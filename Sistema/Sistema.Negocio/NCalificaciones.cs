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
   public class NCalificaciones
    {
        public static DataTable buscarCalificaciones(int valorse, int valorc, int valors, int valora)
        {
            DCalificaciones Datos = new DCalificaciones();
            return Datos.BuscarCalificaciones(valorse,valorc, valors, valora);
        }

        public static string Actualizar(double n1, double n2, double n3, double n4, double n5, int ide, int ida)
        {
            DCalificaciones Datos = new DCalificaciones();
            Calificacion Obj = new Calificacion();


            Obj.N1 = n1;
            Obj.N2 = n2;
            Obj.N3 = n3;
            Obj.N4 = n4;
            Obj.N5 = n5;
            Obj.Id_Estudiante = ide;
            Obj.Id_Asignatura = ida;


            return Datos.Actualizar(Obj);


        }

    }
}
