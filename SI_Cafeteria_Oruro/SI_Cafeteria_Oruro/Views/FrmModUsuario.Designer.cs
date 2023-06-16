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
            System.Windows.Forms.Label nomUserLabel;
            System.Windows.Forms.Label paswordUserLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModUsuario));
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnNuevoUser = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.cargoUserComboBox = new System.Windows.Forms.ComboBox();
            this.estadoUserCheckBox = new System.Windows.Forms.CheckBox();
            this.nombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.nomUserTextBox = new System.Windows.Forms.TextBox();
            this.paswordUserTextBox = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.nomUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paswordUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoUserDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cargoUserLabel = new System.Windows.Forms.Label();
            estadoUserLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            nomUserLabel = new System.Windows.Forms.Label();
            paswordUserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.groupBoxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cargoUserLabel
            // 
            cargoUserLabel.AutoSize = true;
            cargoUserLabel.Location = new System.Drawing.Point(13, 201);
            cargoUserLabel.Name = "cargoUserLabel";
            cargoUserLabel.Size = new System.Drawing.Size(86, 18);
            cargoUserLabel.TabIndex = 11;
            cargoUserLabel.Text = "Cargo User:";
            // 
            // estadoUserLabel
            // 
            estadoUserLabel.AutoSize = true;
            estadoUserLabel.Location = new System.Drawing.Point(13, 271);
            estadoUserLabel.Name = "estadoUserLabel";
            estadoUserLabel.Size = new System.Drawing.Size(90, 18);
            estadoUserLabel.TabIndex = 13;
            estadoUserLabel.Text = "Estado User:";
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Location = new System.Drawing.Point(13, 37);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(133, 18);
            nombreCompletoLabel.TabIndex = 15;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // nomUserLabel
            // 
            nomUserLabel.AutoSize = true;
            nomUserLabel.Location = new System.Drawing.Point(13, 109);
            nomUserLabel.Name = "nomUserLabel";
            nomUserLabel.Size = new System.Drawing.Size(80, 18);
            nomUserLabel.TabIndex = 17;
            nomUserLabel.Text = "Nom User:";
            // 
            // paswordUserLabel
            // 
            paswordUserLabel.AutoSize = true;
            paswordUserLabel.Location = new System.Drawing.Point(13, 151);
            paswordUserLabel.Name = "paswordUserLabel";
            paswordUserLabel.Size = new System.Drawing.Size(101, 18);
            paswordUserLabel.TabIndex = 19;
            paswordUserLabel.Text = "Pasword User:";
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomUserDataGridViewTextBoxColumn,
            this.paswordUserDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.cargoUserDataGridViewTextBoxColumn,
            this.estadoUserDataGridViewCheckBoxColumn});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(362, 68);
            this.usuarioDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.Size = new System.Drawing.Size(755, 418);
            this.usuarioDataGridView.TabIndex = 2;
            this.usuarioDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarioDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar: ";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(613, 28);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(348, 26);
            this.TxtBuscar.TabIndex = 4;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(967, 26);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(86, 23);
            this.BtnBuscar.TabIndex = 5;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnNuevoUser
            // 
            this.BtnNuevoUser.Location = new System.Drawing.Point(18, 25);
            this.BtnNuevoUser.Name = "BtnNuevoUser";
            this.BtnNuevoUser.Size = new System.Drawing.Size(146, 23);
            this.BtnNuevoUser.TabIndex = 6;
            this.BtnNuevoUser.Text = "Nuevo Usuario";
            this.BtnNuevoUser.UseVisualStyleBackColor = true;
            this.BtnNuevoUser.Click += new System.EventHandler(this.BtnNuevoUser_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(16, 329);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(112, 32);
            this.BtnAceptar.TabIndex = 10;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(166, 329);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(112, 32);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(cargoUserLabel);
            this.groupBoxUsuario.Controls.Add(this.cargoUserComboBox);
            this.groupBoxUsuario.Controls.Add(estadoUserLabel);
            this.groupBoxUsuario.Controls.Add(this.estadoUserCheckBox);
            this.groupBoxUsuario.Controls.Add(nombreCompletoLabel);
            this.groupBoxUsuario.Controls.Add(this.nombreCompletoTextBox);
            this.groupBoxUsuario.Controls.Add(nomUserLabel);
            this.groupBoxUsuario.Controls.Add(this.nomUserTextBox);
            this.groupBoxUsuario.Controls.Add(paswordUserLabel);
            this.groupBoxUsuario.Controls.Add(this.paswordUserTextBox);
            this.groupBoxUsuario.Controls.Add(this.BtnCancelar);
            this.groupBoxUsuario.Controls.Add(this.BtnAceptar);
            this.groupBoxUsuario.Enabled = false;
            this.groupBoxUsuario.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsuario.Location = new System.Drawing.Point(18, 68);
            this.groupBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUsuario.Size = new System.Drawing.Size(333, 418);
            this.groupBoxUsuario.TabIndex = 0;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Text = "Usuario";
            // 
            // cargoUserComboBox
            // 
            this.cargoUserComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CargoUser", true));
            this.cargoUserComboBox.FormattingEnabled = true;
            this.cargoUserComboBox.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor"});
            this.cargoUserComboBox.Location = new System.Drawing.Point(122, 201);
            this.cargoUserComboBox.Name = "cargoUserComboBox";
            this.cargoUserComboBox.Size = new System.Drawing.Size(121, 26);
            this.cargoUserComboBox.TabIndex = 12;
            // 
            // estadoUserCheckBox
            // 
            this.estadoUserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "EstadoUser", true));
            this.estadoUserCheckBox.Location = new System.Drawing.Point(122, 265);
            this.estadoUserCheckBox.Name = "estadoUserCheckBox";
            this.estadoUserCheckBox.Size = new System.Drawing.Size(121, 24);
            this.estadoUserCheckBox.TabIndex = 14;
            this.estadoUserCheckBox.Text = "Activo";
            this.estadoUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // nombreCompletoTextBox
            // 
            this.nombreCompletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NombreCompleto", true));
            this.nombreCompletoTextBox.Location = new System.Drawing.Point(34, 58);
            this.nombreCompletoTextBox.Name = "nombreCompletoTextBox";
            this.nombreCompletoTextBox.Size = new System.Drawing.Size(257, 26);
            this.nombreCompletoTextBox.TabIndex = 16;
            // 
            // nomUserTextBox
            // 
            this.nomUserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomUser", true));
            this.nomUserTextBox.Location = new System.Drawing.Point(122, 109);
            this.nomUserTextBox.Name = "nomUserTextBox";
            this.nomUserTextBox.Size = new System.Drawing.Size(121, 26);
            this.nomUserTextBox.TabIndex = 18;
            // 
            // paswordUserTextBox
            // 
            this.paswordUserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "PaswordUser", true));
            this.paswordUserTextBox.Location = new System.Drawing.Point(122, 143);
            this.paswordUserTextBox.Name = "paswordUserTextBox";
            this.paswordUserTextBox.Size = new System.Drawing.Size(121, 26);
            this.paswordUserTextBox.TabIndex = 20;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(170, 25);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(91, 23);
            this.BtnEditar.TabIndex = 7;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(267, 25);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(97, 23);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // nomUserDataGridViewTextBoxColumn
            // 
            this.nomUserDataGridViewTextBoxColumn.DataPropertyName = "NomUser";
            this.nomUserDataGridViewTextBoxColumn.HeaderText = "NomUser";
            this.nomUserDataGridViewTextBoxColumn.Name = "nomUserDataGridViewTextBoxColumn";
            this.nomUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paswordUserDataGridViewTextBoxColumn
            // 
            this.paswordUserDataGridViewTextBoxColumn.DataPropertyName = "PaswordUser";
            this.paswordUserDataGridViewTextBoxColumn.HeaderText = "PaswordUser";
            this.paswordUserDataGridViewTextBoxColumn.Name = "paswordUserDataGridViewTextBoxColumn";
            this.paswordUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoUserDataGridViewTextBoxColumn
            // 
            this.cargoUserDataGridViewTextBoxColumn.DataPropertyName = "CargoUser";
            this.cargoUserDataGridViewTextBoxColumn.HeaderText = "CargoUser";
            this.cargoUserDataGridViewTextBoxColumn.Name = "cargoUserDataGridViewTextBoxColumn";
            this.cargoUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoUserDataGridViewCheckBoxColumn
            // 
            this.estadoUserDataGridViewCheckBoxColumn.DataPropertyName = "EstadoUser";
            this.estadoUserDataGridViewCheckBoxColumn.HeaderText = "EstadoUser";
            this.estadoUserDataGridViewCheckBoxColumn.Name = "estadoUserDataGridViewCheckBoxColumn";
            this.estadoUserDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(SI_Cafeteria_Oruro.Models.Usuario);
            // 
            // FrmModUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1130, 508);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevoUser);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.groupBoxUsuario);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmModUsuario";
            this.Text = "Modificacion de Usuarios";
            this.Load += new System.EventHandler(this.FrmModUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView usuarioDataGridView;
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
        private System.Windows.Forms.TextBox nomUserTextBox;
        private System.Windows.Forms.TextBox paswordUserTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paswordUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoUserDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}