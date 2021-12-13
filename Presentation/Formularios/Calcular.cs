using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentation.Formularios
{
    public partial class Calcular : Form
    {
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
                    TxtCantidad.Text,
                    TxtPrecio.Text,
                    TxtFlete.Text,
                    TxtGasto1.Text,
                    TxtGasto2.Text,
                    TxtGasto3.Text,
                };
        }
    }
}
