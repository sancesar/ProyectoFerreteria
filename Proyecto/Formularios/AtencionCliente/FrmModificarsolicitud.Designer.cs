namespace Proyecto.Formularios.Atencion_al_cliente
{
    partial class FrmModificarsolicitud
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
            this.dgv_Modificar_Solicitud = new System.Windows.Forms.DataGridView();
            this.N_Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modificar_Solicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Modificar_Solicitud
            // 
            this.dgv_Modificar_Solicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Modificar_Solicitud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Solicitud,
            this.Nombres,
            this.Apellidos,
            this.Cedula,
            this.Numero_Telefono,
            this.Email,
            this.Tipo_Solicitud,
            this.Fecha_Solicitud,
            this.Mensaje});
            this.dgv_Modificar_Solicitud.Location = new System.Drawing.Point(11, 11);
            this.dgv_Modificar_Solicitud.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Modificar_Solicitud.Name = "dgv_Modificar_Solicitud";
            this.dgv_Modificar_Solicitud.RowHeadersWidth = 62;
            this.dgv_Modificar_Solicitud.RowTemplate.Height = 33;
            this.dgv_Modificar_Solicitud.Size = new System.Drawing.Size(660, 238);
            this.dgv_Modificar_Solicitud.TabIndex = 1;
            // 
            // N_Solicitud
            // 
            this.N_Solicitud.HeaderText = "N_Solicitud";
            this.N_Solicitud.MinimumWidth = 8;
            this.N_Solicitud.Name = "N_Solicitud";
            this.N_Solicitud.Width = 150;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.MinimumWidth = 8;
            this.Nombres.Name = "Nombres";
            this.Nombres.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 8;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 150;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 8;
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 150;
            // 
            // Numero_Telefono
            // 
            this.Numero_Telefono.HeaderText = "Numero_Telefono";
            this.Numero_Telefono.MinimumWidth = 8;
            this.Numero_Telefono.Name = "Numero_Telefono";
            this.Numero_Telefono.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Tipo_Solicitud
            // 
            this.Tipo_Solicitud.HeaderText = "Tipo_Solicitud";
            this.Tipo_Solicitud.MinimumWidth = 8;
            this.Tipo_Solicitud.Name = "Tipo_Solicitud";
            this.Tipo_Solicitud.Width = 150;
            // 
            // Fecha_Solicitud
            // 
            this.Fecha_Solicitud.HeaderText = "Fecha_Solicitud";
            this.Fecha_Solicitud.MinimumWidth = 8;
            this.Fecha_Solicitud.Name = "Fecha_Solicitud";
            this.Fecha_Solicitud.Width = 150;
            // 
            // Mensaje
            // 
            this.Mensaje.HeaderText = "Mensaje";
            this.Mensaje.MinimumWidth = 8;
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Width = 150;
            // 
            // FrmModificarsolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 260);
            this.Controls.Add(this.dgv_Modificar_Solicitud);
            this.Name = "FrmModificarsolicitud";
            this.Text = "FrmModificarsolicitud";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modificar_Solicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_Modificar_Solicitud;
        private DataGridViewTextBoxColumn N_Solicitud;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Numero_Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Tipo_Solicitud;
        private DataGridViewTextBoxColumn Fecha_Solicitud;
        private DataGridViewTextBoxColumn Mensaje;
    }
}