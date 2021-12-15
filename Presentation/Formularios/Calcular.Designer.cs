
namespace Presentation
{
    partial class Calcular
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlBarraTop = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnModelo = new FontAwesome.Sharp.IconButton();
            this.BtnImportado = new FontAwesome.Sharp.IconButton();
            this.BtnNacional = new FontAwesome.Sharp.IconButton();
            this.PnlLista = new System.Windows.Forms.Panel();
            this.BtnAnclar = new FontAwesome.Sharp.IconButton();
            this.BtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.BtnCalcular = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblCoste = new System.Windows.Forms.Label();
            this.BtnEnviar = new FontAwesome.Sharp.IconButton();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnSeleccionar = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAddIva = new FontAwesome.Sharp.IconButton();
            this.TxtGasto3 = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.TxtGasto2 = new System.Windows.Forms.TextBox();
            this.TxtGasto1 = new System.Windows.Forms.TextBox();
            this.lblFlete = new System.Windows.Forms.Label();
            this.TxtFlete = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.lblGasto1 = new System.Windows.Forms.Label();
            this.lblGasto2 = new System.Windows.Forms.Label();
            this.lblGasto3 = new System.Windows.Forms.Label();
            this.BtnAddIvaF = new FontAwesome.Sharp.IconButton();
            this.DgvCompras = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PnlBarraTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PnlLista.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBarraTop
            // 
            this.PnlBarraTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.PnlBarraTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlBarraTop.Controls.Add(this.BtnMinimizar);
            this.PnlBarraTop.Controls.Add(this.BtnCerrar);
            this.PnlBarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraTop.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraTop.Name = "PnlBarraTop";
            this.PnlBarraTop.Size = new System.Drawing.Size(790, 51);
            this.PnlBarraTop.TabIndex = 2;
            this.PnlBarraTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBarraTop_MouseDown_1);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Image = global::Presentation.Properties.Resources.Minimize;
            this.BtnMinimizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnMinimizar.Location = new System.Drawing.Point(702, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(44, 51);
            this.BtnMinimizar.TabIndex = 1;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Image = global::Presentation.Properties.Resources.Close;
            this.BtnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCerrar.Location = new System.Drawing.Point(746, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(44, 51);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.BtnModelo);
            this.panel2.Controls.Add(this.BtnImportado);
            this.panel2.Controls.Add(this.BtnNacional);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 105);
            this.panel2.TabIndex = 52;
            // 
            // BtnModelo
            // 
            this.BtnModelo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnModelo.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnModelo.FlatAppearance.BorderSize = 0;
            this.BtnModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BtnModelo.ForeColor = System.Drawing.Color.White;
            this.BtnModelo.IconChar = FontAwesome.Sharp.IconChar.Ship;
            this.BtnModelo.IconColor = System.Drawing.Color.White;
            this.BtnModelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnModelo.IconSize = 50;
            this.BtnModelo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnModelo.Location = new System.Drawing.Point(312, 0);
            this.BtnModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnModelo.Name = "BtnModelo";
            this.BtnModelo.Size = new System.Drawing.Size(158, 105);
            this.BtnModelo.TabIndex = 3;
            this.BtnModelo.Text = "Otros";
            this.BtnModelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnModelo.UseVisualStyleBackColor = false;
            // 
            // BtnImportado
            // 
            this.BtnImportado.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnImportado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnImportado.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnImportado.FlatAppearance.BorderSize = 0;
            this.BtnImportado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImportado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BtnImportado.ForeColor = System.Drawing.Color.White;
            this.BtnImportado.IconChar = FontAwesome.Sharp.IconChar.Plane;
            this.BtnImportado.IconColor = System.Drawing.Color.White;
            this.BtnImportado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportado.IconSize = 50;
            this.BtnImportado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnImportado.Location = new System.Drawing.Point(154, 0);
            this.BtnImportado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnImportado.Name = "BtnImportado";
            this.BtnImportado.Size = new System.Drawing.Size(158, 105);
            this.BtnImportado.TabIndex = 2;
            this.BtnImportado.Text = "Importacion";
            this.BtnImportado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnImportado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnImportado.UseVisualStyleBackColor = false;
            // 
            // BtnNacional
            // 
            this.BtnNacional.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnNacional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNacional.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnNacional.FlatAppearance.BorderSize = 0;
            this.BtnNacional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.BtnNacional.ForeColor = System.Drawing.Color.White;
            this.BtnNacional.IconChar = FontAwesome.Sharp.IconChar.Flag;
            this.BtnNacional.IconColor = System.Drawing.Color.White;
            this.BtnNacional.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNacional.IconSize = 50;
            this.BtnNacional.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNacional.Location = new System.Drawing.Point(0, 0);
            this.BtnNacional.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNacional.Name = "BtnNacional";
            this.BtnNacional.Size = new System.Drawing.Size(154, 105);
            this.BtnNacional.TabIndex = 1;
            this.BtnNacional.Text = "Nacional";
            this.BtnNacional.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNacional.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNacional.UseVisualStyleBackColor = false;
            // 
            // PnlLista
            // 
            this.PnlLista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlLista.Controls.Add(this.BtnAnclar);
            this.PnlLista.Controls.Add(this.BtnLimpiar);
            this.PnlLista.Controls.Add(this.BtnCalcular);
            this.PnlLista.Controls.Add(this.label8);
            this.PnlLista.Controls.Add(this.label7);
            this.PnlLista.Controls.Add(this.LblCoste);
            this.PnlLista.Controls.Add(this.BtnEnviar);
            this.PnlLista.Controls.Add(this.TxtBuscar);
            this.PnlLista.Controls.Add(this.BtnSeleccionar);
            this.PnlLista.Controls.Add(this.tableLayoutPanel1);
            this.PnlLista.Controls.Add(this.DgvCompras);
            this.PnlLista.Controls.Add(this.BtnAgregar);
            this.PnlLista.Controls.Add(this.label11);
            this.PnlLista.Controls.Add(this.label6);
            this.PnlLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLista.Location = new System.Drawing.Point(0, 156);
            this.PnlLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlLista.Name = "PnlLista";
            this.PnlLista.Size = new System.Drawing.Size(790, 782);
            this.PnlLista.TabIndex = 53;
            // 
            // BtnAnclar
            // 
            this.BtnAnclar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAnclar.BackColor = System.Drawing.Color.Crimson;
            this.BtnAnclar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAnclar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnAnclar.FlatAppearance.BorderSize = 0;
            this.BtnAnclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnclar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnclar.ForeColor = System.Drawing.Color.White;
            this.BtnAnclar.IconChar = FontAwesome.Sharp.IconChar.Thumbtack;
            this.BtnAnclar.IconColor = System.Drawing.Color.White;
            this.BtnAnclar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnAnclar.IconSize = 20;
            this.BtnAnclar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnclar.Location = new System.Drawing.Point(620, 326);
            this.BtnAnclar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAnclar.Name = "BtnAnclar";
            this.BtnAnclar.Size = new System.Drawing.Size(153, 45);
            this.BtnAnclar.TabIndex = 127;
            this.BtnAnclar.Text = "Anclar";
            this.BtnAnclar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnclar.UseVisualStyleBackColor = false;
            this.BtnAnclar.Click += new System.EventHandler(this.BtnAnclar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.BtnLimpiar.IconColor = System.Drawing.Color.White;
            this.BtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnLimpiar.IconSize = 20;
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpiar.Location = new System.Drawing.Point(184, 595);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(140, 48);
            this.BtnLimpiar.TabIndex = 119;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalcular.BackColor = System.Drawing.Color.Purple;
            this.BtnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnCalcular.FlatAppearance.BorderSize = 0;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.BtnCalcular.IconColor = System.Drawing.Color.White;
            this.BtnCalcular.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnCalcular.IconSize = 20;
            this.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCalcular.Location = new System.Drawing.Point(34, 595);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(141, 48);
            this.BtnCalcular.TabIndex = 120;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(87, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 29);
            this.label8.TabIndex = 126;
            this.label8.Text = "DATOS COMPRA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(435, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 29);
            this.label7.TabIndex = 125;
            this.label7.Text = "COMPRA";
            // 
            // LblCoste
            // 
            this.LblCoste.AutoSize = true;
            this.LblCoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCoste.Location = new System.Drawing.Point(162, 697);
            this.LblCoste.Name = "LblCoste";
            this.LblCoste.Size = new System.Drawing.Size(71, 33);
            this.LblCoste.TabIndex = 124;
            this.LblCoste.Text = "0.00";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEnviar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnEnviar.FlatAppearance.BorderSize = 0;
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.ForeColor = System.Drawing.Color.White;
            this.BtnEnviar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.BtnEnviar.IconColor = System.Drawing.Color.White;
            this.BtnEnviar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEnviar.IconSize = 20;
            this.BtnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEnviar.Location = new System.Drawing.Point(616, 683);
            this.BtnEnviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(152, 51);
            this.BtnEnviar.TabIndex = 123;
            this.BtnEnviar.Text = "ENVIAR";
            this.BtnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscar.BackColor = System.Drawing.Color.White;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.Font = new System.Drawing.Font("Ebrima", 9F);
            this.TxtBuscar.Location = new System.Drawing.Point(332, 165);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBuscar.MaxLength = 200;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(280, 32);
            this.TxtBuscar.TabIndex = 122;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeleccionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnSeleccionar.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.BtnSeleccionar.IconColor = System.Drawing.Color.White;
            this.BtnSeleccionar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnSeleccionar.IconSize = 20;
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSeleccionar.Location = new System.Drawing.Point(621, 206);
            this.BtnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(153, 52);
            this.BtnSeleccionar.TabIndex = 121;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Controls.Add(this.BtnAddIva, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtGasto3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCantidad, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtGasto2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtGasto1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFlete, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtFlete, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPrecio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtPrecio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtCantidad, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGasto1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGasto2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGasto3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtnAddIvaF, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 162);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 425);
            this.tableLayoutPanel1.TabIndex = 120;
            // 
            // BtnAddIva
            // 
            this.BtnAddIva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddIva.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAddIva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAddIva.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnAddIva.FlatAppearance.BorderSize = 0;
            this.BtnAddIva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddIva.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddIva.ForeColor = System.Drawing.Color.White;
            this.BtnAddIva.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddIva.IconColor = System.Drawing.Color.White;
            this.BtnAddIva.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnAddIva.IconSize = 18;
            this.BtnAddIva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddIva.Location = new System.Drawing.Point(240, 47);
            this.BtnAddIva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddIva.Name = "BtnAddIva";
            this.BtnAddIva.Size = new System.Drawing.Size(44, 32);
            this.BtnAddIva.TabIndex = 128;
            this.BtnAddIva.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnAddIva.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAddIva.UseVisualStyleBackColor = false;
            this.BtnAddIva.Click += new System.EventHandler(this.BtnAddIva_Click);
            // 
            // TxtGasto3
            // 
            this.TxtGasto3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGasto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGasto3.Location = new System.Drawing.Point(123, 213);
            this.TxtGasto3.Name = "TxtGasto3";
            this.TxtGasto3.Size = new System.Drawing.Size(110, 35);
            this.TxtGasto3.TabIndex = 9;
            this.TxtGasto3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(3, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(114, 42);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtGasto2
            // 
            this.TxtGasto2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGasto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGasto2.Location = new System.Drawing.Point(123, 171);
            this.TxtGasto2.Name = "TxtGasto2";
            this.TxtGasto2.Size = new System.Drawing.Size(110, 35);
            this.TxtGasto2.TabIndex = 8;
            this.TxtGasto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtGasto1
            // 
            this.TxtGasto1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGasto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGasto1.Location = new System.Drawing.Point(123, 129);
            this.TxtGasto1.Name = "TxtGasto1";
            this.TxtGasto1.Size = new System.Drawing.Size(110, 35);
            this.TxtGasto1.TabIndex = 7;
            this.TxtGasto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFlete
            // 
            this.lblFlete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlete.AutoSize = true;
            this.lblFlete.Location = new System.Drawing.Point(3, 84);
            this.lblFlete.Name = "lblFlete";
            this.lblFlete.Size = new System.Drawing.Size(114, 42);
            this.lblFlete.TabIndex = 3;
            this.lblFlete.Text = "Flete sin iva";
            this.lblFlete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtFlete
            // 
            this.TxtFlete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFlete.Location = new System.Drawing.Point(123, 87);
            this.TxtFlete.Name = "TxtFlete";
            this.TxtFlete.Size = new System.Drawing.Size(110, 35);
            this.TxtFlete.TabIndex = 6;
            this.TxtFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(3, 42);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(114, 42);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio sin iva";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(123, 45);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(110, 35);
            this.TxtPrecio.TabIndex = 5;
            this.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(123, 3);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(110, 35);
            this.TxtCantidad.TabIndex = 4;
            this.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGasto1
            // 
            this.lblGasto1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGasto1.AutoSize = true;
            this.lblGasto1.Location = new System.Drawing.Point(3, 126);
            this.lblGasto1.Name = "lblGasto1";
            this.lblGasto1.Size = new System.Drawing.Size(114, 42);
            this.lblGasto1.TabIndex = 127;
            this.lblGasto1.Text = "Gasto #1";
            this.lblGasto1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGasto2
            // 
            this.lblGasto2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGasto2.AutoSize = true;
            this.lblGasto2.Location = new System.Drawing.Point(3, 168);
            this.lblGasto2.Name = "lblGasto2";
            this.lblGasto2.Size = new System.Drawing.Size(114, 42);
            this.lblGasto2.TabIndex = 128;
            this.lblGasto2.Text = "Gasto #2";
            this.lblGasto2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGasto3
            // 
            this.lblGasto3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGasto3.AutoSize = true;
            this.lblGasto3.Location = new System.Drawing.Point(3, 210);
            this.lblGasto3.Name = "lblGasto3";
            this.lblGasto3.Size = new System.Drawing.Size(114, 42);
            this.lblGasto3.TabIndex = 129;
            this.lblGasto3.Text = "Gasto #3";
            this.lblGasto3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnAddIvaF
            // 
            this.BtnAddIvaF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddIvaF.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAddIvaF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAddIvaF.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnAddIvaF.FlatAppearance.BorderSize = 0;
            this.BtnAddIvaF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddIvaF.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddIvaF.ForeColor = System.Drawing.Color.White;
            this.BtnAddIvaF.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddIvaF.IconColor = System.Drawing.Color.White;
            this.BtnAddIvaF.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnAddIvaF.IconSize = 18;
            this.BtnAddIvaF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddIvaF.Location = new System.Drawing.Point(240, 89);
            this.BtnAddIvaF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddIvaF.Name = "BtnAddIvaF";
            this.BtnAddIvaF.Size = new System.Drawing.Size(44, 32);
            this.BtnAddIvaF.TabIndex = 130;
            this.BtnAddIvaF.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnAddIvaF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAddIvaF.UseVisualStyleBackColor = false;
            this.BtnAddIvaF.Click += new System.EventHandler(this.BtnAddIvaF_Click);
            // 
            // DgvCompras
            // 
            this.DgvCompras.AllowUserToAddRows = false;
            this.DgvCompras.AllowUserToDeleteRows = false;
            this.DgvCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.DgvCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCompras.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCompras.EnableHeadersVisualStyles = false;
            this.DgvCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.DgvCompras.Location = new System.Drawing.Point(332, 206);
            this.DgvCompras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvCompras.MultiSelect = false;
            this.DgvCompras.Name = "DgvCompras";
            this.DgvCompras.ReadOnly = true;
            this.DgvCompras.RowHeadersVisible = false;
            this.DgvCompras.RowHeadersWidth = 62;
            this.DgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCompras.Size = new System.Drawing.Size(280, 437);
            this.DgvCompras.TabIndex = 119;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.BtnAgregar.IconColor = System.Drawing.Color.White;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnAgregar.IconSize = 20;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.Location = new System.Drawing.Point(621, 268);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(153, 45);
            this.BtnAgregar.TabIndex = 118;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(264, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 37);
            this.label11.TabIndex = 116;
            this.label11.Text = "CALCULAR COSTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 697);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 33);
            this.label6.TabIndex = 8;
            this.label6.Text = "COSTE:";
            // 
            // Calcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 938);
            this.Controls.Add(this.PnlLista);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlBarraTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calcular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular";
            this.PnlBarraTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PnlBarraTop;
        internal System.Windows.Forms.Button BtnMinimizar;
        internal System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnModelo;
        private FontAwesome.Sharp.IconButton BtnImportado;
        private FontAwesome.Sharp.IconButton BtnNacional;
        private System.Windows.Forms.Panel PnlLista;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtGasto1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFlete;
        private System.Windows.Forms.TextBox TxtFlete;
        private FontAwesome.Sharp.IconButton BtnSeleccionar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DgvCompras;
        private System.Windows.Forms.TextBox TxtBuscar;
        private FontAwesome.Sharp.IconButton BtnEnviar;
        private System.Windows.Forms.Label LblCoste;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton BtnCalcular;
        private FontAwesome.Sharp.IconButton BtnLimpiar;
        private System.Windows.Forms.TextBox TxtGasto3;
        private System.Windows.Forms.Label lblGasto3;
        private System.Windows.Forms.Label lblGasto2;
        private System.Windows.Forms.Label lblGasto1;
        private System.Windows.Forms.TextBox TxtGasto2;
        private FontAwesome.Sharp.IconButton BtnAnclar;
        private FontAwesome.Sharp.IconButton BtnAddIva;
        private FontAwesome.Sharp.IconButton BtnAddIvaF;
    }
}