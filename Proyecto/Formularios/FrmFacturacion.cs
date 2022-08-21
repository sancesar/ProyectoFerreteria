using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Formularios
{
    public partial class FrmFacturacion : Form
    {
        public FrmFacturacion()
        {
            InitializeComponent();
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
