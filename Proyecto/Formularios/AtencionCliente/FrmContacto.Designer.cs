namespace Proyecto.Formularios.Atencion_al_cliente
{
    partial class FrmContacto
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtNSolicitud = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminarSolicitud = new System.Windows.Forms.Button();
            this.btnModificarSolicitud = new System.Windows.Forms.Button();
            this.btnGuardarSolicitud = new System.Windows.Forms.Button();
            this.btnNuevaSolicitud = new System.Windows.Forms.Button();
            this.dtmFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo_electronico = new System.Windows.Forms.TextBox();
            this.txtNumero_telefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.cmbTipo_solicitud = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "N. Solicitud:";
            // 
            // txtNSolicitud
            // 
            this.txtNSolicitud.Enabled = false;
            this.txtNSolicitud.Location = new System.Drawing.Point(97, 7);
            this.txtNSolicitud.Margin = new System.Windows.Forms.Padding(2);
            this.txtNSolicitud.Name = "txtNSolicitud";
            this.txtNSolicitud.ReadOnly = true;
            this.txtNSolicitud.Size = new System.Drawing.Size(22, 27);
            this.txtNSolicitud.TabIndex = 80;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(396, 62);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(258, 27);
            this.txtDireccion.TabIndex = 79;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(582, 268);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 27);
            this.btnCancelar.TabIndex = 78;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSolicitud
            // 
            this.btnEliminarSolicitud.Location = new System.Drawing.Point(439, 268);
            this.btnEliminarSolicitud.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarSolicitud.Name = "btnEliminarSolicitud";
            this.btnEliminarSolicitud.Size = new System.Drawing.Size(138, 27);
            this.btnEliminarSolicitud.TabIndex = 77;
            this.btnEliminarSolicitud.Text = "Eliminar solicitud";
            this.btnEliminarSolicitud.UseVisualStyleBackColor = true;
            // 
            // btnModificarSolicitud
            // 
            this.btnModificarSolicitud.Location = new System.Drawing.Point(295, 268);
            this.btnModificarSolicitud.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarSolicitud.Name = "btnModificarSolicitud";
            this.btnModificarSolicitud.Size = new System.Drawing.Size(138, 27);
            this.btnModificarSolicitud.TabIndex = 76;
            this.btnModificarSolicitud.Text = "Modificar solicitud";
            this.btnModificarSolicitud.UseVisualStyleBackColor = true;
            this.btnModificarSolicitud.Click += new System.EventHandler(this.btnModificarSolicitud_Click);
            // 
            // btnGuardarSolicitud
            // 
            this.btnGuardarSolicitud.Location = new System.Drawing.Point(153, 268);
            this.btnGuardarSolicitud.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarSolicitud.Name = "btnGuardarSolicitud";
            this.btnGuardarSolicitud.Size = new System.Drawing.Size(137, 27);
            this.btnGuardarSolicitud.TabIndex = 75;
            this.btnGuardarSolicitud.Text = "Guardar solicitud";
            this.btnGuardarSolicitud.UseVisualStyleBackColor = true;
            // 
            // btnNuevaSolicitud
            // 
            this.btnNuevaSolicitud.Location = new System.Drawing.Point(12, 268);
            this.btnNuevaSolicitud.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaSolicitud.Name = "btnNuevaSolicitud";
            this.btnNuevaSolicitud.Size = new System.Drawing.Size(137, 27);
            this.btnNuevaSolicitud.TabIndex = 74;
            this.btnNuevaSolicitud.Text = "Nueva solicitud";
            this.btnNuevaSolicitud.UseVisualStyleBackColor = true;
            this.btnNuevaSolicitud.Click += new System.EventHandler(this.btnNuevaSolicitud_Click);
            // 
            // dtmFechaSolicitud
            // 
            this.dtmFechaSolicitud.Enabled = false;
            this.dtmFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaSolicitud.Location = new System.Drawing.Point(450, 21);
            this.dtmFechaSolicitud.Margin = new System.Windows.Forms.Padding(2);
            this.dtmFechaSolicitud.Name = "dtmFechaSolicitud";
            this.dtmFechaSolicitud.Size = new System.Drawing.Size(146, 27);
            this.dtmFechaSolicitud.TabIndex = 73;
            // 
            // txtCorreo_electronico
            // 
            this.txtCorreo_electronico.Enabled = false;
            this.txtCorreo_electronico.Location = new System.Drawing.Point(158, 195);
            this.txtCorreo_electronico.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo_electronico.Name = "txtCorreo_electronico";
            this.txtCorreo_electronico.Size = new System.Drawing.Size(146, 27);
            this.txtCorreo_electronico.TabIndex = 72;
            // 
            // txtNumero_telefono
            // 
            this.txtNumero_telefono.Enabled = false;
            this.txtNumero_telefono.Location = new System.Drawing.Point(158, 154);
            this.txtNumero_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero_telefono.Name = "txtNumero_telefono";
            this.txtNumero_telefono.Size = new System.Drawing.Size(146, 27);
            this.txtNumero_telefono.TabIndex = 71;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(158, 113);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(146, 27);
            this.txtApellido.TabIndex = 70;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(158, 73);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 27);
            this.txtNombre.TabIndex = 69;
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Location = new System.Drawing.Point(158, 32);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(146, 27);
            this.txtCedula.TabIndex = 68;
            // 
            // cmbTipo_solicitud
            // 
            this.cmbTipo_solicitud.Enabled = false;
            this.cmbTipo_solicitud.FormattingEnabled = true;
            this.cmbTipo_solicitud.Location = new System.Drawing.Point(158, 237);
            this.cmbTipo_solicitud.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipo_solicitud.Name = "cmbTipo_solicitud";
            this.cmbTipo_solicitud.Size = new System.Drawing.Size(146, 28);
            this.cmbTipo_solicitud.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 240);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 66;
            this.label10.Text = "Tipo de solicitud:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Enabled = false;
            this.txtMensaje.Location = new System.Drawing.Point(326, 125);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(2);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(327, 139);
            this.txtMensaje.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Mensaje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Fecha de solicitud:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Correo electrónico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Número de teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Cédula:";
            // 
            // FrmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(685, 321);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNSolicitud);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarSolicitud);
            this.Controls.Add(this.btnModificarSolicitud);
            this.Controls.Add(this.btnGuardarSolicitud);
            this.Controls.Add(this.btnNuevaSolicitud);
            this.Controls.Add(this.dtmFechaSolicitud);
            this.Controls.Add(this.txtCorreo_electronico);
            this.Controls.Add(this.txtNumero_telefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.cmbTipo_solicitud);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmContacto";
            this.Text = "FrmContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private TextBox txtNSolicitud;
        private TextBox txtDireccion;
        private Button btnCancelar;
        private Button btnEliminarSolicitud;
        private Button btnModificarSolicitud;
        private Button btnGuardarSolicitud;
        private Button btnNuevaSolicitud;
        private DateTimePicker dtmFechaSolicitud;
        private TextBox txtCorreo_electronico;
        private TextBox txtNumero_telefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private ComboBox cmbTipo_solicitud;
        private Label label10;
        private TextBox txtMensaje;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}