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
    public class NPeriodo

    {

        public static string Insertar(int Periodos) {

            DPeriodo Datos = new DPeriodo();

            Periodo Obj = new Periodo();

          
            Obj.Periodos = Periodos;

            return Datos.Insertar(Obj);
        }
    }
}
