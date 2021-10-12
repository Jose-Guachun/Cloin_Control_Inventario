
namespace Presentation.Formularios
{
    partial class Marca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlLista = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvMarca = new System.Windows.Forms.DataGridView();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.PnlBarraTop = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TplTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTitleChildForm = new System.Windows.Forms.Label();
            this.PnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarca)).BeginInit();
            this.PnlMenu.SuspendLayout();
            this.PnlBarraTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TplTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLista
            // 
            this.PnlLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlLista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlLista.Controls.Add(this.label11);
            this.PnlLista.Controls.Add(this.TxtBuscar);
            this.PnlLista.Controls.Add(this.DgvMarca);
            this.PnlLista.Location = new System.Drawing.Point(6, 179);
            this.PnlLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlLista.Name = "PnlLista";
            this.PnlLista.Size = new System.Drawing.Size(435, 644);
            this.PnlLista.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(38, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 33);
            this.label11.TabIndex = 116;
            this.label11.Text = "Lista de Marcas";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscar.BackColor = System.Drawing.Color.White;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.Font = new System.Drawing.Font("Ebrima", 9F);
            this.TxtBuscar.Location = new System.Drawing.Point(52, 48);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBuscar.MaxLength = 200;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(332, 32);
            this.TxtBuscar.TabIndex = 23;
            // 
            // DgvMarca
            // 
            this.DgvMarca.AllowUserToAddRows = false;
            this.DgvMarca.AllowUserToDeleteRows = false;
            this.DgvMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvMarca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvMarca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.DgvMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMarca.DefaultCellStyle = dataGridViewCellStyle10;
            this.DgvMarca.EnableHeadersVisualStyles = false;
            this.DgvMarca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.DgvMarca.Location = new System.Drawing.Point(52, 87);
            this.DgvMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvMarca.MultiSelect = false;
            this.DgvMarca.Name = "DgvMarca";
            this.DgvMarca.ReadOnly = true;
            this.DgvMarca.RowHeadersVisible = false;
            this.DgvMarca.RowHeadersWidth = 62;
            this.DgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMarca.Size = new System.Drawing.Size(332, 529);
            this.DgvMarca.TabIndex = 25;
            // 
            // PnlMenu
            // 
            this.PnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlMenu.Controls.Add(this.BtnCancelar);
            this.PnlMenu.Controls.Add(this.BtnEliminar);
            this.PnlMenu.Controls.Add(this.BtnEditar);
            this.PnlMenu.Controls.Add(this.BtnGuardar);
            this.PnlMenu.Controls.Add(this.BtnNuevo);
            this.PnlMenu.Location = new System.Drawing.Point(446, 56);
            this.PnlMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(130, 767);
            this.PnlMenu.TabIndex = 8;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 30;
            this.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancelar.Location = new System.Drawing.Point(0, 545);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 105);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 30;
            this.BtnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEliminar.Location = new System.Drawing.Point(0, 442);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(130, 105);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 30;
            this.BtnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEditar.Location = new System.Drawing.Point(0, 336);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(130, 105);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 30;
            this.BtnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnGuardar.Location = new System.Drawing.Point(0, 232);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(130, 105);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNuevo.BackColor = System.Drawing.Color.Teal;
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.BtnNuevo.IconColor = System.Drawing.Color.White;
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevo.IconSize = 30;
            this.BtnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnNuevo.Location = new System.Drawing.Point(0, 127);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(130, 105);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
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
            this.PnlBarraTop.Size = new System.Drawing.Size(576, 51);
            this.PnlBarraTop.TabIndex = 5;
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
            this.BtnMinimizar.Location = new System.Drawing.Point(488, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(44, 51);
            this.BtnMinimizar.TabIndex = 1;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
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
            this.BtnCerrar.Location = new System.Drawing.Point(532, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(44, 51);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.LblTitleChildForm);
            this.panel1.Controls.Add(this.TplTitulo);
            this.panel1.Location = new System.Drawing.Point(2, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 122);
            this.panel1.TabIndex = 6;
            // 
            // TplTitulo
            // 
            this.TplTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TplTitulo.ColumnCount = 2;
            this.TplTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.TplTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TplTitulo.Controls.Add(this.TxtMarca, 1, 0);
            this.TplTitulo.Controls.Add(this.label5, 0, 0);
            this.TplTitulo.Enabled = false;
            this.TplTitulo.Location = new System.Drawing.Point(56, 67);
            this.TplTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TplTitulo.Name = "TplTitulo";
            this.TplTitulo.RowCount = 1;
            this.TplTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TplTitulo.Size = new System.Drawing.Size(332, 38);
            this.TplTitulo.TabIndex = 103;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TxtMarca.Location = new System.Drawing.Point(121, 5);
            this.TxtMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMarca.MaxLength = 200;
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(207, 26);
            this.TxtMarca.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 38);
            this.label5.TabIndex = 130;
            this.label5.Text = "Descripcion:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTitleChildForm
            // 
            this.LblTitleChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitleChildForm.AutoSize = true;
            this.LblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.LblTitleChildForm.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold);
            this.LblTitleChildForm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblTitleChildForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblTitleChildForm.Location = new System.Drawing.Point(179, 15);
            this.LblTitleChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitleChildForm.Name = "LblTitleChildForm";
            this.LblTitleChildForm.Size = new System.Drawing.Size(109, 33);
            this.LblTitleChildForm.TabIndex = 117;
            this.LblTitleChildForm.Text = "MARCA";
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 827);
            this.Controls.Add(this.PnlLista);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlBarraTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Marca";
            this.Text = "Marca";
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarca)).EndInit();
            this.PnlMenu.ResumeLayout(false);
            this.PnlBarraTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TplTitulo.ResumeLayout(false);
            this.TplTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgvMarca;
        private System.Windows.Forms.Panel PnlMenu;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        internal System.Windows.Forms.Panel PnlBarraTop;
        internal System.Windows.Forms.Button BtnMinimizar;
        internal System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TplTitulo;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblTitleChildForm;
    }
}