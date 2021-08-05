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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        private void PnlDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExaminar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                ImgProducto.ImageLocation = getImage.FileName;
            }
            else
            {
                MessageBox.Show("No se selecciono imagen", "sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TlpDatos.Enabled = true;
            RtbCaracteristicas.Enabled = true;
            BtnExaminar.Enabled = true;
            BtnGuardar.Enabled = true;
            DgvProductos.Enabled = false;
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnCancelar.Enabled = true;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cancelar, se perdera todos los datos ingresados?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TlpDatos.Enabled = false;
                BtnNuevo.Enabled = true;
                BtnGuardar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
                DgvProductos.Enabled = false;
                limpiar();
            }
        }
        public void limpiar()
        {
            TxtCodigo.Clear();
            TxtCantidad.Clear();
            TxtTitulo.Clear();
            TxtPrecio.Clear();
            TxtCoste.Clear();
            TxtIVA.Clear();
            TxtMargen.Clear();
            TxtPVP.Clear();
            TxtTotal.Clear();
        }
    }
}
