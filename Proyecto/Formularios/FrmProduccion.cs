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
        private void LlenarProducto()
        {
            LbEdi.Items.Clear();
            LbEdi.Items.Add("Destornillador");
            LbEdi.Items.Add("Juego de llaves");
            LbEdi.Items.Add("Alicate");
            LbEdi.Items.Add("Pala");
            LbEdi.Items.Add("Clavos");
            LbEdi.Items.Add("Tornillos");
            LbEdi.Items.Add("Espatulas");
            LbEdi.Items.Add("Tuercas");
            LbEdi.Items.Add("Pinzas");
            LbEdi.Items.Add("Brochas");
        }
        private void LlenarMarca()
        {
            LbEdi.Items.Clear();
            LbEdi.Items.Add("Truper");
            LbEdi.Items.Add("Urrea");
            LbEdi.Items.Add("Nacobre");
            LbEdi.Items.Add("Bosch");
            LbEdi.Items.Add("DeWalt");
            LbEdi.Items.Add("Rotoplas");
            LbEdi.Items.Add("Austromex");
            LbEdi.Items.Add("Phillips");
            LbEdi.Items.Add("Makita");
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

        private void BtnProEdi_Click(object sender, EventArgs e)
        {
            LblModi.Text = "Producto";
            LlenarProducto();
        }

        private void BtnMarcEdi_Click(object sender, EventArgs e)
        {
            LblModi.Text = "Marca";
            LlenarMarca();
        }

        private void LbEdi_DoubleClick(object sender, EventArgs e)
        {

            if (LbEdi.Items.Count == 10)
            {

                TxtProEdi.Text = LbEdi.SelectedItem.ToString();
            }
            else
            {
                TxtMarEdi.Text = LbEdi.SelectedItem.ToString();
            }
        }

        private void BtnBusEdi_Click(object sender, EventArgs e)
        {
            TxtIdModi.Enabled = false;
            Bd.BuscarEdi(TxtIdModi,TxtMarEdi,TxtProEdi,TxtCanEdi,TxtFecEdi);
        }

        private void BtnActEdi_Click(object sender, EventArgs e)
        {
            Bd.ActulizarEdi(TxtIdModi, TxtMarEdi, TxtProEdi, TxtCanEdi, TxtFecEdi);
            Limpiar();
            
        }

        private void Limpiar()
        {
            TxtCanEdi.Text = "";
            TxtFecEdi.Text = "";
            TxtProEdi.Text = "";
            TxtMarEdi.Text = "";
            TxtIdModi.Text = "";
            TxtIdModi.Enabled = true;
        }
    }
}
