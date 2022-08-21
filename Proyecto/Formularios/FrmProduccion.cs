using Proyecto.Metodos;
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
    public partial class FrmProduccion : Form
    {
        ConnectBDD Bd = new ConnectBDD();
        public FrmProduccion()
        {
            InitializeComponent();
            SetFecha();
        }
        private void SetFecha()
        {
            DtEla.MinDate = DateTime.Now.Date;
            DtEla.MaxDate = DateTime.Now.Date.AddYears(2);
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

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            string Lote = TxtIdLote.Text;
            string Producto = CmbProEla.Text;
            string Fecha = DtEla.Text;
            string Cantidad = TxtCanEla.Text;
            string Marca = CmbMarca.Text;
            if (string.IsNullOrEmpty(Producto) || string.IsNullOrEmpty(Cantidad))
            {
                MessageBox.Show("Por favor llenar todos los campos....", "Sistema");

            }else
            {
                Bd.Produccion(Lote,Producto, Fecha, Cantidad, Marca);
               
            }
            TxtCanEla.Clear();
            TxtIdLote.Clear();
        }

        private void BtnActu_Click(object sender, EventArgs e)
        {
            Bd.Actulizar(ListProceso);
        }
    }
}
