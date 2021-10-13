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
        public Categoria()
        {
            InitializeComponent();
        }
        private void Categoria_Load(object sender, EventArgs e)
        {
            ListaCategoria();
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
            Dispose();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public void botones()
        {
            TplTitulo.Enabled = false;
            BtnNuevo.Enabled = true;
            BtnGuardar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtCategoria.Text = "";
        }
        private void ListaCategoria()
        {
            try
            {
                DgvCategoria.DataSource = categoria.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TplTitulo.Enabled = true;
            BtnGuardar.Enabled = true;
            DgvCategoria.Enabled = false;
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnCancelar.Enabled = true;
            categoria.estado = EntityState.Agregar;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                categoria.Categoria = TxtCategoria.Text;
                bool valid = new Helps.ValidacionDatos(categoria).Validar();

                if (valid == true)
                {
                    string result = categoria.Guardar();
                    MessageBox.Show(result);
                    categoria.estado = EntityState.Vizualisar;
                    ListaCategoria();
                    botones();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "Escriba la categoria que desea registrar");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvCategoria.SelectedRows.Count > 0)
            {
                TplTitulo.Enabled = true;
                BtnEditar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnGuardar.Enabled = true;
                BtnEditar.Enabled = false;
                BtnNuevo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            botones();
        }


    }
}
