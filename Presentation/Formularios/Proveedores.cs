using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Domain.Models;
using Domain.ValueObjects;

namespace Presentation
{
    public partial class Proveedores : Form
    {
        private ModeloProveedor proveedor = new ModeloProveedor();
        public Proveedores()
        {
            InitializeComponent();
            ListaProveedor();
            ListarTipoDoc();
            CboTipoDoc.SelectedValue = -1;
            DgvProveedor.Columns[0].Visible = false;
            DgvProveedor.Columns[2].Visible = false;
            DgvProveedor.Columns[11].Visible = false;
        }
        private void DgvLleno()
        {
            if (DgvProveedor.RowCount != 0)
            {
                DgvProveedor.Rows[0].Selected = false;
            }
            else
            {
                BtnEliminar.Enabled = false;
                BtnEditar.Enabled = false;
                DgvProveedor.Enabled = false;
            }
        }
        private void ListaProveedor()
        {
            try
            {
                DgvProveedor.DataSource = proveedor.GetAll();
                DgvLleno();
            }
            catch (Exception)
            {
            }

        }
        private void ListarTipoDoc()
        {
            CboTipoDoc.DataSource = proveedor.ListarTipoDoc();
            CboTipoDoc.DisplayMember = "Tipo";
            CboTipoDoc.ValueMember = "IdTipoDoc";
        }
        public void limpiar()
        {
            TxtBuscar.Clear();
            TxtNombre.Clear();
            TxtDoc.Clear();
            TxtEmail.Clear();
            TxtCelular.Clear();
            TxtNomOperador.Clear();
            TxtPais.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
            RtbDescripcion.Clear();
            CboTipoDoc.SelectedValue = -1;


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
            proveedor.estado = EntityState.Agregar;
            limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                proveedor.IdTipoDoc = Convert.ToInt32(CboTipoDoc.SelectedValue);
                proveedor.Nombre = TxtNombre.Text;
                proveedor.Documento = TxtDoc.Text;
                proveedor.Pais = TxtPais.Text;
                proveedor.Direccion = TxtDireccion.Text;
                proveedor.Telefono = TxtTelefono.Text;
                proveedor.Operador= TxtNomOperador.Text;
                proveedor.Celular = TxtCelular.Text;
                proveedor.Email = TxtEmail.Text;
                proveedor.Descripcion=RtbDescripcion.Text;
                bool valid = new Helps.ValidacionDatos(proveedor).Validar();
                if (valid == true)
                    {
                        string result = proveedor.Guardar();
                        MessageBox.Show(result, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        proveedor.estado = EntityState.Vizualisar;
                        ListaProveedor();
                        limpiar();
                        botones();
                    }
            }
            catch (Exception)
            {

                MessageBox.Show("Llene todos los campos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
        private void Datos()
        {
            if (DgvProveedor.RowCount > 0)
            {
                proveedor.IdProveedor = Convert.ToInt32(DgvProveedor.CurrentRow.Cells[0].Value);
                TxtNombre.Text = DgvProveedor.CurrentRow.Cells[3].Value.ToString().Trim();
                CboTipoDoc.SelectedValue = DgvProveedor.CurrentRow.Cells[2].Value;
                TxtDoc.Text = DgvProveedor.CurrentRow.Cells[5].Value.ToString().Trim();
                TxtPais.Text = DgvProveedor.CurrentRow.Cells[6].Value.ToString().Trim();
                TxtDireccion.Text = DgvProveedor.CurrentRow.Cells[7].Value.ToString().Trim();
                TxtTelefono.Text = DgvProveedor.CurrentRow.Cells[8].Value.ToString().Trim();
                TxtNomOperador.Text = DgvProveedor.CurrentRow.Cells[9].Value.ToString().Trim();
                TxtCelular.Text = DgvProveedor.CurrentRow.Cells[10].Value.ToString().Trim();
                TxtEmail.Text = DgvProveedor.CurrentRow.Cells[11].Value.ToString().Trim();
                RtbDescripcion.Text = DgvProveedor.CurrentRow.Cells[12].Value.ToString().Trim();
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvProveedor.SelectedRows.Count > 0)
            {
                PnlLista.Enabled = false;
                PnlDatos.Enabled = true;
                BtnEditar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;
                BtnEditar.Enabled = false;
                BtnNuevo.Enabled = false;
                proveedor.estado = EntityState.Modificar;
                Datos();
            }
            else
            {
                MessageBox.Show("Selecciones la fila a Editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvProveedor.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    proveedor.estado = EntityState.Eliminar;
                    proveedor.IdProveedor = Convert.ToInt32(DgvProveedor.CurrentRow.Cells[0].Value);
                    string result = proveedor.Guardar();
                    MessageBox.Show(result, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaProveedor();
                }
            }
            else
            {
                MessageBox.Show("Selecciones la fila a Eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
