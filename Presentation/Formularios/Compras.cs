using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            TxtBuscar.Clear();
            RtbObservacion.Clear();
            NudCantidad.Text = "0";
            TxtGastos.Clear();
            TxtFlete.Clear();
            TxtTotal.Clear();
            TxtComprobante.Clear();
            RtbDescripcion.Clear();
            DtpFecha.DataBindings.Clear();
            CboProveedor.SelectedValue = -1;
            CboTipo.SelectedValue = -1;


        }
        public void botones()
        {
            PnlLista.Enabled = true;
            PnlDatos.Enabled = false;
            BtnNuevo.Enabled = true;
            BtnGuardar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            PnlLista.Enabled = false;
            PnlDatos.Enabled = true;
            BtnGuardar.Enabled = true;
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnCancelar.Enabled = true;
            //compras.estado = EntityState.Agregar;
            limpiar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cancelar, se perdera todos los datos ingresados?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PnlDatos.Enabled = false;
                limpiar();
                botones();
            }
        }

    }
}
