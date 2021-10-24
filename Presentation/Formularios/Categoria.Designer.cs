
namespace Presentation
{
    partial class Categoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TplTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.CboMarca = new System.Windows.Forms.ComboBox();
            this.TxtMarca = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblTitleChildForm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlBarraTop = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.PnlLista = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSeleccionar = new FontAwesome.Sharp.IconButton();
            this.BtnModelo = new FontAwesome.Sharp.IconButton();
            this.BtnMarca = new FontAwesome.Sharp.IconButton();
            this.BtnCategoria = new FontAwesome.Sharp.IconButton();
            this.TplTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlBarraTop.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.PnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TplTitulo
            // 
            resources.ApplyResources(this.TplTitulo, "TplTitulo");
            this.TplTitulo.Controls.Add(this.CboMarca, 1, 0);
            this.TplTitulo.Controls.Add(this.TxtMarca, 0, 0);
            this.TplTitulo.Controls.Add(this.label5, 0, 1);
            this.TplTitulo.Controls.Add(this.TxtDescripcion, 1, 1);
            this.TplTitulo.Name = "TplTitulo";
            // 
            // CboMarca
            // 
            resources.ApplyResources(this.CboMarca, "CboMarca");
            this.CboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMarca.FormattingEnabled = true;
            this.CboMarca.Name = "CboMarca";
            // 
            // TxtMarca
            // 
            resources.ApplyResources(this.TxtMarca, "TxtMarca");
            this.TxtMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtMarca.Name = "TxtMarca";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Name = "label5";
            // 
            // TxtDescripcion
            // 
            resources.ApplyResources(this.TxtDescripcion, "TxtDescripcion");
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // LblTitleChildForm
            // 
            resources.ApplyResources(this.LblTitleChildForm, "LblTitleChildForm");
            this.LblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.LblTitleChildForm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblTitleChildForm.Name = "LblTitleChildForm";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.LblTitleChildForm);
            this.panel1.Controls.Add(this.TplTitulo);
            this.panel1.Name = "panel1";
            // 
            // PnlBarraTop
            // 
            this.PnlBarraTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            resources.ApplyResources(this.PnlBarraTop, "PnlBarraTop");
            this.PnlBarraTop.Controls.Add(this.BtnMinimizar);
            this.PnlBarraTop.Controls.Add(this.BtnCerrar);
            this.PnlBarraTop.Name = "PnlBarraTop";
            this.PnlBarraTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBarraTop_MouseDown);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            resources.ApplyResources(this.BtnMinimizar, "BtnMinimizar");
            this.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Image = global::Presentation.Properties.Resources.Minimize;
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            resources.ApplyResources(this.BtnCerrar, "BtnCerrar");
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Image = global::Presentation.Properties.Resources.Close;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PnlMenu
            // 
            resources.ApplyResources(this.PnlMenu, "PnlMenu");
            this.PnlMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlMenu.Controls.Add(this.BtnCancelar);
            this.PnlMenu.Controls.Add(this.BtnEliminar);
            this.PnlMenu.Controls.Add(this.BtnEditar);
            this.PnlMenu.Controls.Add(this.BtnGuardar);
            this.PnlMenu.Controls.Add(this.BtnNuevo);
            this.PnlMenu.Name = "PnlMenu";
            // 
            // BtnCancelar
            // 
            resources.ApplyResources(this.BtnCancelar, "BtnCancelar");
            this.BtnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 30;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEliminar
            // 
            resources.ApplyResources(this.BtnEliminar, "BtnEliminar");
            this.BtnEliminar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 30;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            resources.ApplyResources(this.BtnEditar, "BtnEditar");
            this.BtnEditar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 30;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardar
            // 
            resources.ApplyResources(this.BtnGuardar, "BtnGuardar");
            this.BtnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 30;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnNuevo
            // 
            resources.ApplyResources(this.BtnNuevo, "BtnNuevo");
            this.BtnNuevo.BackColor = System.Drawing.Color.Teal;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.BtnNuevo.IconColor = System.Drawing.Color.White;
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevo.IconSize = 30;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // PnlLista
            // 
            resources.ApplyResources(this.PnlLista, "PnlLista");
            this.PnlLista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlLista.Controls.Add(this.label11);
            this.PnlLista.Controls.Add(this.TxtBuscar);
            this.PnlLista.Controls.Add(this.DgvDatos);
            this.PnlLista.Name = "PnlLista";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Name = "label11";
            // 
            // TxtBuscar
            // 
            resources.ApplyResources(this.TxtBuscar, "TxtBuscar");
            this.TxtBuscar.BackColor = System.Drawing.Color.White;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // DgvDatos
            // 
            this.DgvDatos.AllowUserToAddRows = false;
            this.DgvDatos.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.DgvDatos, "DgvDatos");
            this.DgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.DgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDatos.EnableHeadersVisualStyles = false;
            this.DgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.DgvDatos.MultiSelect = false;
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.ReadOnly = true;
            this.DgvDatos.RowHeadersVisible = false;
            this.DgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.BtnSeleccionar);
            this.panel2.Controls.Add(this.BtnModelo);
            this.panel2.Controls.Add(this.BtnMarca);
            this.panel2.Controls.Add(this.BtnCategoria);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // BtnSeleccionar
            // 
            resources.ApplyResources(this.BtnSeleccionar, "BtnSeleccionar");
            this.BtnSeleccionar.BackColor = System.Drawing.Color.Plum;
            this.BtnSeleccionar.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.BtnSeleccionar.IconColor = System.Drawing.Color.White;
            this.BtnSeleccionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSeleccionar.IconSize = 40;
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnModelo
            // 
            this.BtnModelo.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.BtnModelo, "BtnModelo");
            this.BtnModelo.FlatAppearance.BorderSize = 0;
            this.BtnModelo.ForeColor = System.Drawing.Color.White;
            this.BtnModelo.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.BtnModelo.IconColor = System.Drawing.Color.White;
            this.BtnModelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnModelo.IconSize = 50;
            this.BtnModelo.Name = "BtnModelo";
            this.BtnModelo.UseVisualStyleBackColor = false;
            this.BtnModelo.Click += new System.EventHandler(this.BtnModelo_Click);
            // 
            // BtnMarca
            // 
            this.BtnMarca.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.BtnMarca, "BtnMarca");
            this.BtnMarca.FlatAppearance.BorderSize = 0;
            this.BtnMarca.ForeColor = System.Drawing.Color.White;
            this.BtnMarca.IconChar = FontAwesome.Sharp.IconChar.Artstation;
            this.BtnMarca.IconColor = System.Drawing.Color.White;
            this.BtnMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMarca.IconSize = 50;
            this.BtnMarca.Name = "BtnMarca";
            this.BtnMarca.UseVisualStyleBackColor = false;
            this.BtnMarca.Click += new System.EventHandler(this.BtnMarca_Click);
            // 
            // BtnCategoria
            // 
            this.BtnCategoria.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.BtnCategoria, "BtnCategoria");
            this.BtnCategoria.FlatAppearance.BorderSize = 0;
            this.BtnCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnCategoria.IconChar = FontAwesome.Sharp.IconChar.BezierCurve;
            this.BtnCategoria.IconColor = System.Drawing.Color.White;
            this.BtnCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCategoria.IconSize = 50;
            this.BtnCategoria.Name = "BtnCategoria";
            this.BtnCategoria.UseVisualStyleBackColor = false;
            this.BtnCategoria.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // Categoria
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlLista);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlBarraTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categoria";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.TplTitulo.ResumeLayout(false);
            this.TplTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlBarraTop.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TplTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblTitleChildForm;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel PnlBarraTop;
        internal System.Windows.Forms.Button BtnMinimizar;
        internal System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel PnlMenu;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private System.Windows.Forms.Panel PnlLista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.Label TxtMarca;
        private System.Windows.Forms.ComboBox CboMarca;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnModelo;
        private FontAwesome.Sharp.IconButton BtnMarca;
        private FontAwesome.Sharp.IconButton BtnCategoria;
        private FontAwesome.Sharp.IconButton BtnSeleccionar;
    }
}