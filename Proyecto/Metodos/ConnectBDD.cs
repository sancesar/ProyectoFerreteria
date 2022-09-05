using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;
using Proyecto.Formularios;

namespace Proyecto.Metodos
{
    public class ConnectBDD
    {
        MySqlConnection connectionBD = new MySqlConnection("server= btxxzyr0ildyylyibkf2-mysql.services.clever-cloud.com; " +
            "port= 3306; user id=uiw3felwq3nefzn6; password=byRQJsOZPoqRUBP6Gomr; database=btxxzyr0ildyylyibkf2;");
        MySqlDataReader reader = null;
        public void BddConnect()
        {
            string datos = "";
            try
            {
                connectionBD.Open();
                
                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", connectionBD);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                }

            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("CL-Cloud Services\n" + "Schema: " + datos);

        }

        public Boolean login(string usuario, string clave)
        {

            string usu = usuario;
            string cla = clave;
            FrmProduccion frmPro = new FrmProduccion();
            FrmLogistica frmLogis = new FrmLogistica();
            FrmAtencionCliente frmAtCl = new FrmAtencionCliente();
            FrmProveedores frmProv = new FrmProveedores();
            FrmInventario frmIn = new FrmInventario();
            FrmFacturacion frmFa = new FrmFacturacion();
            FrmLogin frmLog = new FrmLogin();
            try
            {
                connectionBD.Open();
                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand("SELECT Nombre_de_usu, Clave, Rol FROM btxxzyr0ildyylyibkf2.Usuarios WHERE Nombre_de_usu = @usu AND " +
                    "Clave = @cla", connectionBD);
                cmd.Parameters.AddWithValue("@usu", usu);
                cmd.Parameters.AddWithValue("@cla", cla);
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (Convert.ToString(reader["Nombre_de_usu"]) == usu && Convert.ToString(reader["Clave"]) == cla)
                    {
                        MessageBox.Show("Inicio de sesión excitosa...", "Conectado");
                        if (Convert.ToString(reader["Rol"]) == "Produccion")
                        {
                            frmPro.Show();
                            return true;
                        }else if (Convert.ToString(reader["Rol"]) == "Logistica")
                        {
                           frmLogis.Show();
                            return true;
                        }
                        else if (Convert.ToString(reader["Rol"]) == "Atencion al cliente")
                        {
                            frmAtCl.Show();
                            return true;
                        }
                        else if (Convert.ToString(reader["Rol"]) == "Compras")
                        {
                            frmProv.Show();
                            return true;
                        }
                        else if (Convert.ToString(reader["Rol"]) == "Inventario")
                        {
                            frmIn.Show();
                            return true;
                        }
                        else if (Convert.ToString(reader["Rol"]) == "Facturacion")
                        {
                            frmFa.Show();
                            return true;
                        }
                    }
                   
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(""+ex.ToString());
                return false;
            }
            return false;
        }

        public void Actulizar(ListView listProceso)
        {
            
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM btxxzyr0ildyylyibkf2.Produccion;", connectionBD);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adap.Fill(ds);
            tabla = ds.Tables[0];
            listProceso.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {

                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["IdLote"].ToString());
                elementos.SubItems.Add(filas["Produc_Ela"].ToString());
                elementos.SubItems.Add(filas["Fech_Ela"].ToString());
                elementos.SubItems.Add(filas["Cant_Ela"].ToString());
                elementos.SubItems.Add(filas["Marca"].ToString());
                listProceso.Items.Add(elementos);
            }
        }

