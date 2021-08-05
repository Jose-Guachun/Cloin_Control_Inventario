
namespace Presentation
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlEscritorio = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlBarraTop = new System.Windows.Forms.Panel();
            this.IconEstado = new FontAwesome.Sharp.IconPictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.BtnMaximisar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.LblTitleChildForm = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnEmpleados = new FontAwesome.Sharp.IconButton();
            this.BtnProveedor = new FontAwesome.Sharp.IconButton();
            this.BtnCompras = new FontAwesome.Sharp.IconButton();
            this.BtnVentas = new FontAwesome.Sharp.IconButton();
            this.BtnProductos = new FontAwesome.Sharp.IconButton();
            this.BtnCarrito = new FontAwesome.Sharp.IconButton();
            this.BtnInicio = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PtLogo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.LblE_mail = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.PnlPrincipal.SuspendLayout();
            this.PnlEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlBarraTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconEstado)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtLogo)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.PnlPrincipal.Controls.Add(this.PnlEscritorio);
            this.PnlPrincipal.Controls.Add(this.PnlBarraTop);
            this.PnlPrincipal.Controls.Add(this.PanelMenu);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1280, 720);
            this.PnlPrincipal.TabIndex = 0;
            // 
            // PnlEscritorio
            // 
            this.PnlEscritorio.Controls.Add(this.pictureBox1);
            this.PnlEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlEscritorio.Location = new System.Drawing.Point(230, 82);
            this.PnlEscritorio.Name = "PnlEscritorio";
            this.PnlEscritorio.Size = new System.Drawing.Size(1050, 638);
            this.PnlEscritorio.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Presentation.Properties.Resources.cloinsin_fondo_con_letras;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1050, 638);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlBarraTop
            // 
            this.PnlBarraTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.PnlBarraTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlBarraTop.Controls.Add(this.IconEstado);
            this.PnlBarraTop.Controls.Add(this.lblFecha);
            this.PnlBarraTop.Controls.Add(this.BtnMaximisar);
            this.PnlBarraTop.Controls.Add(this.lblHora);
            this.PnlBarraTop.Controls.Add(this.LblTitleChildForm);
            this.PnlBarraTop.Controls.Add(this.BtnSalir);
            this.PnlBarraTop.Controls.Add(this.BtnMinimizar);
            this.PnlBarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraTop.Location = new System.Drawing.Point(230, 0);
            this.PnlBarraTop.Margin = new System.Windows.Forms.Padding(2);
            this.PnlBarraTop.Name = "PnlBarraTop";
            this.PnlBarraTop.Size = new System.Drawing.Size(1050, 82);
            this.PnlBarraTop.TabIndex = 1;
            this.PnlBarraTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBarraTop_MouseDown);
            // 
            // IconEstado
            // 
            this.IconEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.IconEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(32)))), ((int)(((byte)(74)))));
            this.IconEstado.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.IconEstado.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(32)))), ((int)(((byte)(74)))));
            this.IconEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconEstado.IconSize = 42;
            this.IconEstado.Location = new System.Drawing.Point(28, 34);
            this.IconEstado.Name = "IconEstado";
            this.IconEstado.Size = new System.Drawing.Size(44, 42);
            this.IconEstado.TabIndex = 32;
            this.IconEstado.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(872, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 16);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // BtnMaximisar
            // 
            this.BtnMaximisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BtnMaximisar.BackgroundImage = global::Presentation.Properties.Resources.maximize3;
            this.BtnMaximisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMaximisar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnMaximisar.FlatAppearance.BorderSize = 0;
            this.BtnMaximisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnMaximisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnMaximisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximisar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMaximisar.Location = new System.Drawing.Point(993, 0);
            this.BtnMaximisar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMaximisar.Name = "BtnMaximisar";
            this.BtnMaximisar.Size = new System.Drawing.Size(29, 29);
            this.BtnMaximisar.TabIndex = 30;
            this.BtnMaximisar.UseVisualStyleBackColor = false;
            this.BtnMaximisar.Click += new System.EventHandler(this.BtnMaximisar_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(951, 34);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(96, 25);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "00:00:00";
            // 
            // LblTitleChildForm
            // 
            this.LblTitleChildForm.AutoSize = true;
            this.LblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.LblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.LblTitleChildForm.Location = new System.Drawing.Point(68, 47);
            this.LblTitleChildForm.Name = "LblTitleChildForm";
            this.LblTitleChildForm.Size = new System.Drawing.Size(91, 20);
            this.LblTitleChildForm.TabIndex = 7;
            this.LblTitleChildForm.Text = "Bienvenido";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSalir.Image = global::Presentation.Properties.Resources.Close;
            this.BtnSalir.Location = new System.Drawing.Point(1022, 0);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(29, 29);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Image = global::Presentation.Properties.Resources.Minimize;
            this.BtnMinimizar.Location = new System.Drawing.Point(963, 0);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(29, 29);
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.PanelMenu.Controls.Add(this.BtnClientes);
            this.PanelMenu.Controls.Add(this.BtnEmpleados);
            this.PanelMenu.Controls.Add(this.BtnProveedor);
            this.PanelMenu.Controls.Add(this.BtnCompras);
            this.PanelMenu.Controls.Add(this.BtnVentas);
            this.PanelMenu.Controls.Add(this.BtnProductos);
            this.PanelMenu.Controls.Add(this.BtnCarrito);
            this.PanelMenu.Controls.Add(this.BtnInicio);
            this.PanelMenu.Controls.Add(this.panel3);
            this.PanelMenu.Controls.Add(this.panel4);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(230, 720);
            this.PanelMenu.TabIndex = 1;
            // 
            // BtnClientes
            // 
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.Silver;
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.BtnClientes.IconColor = System.Drawing.Color.White;
            this.BtnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClientes.IconSize = 32;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 405);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnClientes.Size = new System.Drawing.Size(230, 40);
            this.BtnClientes.TabIndex = 16;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.ForeColor = System.Drawing.Color.Silver;
            this.BtnEmpleados.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.BtnEmpleados.IconColor = System.Drawing.Color.White;
            this.BtnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEmpleados.IconSize = 32;
            this.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleados.Location = new System.Drawing.Point(0, 365);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnEmpleados.Size = new System.Drawing.Size(230, 40);
            this.BtnEmpleados.TabIndex = 15;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProveedor.FlatAppearance.BorderSize = 0;
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedor.ForeColor = System.Drawing.Color.Silver;
            this.BtnProveedor.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.BtnProveedor.IconColor = System.Drawing.Color.White;
            this.BtnProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProveedor.IconSize = 32;
            this.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.Location = new System.Drawing.Point(0, 325);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnProveedor.Size = new System.Drawing.Size(230, 40);
            this.BtnProveedor.TabIndex = 14;
            this.BtnProveedor.Text = "Proveedores";
            this.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProveedor.UseVisualStyleBackColor = true;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedores_Click);
            // 
            // BtnCompras
            // 
            this.BtnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompras.FlatAppearance.BorderSize = 0;
            this.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompras.ForeColor = System.Drawing.Color.Silver;
            this.BtnCompras.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.BtnCompras.IconColor = System.Drawing.Color.White;
            this.BtnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCompras.IconSize = 32;
            this.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.Location = new System.Drawing.Point(0, 285);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCompras.Size = new System.Drawing.Size(230, 40);
            this.BtnCompras.TabIndex = 13;
            this.BtnCompras.Text = "Compras";
            this.BtnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompras.UseVisualStyleBackColor = true;
            this.BtnCompras.Click += new System.EventHandler(this.BtnCompras_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.Silver;
            this.BtnVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.BtnVentas.IconColor = System.Drawing.Color.White;
            this.BtnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVentas.IconSize = 32;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(0, 245);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnVentas.Size = new System.Drawing.Size(230, 40);
            this.BtnVentas.TabIndex = 12;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.Color.Silver;
            this.BtnProductos.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.BtnProductos.IconColor = System.Drawing.Color.White;
            this.BtnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProductos.IconSize = 32;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(0, 205);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnProductos.Size = new System.Drawing.Size(230, 40);
            this.BtnProductos.TabIndex = 11;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnCarrito
            // 
            this.BtnCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCarrito.FlatAppearance.BorderSize = 0;
            this.BtnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarrito.ForeColor = System.Drawing.Color.Silver;
            this.BtnCarrito.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.BtnCarrito.IconColor = System.Drawing.Color.White;
            this.BtnCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCarrito.IconSize = 32;
            this.BtnCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCarrito.Location = new System.Drawing.Point(0, 165);
            this.BtnCarrito.Name = "BtnCarrito";
            this.BtnCarrito.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCarrito.Size = new System.Drawing.Size(230, 40);
            this.BtnCarrito.TabIndex = 10;
            this.BtnCarrito.Text = "Carrito";
            this.BtnCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCarrito.UseVisualStyleBackColor = true;
            this.BtnCarrito.Click += new System.EventHandler(this.BtnCarrito_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.Silver;
            this.BtnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.BtnInicio.IconColor = System.Drawing.Color.White;
            this.BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInicio.IconSize = 32;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(0, 125);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnInicio.Size = new System.Drawing.Size(230, 40);
            this.BtnInicio.TabIndex = 8;
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PtLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 125);
            this.panel3.TabIndex = 40;
            // 
            // PtLogo
            // 
            this.PtLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.PtLogo.BackgroundImage = global::Presentation.Properties.Resources.cloinsin_fondo_con_letras;
            this.PtLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PtLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PtLogo.Image = global::Presentation.Properties.Resources.cloinsin_fondo_con_letras;
            this.PtLogo.Location = new System.Drawing.Point(0, 0);
            this.PtLogo.Name = "PtLogo";
            this.PtLogo.Size = new System.Drawing.Size(230, 125);
            this.PtLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtLogo.TabIndex = 1;
            this.PtLogo.TabStop = false;
            this.PtLogo.Click += new System.EventHandler(this.PtLogo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.iconPictureBox1);
            this.panel4.Controls.Add(this.LblE_mail);
            this.panel4.Controls.Add(this.LblTipo);
            this.panel4.Controls.Add(this.LblNombre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 611);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 109);
            this.panel4.TabIndex = 17;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Snow;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Snow;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 103;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(103, 109);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.UseGdi = true;
            // 
            // LblE_mail
            // 
            this.LblE_mail.AutoSize = true;
            this.LblE_mail.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblE_mail.ForeColor = System.Drawing.Color.White;
            this.LblE_mail.Location = new System.Drawing.Point(118, 61);
            this.LblE_mail.Name = "LblE_mail";
            this.LblE_mail.Size = new System.Drawing.Size(40, 15);
            this.LblE_mail.TabIndex = 4;
            this.LblE_mail.Text = "E_mail";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.ForeColor = System.Drawing.Color.White;
            this.LblTipo.Location = new System.Drawing.Point(118, 46);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(38, 15);
            this.LblTipo.TabIndex = 3;
            this.LblTipo.Text = "Cargo";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(118, 31);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(55, 15);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombres";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.PnlPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Principal";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlEscritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlBarraTop.ResumeLayout(false);
            this.PnlBarraTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconEstado)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtLogo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblE_mail;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Panel PnlBarraTop;
        private System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.Button BtnMaximisar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label LblTitleChildForm;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Button BtnMinimizar;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private FontAwesome.Sharp.IconButton BtnEmpleados;
        private FontAwesome.Sharp.IconButton BtnCompras;
        private FontAwesome.Sharp.IconButton BtnVentas;
        private FontAwesome.Sharp.IconButton BtnProductos;
        private FontAwesome.Sharp.IconButton BtnCarrito;
        private FontAwesome.Sharp.IconButton BtnProveedor;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private System.Windows.Forms.Panel PnlEscritorio;
        private FontAwesome.Sharp.IconPictureBox IconEstado;
        private System.Windows.Forms.PictureBox PtLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

