using System;
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
                producto.IdModelo = 1;
                producto.IdMarca = 1;
                producto.IdCompra = 1;
                producto.IdCategoria = 1;
                producto.Codigo = "01234567890123456789";
                producto.Titulo = "jisdsd";
                producto.Cantidad = 12;
                producto.Precio = 21;
                producto.Coste = 12;
                producto.Margen = 21;
                producto.Pvp = 12;
                producto.Iva = 12;
                producto.Total = 12;
                producto.Caracteristicas = "jsoidjdhbsdf";
                producto.Img = ConvertirImg();
                bool valid = new Helps.ValidacionDatos(producto).Validar();

                if (valid == true)
                {
                    string result = producto.Guardar();
                    MessageBox.Show(result);
                    ListaProducto();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Llene todos los campos");
            }
        }
        private byte[] ConvertirImg()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            ImgProducto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }


        private void TxtCoste_KeyPress(object sender, KeyPressEventArgs e)
        {
            double a;
            a = Convert.ToDouble(TxtPrecio.Text) * 0.12;
            a = Convert.ToDouble(TxtPrecio.Text) + a;
            TxtCoste.Text = a.ToString();
        }
    }
}
