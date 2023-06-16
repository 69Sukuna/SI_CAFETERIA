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
    public partial class FrmModificarProductos : Form
    {
        public FrmModificarProductos()
        {
            InitializeComponent();
        }
        ProductoController _productoController = new ProductoController();
        //Es un nuevo usuario?
        bool _isNew = true;
        private void BtnNuevoProd_Click(object sender, EventArgs e)
        {
            _isNew = true;
            groupBoxProducto.Enabled = true;
            productoBindingSource.AddNew();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _isNew = false;
            groupBoxProducto.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //se recupera todo del producto seleccionado
            var prod = (Producto)productoBindingSource.Current;

            DialogResult dlr = MessageBox.Show("Esta seguro de ELIMINAR el registro?",
                "CAFETERIA", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (dlr == DialogResult.OK)
            {
                _productoController.Delete(prod);
            }
            productoBindingSource.DataSource = _productoController.GetAll();
        }

        private void FrmModificarProductos_Load(object sender, EventArgs e)
        {
            //Cuando se carga aparece todos los usuarios en el DataGrid
           productoBindingSource.DataSource = _productoController.GetAll();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //Desabilita el group box
            groupBoxProducto.Enabled = false;
            //Desabilita los cambios
            productoBindingSource.CancelEdit();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Guardar()
        {
            var user = (Producto)productoBindingSource.Current;
            if (_isNew == true)
            {
                _productoController.Create(user);
            }
            else
            {
                _productoController.Update(user);
            }

            groupBoxProducto.Enabled = false;
            productoBindingSource.DataSource = _productoController.GetAll();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            String par = TxtBuscar.Text;

            productoBindingSource.DataSource = _productoController.Search(par);
        }
    }
}
