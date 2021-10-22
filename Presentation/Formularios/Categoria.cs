using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

//referencias
using System.Globalization;
using Domain.Models;
using Domain.ValueObjects;
using System.IO;

namespace Presentation
{
    public partial class Categoria : Form
    {
        private ModeloCategoria categoria = new ModeloCategoria();
        private ModeloMarca marca = new ModeloMarca();
        private ModeloModelo modelo = new ModeloModelo();
        private ModeloProducto producto = new ModeloProducto();
        public Categoria()
        {
            InitializeComponent();
        }
        private void Categoria_Load(object sender, EventArgs e)
        {
            ListarDatos();
            DgvLleno();
            

        }
        private void DgvLleno()
        {
            if (DgvDatos.RowCount > 0)
            {
                DgvDatos.Rows[0].Selected = false;
                DgvDatos.Columns[0].Visible = false;
            }
            else
            {
                BtnEliminar.Enabled = false;
                BtnEditar.Enabled = false;
                DgvDatos.Enabled = false;
            }
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            switch (ClsCalculoDatos.caso)
            {
                case 1:
                    ClsCalculoDatos.bandera = true;
                    break;
                case 2:
                    ClsCalculoDatos.bandera1 = true;
                    break;
                case 3:
                    ClsCalculoDatos.bandera2 = true;
                    break;
            }
            Dispose();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public void botones()
        {
            TxtBuscar.Enabled = true;
            TplTitulo.Enabled = false;
            BtnNuevo.Enabled = true;
            BtnGuardar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtDescripcion.Text = "";
            DgvDatos.Enabled = true;
        }
        private void ListarDatos()
        {
            try
            {
                switch (ClsCalculoDatos.caso)
                {
                    case 1:
                        DgvDatos.DataSource = categoria.GetAll();
                        CboMarca.Visible = false;
                        TxtMarca.Visible = false;
                        LblTitleChildForm.Text ="CATEGORIA";
                        break;

                    case 2:
                        DgvDatos.DataSource = marca.GetAll();
                        CboMarca.Visible = false;
                        TxtMarca.Visible = false;
                        LblTitleChildForm.Text = "MARCA";
                        break;

                    case 3:
                        DgvDatos.DataSource = modelo.GetAll();
                        DgvDatos.Columns[2].Visible = false;
                        LblTitleChildForm.Text = "MODELO";
                        ListarMarca();
                        break;
                }
                DgvLleno();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtBuscar.Enabled = false;
            TplTitulo.Enabled = true;
            BtnGuardar.Enabled = true;
            DgvDatos.Enabled = false;
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnCancelar.Enabled = true;
            switch (ClsCalculoDatos.caso)
            {
                case 1:
                    categoria.estado = EntityState.Agregar;
                    break;
                case 2:
                    marca.estado = EntityState.Agregar;
                    break;
                case 3:
                    modelo.estado = EntityState.Agregar;
                    break;
            }
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool valid;
                string result;
                switch (ClsCalculoDatos.caso)
                {
                    case 1:
                        categoria.Categoria = TxtDescripcion.Text.ToUpper();
                        valid = new Helps.ValidacionDatos(categoria).Validar();
                        if (valid == true)
                        {

                            result = categoria.Guardar();
                            MessageBox.Show(result);
                            categoria.estado = EntityState.Vizualisar;
                            ListarDatos();
                            botones();
                        }
                        break;
                    case 2:
                        marca.Marca = TxtDescripcion.Text.ToUpper();
                        valid = new Helps.ValidacionDatos(marca).Validar();
                        if (valid == true)
                        {

                            result = marca.Guardar();
                            MessageBox.Show(result);
                            marca.estado = EntityState.Vizualisar;
                            ListarDatos();
                            botones();
                        }
                        break;
                    case 3:
                        if (CboMarca.SelectedIndex != 0)
                        {
                            modelo.IdMarca = Convert.ToInt32(CboMarca.SelectedValue);
                            modelo.Modelo = TxtDescripcion.Text.ToUpper();
                            valid = new Helps.ValidacionDatos(modelo).Validar();
                            if (valid == true)
                            {
                                result = modelo.Guardar();
                                MessageBox.Show(result);
                                modelo.estado = EntityState.Vizualisar;
                                ListarDatos();
                                botones();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione la Marca que pertenece el modelo a crear");
                        }
                        break;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "Escriba la categoria que desea registrar");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count > 0)
            {
                BtnEliminar.Enabled = false;
                DgvDatos.Enabled = false;
                TxtBuscar.Enabled = false;
                TplTitulo.Enabled = true;
                BtnEditar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;
                BtnEditar.Enabled = false;
                BtnNuevo.Enabled = false;
                CboMarca.Text = DgvDatos.CurrentRow.Cells[3].Value.ToString().Trim();
                TxtDescripcion.Text = DgvDatos.CurrentRow.Cells[4].Value.ToString().Trim();
                switch (ClsCalculoDatos.caso)
                {
                    case 1:
                        categoria.estado = EntityState.Modificar;
                        categoria.IdCategoria = Convert.ToInt32(DgvDatos.CurrentRow.Cells[0].Value);
                        break;
                    case 2:
                        marca.estado = EntityState.Modificar;
                        marca.IdMarca = Convert.ToInt32(DgvDatos.CurrentRow.Cells[0].Value);
                        break;
                    case 3:
                        modelo.estado = EntityState.Modificar;
                        modelo.IdModelo = Convert.ToInt32(DgvDatos.CurrentRow.Cells[0].Value);
                        break;
                }   
            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count > 0)   
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string result;
                    switch (ClsCalculoDatos.caso)
                    {
                        case 1:
                            categoria.estado = EntityState.Eliminar;
                            categoria.IdCategoria = Convert.ToInt32(DgvDatos.CurrentRow.Cells[0].Value);
                            result = categoria.Guardar();
                            MessageBox.Show(result);
                            break;
                        case 2:
                            marca.estado = EntityState.Eliminar;
                            marca.IdMarca = Convert.ToInt32(DgvDatos.CurrentRow.Cells[0].Value);
                            result = marca.Guardar();
                            MessageBox.Show(result);
                            break;
                        case 3:
                            modelo.estado = EntityState.Eliminar;
                            modelo.IdModelo = Convert.ToInt32(DgvDatos.CurrentRow.Cells[0].Value);
                            result = modelo.Guardar();
                            MessageBox.Show(result);
                            break;
                    }
                    ListarDatos();
                }
            }
            else MessageBox.Show("Seleccione una fila a Eliminar");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (ClsCalculoDatos.caso)
            {
                case 1:
                    DgvDatos.DataSource = categoria.FindById(TxtBuscar.Text);
                    break;
                case 2:
                    DgvDatos.DataSource = marca.FindById(TxtBuscar.Text);
                    break;
                case 3:
                    DgvDatos.DataSource = modelo.FindById(TxtBuscar.Text);
                    break;
            }
            
        }
        private void ListarMarca()
        {
            CboMarca.DataSource = producto.ListarMarca();
            CboMarca.DisplayMember = "Marca";
            CboMarca.ValueMember = "IdMarca";
        }
    }
}