        public void Actulizar2(ListView listProceso)
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM btxxzyr0ildyylyibkf2.Produccion;", connectionBD);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adap.Fill(ds);
            tabla = ds.Tables[0];
            listProceso.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                llenarlist(i, tabla, listProceso);
            }
        }

        public void Produccion(string lote,string producto, string fecha, string cantidad, string marca)
        {
            string id = lote;
            string pro = producto;
            string fec = fecha;
            string can = cantidad;
            string mar = marca;
            int valalt = 0;
            string pre = "";
            int max = 1000;
            int min = Int32.Parse(cantidad);

            Random rnd = new Random();
            valalt = (rnd.Next(min, max + 1));
            pre = valalt.ToString();
            try
            {
                connectionBD.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `btxxzyr0ildyylyibkf2`.`Produccion` (`IdLote`, `Produc_Ela`, `Fech_Ela`, `Cant_Ela`, `Marca`, `Cant_Re` ) " +
                    "VALUES ('" + id + "','" + pro + "','" + fec + "','" + can + "','" + mar + "','" + pre + "');", connectionBD);
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
        }

        public void Buscar(string produc, string marbu, ListView listProceso)
        {
            if (marbu == "")
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM btxxzyr0ildyylyibkf2.Produccion WHERE Produc_Ela = @produc ;", connectionBD);
                cmd.Parameters.AddWithValue("@produc", produc);
                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adap.Fill(ds);
                tabla = ds.Tables[0];
                listProceso.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    llenarlist(i, tabla, listProceso);
                }
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM btxxzyr0ildyylyibkf2.Produccion WHERE Produc_Ela = @produc AND Marca = @marca ;", connectionBD);
                cmd.Parameters.AddWithValue("@produc", produc);
                cmd.Parameters.AddWithValue("@marca", marbu);
                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                DataSet ds = new DataSet();
                DataTable tabla = new DataTable();
                adap.Fill(ds);
                tabla = ds.Tables[0];
                listProceso.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    llenarlist(i, tabla, listProceso);
                }
            }

        }

        private void llenarlist(int i, DataTable tabla, ListView listProceso)
        {
            DataRow filas = tabla.Rows[i];
            ListViewItem elementos = new ListViewItem(filas["IdLote"].ToString());
            elementos.SubItems.Add(filas["Produc_Ela"].ToString());
            elementos.SubItems.Add(filas["Fech_Ela"].ToString());
            elementos.SubItems.Add(filas["Marca"].ToString());
            elementos.SubItems.Add(filas["Cant_Ela"].ToString());
            elementos.SubItems.Add(filas["Cant_Re"].ToString());
            listProceso.Items.Add(elementos);
        }

        internal void BuscarEdi(TextBox TxtIdModi, TextBox txtMarEdi, TextBox txtProEdi, TextBox txtCanEdi, TextBox txtFecEdi)
        {
            try
            {
                connectionBD.Open();
                string id = TxtIdModi.Text;
                MySqlCommand cmd = new MySqlCommand("SELECT Produc_Ela, Fech_Ela, Cant_Ela, Marca FROM btxxzyr0ildyylyibkf2.Produccion WHERE IdLote = @id ;", connectionBD);
                cmd.Parameters.AddWithValue("@id", id);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtProEdi.Text = reader.GetString(0);
                        txtFecEdi.Text = reader.GetString(1);
                        txtCanEdi.Text = reader.GetString(2);
                        txtMarEdi.Text = reader.GetString(3);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro lote...");
                    
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                connectionBD.Close();
            }
        }

        public void ActulizarEdi(TextBox txtIdModi, TextBox txtMarEdi, TextBox txtProEdi, TextBox txtCanEdi, TextBox txtFecEdi)
        {
            string id = txtIdModi.Text;
            string pro = txtProEdi.Text;
            string fec = txtFecEdi.Text;
            string can = txtCanEdi.Text;
            string mar = txtMarEdi.Text;

            try
            {
                
                MySqlCommand cmd = new MySqlCommand("UPDATE `btxxzyr0ildyylyibkf2`.`Produccion` SET `Produc_Ela` = '" + pro + "', " +
                    "`Fech_Ela` = '" + fec + "', `Cant_Ela` = '" + can + "', `Marca` = '" + mar + "' WHERE `IdLote` = '" + id + "';", connectionBD);
                connectionBD.Open();
                cmd.ExecuteNonQuery(); 
                

                MessageBox.Show("Producto Actualizado...");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex.ToString());
            }finally
            {
                connectionBD.Close();
            }
        }
    }
}
