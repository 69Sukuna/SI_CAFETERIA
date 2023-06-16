using SI_Cafeteria_Oruro.Contex;
using SI_Cafeteria_Oruro.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SI_Cafeteria_Oruro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Creando las clases en la BBD
            //ModelCafeteria db = new ModelCafeteria();
            //var usuarios = db.Usuario.ToList();
            //var clientes = db.Cliente.ToList();
            //var productos = db.Producto.ToList();
            //var historialventas = db.HistorialVenta.ToList();
        }      
        
        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = TxtUser.Text;
            String password = TxtPasword.Text;
            UsuarioController usuarioController = new UsuarioController();

            bool isLogin = usuarioController.Login(usuario, password);
            if(isLogin)
            {
                FrmMainMenu frmprin = new FrmMainMenu();
                frmprin.Show(); 
                
            }
            else
            {
                MessageBox.Show("Usuario y/o Password Incorrectos",
                    "Login Cafeteria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
           
        }
    }
}
