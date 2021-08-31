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
using System.Globalization;
using Domain.Models;
using Domain.ValueObjects;
using System.IO;

namespace Presentation
{
    public partial class Productos : Form
    {
        private ModeloProducto producto = new ModeloProducto();
        private ClsCalculoDatos calculo = new ClsCalculoDatos();
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
            DgvProductos.Columns[5].Visible = false;
            DgvProductos.Columns[10].Visible = false;
            DgvProductos.Columns[13].Visible = false;

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
        public void botones()
        {
            BtnExaminar.Enabled = false;
            TxtTotal.Enabled = false;
            TlpDatos.Enabled = false;
            TlpCaracteristicas.Enabled = false;
            TlpIvaTotal.Enabled = false;
            BtnNuevo.Enabled = true;
            BtnGuardar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            DgvProductos.Enabled = true;
        }
        public void limpiar()
        {
            TxtCodigo.Clear();
            TxtCantidad.Clear();
            TxtTitulo.Clear();
            TxtDescuento.Text="0";
            TxtPrecio.Text = "0";
            TxtCoste.Text = "0";
            TxtIVA.Text = "0";
            TxtMargen.Text="20";
            TxtPVP.Text = "0";
            TxtTotal.Text = "0";
            RtbCaracteristicas.Clear();
            if (ImgProducto.Image != null)
            {
                
                ImgProducto.Image = PtbImg.Image;
            }
                
        }
        private void Datos()
        {
            producto.IdProducto = Convert.ToInt32(DgvProductos.CurrentRow.Cells[0].Value);
            CboCompra.Text = DgvProductos.CurrentRow.Cells[5].Value.ToString().Trim();
            CboMarca.Text = DgvProductos.CurrentRow.Cells[6].Value.ToString().Trim();
            CboModelo.Text = DgvProductos.CurrentRow.Cells[7].Value.ToString().Trim();
            CboCategoria.Text = DgvProductos.CurrentRow.Cells[8].Value.ToString().Trim();
            TxtCodigo.Text = DgvProductos.CurrentRow.Cells[9].Value.ToString().Trim();
            TxtTitulo.Text = DgvProductos.CurrentRow.Cells[11].Value.ToString().Trim();
            TxtCantidad.Text = DgvProductos.CurrentRow.Cells[12].Value.ToString().Trim();
            RtbCaracteristicas.Text = DgvProductos.CurrentRow.Cells[13].Value.ToString().Trim();
            TxtPrecio.Text = DgvProductos.CurrentRow.Cells[14].Value.ToString().Trim();
            TxtCoste.Text = DgvProductos.CurrentRow.Cells[15].Value.ToString().Trim();
            TxtMargen.Text = DgvProductos.CurrentRow.Cells[16].Value.ToString().Trim();
            TxtDescuento.Text = DgvProductos.CurrentRow.Cells[17].Value.ToString().Trim();
            TxtPVP.Text = DgvProductos.CurrentRow.Cells[18].Value.ToString().Trim();
            TxtIVA.Text = DgvProductos.CurrentRow.Cells[19].Value.ToString().Trim();
            TxtTotal.Text = DgvProductos.CurrentRow.Cells[20].Value.ToString().Trim();
            ImgProducto.Image = Image.FromStream(ByteImage());
        }

