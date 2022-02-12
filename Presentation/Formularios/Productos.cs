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
using FontAwesome.Sharp;
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
        private int idNum = 0;
        private int idTipo = 1;
        private IconButton BtnCurrent;
        public Productos()
        {
            InitializeComponent();
        }
        private void Productos_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            ListarMarca();
            ListaProducto();
            Combo();
            BtnTitulo_Click(sender,e);
            BtnPVP_Click(sender, e);
            DgvProductos.Columns[0].Visible = false;
            DgvProductos.Columns[2].Visible = false;
            DgvProductos.Columns[3].Visible = false;
            DgvProductos.Columns[4].Visible = false;
            DgvProductos.Columns[12].Visible = false;
        }
        private void Combo()
        {
            CboCategoria.SelectedValue = -1;
            CboMarca.SelectedValue = -1;
            CboModelo.SelectedValue = -1;
        }
        private void DgvLleno()
        {
            if (DgvProductos.RowCount != 0)
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
        private void ListaProducto()
        {
            try
            {
                DgvProductos.DataSource = producto.GetAll();
                DgvLleno();
            }
            catch (Exception )
            {
            }

        }
        private void ListarCategorias()
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
        private void DesactivarBoton()
        {
            if (BtnCurrent != null)
            {
                BtnCurrent.BackColor = Color.SlateGray;
                BtnCurrent.ForeColor = Color.White;
                BtnCurrent.IconColor = Color.White;
            }
        }

        private void ActivarBoton(object BtnRemitente, Color color)
        {
            if (BtnRemitente != null)
            {
                DesactivarBoton();
                BtnCurrent = (IconButton)BtnRemitente;
                BtnCurrent.BackColor = Color.DodgerBlue;
                BtnCurrent.ForeColor = color;
                BtnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                BtnCurrent.IconColor = color;
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
            NupCantidad.Text = "0";
            TxtTitulo.Clear();
            ListarModelo("0");
            limpiarContable();
            RtbCaracteristicas.Clear();
            TxtCoste.Text = "00";
            ClsCalculoDatos.valueCategoria=null;
            ClsCalculoDatos.valueMarca=null;
            ClsCalculoDatos.valueModelo=null;
            if (CboCategoria.Items.Count != 0)
            {
                CboCategoria.SelectedValue= -1;
            }
            if (CboMarca.Items.Count != 0)
            {
                CboMarca.SelectedValue = -1;
            }

        }
        public void limpiarContable()
        {
            TxtUtilidad.Text="00";
            MTXTDescuento.Text = "00";
            TxtIVA.Text = "00";
            MTXTMargen.Text = "20";
            TxtPVP.Text = "00";
            TxtTotal.Text = "00";
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
                TxtTitulo.Text = DgvProductos.CurrentRow.Cells[10].Value.ToString().Trim();
                NupCantidad.Text = DgvProductos.CurrentRow.Cells[11].Value.ToString().Trim();
                RtbCaracteristicas.Text = DgvProductos.CurrentRow.Cells[12].Value.ToString().Trim();
                TxtCoste.Text = DgvProductos.CurrentRow.Cells[13].Value.ToString().Trim();
                MTXTMargen.Text = DgvProductos.CurrentRow.Cells[14].Value.ToString().Trim();
                MTXTDescuento.Text = DgvProductos.CurrentRow.Cells[15].Value.ToString().Trim();
                TxtUtilidad.Text = DgvProductos.CurrentRow.Cells[16].Value.ToString().Trim();
                TxtPVP.Text = DgvProductos.CurrentRow.Cells[17].Value.ToString().Trim();
                TxtIVA.Text = DgvProductos.CurrentRow.Cells[18].Value.ToString().Trim();
                TxtTotal.Text = DgvProductos.CurrentRow.Cells[19].Value.ToString().Trim();
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            PnlLista.Enabled = false;
            PnlDatos.Enabled = true;
            BtnPVP.Enabled = true;
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
            if (MessageBox.Show("¿Está seguro de cancelar, se perdera todos los datos ingresados?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            DgvProductos.DataSource = producto.FindById(idTipo, TxtBuscar.Text);

        }
        private void Buscar()
        {
            DgvProductos.DataSource = producto.FindById(idTipo, TxtBuscar.Text);
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Buscar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TxtCoste.Text) != 0)
                {
                    producto.IdModelo = Convert.ToInt32(CboModelo.SelectedValue);
                    producto.IdCategoria = Convert.ToInt32(CboCategoria.SelectedValue);
                    producto.SKU = calculo.SKU(CboCategoria.Text, CboMarca.Text, CboModelo.Text);
                    producto.UPC= TxtCodigoUpc.Text;
                    producto.Titulo = TxtTitulo.Text.ToLower();
                    producto.Cantidad = Convert.ToInt32(NupCantidad.Text);
                    producto.Coste = decimal.Parse(TxtCoste.Text);
                    producto.Margen = Convert.ToInt32(MTXTMargen.Text.Substring(0,2));
                    producto.Pvp = decimal.Parse(TxtPVP.Text);
                    producto.Descuento = Convert.ToInt32(MTXTDescuento.Text.Substring(0, 2));
                    producto.Utilidad = decimal.Parse(TxtUtilidad.Text);
                    if (idNum > 0 && TxtTotal.Text != "0")
                    {
                        producto.Iva = decimal.Parse(TxtIVA.Text);
                        producto.Total = decimal.Parse(TxtTotal.Text);
                    }
                    else
                    {
                        producto.Iva = 0;
                        producto.Total=0;
                    }

                    producto.Caracteristicas = RtbCaracteristicas.Text;
                    bool valid = new Helps.ValidacionDatos(producto).Validar();
                    if (valid == true)
                    {
                        string result = producto.Guardar();
                        if (ModeloProducto.ban != false)
                        {
                            MessageBox.Show(result, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            producto.estado = EntityState.Vizualisar;
                            ListaProducto();
                            limpiar();
                            botones();
                        }
                        else
                        {
                            ModeloProducto.ban = true; 
                            MessageBox.Show(result, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("LLene todos lo campos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Llene todos los campos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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
                BtnPVP.Enabled = true;
                BtnEditar.Enabled = false;
                BtnNuevo.Enabled = false;
                producto.estado = EntityState.Modificar;
                Datos();
            }
            else
            {
                MessageBox.Show("Selecciones la fila a Editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (DgvProductos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    producto.estado = EntityState.Eliminar;
                    producto.Id = Convert.ToInt32(DgvProductos.CurrentRow.Cells[0].Value);
                    string result = producto.Guardar();
                    MessageBox.Show(result,"Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaProducto();
                }
            }
            else
            {
                MessageBox.Show("Selecciones la fila a Eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Datos();
        }
        private void TxtCoste_Leave(object sender, EventArgs e)
        {
            if (TxtCoste.Text!= "" && MTXTMargen.Text !=null)
            {
                    MTXTMargen_Leave(sender, e);
            }
            else
            {
                TxtCoste.Text = "00";
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
            MTXTDescuento_Leave(sender,e);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            activated(TxtTotal, BtnCheck, sender, e);

        }
        private void CboListar()
        {
            Categoria categoria = new Categoria();
            categoria.ShowDialog();

            if (ClsCalculoDatos.edit == true && ModeloCategoria.banderaCat == true || ModeloMarca.banderaMa == true || ModeloModelo.banderaMo == true)
            {
                ListaProducto();
            }

            if (ModeloCategoria.banderaCat==true)
            {
                ListarCategorias();
                ModeloCategoria.banderaCat = false;
            }
            if (ModeloMarca.banderaMa == true)
            {
                ListarMarca();
                ModeloMarca.banderaMa = false;
            }

            if (ModeloModelo.banderaMo == true && ClsCalculoDatos.valueMarca!=null)
            {
                try
                {
                    ListarModelo(CboMarca.SelectedValue.ToString());
                }
                catch (Exception)
                {
                    ListarModelo("0");
                }
                ModeloModelo.banderaMo = false;  
            }
            if (ClsCalculoDatos.valueCategoria!=null)
            {
                CboCategoria.SelectedValue = ClsCalculoDatos.valueCategoria;
            }else
            {
                CboCategoria.SelectedValue = -1;
            }
            if (ClsCalculoDatos.valueMarca != null)
            {
                
                CboMarca.SelectedValue = ClsCalculoDatos.valueMarca;
            }
            else
            {
                CboMarca.SelectedValue = -1;
            }
            if (ClsCalculoDatos.valueModelo != null)
            {
                CboModelo.SelectedValue = ClsCalculoDatos.valueModelo;
            }
            else
            {
                CboModelo.SelectedValue = -1;
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
                if (CboCategoria.Items.Count!= 0 && CboCategoria.SelectedIndex != 0)
                {
                    ClsCalculoDatos.valueCategoria = Convert.ToInt32(CboCategoria.SelectedValue);
                }
        }
        private void CboMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboMarca.Items.Count != 0 && CboMarca.SelectedIndex != -1)
                {
                    ClsCalculoDatos.valueMarca = Convert.ToInt32(CboMarca.SelectedValue);
                    ListarModelo(ClsCalculoDatos.valueMarca.ToString());
                    CboModelo.SelectedValue = -1;
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
                if (CboModelo.SelectedIndex != -1)
                {
                    ClsCalculoDatos.valueModelo = Convert.ToInt32(CboModelo.SelectedValue);
                }

            }
            catch (Exception)
            {


            }
        }

        private void BtnTitulo_Click(object sender, EventArgs e)
        {
            ActivarBoton(BtnTitulo, Color.White);
            idTipo = 1;
            BtnLimpiar_Click(sender,e);
        }

        private void BtnCodSku_Click(object sender, EventArgs e)
        {
            ActivarBoton(BtnCodSku, Color.White);
            idTipo = 2;
            BtnLimpiar_Click(sender, e);
        }

        private void BtnCat_Click(object sender, EventArgs e)
        {
            ActivarBoton(BtnCat, Color.White);
            idTipo = 3;
            BtnLimpiar_Click(sender, e);
        }

        private void BtnMa_Click(object sender, EventArgs e)
        {
            ActivarBoton(BtnMa, Color.White);
            idTipo = 4;
            BtnLimpiar_Click(sender, e);
        
        }

        private void BtnMo_Click(object sender, EventArgs e)
        {
            ActivarBoton(BtnMo, Color.White);
            idTipo = 5;
            BtnLimpiar_Click(sender, e);
        }

        private void BtnCodBarra_Click(object sender, EventArgs e)
        {
            ActivarBoton(BtnCodBarra, Color.White);
            idTipo = 6;
            BtnLimpiar_Click(sender, e);
        }

        private void BtnCoste_Click(object sender, EventArgs e)
        {
            Calcular calculo = new Calcular();
            calculo.ShowDialog();
            TxtCoste.Text = ClsCalculoCoste.cost;
            TxtCoste_Leave(sender,e);
        }

        private void MTXTMargen_Leave(object sender, EventArgs e)
        {
            if (MTXTMargen!=null && MTXTDescuento.Text != null)
            {
                MTXTDescuento_Leave(sender, e);

            }
            else
            {
                MTXTMargen.Text = "20";
                MTXTMargen_Leave(sender, e);
            }
        }

        private void MTXTDescuento_Leave(object sender, EventArgs e)
        {

            if (MTXTDescuento.Text != null && MTXTMargen.Text != null)
            {
                decimal coste = Convert.ToDecimal(TxtCoste.Text);
                decimal pvp1 = Convert.ToDecimal(TxtPVP.Text);
                decimal margen = Convert.ToDecimal(MTXTMargen.Text.Substring(0,2));
                decimal descuento = Convert.ToDecimal(MTXTDescuento.Text.Substring(0,2));
                decimal total = Convert.ToDecimal(TxtTotal.Text);

                int cont = 0;
                foreach (var item in calculo.ListaCalculo(idNum,margen, descuento, coste,pvp1, total, idDato))
                {
                    if (cont == 0)
                    {
                        MTXTDescuento.Text = item;
                    }
                    if (cont == 1)
                    {
                        TxtPVP.Text = item;
                    }
                    if (cont == 2)
                    {
                        TxtIVA.Text = item;
                    }
                    if (cont == 3)
                    {
                        TxtTotal.Text = item;
                    }
                    if (cont == 4)
                    {
                        TxtUtilidad.Text = item;
                    }
                    if (cont == 5 && idDato==false)
                    {
                        MTXTMargen.Text = item;
                    }
                    cont++;
                }
            }
            else if (MTXTDescuento.Text == null)
            {
                MTXTDescuento.Text = "00";
                MTXTDescuento_Leave(sender, e);
            }
        }
        private void activated(TextBox txt, IconButton boton, object sender, EventArgs e)
        {
            if (idDato)
            {
                idDato = false;
                limpiarContable();
                txt.Enabled = true;
                MTXTMargen.Enabled = false;
                MTXTMargen.Text = "00";
                boton.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
                boton.BackColor = System.Drawing.Color.Firebrick;
            }
            else
            {
                idDato = true;
                txt.Text = "00";
                MTXTMargen.Enabled = true;
                MTXTMargen.Text = "20";
                MTXTDescuento_Leave(sender, e);
                txt.Enabled = false;
                boton.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
                boton.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
        }
        private void BtnCheckPvp_Click(object sender, EventArgs e)
        {
            activated(TxtPVP, BtnCheckPvp, sender, e);
        }

        private void BtnPVP_Click(object sender, EventArgs e)
        {
            BtnPVP.BackColor = Color.DodgerBlue;
            BtnIvaTotal.BackColor = Color.SlateGray;
            idNum = 0;
            LblIva.Visible=false;
            LblTotal.Visible=false;
            TxtIVA.Visible = false;
            TxtTotal.Visible = false;
            TxtTotal.Enabled = false;
            TxtIVA.Enabled = false;
            BtnCheck.Enabled = false;
            BtnCheck.Visible = false;
            BtnCheckPvp.Enabled = true;
            BtnCheckPvp.Visible = true;
            if (!idDato)
            {
                BtnCheck_Click(sender, e);
            }
            if (Convert.ToDecimal(TxtPVP.Text)!=0)
            {
                MTXTDescuento_Leave(sender, e);
            }
        }

        private void BtnIvaTotal_Click(object sender, EventArgs e)
        {
            BtnIvaTotal.BackColor = Color.DodgerBlue;
            BtnPVP.BackColor = Color.SlateGray;
            idNum = 1;
            LblIva.Visible = true;
            LblTotal.Visible = true;
            TxtIVA.Visible = true;
            TxtTotal.Visible = true;
            BtnCheck.Enabled = true;
            BtnCheck.Visible = true;
            BtnCheckPvp.Enabled = false;
            BtnCheckPvp.Visible = false;
            if (!idDato)
            {
                BtnCheckPvp_Click(sender, e);
            }
            if (Convert.ToDecimal(TxtPVP.Text) != 0)
            {
                MTXTDescuento_Leave(sender, e);
            }

        }

        private void TxtPVP_Leave(object sender, EventArgs e)
        {
            MTXTDescuento_Leave(sender, e);
        }
    }
}
