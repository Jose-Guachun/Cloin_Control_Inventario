
namespace Presentation.Formularios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TplTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.TplTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlBarraTop.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.PnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // TplTitulo
            // 
            this.TplTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TplTitulo.ColumnCount = 2;
            this.TplTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.TplTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TplTitulo.Controls.Add(this.TxtCategoria, 1, 0);
            this.TplTitulo.Controls.Add(this.label5, 0, 0);
            this.TplTitulo.Enabled = false;
            this.TplTitulo.Location = new System.Drawing.Point(32, 43);
            this.TplTitulo.Name = "TplTitulo";
            this.TplTitulo.RowCount = 1;
            this.TplTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TplTitulo.Size = new System.Drawing.Size(221, 25);
            this.TplTitulo.TabIndex = 103;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoria.Location = new System.Drawing.Point(74, 3);
            this.TxtCategoria.MaxLength = 200;
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(144, 20);
            this.TxtCategoria.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 130;
            this.label5.Text = "Categoria";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblTitleChildForm
            // 
            this.LblTitleChildForm.AutoSize = true;
            this.LblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.LblTitleChildForm.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleChildForm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblTitleChildForm.Location = new System.Drawing.Point(28, 9);
            this.LblTitleChildForm.Name = "LblTitleChildForm";
            this.LblTitleChildForm.Size = new System.Drawing.Size(164, 22);
            this.LblTitleChildForm.TabIndex = 116;
            this.LblTitleChildForm.Text = "Datos de Categoria";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LblTitleChildForm);
            this.panel1.Controls.Add(this.TplTitulo);
            this.panel1.Location = new System.Drawing.Point(1, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 79);
            this.panel1.TabIndex = 2;
            // 
            // PnlBarraTop
            // 
            this.PnlBarraTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.PnlBarraTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlBarraTop.Controls.Add(this.BtnMinimizar);
            this.PnlBarraTop.Controls.Add(this.BtnCerrar);
            this.PnlBarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraTop.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraTop.Margin = new System.Windows.Forms.Padding(2);
            this.PnlBarraTop.Name = "PnlBarraTop";
            this.PnlBarraTop.Size = new System.Drawing.Size(376, 33);
            this.PnlBarraTop.TabIndex = 1;
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
            this.BtnMinimizar.Location = new System.Drawing.Point(318, 0);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(29, 33);
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
            this.BtnCerrar.Location = new System.Drawing.Point(347, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(29, 33);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PnlMenu
            // 
            this.PnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMenu.BackColor = System.Drawing.Color.GhostWhite;
            this.PnlMenu.Controls.Add(this.BtnCancelar);
            this.PnlMenu.Controls.Add(this.BtnEliminar);
            this.PnlMenu.Controls.Add(this.BtnEditar);
            this.PnlMenu.Controls.Add(this.BtnGuardar);
            this.PnlMenu.Controls.Add(this.BtnNuevo);
            this.PnlMenu.Location = new System.Drawing.Point(289, 34);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(87, 373);
            this.PnlMenu.TabIndex = 4;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 30;
            this.BtnCancelar.Location = new System.Drawing.Point(0, 272);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(87, 68);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 30;
            this.BtnEliminar.Location = new System.Drawing.Point(0, 204);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(87, 68);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 30;
            this.BtnEditar.Location = new System.Drawing.Point(0, 136);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(87, 68);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGuardar.IconSize = 30;
            this.BtnGuardar.Location = new System.Drawing.Point(0, 68);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(87, 68);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Teal;
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.BtnNuevo.IconColor = System.Drawing.Color.White;
            this.BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNuevo.IconSize = 30;
            this.BtnNuevo.Location = new System.Drawing.Point(0, 0);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(87, 68);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // PnlLista
            // 
            this.PnlLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlLista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PnlLista.Controls.Add(this.label11);
            this.PnlLista.Controls.Add(this.TxtBuscar);
            this.PnlLista.Controls.Add(this.DgvProductos);
            this.PnlLista.Location = new System.Drawing.Point(4, 114);
            this.PnlLista.Name = "PnlLista";
            this.PnlLista.Size = new System.Drawing.Size(282, 293);
            this.PnlLista.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(27, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 22);
            this.label11.TabIndex = 116;
            this.label11.Text = "Lista de Categorias";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscar.BackColor = System.Drawing.Color.White;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(31, 35);
            this.TxtBuscar.MaxLength = 200;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(216, 24);
            this.TxtBuscar.TabIndex = 23;
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.DgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvProductos.EnableHeadersVisualStyles = false;
            this.DgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.DgvProductos.Location = new System.Drawing.Point(31, 64);
            this.DgvProductos.MultiSelect = false;
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.RowHeadersVisible = false;
            this.DgvProductos.RowHeadersWidth = 62;
            this.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductos.Size = new System.Drawing.Size(216, 212);
            this.DgvProductos.TabIndex = 25;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(376, 412);
            this.Controls.Add(this.PnlLista);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlBarraTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.TplTitulo.ResumeLayout(false);
            this.TplTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlBarraTop.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TplTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCategoria;
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
        private System.Windows.Forms.DataGridView DgvProductos;
    }
}