        private MemoryStream ByteImage()
        {
            byte[] im = (byte[])DgvProductos.CurrentRow.Cells[10].Value;
            MemoryStream ms = new MemoryStream(im);
            return ms;
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
            TlpCaracteristicas.Enabled = true;
            BtnExaminar.Enabled = true;
            BtnGuardar.Enabled = true;
            DgvProductos.Enabled = false;
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnCancelar.Enabled = true;
            producto.estado = EntityState.Agregar;
            limpiar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cancelar, se perdera todos los datos ingresados?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                botones();
                limpiar();
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {

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
                producto.Titulo = TxtTitulo.Text.ToLower();
                producto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                producto.Precio = float.Parse(TxtPrecio.Text);
                producto.Coste = float.Parse(TxtCoste.Text);
                producto.Margen = float.Parse(TxtMargen.Text);
                producto.Pvp = float.Parse(TxtPVP.Text);
                producto.Descuento= float.Parse(TxtDescuento.Text);
                producto.Iva = float.Parse(TxtIVA.Text);
                producto.Total = float.Parse(TxtTotal.Text);
                producto.Caracteristicas = RtbCaracteristicas.Text;
                producto.Img = ConvertirImg();
                bool valid = new Helps.ValidacionDatos(producto).Validar();

                if (valid == true)
                {
                    string result = producto.Guardar();
                    MessageBox.Show(result);
                    producto.estado = EntityState.Vizualisar;
                    ListaProducto();
                    limpiar();
                    botones();
    
                }
            }
            catch (Exception)
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvProductos.SelectedRows.Count > 0)
            {
                BtnEditar.Enabled = true;
                TlpCaracteristicas.Enabled = true;
                BtnCancelar.Enabled = true;
                TlpDatos.Enabled = true;
                DgvProductos.Enabled = false;
                BtnGuardar.Enabled = true;
                BtnExaminar.Enabled = true;
                BtnEditar.Enabled = false;
                BtnNuevo.Enabled = false;
                producto.estado = EntityState.Modificar;
                Datos();
            }
            else MessageBox.Show("Seleccione la fila a editar");
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DgvProductos.SelectedRows.Count > 0)
                {
                    producto.estado = EntityState.Eliminar;
                    producto.IdProducto = Convert.ToInt32(DgvProductos.CurrentRow.Cells[0].Value);
                    string result = producto.Guardar();
                    MessageBox.Show(result);
                    ListaProducto();
                }
                else MessageBox.Show("Selecciones la fila a editar");
            }
        }

        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Datos();
        }

        private void TxtPrecio_Leave(object sender, EventArgs e)
        {
            if (TxtPrecio.Text != "")
            {
                decimal precio = Convert.ToDecimal(TxtPrecio.Text);
                TxtCoste.Text = calculo.Coste(precio).ToString();
                if (TxtMargen.Text != "")
                {
                    TxtMargen_Leave(sender, e);
                }
            }

        }

        private void TxtMargen_Leave(object sender, EventArgs e)
        {
            if (TxtMargen.Text != "" && TxtDescuento.Text != "")
            { 
               TxtDescuento_Leave(sender, e);

            }
            else
            {
                TxtMargen.Text = "20";
                TxtMargen_Leave(sender, e);
            }

        }

        private void TxtDescuento_Leave(object sender, EventArgs e)
        {

            if (TxtDescuento.Text!="" && TxtMargen.Text !="" && TxtPrecio.Text!="0")
            {
                decimal margen = Convert.ToDecimal(TxtMargen.Text);
                decimal descuento = Convert.ToDecimal(TxtDescuento.Text);
                int cont=0;    
                    foreach (var item in calculo.ListaCalculo(margen, descuento))
                    {
                        if (cont == 0)
                        {
                        TxtDescuento.Text = item;
                        }
                        if (cont == 1)
                        {
                            TxtPVP.Text = item;
                        }
                        if (cont==2)
                        {
                            TxtIVA.Text = item;
                        }
                        if (cont==3)
                        {
                            TxtTotal.Text = item;
                        }
                        cont++;     
                    }
            }
            else if (TxtDescuento.Text == "")
            {
                TxtDescuento.Text = "0";
                TxtDescuento_Leave(sender, e);
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloNumerosDecimales(sender, e);
        }

        private void TxtCoste_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloNumerosDecimales(sender, e);
        }

        private void TxtMargen_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloNumeros(e);
        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloNumeros(e);
        }

        private void TxtPVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloNumerosDecimales(sender, e);
        }

        private void TxtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloNumerosDecimales(sender, e);
        }

        private void TxtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloNumerosDecimales(sender, e);
        }

        private void TxtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloLetrasNumeroEspacio(e);
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloNumeros(e);
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloLetrasNumero(e);
        }

        private void RtbCaracteristicas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloLetrasNumeroEspacio(e);        
        }
    }
}
