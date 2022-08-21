using Proyecto.Metodos;

namespace Proyecto
{
    public partial class FrmLogin : Form
    {
        ConnectBDD Bd = new ConnectBDD();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Btnacep_Click(object sender, EventArgs e)
        {
            string usuario = Txtusu.Text;
            string clave = Txtcontr.Text;
            Boolean contrane = false;
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor llenar todos los campos....", "Sistema");
                
            }
            else
            {
                
                contrane = Bd.login(usuario, clave);
                if(contrane == true)
                {
                    this.Hide();
                }else
                {
                    MessageBox.Show("Usuario/Clave incorrectas....", "Sistema");
                }
                
                //Bd.BddConnect();
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}