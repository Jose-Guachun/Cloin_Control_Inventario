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
        private bool idDato= true;
        public Productos()
        {
            InitializeComponent();
        }
        private void Productos_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            ListarMarca();
            ListaProducto();
            DgvProductos.Columns[0].Visible = false;
            DgvProductos.Columns[2].Visible = false;
            DgvProductos.Columns[3].Visible = false;
            DgvProductos.Columns[4].Visible = false;
            DgvProductos.Columns[9].Visible = false;
            DgvProductos.Columns[10].Visible = false;
            DgvProductos.Columns[13].Visible = false;
        }
        public void DgvLleno()
        {
            if (DgvProductos.RowCount > 0)
            {
                DgvProductos.Rows[0].Selected = false;

                
            }
            else
            {
                BtnEliminar.Enabled = false;
                BtnEditar.Enabled = false;
                DgvProductos.Enabled = false;
            }
        }
        public void ListarCategorias()
        {
            CboCategoria.DataSource = producto.ListarCategorias();
            CboCategoria.DisplayMember = "Categoria";
            CboCategoria.ValueMember = "IdCategoria";
        }

        private void ListarMarca()
        {
            CboMarca.DataSource = producto.ListarMarca();
            CboMarca.DisplayMember = "Marca";
            CboMarca.ValueMember = "IdMarca";
        }
        private void ListarModelo(string marca)
        {
             CboModelo.DataSource = producto.ListarModelo(marca);
             CboModelo.DisplayMember = "Modelo";
             CboModelo.ValueMember = "IdModelo";
        }
        private void ListaProducto()
        {
            try
            {
                DgvProductos.DataSource = producto.GetAll();
                DgvLleno();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

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
            BtnCheck.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            BtnCheck.BackColor = System.Drawing.Color.MediumSeaGreen;
            idDato = true;
        }
        public void limpiar()
        {
            
            TxtCodigoSku.Clear();
            TxtCodigoUpc.Clear();
            TxtCantidad.Clear();
            TxtTitulo.Clear();
            CboCategoria.SelectedIndex = 0;
            CboMarca.SelectedIndex = 0;
            ListarModelo("0");
            limpiarContable();
            RtbCaracteristicas.Clear();
            TxtCoste.Text = "0";
            ClsCalculoDatos.valueCategoria=null;
            ClsCalculoDatos.valueMarca=null;
            ClsCalculoDatos.valueModelo=null;
            if (ImgProducto.Image != null)
            {
                ImgProducto.Image = PtbImg.Image;
            }
                
        }
        public void limpiarContable()
        {
            TxtDescuento.Text = "0";
            TxtIVA.Text = "0";
            TxtMargen.Text = "20";
            TxtPVP.Text = "0";
            TxtTotal.Text = "0";
        }
        public void selecCombo(string idvalue)
        {
            CboMarca.SelectedValue =idvalue;
        }
            private void Datos()
        {
            if (DgvProductos.RowCount > 0)
            {
                producto.Id = Convert.ToInt32(DgvProductos.CurrentRow.Cells[0].Value);
                CboMarca.SelectedValue = DgvProductos.CurrentRow.Cells[2].Value;
                CboModelo.SelectedValue = DgvProductos.CurrentRow.Cells[3].Value;
                CboCategoria.SelectedValue = DgvProductos.CurrentRow.Cells[4].Value;
                TxtCodigoSku.Text = DgvProductos.CurrentRow.Cells[8].Value.ToString().Trim();
                TxtCodigoUpc.Text = DgvProductos.CurrentRow.Cells[9].Value.ToString().Trim();
                TxtTitulo.Text = DgvProductos.CurrentRow.Cells[11].Value.ToString().Trim();
                TxtCantidad.Text = DgvProductos.CurrentRow.Cells[12].Value.ToString().Trim();
                RtbCaracteristicas.Text = DgvProductos.CurrentRow.Cells[13].Value.ToString().Trim();
                TxtCoste.Text = DgvProductos.CurrentRow.Cells[14].Value.ToString().Trim();
                TxtMargen.Text = DgvProductos.CurrentRow.Cells[15].Value.ToString().Trim();
                TxtDescuento.Text = DgvProductos.CurrentRow.Cells[16].Value.ToString().Trim();
                TxtPVP.Text = DgvProductos.CurrentRow.Cells[17].Value.ToString().Trim();
                TxtIVA.Text = DgvProductos.CurrentRow.Cells[18].Value.ToString().Trim();
                TxtTotal.Text = DgvProductos.CurrentRow.Cells[19].Value.ToString().Trim();
                ImgProducto.Image = Image.FromStream(ByteImage());
            }
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
            PnlLista.Enabled = false;
            PnlDatos.Enabled = true;
            BtnExaminar.Enabled = true;
            BtnGuardar.Enabled = true;
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
                DgvLleno();
                producto.estado = EntityState.Vizualisar;
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Text = "";
            DgvProductos.DataSource = producto.FindById(TxtBuscar.Text);
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DgvProductos.DataSource = producto.FindById(TxtBuscar.Text);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCoste.Text!="0"&& TxtTotal.Text!="0")
                {
                    producto.IdModelo = Convert.ToInt32(CboModelo.SelectedValue);
                    producto.IdCategoria = Convert.ToInt32(CboCategoria.SelectedValue);
                    producto.SKU = calculo.SKU(CboCategoria.Text, CboMarca.Text, CboModelo.Text);
                    producto.Codigo_UPC = TxtCodigoUpc.Text;
                    producto.Titulo = TxtTitulo.Text.ToLower();
                    producto.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                    producto.Coste = float.Parse(TxtCoste.Text);
                    producto.Margen = float.Parse(TxtMargen.Text);
                    producto.Pvp = float.Parse(TxtPVP.Text);
                    producto.Descuento = float.Parse(TxtDescuento.Text);
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
                else
                {
                    MessageBox.Show("Llene todos los campos");
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
                PnlLista.Enabled = false;
                PnlDatos.Enabled = true;
                BtnEditar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;
                BtnExaminar.Enabled = true;
                BtnEditar.Enabled = false;
                BtnNuevo.Enabled = false;
                producto.estado = EntityState.Modificar;;
                Datos();
            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar");
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DgvProductos.SelectedRows.Count > 0)
                {
                    producto.estado = EntityState.Eliminar;
                    producto.Id = Convert.ToInt32(DgvProductos.CurrentRow.Cells[0].Value);
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
        private void TxtCoste_Leave(object sender, EventArgs e)
        {
            if (TxtCoste.Text!= "" && TxtMargen.Text != "")
            {
                    TxtMargen_Leave(sender, e);
            }
            else
            {
                TxtCoste.Text = "0";
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

            if (TxtDescuento.Text!="" && TxtMargen.Text !="")
            {
                decimal coste = Convert.ToDecimal(TxtCoste.Text);
                decimal margen = Convert.ToDecimal(TxtMargen.Text);
                decimal descuento = Convert.ToDecimal(TxtDescuento.Text);
                decimal total = Convert.ToDecimal(TxtTotal.Text);
                
                int cont=0;    
                    foreach (var item in calculo.ListaCalculo(margen, descuento,coste,total,idDato))
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

        private void TxtCodigoUpc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidarCampos.SoloNumeros(e);
        }

        private void TxtTotal_Leave(object sender, EventArgs e)
        { 
            TxtDescuento_Leave(sender,e);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (idDato)
            {
                idDato = false;
                limpiarContable();
                TxtTotal.Enabled = true;
                TxtMargen.Enabled = false;
                BtnCheck.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
                BtnCheck.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                idDato = true;
                TxtTotal.Text = "0";
                TxtMargen.Enabled = true;
                TxtDescuento_Leave(sender, e);
                TxtTotal.Enabled = false;
                
                BtnCheck.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
                BtnCheck.BackColor = System.Drawing.Color.MediumSeaGreen;
            }

        }
        private void CboListar()
        {
            Categoria categoria = new Categoria();
            categoria.ShowDialog();
            if (ClsCalculoDatos.banderaCat==true)
            {
                ListarCategorias();
                ClsCalculoDatos.banderaCat = false;
            }
            if (ClsCalculoDatos.banderaMa == true)
            {
                ListarMarca();
                ClsCalculoDatos.banderaMa = false;
            }
            if (ClsCalculoDatos.banderaMo == true)
            {
                ListarModelo(CboMarca.SelectedValue.ToString());
                ClsCalculoDatos.banderaMo = false;  
            }
            if (ClsCalculoDatos.valueCategoria!=null)
            {
                CboCategoria.SelectedValue = ClsCalculoDatos.valueCategoria;
            }
            if (ClsCalculoDatos.valueMarca != null)
            {
                CboMarca.SelectedValue = ClsCalculoDatos.valueMarca;
            }
            if (ClsCalculoDatos.valueModelo != null)
            {
                CboModelo.SelectedValue = ClsCalculoDatos.valueModelo;
            }
            
        }
        private void BtnCategoria_Click(object sender, EventArgs e)
        { 
            ClsCalculoDatos.caso = 1;
            CboListar();


        }
        private void BtnMarca_Click(object sender, EventArgs e)
        {
            ClsCalculoDatos.caso = 2;
            CboListar();
        }

        private void BtnModelo_Click(object sender, EventArgs e)
        {
            ClsCalculoDatos.caso = 3;
            CboListar();
        }
        private void BtnAtributos_Click(object sender, EventArgs e)
        {
            ClsCalculoDatos.banderaAt = true;
            ClsCalculoDatos.caso = 1;
            CboListar();
            ClsCalculoDatos.banderaAt = false;
        }



        private void CboCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboCategoria.SelectedIndex != 0)
                {
                    ClsCalculoDatos.valueCategoria = Convert.ToInt32(CboCategoria.SelectedValue);
                }
                
            }
            catch (Exception)
            {

               
            }

        }
        private void CboMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboMarca.SelectedIndex != 0)
                {
                    ClsCalculoDatos.valueMarca = Convert.ToInt32(CboMarca.SelectedValue);
                    ListarModelo(ClsCalculoDatos.valueMarca.ToString());
                    
                }
            }
            catch (Exception)
            {
                ListarModelo("0");
            }

        }

        private void CboModelo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboModelo.SelectedIndex != 0)
                {
                    ClsCalculoDatos.valueModelo = Convert.ToInt32(CboModelo.SelectedValue);
                }

            }
            catch (Exception)
            {


            }
        }
    }
}
