using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Formularios.Atencion_al_cliente
{
    public partial class FrmContacto : Form
    {
        public FrmContacto()
        {
            InitializeComponent();
        }

        private void btnNuevaSolicitud_Click(object sender, EventArgs e)
        {
            txtCedula.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtNumero_telefono.Enabled = true;
            txtCorreo_electronico.Enabled = true;
            cmbTipo_solicitud.Enabled = true;
            txtDireccion.Enabled = true;
            txtMensaje.Enabled = true;
        }

        private void btnModificarSolicitud_Click(object sender, EventArgs e)
        {
            FrmModificarsolicitud frmCont = new FrmModificarsolicitud();
            frmCont.Show();
        }
    }
}
