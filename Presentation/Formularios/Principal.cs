using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

///Importadas
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace Presentation
{
    public partial class Principal : Form
    {
        private IconButton BtnCurrent;
        private Panel BtnLeftBordes;
        private Form FormHijoActual;
        public Principal()
        {
            InitializeComponent();
            BtnLeftBordes = new Panel();
            BtnLeftBordes.Size = new Size(7, 40);
            PanelMenu.Controls.Add(BtnLeftBordes);
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            // fromulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Principal_Load(object sender, EventArgs e)
        {


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

        //struct
        private struct RGBColors
        {
            public static Color color0 = Color.FromArgb(173, 32, 74);
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(253, 190, 27);
            public static Color color8 = Color.FromArgb(149, 204, 202);
        }
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        //private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void BtnMaximisar_Click(object sender, EventArgs e)
        {
            {
                if (WindowState == FormWindowState.Normal)
                    this.WindowState = FormWindowState.Maximized;
                else
                    this.WindowState = FormWindowState.Normal;
            }   
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Salir!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Reset()
        {
            DesactivarBoton();
            BtnLeftBordes.Visible = false;
            IconEstado.IconChar = IconChar.Heartbeat;
            IconEstado.IconColor = Color.FromArgb(173, 32, 74);
            LblTitleChildForm.Text = "Bienvenido";
        }
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color0);
            AbrirFormHijo(new Inicio());
        }

        private void ActivarBoton(object BtnRemitente, Color color)
        {
            if (BtnRemitente != null)
            {
                DesactivarBoton();
                BtnCurrent = (IconButton)BtnRemitente;
                BtnCurrent.BackColor = Color.FromArgb(37, 36, 81);
                BtnCurrent.ForeColor = color;
                BtnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                BtnCurrent.IconColor = color;
                BtnCurrent.TextImageRelation = TextImageRelation.TextBeforeImage;
                BtnCurrent.ImageAlign = ContentAlignment.MiddleRight;
                //bordes de boton izquierdo
                BtnLeftBordes.BackColor = color;
                BtnLeftBordes.Location = new Point(0, BtnCurrent.Location.Y);
                BtnLeftBordes.Visible = true;
                BtnLeftBordes.BringToFront();
                //Current Child Form Icon
                IconEstado.IconChar = BtnCurrent.IconChar;
                IconEstado.IconColor = color;
            }
        }

        private void PtLogo_Click(object sender, EventArgs e)
        {
            if (FormHijoActual != null)
            {
                FormHijoActual.Close();
            }
            Reset();
        }

        private void DesactivarBoton()
        {
            if (BtnCurrent != null)
            {
                //CerrarMenu();
                BtnCurrent.BackColor = Color.FromArgb(20, 27, 32);
                BtnCurrent.ForeColor = Color.White;
                BtnCurrent.TextAlign = ContentAlignment.MiddleLeft;
                BtnCurrent.IconColor = Color.White;
                BtnCurrent.TextImageRelation = TextImageRelation.ImageBeforeText;
                BtnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void AbrirFormHijo(Form FrmHijo)
        {
            if (FormHijoActual != null)
            {
                FormHijoActual.Close();
            }
            FormHijoActual = FrmHijo;
            FrmHijo.TopLevel = false;
            FrmHijo.FormBorderStyle = FormBorderStyle.None;
            FrmHijo.Dock = DockStyle.Fill;
            PnlEscritorio.Controls.Add(FrmHijo);
            PnlEscritorio.Tag = FrmHijo;
            FrmHijo.BringToFront();
            FrmHijo.Show();
            LblTitleChildForm.Text = FrmHijo.Text;
        }


        private void BtnCarrito_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color2);
            AbrirFormHijo(new Ventas());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color3);
            AbrirFormHijo(new Productos());
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color5);
            AbrirFormHijo(new Compras());
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color6);
            AbrirFormHijo(new Empleados());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color7);
            AbrirFormHijo(new Clientes());
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color8);
            AbrirFormHijo(new Proveedores());
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color4);
            AbrirFormHijo(new Caja());
        }
    }
}
