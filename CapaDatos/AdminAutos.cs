using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Backendd;

namespace CapaDatos
{
        public class AdminAutos : DatosConexion
    {
        public int abmAutos(string accion, Autos autos)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = $"insert into Autos values ( '{ autos.Patente}','{ autos.Color }','{autos.Fecha}',{ autos.Disponibilidad},{autos.Precio});";

            }
              
            if (accion == "Modificar")
            {
                orden = "update Autos SET Color='"+autos.Color + "'Fecha='"+autos.Fecha+  "Disponibilidad="+ autos.Disponibilidad+ "Precio="+ autos.Precio+ "'where patente like  '%"+autos.Patente+"%'";
            }
            if (accion == "Borrar")
            {
                orden = "Delete* from Autos WHERE Patente='" + autos.Patente + "'";
            }
                
            // falta la orden de borrar
           OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de autos",e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }


        public DataSet listadoAutos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
            {
                orden = "select * from Autos where Patente = " + cual + ";";
            }

            else
            {
                orden = "select * from Autos;";
            }
                
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Autos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

    }
}

        

    
