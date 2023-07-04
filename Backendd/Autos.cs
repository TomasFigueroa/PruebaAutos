using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backendd
{
    public class Autos
    {
        public int Precio { get; set; }
        public string Color { get; set; }
        public string Patente { get; set; }
        public DateTime Fecha { get; set; }
        public bool Disponibilidad { get; set; }

        public DataTable DT { get; set; } = new DataTable();

        public Autos()
        {

            DT.TableName = "Autos";
            DT.Columns.Add("Patente", typeof(string));
            DT.Columns.Add("Color", typeof(string));
            DT.Columns.Add("Fecha", typeof(DateTime));
            DT.Columns.Add("Disponibilidad", typeof(bool));
            DT.Columns.Add("Precio", typeof(int));






            Leer_DT();
        }
        public bool CargarAutos(Autos autos)
        {
            bool res = false;
            if (!Validar(autos))
            {

                DT.Rows.Add();
                int i = DT.Rows.Count - 1;

                DT.Rows[i]["Patente"] = Patente;
                DT.Rows[i]["Disponibilidad"] = Disponibilidad;
                DT.Rows[i]["Color"] = Color;
                DT.Rows[i]["Fecha"] = Fecha;
                DT.Rows[i]["Precio"] = Precio;


                DT.WriteXml("Autos.xml");

                res = true;
            }
            return res;
        }
        private bool Validar(Autos auto)
        {
            bool res = false;
            int fila = BuscarFilaAutos(Patente);

            if (fila != -1)
            {
                res = true;
            }

            return res;
        }

       
        public int BuscarFilaAutos(string vehiculo)
        {
            int fila = -1;

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (DT.Rows[i]["Patente"].ToString() == vehiculo)
                {
                    fila = i;
                    break;
                }
            }

            return fila;
        }
        private void Leer_DT()
        {
            if (System.IO.File.Exists("Autos.xml"))
            {
                DT.ReadXml("Autos.xml");
            }
        }
    }
}
