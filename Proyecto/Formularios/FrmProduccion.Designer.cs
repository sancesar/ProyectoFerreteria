﻿namespace Proyecto.Formularios
{
    partial class FrmProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduccion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dgvmapri = new System.Windows.Forms.DataGridView();
            this.Produc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecResec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnActu = new System.Windows.Forms.Button();
            this.TxtIdLote = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListProceso = new System.Windows.Forms.ListView();
            this.Proela = new System.Windows.Forms.ColumnHeader();
            this.Fechela = new System.Windows.Forms.ColumnHeader();
            this.Cantela = new System.Windows.Forms.ColumnHeader();
            this.Marcela = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtCanEla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbProEla = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtEla = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.Btnmarca = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.Brnfecha = new System.Windows.Forms.Button();
            this.Gbmarca = new System.Windows.Forms.GroupBox();
            this.Cbbmarca = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GbProducto = new System.Windows.Forms.GroupBox();
            this.Cbbproducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Gbfecha = new System.Windows.Forms.GroupBox();
            this.Dtbfecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.Listvali = new System.Windows.Forms.ListView();
            this.Proval = new System.Windows.Forms.ColumnHeader();
            this.Fecelaval = new System.Windows.Forms.ColumnHeader();
            this.Marval = new System.Windows.Forms.ColumnHeader();
            this.Cantpreval = new System.Windows.Forms.ColumnHeader();
            this.Cantreaval = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.IdLo = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvmapri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.Gbmarca.SuspendLayout();
            this.GbProducto.SuspendLayout();
            this.Gbfecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.Dgvmapri);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recepción de materia prima";
            // 
            // Dgvmapri
            // 
            this.Dgvmapri.AllowUserToAddRows = false;
            this.Dgvmapri.AllowUserToDeleteRows = false;
            this.Dgvmapri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvmapri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produc,
            this.Prov,
            this.Cant,
            this.FecResec});
            this.Dgvmapri.Location = new System.Drawing.Point(15, 6);
            this.Dgvmapri.Name = "Dgvmapri";
            this.Dgvmapri.ReadOnly = true;
            this.Dgvmapri.RowHeadersWidth = 51;
            this.Dgvmapri.RowTemplate.Height = 29;
            this.Dgvmapri.Size = new System.Drawing.Size(739, 184);
            this.Dgvmapri.TabIndex = 0;
            // 
            // Produc
            // 
            this.Produc.Frozen = true;
            this.Produc.HeaderText = "Producto";
            this.Produc.MinimumWidth = 6;
            this.Produc.Name = "Produc";
            this.Produc.ReadOnly = true;
            this.Produc.Width = 170;
            // 
            // Prov
            // 
            this.Prov.Frozen = true;
            this.Prov.HeaderText = "Proveedor";
            this.Prov.MinimumWidth = 6;
            this.Prov.Name = "Prov";
            this.Prov.ReadOnly = true;
            this.Prov.Width = 170;
            // 
            // Cant
            // 
            this.Cant.Frozen = true;
            this.Cant.HeaderText = "Cantidad";
            this.Cant.MinimumWidth = 6;
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            this.Cant.Width = 170;
            // 
            // FecResec
            // 
            this.FecResec.Frozen = true;
            this.FecResec.HeaderText = "Fecha de recepción";
            this.FecResec.MinimumWidth = 174;
            this.FecResec.Name = "FecResec";
            this.FecResec.ReadOnly = true;
            this.FecResec.Width = 174;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(119, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.BtnActu);
            this.tabPage2.Controls.Add(this.TxtIdLote);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.CmbMarca);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Btnagregar);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.TxtCanEla);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.CmbProEla);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.DtEla);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proceso productivo";
            // 
            // BtnActu
            // 
            this.BtnActu.Location = new System.Drawing.Point(581, 164);
            this.BtnActu.Name = "BtnActu";
            this.BtnActu.Size = new System.Drawing.Size(94, 29);
            this.BtnActu.TabIndex = 15;
            this.BtnActu.Text = "Actualizar";
            this.BtnActu.UseVisualStyleBackColor = true;
            this.BtnActu.Click += new System.EventHandler(this.BtnActu_Click);
            // 
            // TxtIdLote
            // 
            this.TxtIdLote.Location = new System.Drawing.Point(218, 11);
            this.TxtIdLote.Name = "TxtIdLote";
            this.TxtIdLote.Size = new System.Drawing.Size(151, 27);
            this.TxtIdLote.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "ID Lote:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(517, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Producción";
            // 
            // CmbMarca
            // 
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Items.AddRange(new object[] {
            "Truper",
            "Urrea",
            "Nacobre",
            "Bosch",
            "IUSA",
            "DeWalt",
            "Rotoplas",
            "Austromex",
            "Phillips",
            "Makita"});
            this.CmbMarca.Location = new System.Drawing.Point(218, 149);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(151, 28);
            this.CmbMarca.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.ListProceso);
            this.groupBox1.Location = new System.Drawing.Point(31, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 201);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de productos para elaborar";
            // 
            // ListProceso
            // 
            this.ListProceso.BackColor = System.Drawing.SystemColors.Window;
            this.ListProceso.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdLo,
            this.Proela,
            this.Fechela,
            this.Cantela,
            this.Marcela});
            this.ListProceso.Location = new System.Drawing.Point(15, 26);
            this.ListProceso.Name = "ListProceso";
            this.ListProceso.Size = new System.Drawing.Size(686, 158);
            this.ListProceso.TabIndex = 4;
            this.ListProceso.UseCompatibleStateImageBehavior = false;
            this.ListProceso.View = System.Windows.Forms.View.Details;
            // 
            // Proela
            // 
            this.Proela.Text = "Producto";
            this.Proela.Width = 170;
            // 
            // Fechela
            // 
            this.Fechela.Text = "Fecha de elaboración";
            this.Fechela.Width = 170;
            // 
            // Cantela
            // 
            this.Cantela.Text = "Cantidad";
            this.Cantela.Width = 110;
            // 
            // Marcela
            // 
            this.Marcela.Text = "Marca";
            this.Marcela.Width = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Marca:";
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(458, 163);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(94, 29);
            this.Btnagregar.TabIndex = 8;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.image_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(408, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // TxtCanEla
            // 
            this.TxtCanEla.Location = new System.Drawing.Point(218, 113);
            this.TxtCanEla.Name = "TxtCanEla";
            this.TxtCanEla.Size = new System.Drawing.Size(151, 27);
            this.TxtCanEla.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad a elaborar:";
            // 
            // CmbProEla
            // 
            this.CmbProEla.FormattingEnabled = true;
            this.CmbProEla.Items.AddRange(new object[] {
            "Destornillador",
            "Juego de llaves",
            "Alicate",
            "Pala",
            "Clavos",
            "Tornillos",
            "Espatulas",
            "Tuercas",
            "Pinzas",
            "Brochas"});
            this.CmbProEla.Location = new System.Drawing.Point(218, 46);
            this.CmbProEla.Name = "CmbProEla";
            this.CmbProEla.Size = new System.Drawing.Size(151, 28);
            this.CmbProEla.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto a elaborar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de elaboración:";
            // 
            // DtEla
            // 
            this.DtEla.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtEla.Location = new System.Drawing.Point(218, 80);
            this.DtEla.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DtEla.Name = "DtEla";
            this.DtEla.Size = new System.Drawing.Size(151, 27);
            this.DtEla.TabIndex = 0;
            this.DtEla.Value = new System.DateTime(2022, 7, 10, 13, 3, 17, 0);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.Btnmarca);
            this.tabPage3.Controls.Add(this.BtnProducto);
            this.tabPage3.Controls.Add(this.Btncancelar);
            this.tabPage3.Controls.Add(this.Brnfecha);
            this.tabPage3.Controls.Add(this.Gbmarca);
            this.tabPage3.Controls.Add(this.GbProducto);
            this.tabPage3.Controls.Add(this.Gbfecha);
            this.tabPage3.Controls.Add(this.BtnBuscar);
            this.tabPage3.Controls.Add(this.Listvali);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Validación de producción y servicio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(220, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(331, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Seleccione la opcion a buscar:";
            // 
            // Btnmarca
            // 
            this.Btnmarca.Location = new System.Drawing.Point(550, 231);
            this.Btnmarca.Name = "Btnmarca";
            this.Btnmarca.Size = new System.Drawing.Size(94, 29);
            this.Btnmarca.TabIndex = 7;
            this.Btnmarca.Text = "Marca";
            this.Btnmarca.UseVisualStyleBackColor = true;
            // 
            // BtnProducto
            // 
            this.BtnProducto.Location = new System.Drawing.Point(325, 233);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(94, 29);
            this.BtnProducto.TabIndex = 6;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = true;
            // 
            // Btncancelar
            // 
            this.Btncancelar.Location = new System.Drawing.Point(584, 184);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(155, 29);
            this.Btncancelar.TabIndex = 5;
            this.Btncancelar.Text = "Cancelar busqueda";
            this.Btncancelar.UseVisualStyleBackColor = true;
            // 
            // Brnfecha
            // 
            this.Brnfecha.Location = new System.Drawing.Point(56, 233);
            this.Brnfecha.Name = "Brnfecha";
            this.Brnfecha.Size = new System.Drawing.Size(94, 29);
            this.Brnfecha.TabIndex = 4;
            this.Brnfecha.Text = "Fecha";
            this.Brnfecha.UseVisualStyleBackColor = true;
            // 
            // Gbmarca
            // 
            this.Gbmarca.Controls.Add(this.Cbbmarca);
            this.Gbmarca.Controls.Add(this.label9);
            this.Gbmarca.Location = new System.Drawing.Point(503, 266);
            this.Gbmarca.Name = "Gbmarca";
            this.Gbmarca.Size = new System.Drawing.Size(227, 125);
            this.Gbmarca.TabIndex = 3;
            this.Gbmarca.TabStop = false;
            this.Gbmarca.Text = "Busqueda por marca";
            // 
            // Cbbmarca
            // 
            this.Cbbmarca.FormattingEnabled = true;
            this.Cbbmarca.Location = new System.Drawing.Point(34, 66);
            this.Cbbmarca.Name = "Cbbmarca";
            this.Cbbmarca.Size = new System.Drawing.Size(151, 28);
            this.Cbbmarca.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Seleccione la marca:";
            // 
            // GbProducto
            // 
            this.GbProducto.Controls.Add(this.Cbbproducto);
            this.GbProducto.Controls.Add(this.label8);
            this.GbProducto.Location = new System.Drawing.Point(261, 266);
            this.GbProducto.Name = "GbProducto";
            this.GbProducto.Size = new System.Drawing.Size(235, 125);
            this.GbProducto.TabIndex = 3;
            this.GbProducto.TabStop = false;
            this.GbProducto.Text = "Busqueda por producto";
            // 
            // Cbbproducto
            // 
            this.Cbbproducto.FormattingEnabled = true;
            this.Cbbproducto.Location = new System.Drawing.Point(44, 66);
            this.Cbbproducto.Name = "Cbbproducto";
            this.Cbbproducto.Size = new System.Drawing.Size(151, 28);
            this.Cbbproducto.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Seleccione el producto:";
            // 
            // Gbfecha
            // 
            this.Gbfecha.Controls.Add(this.Dtbfecha);
            this.Gbfecha.Controls.Add(this.label7);
            this.Gbfecha.Location = new System.Drawing.Point(22, 266);
            this.Gbfecha.Name = "Gbfecha";
            this.Gbfecha.Size = new System.Drawing.Size(233, 125);
            this.Gbfecha.TabIndex = 2;
            this.Gbfecha.TabStop = false;
            this.Gbfecha.Text = "Busqueda por fecha";
            // 
            // Dtbfecha
            // 
            this.Dtbfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtbfecha.Location = new System.Drawing.Point(46, 67);
            this.Dtbfecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Dtbfecha.Name = "Dtbfecha";
            this.Dtbfecha.Size = new System.Drawing.Size(122, 27);
            this.Dtbfecha.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Seleccione la fecha:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(29, 184);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(157, 29);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Realizar busqueda";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // Listvali
            // 
            this.Listvali.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Proval,
            this.Fecelaval,
            this.Marval,
            this.Cantpreval,
            this.Cantreaval});
            this.Listvali.Location = new System.Drawing.Point(19, 14);
            this.Listvali.Name = "Listvali";
            this.Listvali.Size = new System.Drawing.Size(733, 164);
            this.Listvali.TabIndex = 0;
            this.Listvali.UseCompatibleStateImageBehavior = false;
            this.Listvali.View = System.Windows.Forms.View.Details;
            // 
            // Proval
            // 
            this.Proval.Text = "Producto";
            this.Proval.Width = 150;
            // 
            // Fecelaval
            // 
            this.Fecelaval.Text = "Fecha de elaboración";
            this.Fecelaval.Width = 170;
            // 
            // Marval
            // 
            this.Marval.Text = "Marca";
            this.Marval.Width = 100;
            // 
            // Cantpreval
            // 
            this.Cantpreval.Text = "Cantidad prevista";
            this.Cantpreval.Width = 150;
            // 
            // Cantreaval
            // 
            this.Cantreaval.Text = "Cantidad realizada";
            this.Cantreaval.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(271, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu de producción";
            // 
            // LblCerrar
            // 
            this.LblCerrar.AutoSize = true;
            this.LblCerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LblCerrar.Location = new System.Drawing.Point(690, 9);
            this.LblCerrar.Name = "LblCerrar";
            this.LblCerrar.Size = new System.Drawing.Size(98, 20);
            this.LblCerrar.TabIndex = 2;
            this.LblCerrar.Text = "Cerrar sesión";
            this.LblCerrar.Click += new System.EventHandler(this.LblCerrar_Click);
            // 
            // IdLo
            // 
            this.IdLo.Text = "Id Lote";
            this.IdLo.Width = 90;
            // 
            // FrmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.ControlBox = false;
            this.Controls.Add(this.LblCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProduccion";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producción";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvmapri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.Gbmarca.ResumeLayout(false);
            this.Gbmarca.PerformLayout();
            this.GbProducto.ResumeLayout(false);
            this.GbProducto.PerformLayout();
            this.Gbfecha.ResumeLayout(false);
            this.Gbfecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private DataGridView Dgvmapri;
        private PictureBox pictureBox1;
        private Button Btnagregar;
        private PictureBox pictureBox2;
        private TextBox TxtCanEla;
        private Label label4;
        private ListView ListProceso;
        private ColumnHeader Proela;
        private ColumnHeader Fechela;
        private ColumnHeader Cantela;
        private ComboBox CmbProEla;
        private Label label3;
        private Label label2;
        private DateTimePicker DtEla;
        private ColumnHeader Marcela;
        private ComboBox CmbMarca;
        private GroupBox groupBox1;
        private Label label5;
        private Label label6;
        private Button BtnBuscar;
        private ListView Listvali;
        private ColumnHeader Proval;
        private ColumnHeader Fecelaval;
        private ColumnHeader Marval;
        private ColumnHeader Cantreaval;
        private ColumnHeader Cantpreval;
        private Button Btnmarca;
        private Button BtnProducto;
        private Button Btncancelar;
        private Button Brnfecha;
        private GroupBox Gbmarca;
        private GroupBox GbProducto;
        private GroupBox Gbfecha;
        private Label label7;
        private Label label10;
        private ComboBox Cbbmarca;
        private Label label9;
        private ComboBox Cbbproducto;
        private Label label8;
        private DateTimePicker Dtbfecha;
        private DataGridViewTextBoxColumn Produc;
        private DataGridViewTextBoxColumn Prov;
        private DataGridViewTextBoxColumn Cant;
        private DataGridViewTextBoxColumn FecResec;
        private Label LblCerrar;
        private TextBox TxtIdLote;
        private Label label11;
        private Button BtnActu;
        private ColumnHeader IdLo;
    }
}