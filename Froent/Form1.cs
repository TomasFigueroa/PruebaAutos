using Backendd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Froent
{
    public partial class Auto : Form
    {
        public DataTable DT { get; set; } = new DataTable();
        private Autos autos = new Autos();
        private NegAutos negAutos = new NegAutos();
        DataSet ds = new DataSet();
        public Auto()
        {
            InitializeComponent();

            dgautos.ColumnCount = 5;
            dgautos.Columns[0].HeaderText = "Patente";
            dgautos.Columns[1].HeaderText = "Color";
            dgautos.Columns[0].Width = 100;
            dgautos.Columns[1].Width = 100;
            dgautos.Columns[2].HeaderText = "Fecha";
            dgautos.Columns[3].HeaderText = "Disponibilidad";
            dgautos.Columns[4].HeaderText = "Precio";
            dgautos.Columns[2].Width = 70;
            dgautos.Columns[3].Width = 50;
            dgautos.Columns[4].Width = 200;
            LlenarDGV();
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Agregar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            CargarAutos();

                

            nGrabados = negAutos.abmAutos("Alta", autos);
            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el Auto en el sistema");
            }
            else
            {
                MessageBox.Show("Se pudo grabar el Auto en el sistema con exito");
                LlenarDGV();


            }

        
        }


        private void LlenarMod()
        {
            dgautos.Rows.Clear();

            ds = negAutos.ListadoAutos("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgautos.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4]);
                    
                }
            }
            else
                lblMensaje.Text = "No hay Autos cargados en el sistema";
        }
        private void LlenarDGV()
        {
            dgautos.Rows.Clear();
            
            ds = negAutos.ListadoAutos("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                     dgautos.Rows.Add(dr[0].ToString(), dr[1] , dr[2], dr[3], dr[4]);
                    limpiarpantalla();
                }
            }
            else
                lblMensaje.Text = "No hay Autos cargados en el sistema";
        }
        private void CargarAutos()
        {
            autos.Patente = Txt_Patente.Text.ToUpper();
            autos.Color = Txt_Color.Text;
            autos.Precio = Convert.ToInt32(Txt_Precio.Text);
            autos.Fecha = Dt_Fecha.Value;
            autos.Disponibilidad = Check.Checked;

        }

        private void Bt_Modificar_Click(object sender, EventArgs e)
        {
            DataSet dG = new DataSet();
            string DATO = Txt_Patente.Text;
            int nGrabados = -1;
            autos.Patente = Txt_Patente.Text.ToString();
            if (DATO!="")
            {
                nGrabados = negAutos.abmAutos("Modificar", autos);

                dgautos.Rows.Clear();

                LlenarDGV();

                MessageBox.Show("Se pudo borrar el auto con exito");
            }
         
        }
       
        public void limpiarpantalla()
        {
            Txt_Color.Text= string.Empty;   
            Txt_Patente.Text= string.Empty;
            Txt_Precio.Text= string.Empty;  
        }
        private void ds_a_Box(DataSet ds)
        {
            Txt_Patente.Text= ds.Tables[0].Rows[fila]["Patente"].ToString();
            Txt_Color.Text = ds.Tables[0].Rows[fila]["Color"].ToString();
            Txt_Precio.Text = ds.Tables[0].Rows[fila]["Precio"].ToString() ;

            Txt_Patente.Enabled = false;
        }
        
        
        int fila= -1 ;
        public int BuscarFilaAutos(string vehiculo,DataSet ds)
        {
           

            for (int i = 0; i < dgautos.Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["Patente"].ToString() == vehiculo)
                {
                    fila = i;
                    break;
                }
            }

            return fila;
        }


        bool boton = false;
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        { 

            string DATO = Txt_Patente.Text;
            if (DATO!="")
            {
                autos.Patente = Txt_Patente.Text;
                BuscarFilaAutos(Txt_Patente.Text, ds);
                ds_a_Box(ds);
                


                negAutos.abmAutos("Borrar", autos);
                boton = true;
                dgautos.Rows.Clear();
                LlenarMod();

            }
         

        }

        private void Bt_Acepmod_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            CargarAutos();
            if (boton==true)
            {
                nGrabados = negAutos.abmAutos("Alta", autos);
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se pudo grabar el Auto en el sistema");
                }
                else
                {

                    MessageBox.Show("Se pudo Modificar el Auto en el sistema con exito");
                    dgautos.Rows.Clear();
                    LlenarDGV();


                }
                Txt_Patente.Enabled = true;
            }
           
        }
    }
}
