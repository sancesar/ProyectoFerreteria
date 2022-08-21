using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Formularios.Atencion_al_cliente;

namespace Proyecto.Formularios
{
    public partial class FrmAtencionCliente : Form
    {
        private Form formularioHijoActual;
        public FrmAtencionCliente()
        {
            InitializeComponent();
        }
        private void abrirFormularios(Form formulario)
        {
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Close();
            }

            formularioHijoActual = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formulario);
            panelPrincipal.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            abrirFormularios(new FrmContacto());
            lblEtiqueta.Text = "Solicitud de contacto";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            abrirFormularios(new FrmDevoluciones());
            lblEtiqueta.Text = "Solicitud de devolución";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            abrirFormularios(new FrmNuevodistribuidor());
            lblEtiqueta.Text = "Solicitud de distribuidor";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Close();
            }
            lblEtiqueta.Text = "";
        }

        private void LblCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Seguro que desea cerrar sesión?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FrmLogin FrmLogin = new FrmLogin();
                FrmLogin.Show();
                this.Close();
            }
        }
    }
}
