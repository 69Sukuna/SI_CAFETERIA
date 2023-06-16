namespace SI_Cafeteria_Oruro
{
    partial class FrmModificarProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cantProductLabel;
            System.Windows.Forms.Label nomProductLabel;
            System.Windows.Forms.Label precioProductLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarProductos));
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cantProductTextBox = new System.Windows.Forms.TextBox();
            this.nomProductTextBox = new System.Windows.Forms.TextBox();
            this.precioProductTextBox = new System.Windows.Forms.TextBox();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNuevoProd = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cantProductLabel = new System.Windows.Forms.Label();
            nomProductLabel = new System.Windows.Forms.Label();
            precioProductLabel = new System.Windows.Forms.Label();
            this.groupBoxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cantProductLabel
            // 
            cantProductLabel.AutoSize = true;
            cantProductLabel.Location = new System.Drawing.Point(23, 135);
            cantProductLabel.Name = "cantProductLabel";
            cantProductLabel.Size = new System.Drawing.Size(96, 18);
            cantProductLabel.TabIndex = 4;
            cantProductLabel.Text = "Cant Product:";
            // 
            // nomProductLabel
            // 
            nomProductLabel.AutoSize = true;
            nomProductLabel.Location = new System.Drawing.Point(23, 88);
            nomProductLabel.Name = "nomProductLabel";
            nomProductLabel.Size = new System.Drawing.Size(128, 18);
            nomProductLabel.TabIndex = 6;
            nomProductLabel.Text = "Nombre Producto:";
            // 
            // precioProductLabel
            // 
            precioProductLabel.AutoSize = true;
            precioProductLabel.Location = new System.Drawing.Point(23, 199);
            precioProductLabel.Name = "precioProductLabel";
            precioProductLabel.Size = new System.Drawing.Size(115, 18);
            precioProductLabel.TabIndex = 8;
            precioProductLabel.Text = "Precio Producto:";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(40, 359);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(112, 32);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(237, 359);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(112, 32);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.label1);
            this.groupBoxProducto.Controls.Add(cantProductLabel);
            this.groupBoxProducto.Controls.Add(this.cantProductTextBox);
            this.groupBoxProducto.Controls.Add(nomProductLabel);
            this.groupBoxProducto.Controls.Add(this.nomProductTextBox);
            this.groupBoxProducto.Controls.Add(precioProductLabel);
            this.groupBoxProducto.Controls.Add(this.precioProductTextBox);
            this.groupBoxProducto.Controls.Add(this.BtnCancelar);
            this.groupBoxProducto.Controls.Add(this.BtnAceptar);
            this.groupBoxProducto.Enabled = false;
            this.groupBoxProducto.Location = new System.Drawing.Point(34, 47);
            this.groupBoxProducto.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProducto.Size = new System.Drawing.Size(378, 438);
            this.groupBoxProducto.TabIndex = 1;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bs.";
            // 
            // cantProductTextBox
            // 
            this.cantProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "CantProduct", true));
            this.cantProductTextBox.Location = new System.Drawing.Point(160, 135);
            this.cantProductTextBox.Name = "cantProductTextBox";
            this.cantProductTextBox.Size = new System.Drawing.Size(100, 26);
            this.cantProductTextBox.TabIndex = 5;
            // 
            // nomProductTextBox
            // 
            this.nomProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "NomProduct", true));
            this.nomProductTextBox.Location = new System.Drawing.Point(160, 85);
            this.nomProductTextBox.Name = "nomProductTextBox";
            this.nomProductTextBox.Size = new System.Drawing.Size(132, 26);
            this.nomProductTextBox.TabIndex = 7;
            // 
            // precioProductTextBox
            // 
            this.precioProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "PrecioProduct", true));
            this.precioProductTextBox.Location = new System.Drawing.Point(160, 199);
            this.precioProductTextBox.Name = "precioProductTextBox";
            this.precioProductTextBox.Size = new System.Drawing.Size(100, 26);
            this.precioProductTextBox.TabIndex = 9;
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToAddRows = false;
            this.productoDataGridView.AllowUserToDeleteRows = false;
            this.productoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(449, 64);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.ReadOnly = true;
            this.productoDataGridView.Size = new System.Drawing.Size(739, 374);
            this.productoDataGridView.TabIndex = 2;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(289, 12);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(97, 23);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(192, 12);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(91, 23);
            this.BtnEditar.TabIndex = 12;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNuevoProd
            // 
            this.BtnNuevoProd.Location = new System.Drawing.Point(40, 12);
            this.BtnNuevoProd.Name = "BtnNuevoProd";
            this.BtnNuevoProd.Size = new System.Drawing.Size(146, 23);
            this.BtnNuevoProd.TabIndex = 11;
            this.BtnNuevoProd.Text = "Nuevo Producto";
            this.BtnNuevoProd.UseVisualStyleBackColor = true;
            this.BtnNuevoProd.Click += new System.EventHandler(this.BtnNuevoProd_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(635, 15);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(348, 26);
            this.TxtBuscar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar: ";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(1017, 18);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(93, 23);
            this.BtnBuscar.TabIndex = 14;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomProduct";
            this.dataGridViewTextBoxColumn1.HeaderText = "NomProduct";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CantProduct";
            this.dataGridViewTextBoxColumn2.HeaderText = "CantProduct";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrecioProduct";
            this.dataGridViewTextBoxColumn3.HeaderText = "PrecioProduct";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(SI_Cafeteria_Oruro.Models.Producto);
            // 
            // FrmModificarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevoProd);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(this.groupBoxProducto);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmModificarProductos";
            this.Text = "FrmModificarProductos";
            this.Load += new System.EventHandler(this.FrmModificarProductos_Load);
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.TextBox cantProductTextBox;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox nomProductTextBox;
        private System.Windows.Forms.TextBox precioProductTextBox;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNuevoProd;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
    }
}