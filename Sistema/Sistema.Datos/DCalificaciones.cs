using System;
using System.Data;
using Sistema.Entidades;
using System.Data.SqlClient;


namespace Sistema.Datos
{
    public class DCalificaciones
    {
        public DataTable BuscarCalificaciones(int valorse,int valorc,int valors,int valora)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("listar_calificaciones", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("id_semestre", SqlDbType.Int).Value = valorse;
                Comando.Parameters.Add("id_curso", SqlDbType.Int).Value = valorc;
                Comando.Parameters.Add("id_seccion", SqlDbType.VarChar).Value = valors;
                Comando.Parameters.Add("id_asignatura", SqlDbType.VarChar).Value = valora;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Actualizar(Calificacion Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("calificacion_ingresar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nota1", SqlDbType.Decimal).Value = Obj.N1;
                Comando.Parameters.Add("@nota2", SqlDbType.Decimal).Value = Obj.N2;
                Comando.Parameters.Add("@nota3", SqlDbType.Decimal).Value = Obj.N3;
                Comando.Parameters.Add("@nota4", SqlDbType.Decimal).Value = Obj.N4;
                Comando.Parameters.Add("@nota5", SqlDbType.Decimal).Value = Obj.N5;
                Comando.Parameters.Add("@idestudiante", SqlDbType.Int).Value = Obj.Id_Estudiante;
                Comando.Parameters.Add("@idasignatura", SqlDbType.Int).Value = Obj.Id_Asignatura;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }



    }
}
