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
            esconder();
            Bd.Actulizar2(Listvali);
            Bd.Actulizar(ListProceso);
        }
        private void esconder()
        {
            lblSelec.Visible = false;
            BtnBusqAvan.Visible = false;
            Lblpro.Visible = false;
            Cbbproducto.Visible = false;
            Gbmarca.Visible = false;
            BtnBuscar.Visible = false;
            Btncancelar.Visible = false;
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
            Bd.Actulizar2(Listvali);
        }

        private void BtnBuscarDat_Click(object sender, EventArgs e)
        {
            lblSelec.Visible = true;
            BtnBusqAvan.Visible = true;
            Lblpro.Visible = true;
            Cbbproducto.Visible = true;
            Btncancelar.Visible = true;
            BtnBuscar.Visible = true;
            BtnBuscarDat.Visible = false;

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            lblSelec.Visible = false;
            BtnBusqAvan.Visible = false;
            Lblpro.Visible = false;
            Cbbproducto.Visible = false;
            Gbmarca.Visible = false;
            Btncancelar.Visible = false;
            BtnBuscar.Visible = false;
            BtnBuscarDat.Visible = true;
            Bd.Actulizar2(Listvali);
        }

        private void BtnBusqAvan_Click(object sender, EventArgs e)
        {
            Gbmarca.Visible = true;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string produc = Cbbproducto.Text;
            string marbu = CbbMarcaBu.Text;

            Bd.Buscar(produc, marbu, Listvali);
        }
    }
}
