using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using Backendd;

namespace CapaNegocio
{
    public class NegAutos
    {

        AdminAutos DatosAutos = new AdminAutos();
        public int abmAutos(string accion, Autos autos)
        {
            return DatosAutos.abmAutos(accion, autos);
        }
        public DataSet ListadoAutos(string cual)
        {
            return DatosAutos.listadoAutos(cual);
        }
    }
}
