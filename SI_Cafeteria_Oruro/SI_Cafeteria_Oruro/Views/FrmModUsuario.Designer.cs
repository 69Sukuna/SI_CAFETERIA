namespace SI_Cafeteria_Oruro
{
    partial class FrmModUsuario
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
            System.Windows.Forms.Label cargoUserLabel;
            System.Windows.Forms.Label estadoUserLabel;
            System.Windows.Forms.Label nombreCompletoLabel;
            System.Windows.Forms.Label paswordUserLabel;
            System.Windows.Forms.Label nomUserLabel1;
            System.Windows.Forms.Label nomUserLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnNuevoUser = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.nomUserLabel2 = new System.Windows.Forms.Label();
            this.cargoUserComboBox = new System.Windows.Forms.ComboBox();
            this.estadoUserCheckBox = new System.Windows.Forms.CheckBox();
            this.nombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.paswordUserTextBox = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paswordUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoUserDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomUserTextBox = new System.Windows.Forms.TextBox();
            cargoUserLabel = new System.Windows.Forms.Label();
            estadoUserLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            paswordUserLabel = new System.Windows.Forms.Label();
            nomUserLabel1 = new System.Windows.Forms.Label();
            nomUserLabel = new System.Windows.Forms.Label();
            this.groupBoxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cargoUserLabel
            // 
            cargoUserLabel.AutoSize = true;
            cargoUserLabel.Location = new System.Drawing.Point(17, 268);
            cargoUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cargoUserLabel.Name = "cargoUserLabel";
            cargoUserLabel.Size = new System.Drawing.Size(109, 24);
            cargoUserLabel.TabIndex = 11;
            cargoUserLabel.Text = "Cargo User:";
            // 
            // estadoUserLabel
            // 
            estadoUserLabel.AutoSize = true;
            estadoUserLabel.Location = new System.Drawing.Point(17, 361);
            estadoUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoUserLabel.Name = "estadoUserLabel";
            estadoUserLabel.Size = new System.Drawing.Size(115, 24);
            estadoUserLabel.TabIndex = 13;
            estadoUserLabel.Text = "Estado User:";
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreCompletoLabel.Location = new System.Drawing.Point(17, 49);
            nombreCompletoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(174, 24);
            nombreCompletoLabel.TabIndex = 15;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // paswordUserLabel
            // 
            paswordUserLabel.AutoSize = true;
            paswordUserLabel.Location = new System.Drawing.Point(17, 201);
            paswordUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            paswordUserLabel.Name = "paswordUserLabel";
            paswordUserLabel.Size = new System.Drawing.Size(85, 24);
            paswordUserLabel.TabIndex = 19;
            paswordUserLabel.Text = "Pasword:";
            // 
            // nomUserLabel1
            // 
            nomUserLabel1.AutoSize = true;
            nomUserLabel1.Location = new System.Drawing.Point(17, 152);
            nomUserLabel1.Name = "nomUserLabel1";
            nomUserLabel1.Size = new System.Drawing.Size(81, 24);
            nomUserLabel1.TabIndex = 20;
            nomUserLabel1.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar: ";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(681, 35);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(463, 31);
            this.TxtBuscar.TabIndex = 4;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(1159, 33);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(115, 31);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnNuevoUser
            // 
            this.BtnNuevoUser.Location = new System.Drawing.Point(24, 33);
            this.BtnNuevoUser.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevoUser.Name = "BtnNuevoUser";
            this.BtnNuevoUser.Size = new System.Drawing.Size(159, 49);
            this.BtnNuevoUser.TabIndex = 6;
            this.BtnNuevoUser.Text = "Nuevo Usuario";
            this.BtnNuevoUser.UseVisualStyleBackColor = true;
            this.BtnNuevoUser.Click += new System.EventHandler(this.BtnNuevoUser_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(22, 439);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(149, 59);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(218, 439);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(149, 59);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(nomUserLabel);
            this.groupBoxUsuario.Controls.Add(this.nomUserTextBox);
            this.groupBoxUsuario.Controls.Add(nomUserLabel1);
            this.groupBoxUsuario.Controls.Add(this.nomUserLabel2);
            this.groupBoxUsuario.Controls.Add(cargoUserLabel);
            this.groupBoxUsuario.Controls.Add(this.cargoUserComboBox);
            this.groupBoxUsuario.Controls.Add(estadoUserLabel);
            this.groupBoxUsuario.Controls.Add(this.estadoUserCheckBox);
            this.groupBoxUsuario.Controls.Add(nombreCompletoLabel);
            this.groupBoxUsuario.Controls.Add(this.nombreCompletoTextBox);
            this.groupBoxUsuario.Controls.Add(paswordUserLabel);
            this.groupBoxUsuario.Controls.Add(this.paswordUserTextBox);
            this.groupBoxUsuario.Controls.Add(this.BtnCancelar);
            this.groupBoxUsuario.Controls.Add(this.BtnAceptar);
            this.groupBoxUsuario.Enabled = false;
            this.groupBoxUsuario.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsuario.Location = new System.Drawing.Point(24, 91);
            this.groupBoxUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxUsuario.Size = new System.Drawing.Size(417, 557);
            this.groupBoxUsuario.TabIndex = 0;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Text = "Usuario";
            // 
            // nomUserLabel2
            // 
            this.nomUserLabel2.BackColor = System.Drawing.Color.White;
            this.nomUserLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomUser", true));
            this.nomUserLabel2.Location = new System.Drawing.Point(159, 152);
            this.nomUserLabel2.Name = "nomUserLabel2";
            this.nomUserLabel2.Size = new System.Drawing.Size(160, 35);
            this.nomUserLabel2.TabIndex = 21;
            this.nomUserLabel2.Text = "label2";
            this.nomUserLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cargoUserComboBox
            // 
            this.cargoUserComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CargoUser", true));
            this.cargoUserComboBox.FormattingEnabled = true;
            this.cargoUserComboBox.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor"});
            this.cargoUserComboBox.Location = new System.Drawing.Point(163, 268);
            this.cargoUserComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cargoUserComboBox.Name = "cargoUserComboBox";
            this.cargoUserComboBox.Size = new System.Drawing.Size(160, 32);
            this.cargoUserComboBox.TabIndex = 12;
            // 
            // estadoUserCheckBox
            // 
            this.estadoUserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "EstadoUser", true));
            this.estadoUserCheckBox.Location = new System.Drawing.Point(163, 359);
            this.estadoUserCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoUserCheckBox.Name = "estadoUserCheckBox";
            this.estadoUserCheckBox.Size = new System.Drawing.Size(161, 32);
            this.estadoUserCheckBox.TabIndex = 14;
            this.estadoUserCheckBox.Text = "Activo";
            this.estadoUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // nombreCompletoTextBox
            // 
            this.nombreCompletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NombreCompleto", true));
            this.nombreCompletoTextBox.Location = new System.Drawing.Point(45, 83);
            this.nombreCompletoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreCompletoTextBox.Name = "nombreCompletoTextBox";
            this.nombreCompletoTextBox.Size = new System.Drawing.Size(341, 31);
            this.nombreCompletoTextBox.TabIndex = 16;
            // 
            // paswordUserTextBox
            // 
            this.paswordUserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "PaswordUser", true));
            this.paswordUserTextBox.Location = new System.Drawing.Point(159, 197);
            this.paswordUserTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.paswordUserTextBox.Name = "paswordUserTextBox";
            this.paswordUserTextBox.Size = new System.Drawing.Size(160, 31);
            this.paswordUserTextBox.TabIndex = 20;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(201, 33);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(121, 49);
            this.BtnEditar.TabIndex = 7;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(346, 33);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(129, 49);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomUserDataGridViewTextBoxColumn,
            this.paswordUserDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.cargoUserDataGridViewTextBoxColumn,
            this.estadoUserDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(461, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(879, 557);
            this.dataGridView1.TabIndex = 9;
            // 
            // nomUserDataGridViewTextBoxColumn
            // 
            this.nomUserDataGridViewTextBoxColumn.DataPropertyName = "NomUser";
            this.nomUserDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.nomUserDataGridViewTextBoxColumn.Name = "nomUserDataGridViewTextBoxColumn";
            this.nomUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomUserDataGridViewTextBoxColumn.Width = 120;
            // 
            // paswordUserDataGridViewTextBoxColumn
            // 
            this.paswordUserDataGridViewTextBoxColumn.DataPropertyName = "PaswordUser";
            this.paswordUserDataGridViewTextBoxColumn.HeaderText = "Pasword";
            this.paswordUserDataGridViewTextBoxColumn.Name = "paswordUserDataGridViewTextBoxColumn";
            this.paswordUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.paswordUserDataGridViewTextBoxColumn.Width = 120;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCompletoDataGridViewTextBoxColumn.Width = 250;
            // 
            // cargoUserDataGridViewTextBoxColumn
            // 
            this.cargoUserDataGridViewTextBoxColumn.DataPropertyName = "CargoUser";
            this.cargoUserDataGridViewTextBoxColumn.HeaderText = "Cargo que Ocupa";
            this.cargoUserDataGridViewTextBoxColumn.Name = "cargoUserDataGridViewTextBoxColumn";
            this.cargoUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargoUserDataGridViewTextBoxColumn.Width = 190;
            // 
            // estadoUserDataGridViewCheckBoxColumn
            // 
            this.estadoUserDataGridViewCheckBoxColumn.DataPropertyName = "EstadoUser";
            this.estadoUserDataGridViewCheckBoxColumn.HeaderText = "Estado Usuario";
            this.estadoUserDataGridViewCheckBoxColumn.Name = "estadoUserDataGridViewCheckBoxColumn";
            this.estadoUserDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estadoUserDataGridViewCheckBoxColumn.Width = 150;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(SI_Cafeteria_Oruro.Models.Usuario);
            // 
            // nomUserLabel
            // 
            nomUserLabel.AutoSize = true;
            nomUserLabel.Location = new System.Drawing.Point(23, 153);
            nomUserLabel.Name = "nomUserLabel";
            nomUserLabel.Size = new System.Drawing.Size(103, 24);
            nomUserLabel.TabIndex = 21;
            nomUserLabel.Text = "Nom User:";
            nomUserLabel.Visible = false;
            // 
            // nomUserTextBox
            // 
            this.nomUserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomUser", true));
            this.nomUserTextBox.Location = new System.Drawing.Point(159, 154);
            this.nomUserTextBox.Name = "nomUserTextBox";
            this.nomUserTextBox.Size = new System.Drawing.Size(160, 31);
            this.nomUserTextBox.TabIndex = 22;
            // 
            // FrmModUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 677);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevoUser);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxUsuario);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmModUsuario";
            this.Text = "Gestionar Usuarios";
            this.Load += new System.EventHandler(this.FrmModUsuario_Load);
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnNuevoUser;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox groupBoxUsuario;
        private System.Windows.Forms.ComboBox cargoUserComboBox;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.CheckBox estadoUserCheckBox;
        private System.Windows.Forms.TextBox nombreCompletoTextBox;
        private System.Windows.Forms.TextBox paswordUserTextBox;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label nomUserLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paswordUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox nomUserTextBox;
    }
}