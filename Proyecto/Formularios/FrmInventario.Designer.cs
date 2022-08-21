namespace Proyecto.Formularios
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Registrar = new System.Windows.Forms.TabPage();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Actualizar = new System.Windows.Forms.TabPage();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.btnBuscarA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Consulta_General = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnBuscarGeneral = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Consulta_Stock = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.btnBuscarStock = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.TabPage();
            this.btnBuscarEliminar = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.LblCerrar = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Registrar.SuspendLayout();
            this.Actualizar.SuspendLayout();
            this.Consulta_General.SuspendLayout();
            this.Consulta_Stock.SuspendLayout();
            this.Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "--- INVENTARIO ---";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.Registrar);
            this.tabControl1.Controls.Add(this.Actualizar);
            this.tabControl1.Controls.Add(this.Consulta_General);
            this.tabControl1.Controls.Add(this.Consulta_Stock);
            this.tabControl1.Controls.Add(this.Eliminar);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(140, 30);
            this.tabControl1.Location = new System.Drawing.Point(34, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 400);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Registrar.Controls.Add(this.textBox12);
            this.Registrar.Controls.Add(this.label13);
            this.Registrar.Controls.Add(this.btnAceptar);
            this.Registrar.Controls.Add(this.textBox8);
            this.Registrar.Controls.Add(this.textBox7);
            this.Registrar.Controls.Add(this.textBox6);
            this.Registrar.Controls.Add(this.label9);
            this.Registrar.Controls.Add(this.label8);
            this.Registrar.Controls.Add(this.label7);
            this.Registrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registrar.Location = new System.Drawing.Point(4, 34);
            this.Registrar.Name = "Registrar";
            this.Registrar.Padding = new System.Windows.Forms.Padding(3);
            this.Registrar.Size = new System.Drawing.Size(746, 362);
            this.Registrar.TabIndex = 0;
            this.Registrar.Text = "Registrar";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(214, 241);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(254, 30);
            this.textBox12.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 23);
            this.label13.TabIndex = 7;
            this.label13.Text = "Estado:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(294, 305);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(147, 40);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(214, 175);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(254, 30);
            this.textBox8.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(214, 111);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(254, 30);
            this.textBox7.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(214, 46);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(254, 30);
            this.textBox6.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Código:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre del Producto:";
            // 
            // Actualizar
            // 
            this.Actualizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Actualizar.Controls.Add(this.textBox11);
            this.Actualizar.Controls.Add(this.label12);
            this.Actualizar.Controls.Add(this.textBox1);
            this.Actualizar.Controls.Add(this.textBox9);
            this.Actualizar.Controls.Add(this.label10);
            this.Actualizar.Controls.Add(this.textBox2);
            this.Actualizar.Controls.Add(this.label2);
            this.Actualizar.Controls.Add(this.textBox10);
            this.Actualizar.Controls.Add(this.btnActualizar);
            this.Actualizar.Controls.Add(this.label11);
            this.Actualizar.Controls.Add(this.listView4);
            this.Actualizar.Controls.Add(this.btnBuscarA);
            this.Actualizar.Controls.Add(this.label3);
            this.Actualizar.Location = new System.Drawing.Point(4, 34);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Padding = new System.Windows.Forms.Padding(3);
            this.Actualizar.Size = new System.Drawing.Size(746, 362);
            this.Actualizar.TabIndex = 1;
            this.Actualizar.Text = "Actualizar";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(594, 266);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 30);
            this.textBox11.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(508, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Estado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(594, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 23;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(218, 210);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(254, 30);
            this.textBox9.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nombre del Producto:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 269);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 30);
            this.textBox2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cantidad:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(183, 15);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(302, 30);
            this.textBox10.TabIndex = 16;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(311, 316);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(161, 40);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Ingrese producto:";
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.listView4.Location = new System.Drawing.Point(32, 61);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(688, 124);
            this.listView4.TabIndex = 17;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Nombre";
            this.columnHeader13.Width = 170;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Código";
            this.columnHeader14.Width = 170;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Cantidad";
            this.columnHeader15.Width = 170;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Estado";
            this.columnHeader16.Width = 170;
            // 
            // btnBuscarA
            // 
            this.btnBuscarA.Location = new System.Drawing.Point(604, 15);
            this.btnBuscarA.Name = "btnBuscarA";
            this.btnBuscarA.Size = new System.Drawing.Size(116, 40);
            this.btnBuscarA.TabIndex = 14;
            this.btnBuscarA.Text = "Buscar";
            this.btnBuscarA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Código:";
            // 
            // Consulta_General
            // 
            this.Consulta_General.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Consulta_General.Controls.Add(this.listView1);
            this.Consulta_General.Controls.Add(this.btnBuscarGeneral);
            this.Consulta_General.Controls.Add(this.textBox3);
            this.Consulta_General.Controls.Add(this.label4);
            this.Consulta_General.Location = new System.Drawing.Point(4, 34);
            this.Consulta_General.Name = "Consulta_General";
            this.Consulta_General.Padding = new System.Windows.Forms.Padding(3);
            this.Consulta_General.Size = new System.Drawing.Size(746, 362);
            this.Consulta_General.TabIndex = 2;
            this.Consulta_General.Text = "Consulta_General";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7});
            this.listView1.Location = new System.Drawing.Point(24, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(696, 251);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Código";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.Width = 170;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Estado";
            this.columnHeader7.Width = 170;
            // 
            // btnBuscarGeneral
            // 
            this.btnBuscarGeneral.Location = new System.Drawing.Point(570, 30);
            this.btnBuscarGeneral.Name = "btnBuscarGeneral";
            this.btnBuscarGeneral.Size = new System.Drawing.Size(150, 30);
            this.btnBuscarGeneral.TabIndex = 2;
            this.btnBuscarGeneral.Text = "Buscar";
            this.btnBuscarGeneral.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(302, 30);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ingrese producto:";
            // 
            // Consulta_Stock
            // 
            this.Consulta_Stock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Consulta_Stock.Controls.Add(this.listView2);
            this.Consulta_Stock.Controls.Add(this.btnBuscarStock);
            this.Consulta_Stock.Controls.Add(this.textBox4);
            this.Consulta_Stock.Controls.Add(this.label5);
            this.Consulta_Stock.Location = new System.Drawing.Point(4, 34);
            this.Consulta_Stock.Name = "Consulta_Stock";
            this.Consulta_Stock.Padding = new System.Windows.Forms.Padding(3);
            this.Consulta_Stock.Size = new System.Drawing.Size(746, 362);
            this.Consulta_Stock.TabIndex = 3;
            this.Consulta_Stock.Text = "Consulta_Stock";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.listView2.Location = new System.Drawing.Point(24, 77);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(696, 259);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Código";
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cantidad";
            this.columnHeader6.Width = 170;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Estado";
            this.columnHeader8.Width = 170;
            // 
            // btnBuscarStock
            // 
            this.btnBuscarStock.Location = new System.Drawing.Point(570, 24);
            this.btnBuscarStock.Name = "btnBuscarStock";
            this.btnBuscarStock.Size = new System.Drawing.Size(150, 30);
            this.btnBuscarStock.TabIndex = 7;
            this.btnBuscarStock.Text = "Buscar";
            this.btnBuscarStock.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(302, 30);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese producto:";
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Eliminar.Controls.Add(this.btnBuscarEliminar);
            this.Eliminar.Controls.Add(this.textBox5);
            this.Eliminar.Controls.Add(this.label6);
            this.Eliminar.Controls.Add(this.btnEliminar);
            this.Eliminar.Controls.Add(this.listView3);
            this.Eliminar.Location = new System.Drawing.Point(4, 34);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.Eliminar.Size = new System.Drawing.Size(746, 362);
            this.Eliminar.TabIndex = 4;
            this.Eliminar.Text = "Eliminar";
            // 
            // btnBuscarEliminar
            // 
            this.btnBuscarEliminar.Location = new System.Drawing.Point(486, 298);
            this.btnBuscarEliminar.Name = "btnBuscarEliminar";
            this.btnBuscarEliminar.Size = new System.Drawing.Size(117, 39);
            this.btnBuscarEliminar.TabIndex = 15;
            this.btnBuscarEliminar.Text = "Buscar";
            this.btnBuscarEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarEliminar.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(178, 303);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(302, 30);
            this.textBox5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingrese producto:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(609, 298);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 39);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView3.Location = new System.Drawing.Point(27, 26);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(696, 252);
            this.listView3.TabIndex = 11;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nombre";
            this.columnHeader9.Width = 170;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Código";
            this.columnHeader10.Width = 170;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Cantidad";
            this.columnHeader11.Width = 170;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Estado";
            this.columnHeader12.Width = 170;
            // 
            // LblCerrar
            // 
            this.LblCerrar.AutoSize = true;
            this.LblCerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LblCerrar.Location = new System.Drawing.Point(672, 33);
            this.LblCerrar.Name = "LblCerrar";
            this.LblCerrar.Size = new System.Drawing.Size(98, 20);
            this.LblCerrar.TabIndex = 17;
            this.LblCerrar.Text = "Cerrar sesión";
            this.LblCerrar.Click += new System.EventHandler(this.LblCerrar_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(814, 497);
            this.ControlBox = false;
            this.Controls.Add(this.LblCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.tabControl1.ResumeLayout(false);
            this.Registrar.ResumeLayout(false);
            this.Registrar.PerformLayout();
            this.Actualizar.ResumeLayout(false);
            this.Actualizar.PerformLayout();
            this.Consulta_General.ResumeLayout(false);
            this.Consulta_General.PerformLayout();
            this.Consulta_Stock.ResumeLayout(false);
            this.Consulta_Stock.PerformLayout();
            this.Eliminar.ResumeLayout(false);
            this.Eliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage Registrar;
        private TextBox textBox12;
        private Label label13;
        private Button btnAceptar;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label9;
        private Label label8;
        private Label label7;
        private TabPage Actualizar;
        private TextBox textBox11;
        private Label label12;
        private TextBox textBox1;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox10;
        private Button btnActualizar;
        private Label label11;
        private ListView listView4;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private Button btnBuscarA;
        private Label label3;
        private TabPage Consulta_General;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader7;
        private Button btnBuscarGeneral;
        private TextBox textBox3;
        private Label label4;
        private TabPage Consulta_Stock;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
        private Button btnBuscarStock;
        private TextBox textBox4;
        private Label label5;
        private TabPage Eliminar;
        private Button btnBuscarEliminar;
        private TextBox textBox5;
        private Label label6;
        private Button btnEliminar;
        private ListView listView3;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Label LblCerrar;
    }
}