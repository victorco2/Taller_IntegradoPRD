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
    public class NPlanAcademico
    {

        public static DataTable seleccionSemestre()
        {
            DPlanAcademico Datos = new DPlanAcademico();
            return Datos.seleccionarSemestre();
        }

        public static DataTable seleccionSeccion()
        {
            DPlanAcademico Datos = new DPlanAcademico();
            return Datos.seleccionarSeccion();
        }

        public static DataTable seleccionAsignatura()
        {
            DPlanAcademico Datos = new DPlanAcademico();
            return Datos.seleccionarAsignaturas();
        }

        public static DataTable seleccionDocente()
        {
            DPlanAcademico Datos = new DPlanAcademico();
            return Datos.seleccionarDocente();
        }

        public static DataTable seleccionarDgvAsignatura(int Id_Semestre, int Id_Curso, int Id_Seccion)
        {
            DPlanAcademico Datos = new DPlanAcademico();
            return Datos.cargarDgvAsignaturas(Id_Semestre, Id_Curso, Id_Seccion);
        }

        public static string Eliminar(int semestre, int curso, int seccion, int asignatura, int docente)
        {
            DPlanAcademico Datos = new DPlanAcademico();
            return Datos.Eliminar(semestre,curso,seccion,asignatura,docente);
        }


        public static string insertar(int id_semestre, int id_curso, int id_seccion, int id_asignatura, int id_docente)
        {
            DPlanAcademico Datos = new DPlanAcademico();

            string Existe = Datos.Existe(id_semestre, id_curso, id_seccion, id_asignatura,id_docente);
            if (Existe.Equals("1"))
            {
                return "El registro ya existe";
            }
            else
            {

                Curso_Asignaturas Obj = new Curso_Asignaturas();

                Obj.Id_Semestre = id_semestre;
                Obj.Id_Curso = id_curso;
                Obj.Id_Seccion = id_seccion;
                Obj.Id_Asignatura = id_asignatura;
                Obj.Id_Docente = id_docente;


                return Datos.Insertar(Obj);

            }
        }
    }
}
