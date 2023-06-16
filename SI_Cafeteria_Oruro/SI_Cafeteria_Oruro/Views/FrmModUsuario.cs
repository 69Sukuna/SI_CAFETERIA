using SI_Cafeteria_Oruro.Controller;
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
    public partial class FrmModUsuario : Form
    {
        public FrmModUsuario()
        {
            InitializeComponent();
        }

        private void usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        UsuarioController _usuarioController = new UsuarioController();
        //Es un nuevo usuario?
        bool _isNew = true;
        private void FrmModUsuario_Load(object sender, EventArgs e)
        {
            //Cuando se carga aparece todos los usuarios en el DataGrid
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //Desabilita el group box
            groupBoxUsuario.Enabled = false;
            //Desabilita los cambios
            usuarioBindingSource.CancelEdit();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar()
        {
            var user = (Usuario)usuarioBindingSource.Current;
            if(_isNew == true)
            {
                _usuarioController.Create(user);
            }
            else
            {
                _usuarioController.Update(user);
            }

            groupBoxUsuario.Enabled = false;
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
        }

        private void BtnNuevoUser_Click(object sender, EventArgs e)
        {
            _isNew = true;
            groupBoxUsuario.Enabled = true;
            usuarioBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _isNew = false;
            groupBoxUsuario.Enabled = true;

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //se recupera todo del usuario seleccionado
            var user = (Usuario)usuarioBindingSource.Current;

            DialogResult dlr = MessageBox.Show("Esta seguro de ELIMINAR el registro?",
                "CAFETERIA", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (dlr == DialogResult.OK)
            {
                _usuarioController.Delete(user);
            }
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            String par = TxtBuscar.Text;

            usuarioBindingSource.DataSource = _usuarioController.Search(par);
        }
    }
}
