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
    public class NPromedio
    {
        public static DataTable calcularPromedio(int Valore, int Valora)
        {
            DPromedio Datos = new DPromedio();
            return Datos.calculoPromedio(Valore,Valora);
        }


        public static DataTable guardarPromedio(int Valore, int Valora,double promedio)
        {
            DPromedio Datos = new DPromedio();
            return Datos.guardarPromedio(Valore, Valora,promedio);
        }
    }
}
