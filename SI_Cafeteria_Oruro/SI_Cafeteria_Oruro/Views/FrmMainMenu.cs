using SI_Cafeteria_Oruro.Models;
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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu(Usuario usLog)
        {
            InitializeComponent();
            NomUserPrin.Text = "Bienvenido al sistema\n"+usLog.NombreCompleto;
            toolStripStatusMessage.Text = "Cafeteria Oruro v1.0 Usuario: "+ usLog.NombreCompleto;
            if (usLog.CargoUser != "Gerente")
            {
                modificarUsuarioToolStripMenuItem.Enabled = false;
                modificarUsuarioToolStripMenuItem.Visible = false;
                modificarVentaToolStripMenuItem.Enabled = false;
                modificarVentaToolStripMenuItem.Visible = false;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NomUserPrin.Visible = false;
            FrmModificarProductos frmProductosMod = new FrmModificarProductos();
            frmProductosMod.MdiParent = this;
            frmProductosMod.WindowState = FormWindowState.Maximized;
            frmProductosMod.Show();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NomUserPrin.Visible = false;
            FrmModUsuario frmModUser= new FrmModUsuario();
            frmModUser.MdiParent = this;
            frmModUser.WindowState = FormWindowState.Maximized;
            frmModUser.Show();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
