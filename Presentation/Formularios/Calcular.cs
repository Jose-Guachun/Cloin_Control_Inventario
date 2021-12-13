using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using FontAwesome.Sharp;

namespace Presentation
{
    public partial class Calcular : Form
    {
        private ClsCamposVacios vacio= new ClsCamposVacios();
        private ClsCalculoCoste calculo = new ClsCalculoCoste();
        private IconButton BtnCurrent;
        public Calcular()
        {
            InitializeComponent();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PnlBarraTop_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PnlBarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void ActivarBoton(object BtnRemitente)
        {
            if (BtnRemitente != null)
            {
                BtnCurrent = (IconButton)BtnRemitente;
                BtnCurrent.IconChar = FontAwesome.Sharp.IconChar.Plus;
                BtnCurrent.BackColor = System.Drawing.Color.MediumSeaGreen;
            }
        }
        private void DesactivarBoton(object BtnRemitente)
        {
            if (BtnRemitente != null)
            {
                BtnCurrent = (IconButton)BtnRemitente;
                BtnCurrent.IconChar = FontAwesome.Sharp.IconChar.Line;
                BtnCurrent.BackColor = System.Drawing.Color.Firebrick;
            }
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
                
                List<string> listCalculo = new List<string>()
                {
                    vacio.CampoVacio(lblCantidad.Text,TxtCantidad.Text),
                    vacio.CampoVacio(lblPrecio.Text,TxtPrecio.Text),
                    vacio.CampoVacio(lblFlete.Text,TxtFlete.Text),
                    vacio.CampoVacio(lblGasto1.Text,TxtGasto1.Text),
                    vacio.CampoVacio(lblGasto2.Text,TxtGasto2.Text),
                    vacio.CampoVacio(lblGasto3.Text,TxtGasto3.Text),
                };
            LblCoste.Text = calculo.Coste(listCalculo).ToString();

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            ClsCalculoCoste.cost = LblCoste.Text;
            Dispose();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCantidad.Clear();
            TxtFlete.Clear();
            TxtPrecio.Clear();
            TxtGasto1.Clear();
            TxtGasto2.Clear();
            TxtGasto3.Clear();
        }

        private void BtnAddIva_Click(object sender, EventArgs e)
        {
            if (ClsCalculoCoste.PIVa)
            {
                lblPrecio.Text = "Precio sin iva";
                ClsCalculoCoste.PIVa = false;
                BtnAddIva.IconChar = FontAwesome.Sharp.IconChar.Plus;
                BtnAddIva.BackColor = System.Drawing.Color.SeaGreen;
                
            }
            else
            {
                lblPrecio.Text = "Precio con iva";
                ClsCalculoCoste.PIVa = true;
                BtnAddIva.IconChar = FontAwesome.Sharp.IconChar.GripHorizontal;
                BtnAddIva.BackColor = System.Drawing.Color.Firebrick;
            }

            

        }

        private void BtnAddIvaF_Click(object sender, EventArgs e)
        {
            if (ClsCalculoCoste.FIVa)
            {
                lblFlete.Text = "Flete sin iva";
                ClsCalculoCoste.FIVa = false;
                BtnAddIvaF.IconChar = FontAwesome.Sharp.IconChar.Plus;
                BtnAddIvaF.BackColor = System.Drawing.Color.SeaGreen;

            }
            else
            {
                lblFlete.Text = "Flete con iva";
                ClsCalculoCoste.FIVa = true;
                BtnAddIvaF.IconChar = FontAwesome.Sharp.IconChar.GripHorizontal;
                BtnAddIvaF.BackColor = System.Drawing.Color.Firebrick;
            }
        }
    }
}
