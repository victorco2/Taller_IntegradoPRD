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
    public class NSeleccionar
    {
        public static DataTable Seleccionar()
        {
             DSeccion Datos = new DSeccion();
            return Datos.Seleccionar();
        }

        public static DataTable SeleccionarSeccion( int valor)
        {
            DSeccion Datos = new DSeccion();
            return Datos.SeleccionarSeccion(valor);
        }

    
    }
}
