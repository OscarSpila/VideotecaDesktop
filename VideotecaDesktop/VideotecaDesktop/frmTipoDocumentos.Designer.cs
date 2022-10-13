namespace VideotecaDesktop
{
    partial class frmTipoDocumentos
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
            this.grdTipoDocumentos = new System.Windows.Forms.DataGridView();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindTipoDocumento = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtDescripcionDocumento = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlAceptarCancelar = new System.Windows.Forms.Panel();
            this.pnlAMB = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrados = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTipoDocumento)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.pnlAceptarCancelar.SuspendLayout();
            this.pnlAMB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdTipoDocumentos
            // 
            this.grdTipoDocumentos.AllowUserToAddRows = false;
            this.grdTipoDocumentos.AllowUserToDeleteRows = false;
            this.grdTipoDocumentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTipoDocumentos.AutoGenerateColumns = false;
            this.grdTipoDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTipoDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn,
            this.deletedAtDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.grdTipoDocumentos.DataSource = this.bindTipoDocumento;
            this.grdTipoDocumentos.Location = new System.Drawing.Point(11, 105);
            this.grdTipoDocumentos.MultiSelect = false;
            this.grdTipoDocumentos.Name = "grdTipoDocumentos";
            this.grdTipoDocumentos.ReadOnly = true;
            this.grdTipoDocumentos.RowHeadersWidth = 51;
            this.grdTipoDocumentos.RowTemplate.Height = 29;
            this.grdTipoDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTipoDocumentos.Size = new System.Drawing.Size(751, 276);
            this.grdTipoDocumentos.TabIndex = 5;
            this.grdTipoDocumentos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTipoDocumentos_RowEnter);
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "Creado";
            this.createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "Última Actualización";
            this.updatedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            this.updatedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // deletedAtDataGridViewTextBoxColumn
            // 
            this.deletedAtDataGridViewTextBoxColumn.DataPropertyName = "DeletedAt";
            this.deletedAtDataGridViewTextBoxColumn.HeaderText = "Borrado";
            this.deletedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deletedAtDataGridViewTextBoxColumn.Name = "deletedAtDataGridViewTextBoxColumn";
            this.deletedAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.deletedAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindTipoDocumento
            // 
            this.bindTipoDocumento.AllowNew = false;
            this.bindTipoDocumento.DataSource = typeof(VideotecaDesktop.Models.TipoDocumento.Item);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.txtDescripcionDocumento);
            this.pnlDatos.Controls.Add(this.txtTipoDocumento);
            this.pnlDatos.Controls.Add(this.lblID);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Location = new System.Drawing.Point(11, 393);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(751, 135);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.TabStop = true;
            // 
            // txtDescripcionDocumento
            // 
            this.txtDescripcionDocumento.Location = new System.Drawing.Point(205, 93);
            this.txtDescripcionDocumento.MaxLength = 8;
            this.txtDescripcionDocumento.Name = "txtDescripcionDocumento";
            this.txtDescripcionDocumento.Size = new System.Drawing.Size(543, 27);
            this.txtDescripcionDocumento.TabIndex = 10;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(206, 53);
            this.txtTipoDocumento.MaxLength = 3;
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(44, 27);
            this.txtTipoDocumento.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(207, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(15, 20);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrip.  de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(11, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(11, 43);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_ClickAsync);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(11, 83);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 29);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(11, 48);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pnlAceptarCancelar
            // 
            this.pnlAceptarCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAceptarCancelar.Controls.Add(this.btnCancelar);
            this.pnlAceptarCancelar.Controls.Add(this.btnAceptar);
            this.pnlAceptarCancelar.Location = new System.Drawing.Point(773, 393);
            this.pnlAceptarCancelar.Name = "pnlAceptarCancelar";
            this.pnlAceptarCancelar.Size = new System.Drawing.Size(118, 89);
            this.pnlAceptarCancelar.TabIndex = 7;
            this.pnlAceptarCancelar.TabStop = true;
            // 
            // pnlAMB
            // 
            this.pnlAMB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlAMB.Controls.Add(this.btnModificar);
            this.pnlAMB.Controls.Add(this.btnBorrar);
            this.pnlAMB.Controls.Add(this.btnAgregar);
            this.pnlAMB.Location = new System.Drawing.Point(773, 105);
            this.pnlAMB.Name = "pnlAMB";
            this.pnlAMB.Size = new System.Drawing.Size(118, 127);
            this.pnlAMB.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnBorrados);
            this.panel1.Controls.Add(this.btnTodos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 89);
            this.panel1.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(658, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 29);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrados
            // 
            this.btnBorrados.Location = new System.Drawing.Point(114, 48);
            this.btnBorrados.Name = "btnBorrados";
            this.btnBorrados.Size = new System.Drawing.Size(94, 29);
            this.btnBorrados.TabIndex = 4;
            this.btnBorrados.Text = "Borrados";
            this.btnBorrados.UseVisualStyleBackColor = true;
            this.btnBorrados.Click += new System.EventHandler(this.btnBorrados_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(14, 48);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(94, 29);
            this.btnTodos.TabIndex = 2;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Buscar por Tipo o Descrip.  Documento:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(293, 7);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(359, 27);
            this.txtBuscar.TabIndex = 0;
            // 
            // frmTipoDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAMB);
            this.Controls.Add(this.pnlAceptarCancelar);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdTipoDocumentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(920, 584);
            this.Name = "frmTipoDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Tipo de Documentos";
            this.Load += new System.EventHandler(this.frmTipoDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTipoDocumento)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.pnlAceptarCancelar.ResumeLayout(false);
            this.pnlAMB.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdTipoDocumentos;
        private Panel pnlDatos;
        private TextBox txtDescripcionDocumento;
        private TextBox txtTipoDocumento;
        private Label lblID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnModificar;
        private BindingSource bindTipoDocumento;
        private Panel pnlAceptarCancelar;
        private Panel pnlAMB;
        private Panel panel1;
        private Button btnBuscar;
        private Button btnBorrados;
        private Button btnTodos;
        private Label label4;
        private TextBox txtBuscar;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deletedAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}