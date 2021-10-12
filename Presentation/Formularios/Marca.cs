using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Formularios
{
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }
        public void botones()
        {
            TplTitulo.Enabled = false;
            BtnNuevo.Enabled = true;
            BtnGuardar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = true;
            DgvMarca.Enabled = false;
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnCancelar.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }
    }
}
