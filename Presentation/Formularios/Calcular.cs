using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentation
{
    public partial class Calcular : Form
    {
        private ClsCamposVacios vacio= new ClsCamposVacios();
        private ClsCalculoCoste calculo = new ClsCalculoCoste();
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
            TxtBuscar.Clear();
        }
    }
}
