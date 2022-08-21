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
    public partial class FrmLogistica : Form
    {
        string codigo = "";
        string region = "";
        string provincia = "";
        public FrmLogistica()
        {
            InitializeComponent();
        }
        private void Lista_Inventario_Click(object sender, EventArgs e)
        {
            txtCodigoI.Text = "Ingrese el código del producto";
            txtCodigoI.ForeColor = Color.Gray;
        }

        private void Transporte_Productos_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = "Ingrese el código del producto";
            txtCodigoP.ForeColor = Color.Gray;

            cmbRegion.Text = "Seleccione la región";
            cmbRegion.ForeColor = Color.Gray;

            cmbProvincia.Text = "Seleccione la provincia";
            cmbProvincia.ForeColor = Color.Gray;
        }

        private void Entregas_Realizadas_Click(object sender, EventArgs e)
        {
            txtCodigoR.Text = "Ingrese el código del producto";
            txtCodigoR.ForeColor = Color.Gray;
        }

        private void Productos_Devueltos_Click(object sender, EventArgs e)
        {
            txtCodigoD.Text = "Ingrese el código del producto";
            txtCodigoD.ForeColor = Color.Gray;
        }

        private void cmbRegion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbRegion.SelectedItem.ToString() == "Costa")
            {
                cmbProvincia.Items.Clear();

                cmbProvincia.Items.Add("Esmeraldas");
                cmbProvincia.Items.Add("Manabí");
                cmbProvincia.Items.Add("Los Ríos");
                cmbProvincia.Items.Add("Santa Elena");
                cmbProvincia.Items.Add("Guayas");
                cmbProvincia.Items.Add("El Oro");
                cmbProvincia.Items.Add("Santo Domingo de los Tsáchilas");

            }
            else
            {
                if (cmbRegion.SelectedItem.ToString() == "Sierra")
                {
                    cmbProvincia.Items.Clear();

                    cmbProvincia.Items.Add("Carchi");
                    cmbProvincia.Items.Add("Imbabura");
                    cmbProvincia.Items.Add("Pichincha");
                    cmbProvincia.Items.Add("Cotopaxi");
                    cmbProvincia.Items.Add("Chimborazo");
                    cmbProvincia.Items.Add("Tungurahua");
                    cmbProvincia.Items.Add("Cañar");
                    cmbProvincia.Items.Add("Bolivar");
                    cmbProvincia.Items.Add("Azuay");
                    cmbProvincia.Items.Add("Loja");
                }
                else
                {
                    if (cmbRegion.SelectedItem.ToString() == "Oriente")
                    {
                        cmbProvincia.Items.Clear();

                        cmbProvincia.Items.Add("Morona Santiago");
                        cmbProvincia.Items.Add("Napo");
                        cmbProvincia.Items.Add("Orellana");
                        cmbProvincia.Items.Add("Pastaza");
                        cmbProvincia.Items.Add("Sucumbíos");
                        cmbProvincia.Items.Add("Zamora Chinchipe");
                    }
                    else
                    {
                        if (cmbRegion.SelectedItem.ToString() == "Insular")
                        {
                            cmbProvincia.Items.Clear();

                            cmbProvincia.Items.Add("Galápagos");
                        }
                    }
                }
            }
        }

        private void txtCodigoI_TextChanged(object sender, EventArgs e) { }

        private void txtCodigoI_Enter(object sender, EventArgs e)
        {
            txtCodigoI.Text = "";
            txtCodigoI.ForeColor = Color.Black;
        }

        private void txtCodigoI_Leave(object sender, EventArgs e)
        {
            codigo = txtCodigoI.Text;
            if (codigo.Equals("Ingrese el código del producto"))
            {
                txtCodigoI.Text = "Ingrese el código del producto";
                txtCodigoI.ForeColor = Color.Gray;
            }
            else
            {
                if (codigo.Equals(""))
                {
                    txtCodigoI.Text = "Ingrese el código del producto";
                    txtCodigoI.ForeColor = Color.Gray;
                }
                else
                {
                    txtCodigoI.Text = codigo;
                    txtCodigoI.ForeColor = Color.Gray;
                }
            }
        }

        private void txtCodigoP_Enter(object sender, EventArgs e)
        {
            txtCodigoP.Text = "";
            txtCodigoP.ForeColor = Color.Black;
        }

        private void txtCodigoP_Leave(object sender, EventArgs e)
        {
            codigo = txtCodigoP.Text;
            if (codigo.Equals("Ingrese el código del producto"))
            {
                txtCodigoP.Text = "Ingrese el código del producto";
                txtCodigoP.ForeColor = Color.Gray;
            }
            else
            {
                if (codigo.Equals(""))
                {
                    txtCodigoP.Text = "Ingrese el código del producto";
                    txtCodigoP.ForeColor = Color.Gray;
                }
                else
                {
                    txtCodigoP.Text = codigo;
                    txtCodigoP.ForeColor = Color.Gray;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e) { }

        private void txtCodigoR_Enter(object sender, EventArgs e)
        {
            txtCodigoR.Text = "";
            txtCodigoR.ForeColor = Color.Black;
        }

        private void txtCodigoR_Leave(object sender, EventArgs e)
        {
            codigo = txtCodigoR.Text;
            if (codigo.Equals("Ingrese el código del producto"))
            {
                txtCodigoR.Text = "Ingrese el código del producto";
                txtCodigoR.ForeColor = Color.Gray;
            }
            else
            {
                if (codigo.Equals(""))
                {
                    txtCodigoR.Text = "Ingrese el código del producto";
                    txtCodigoR.ForeColor = Color.Gray;
                }
                else
                {
                    txtCodigoR.Text = codigo;
                    txtCodigoR.ForeColor = Color.Gray;
                }
            }
        }

        private void txtCodigoD_Enter(object sender, EventArgs e)
        {
            txtCodigoD.Text = "";
            txtCodigoD.ForeColor = Color.Black;
        }

        private void txtCodigoD_Leave(object sender, EventArgs e)
        {
            codigo = txtCodigoD.Text;
            if (codigo.Equals("Ingrese el código del producto"))
            {
                txtCodigoD.Text = "Ingrese el código del producto";
                txtCodigoD.ForeColor = Color.Gray;
            }
            else
            {
                if (codigo.Equals(""))
                {
                    txtCodigoD.Text = "Ingrese el código del producto";
                    txtCodigoD.ForeColor = Color.Gray;
                }
                else
                {
                    txtCodigoD.Text = codigo;
                    txtCodigoD.ForeColor = Color.Gray;
                }
            }
        }

        private void cmbRegion_Enter(object sender, EventArgs e)
        {
            cmbRegion.Text = "";
            cmbRegion.ForeColor = Color.Black;
        }

        private void cmbRegion_Leave(object sender, EventArgs e)
        {
            region = cmbRegion.Text;
            if (region.Equals("Seleccione la región"))
            {
                cmbRegion.Text = "Seleccione la región";
                cmbRegion.ForeColor = Color.Gray;
            }
            else
            {
                if (region.Equals(""))
                {
                    cmbRegion.Text = "Seleccione la región";
                    cmbRegion.ForeColor = Color.Gray;
                }
                else
                {
                    cmbRegion.Text = region;
                    cmbRegion.ForeColor = Color.Gray;
                }
            }
        }

        private void cmbProvincia_Enter(object sender, EventArgs e)
        {
            cmbProvincia.Text = "";
            cmbProvincia.ForeColor = Color.Black;
        }

        private void cmbProvincia_Leave(object sender, EventArgs e)
        {
            provincia = cmbProvincia.Text;
            if (region.Equals("Seleccione la región"))
            {
                cmbProvincia.Text = "Seleccione la región";
                cmbProvincia.ForeColor = Color.Gray;
            }
            else
            {
                if (provincia.Equals(""))
                {
                    cmbProvincia.Text = "Seleccione la región";
                    cmbProvincia.ForeColor = Color.Gray;
                }
                else
                {
                    cmbProvincia.Text = provincia;
                    cmbProvincia.ForeColor = Color.Gray;
                }
            }
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
