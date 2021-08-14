﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

//referencias
using Domain.Models;
using Domain.ValueObjects;
using System.IO;

namespace Presentation
{
    public partial class Productos : Form
    {
        private  ModeloProducto producto = new ModeloProducto();
        public Productos()
        {
            InitializeComponent();
        }
        private void Productos_Load(object sender, EventArgs e)
        {
            ListaProducto();
            DgvProductos.Columns[1].Visible = false;
            DgvProductos.Columns[2].Visible = false;
            DgvProductos.Columns[3].Visible = false;
            DgvProductos.Columns[4].Visible = false;
            DgvProductos.Columns[10].Visible = false;

        }
        private void ListaProducto()
        {
            try
            {
                DgvProductos.DataSource = producto.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                
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
            producto.estado = EntityState.Agregar;


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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DgvProductos.DataSource = producto.FindById(TxtBuscar.Text);
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DgvProductos.DataSource = producto.FindById(TxtBuscar.Text.ToLower());
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                producto.IdModelo = Convert.ToInt32(CboModelo.Text);
                producto.IdMarca = Convert.ToInt32(CboMarca.SelectedValue);
                producto.IdCompra = Convert.ToInt32(CboCompra.SelectedValue);
                producto.IdCategoria = Convert.ToInt32(CboCategoria.SelectedValue);
                producto.Codigo = TxtCodigo.Text;
                producto.Titulo = TxtTitulo.Text;
                producto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                producto.Precio = Convert.ToDecimal(TxtPrecio.Text);
                producto.Coste = Convert.ToDecimal(TxtCoste.Text);
                producto.Margen = Convert.ToDecimal(TxtMargen.Text);
                producto.Pvp = Convert.ToDecimal(TxtPVP.Text);
                producto.Iva = Convert.ToDecimal(TxtIVA.Text);
                producto.Total = Convert.ToDecimal(TxtTotal.Text);
                producto.Caracteristicas = RtbCaracteristicas.Text;
                producto.Img = ConvertirImg();
                bool valid = new Helps.ValidacionDatos(producto).Validar();

                if (valid == true)
                {
                    string result = producto.Guardar();
                    MessageBox.Show(result);
                    ListaProducto();
                    DgvProductos.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex +"Llene todos los campos");
            }
        }
        private byte[] ConvertirImg()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            ImgProducto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvProductos.SelectedRows.Count > 0)
            {
                TlpDatos.Enabled = true;
                producto.estado = EntityState.Modificar;
                producto.IdProducto = Convert.ToInt32(DgvProductos.CurrentRow.Cells[0].Value);
                CboCompra.Text = DgvProductos.CurrentRow.Cells[5].Value.ToString().Trim();
                CboMarca.Text = DgvProductos.CurrentRow.Cells[6].Value.ToString().Trim();
                CboModelo.Text = DgvProductos.CurrentRow.Cells[7].Value.ToString().Trim();
                CboCategoria.Text = DgvProductos.CurrentRow.Cells[8].Value.ToString().Trim();
                TxtCodigo.Text=DgvProductos.CurrentRow.Cells[9].Value.ToString().Trim();
                TxtTitulo.Text = DgvProductos.CurrentRow.Cells[11].Value.ToString().Trim();
                TxtCantidad.Text = DgvProductos.CurrentRow.Cells[12].Value.ToString().Trim();
                RtbCaracteristicas.Text = DgvProductos.CurrentRow.Cells[13].Value.ToString().Trim();
                TxtPrecio.Text = DgvProductos.CurrentRow.Cells[14].Value.ToString().Trim();
                TxtCoste.Text = DgvProductos.CurrentRow.Cells[15].Value.ToString().Trim();
                TxtMargen.Text = DgvProductos.CurrentRow.Cells[16].Value.ToString().Trim();
                TxtPVP.Text = DgvProductos.CurrentRow.Cells[17].Value.ToString().Trim();
                TxtIVA.Text = DgvProductos.CurrentRow.Cells[18].Value.ToString().Trim();
                TxtTotal.Text = DgvProductos.CurrentRow.Cells[20].Value.ToString().Trim();
                ImgProducto.Image = Image.FromStream(ByteImage());
                BtnNuevo.Enabled = false;
            }
            else MessageBox.Show("Selecciones la fila a editar");
        }
        private MemoryStream ByteImage()
        {
            byte[] im = (byte[])DgvProductos.CurrentRow.Cells[10].Value;
            MemoryStream ms = new MemoryStream(im);
            return ms;
        }
    }
}
