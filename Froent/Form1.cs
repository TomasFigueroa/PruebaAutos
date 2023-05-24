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

namespace Froent
{
    public partial class Auto : Form
    {
        private Autos autos = new Autos();
        public Auto()
        {
            InitializeComponent();
            dgautos.DataSource = autos.DT;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Agregar_Click(object sender, EventArgs e)
        {
            autos.Patente = Txt_Patente.Text.ToUpper();
            autos.Color = Txt_Color.Text;
            autos.Precio = Convert.ToInt32(Txt_Precio.Text);
            autos.Fecha = Dt_Fecha.Value;
            autos.Disponibilidad = Check.Checked;
            autos.CargarAutos(autos);
        }
    }
}
