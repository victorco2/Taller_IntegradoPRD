namespace Sistema.Presentacion
{
    partial class FrmSeccion
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
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnDesactivar = new System.Windows.Forms.Button();
            this.BtnActivar = new System.Windows.Forms.Button();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtDocenteAsignado = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.paneldocente = new System.Windows.Forms.Panel();
            this.DgvDocente = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtProfeJefe = new System.Windows.Forms.TextBox();
            this.BtnAgregarDocente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombreSeccion = new System.Windows.Forms.TextBox();
            this.CboCurso = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CboCurso2 = new System.Windows.Forms.ComboBox();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.TabGeneral.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.paneldocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocente)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccionar";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Curso:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEliminar.FlatAppearance.BorderSize = 2;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(550, 426);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(140, 40);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDesactivar.FlatAppearance.BorderSize = 2;
            this.BtnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesactivar.Location = new System.Drawing.Point(368, 426);
            this.BtnDesactivar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(140, 40);
            this.BtnDesactivar.TabIndex = 6;
            this.BtnDesactivar.Text = "Desactivar";
            this.BtnDesactivar.UseVisualStyleBackColor = true;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // BtnActivar
            // 
            this.BtnActivar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnActivar.FlatAppearance.BorderSize = 2;
            this.BtnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActivar.Location = new System.Drawing.Point(184, 426);
            this.BtnActivar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(140, 40);
            this.BtnActivar.TabIndex = 5;
            this.BtnActivar.Text = "Activar";
            this.BtnActivar.UseVisualStyleBackColor = true;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(35, 428);
            this.ChkSeleccionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(109, 23);
            this.ChkSeleccionar.TabIndex = 4;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.DgvListado.Location = new System.Drawing.Point(35, 80);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(743, 300);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Location = new System.Drawing.Point(13, 3);
            this.TabGeneral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1113, 584);
            this.TabGeneral.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1105, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDocenteAsignado);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.paneldocente);
            this.groupBox1.Controls.Add(this.TxtProfeJefe);
            this.groupBox1.Controls.Add(this.BtnAgregarDocente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtNombreSeccion);
            this.groupBox1.Controls.Add(this.CboCurso);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnActualizar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnInsertar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1087, 537);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creacion de Secciones";
            // 
            // TxtDocenteAsignado
            // 
            this.TxtDocenteAsignado.Location = new System.Drawing.Point(232, 122);
            this.TxtDocenteAsignado.Margin = new System.Windows.Forms.Padding(5);
            this.TxtDocenteAsignado.Name = "TxtDocenteAsignado";
            this.TxtDocenteAsignado.ReadOnly = true;
            this.TxtDocenteAsignado.Size = new System.Drawing.Size(309, 24);
            this.TxtDocenteAsignado.TabIndex = 42;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(578, 59);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(155, 24);
            this.TxtId.TabIndex = 4;
            this.TxtId.Visible = false;
            // 
            // paneldocente
            // 
            this.paneldocente.BackColor = System.Drawing.Color.Azure;
            this.paneldocente.Controls.Add(this.DgvDocente);
            this.paneldocente.Controls.Add(this.BtnSalir);
            this.paneldocente.Location = new System.Drawing.Point(232, 156);
            this.paneldocente.Margin = new System.Windows.Forms.Padding(5);
            this.paneldocente.Name = "paneldocente";
            this.paneldocente.Size = new System.Drawing.Size(611, 271);
            this.paneldocente.TabIndex = 40;
            this.paneldocente.Visible = false;
            // 
            // DgvDocente
            // 
            this.DgvDocente.AllowUserToAddRows = false;
            this.DgvDocente.AllowUserToDeleteRows = false;
            this.DgvDocente.AllowUserToOrderColumns = true;
            this.DgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDocente.Location = new System.Drawing.Point(25, 27);
            this.DgvDocente.Margin = new System.Windows.Forms.Padding(5);
            this.DgvDocente.Name = "DgvDocente";
            this.DgvDocente.ReadOnly = true;
            this.DgvDocente.RowHeadersWidth = 51;
            this.DgvDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDocente.Size = new System.Drawing.Size(574, 227);
            this.DgvDocente.TabIndex = 4;
            this.DgvDocente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDocente_CellDoubleClick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(574, 5);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(25, 22);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtProfeJefe
            // 
            this.TxtProfeJefe.Location = new System.Drawing.Point(578, 27);
            this.TxtProfeJefe.Margin = new System.Windows.Forms.Padding(5);
            this.TxtProfeJefe.Name = "TxtProfeJefe";
            this.TxtProfeJefe.Size = new System.Drawing.Size(155, 24);
            this.TxtProfeJefe.TabIndex = 41;
            this.TxtProfeJefe.Visible = false;
            // 
            // BtnAgregarDocente
            // 
            this.BtnAgregarDocente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAgregarDocente.FlatAppearance.BorderSize = 2;
            this.BtnAgregarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarDocente.Location = new System.Drawing.Point(578, 115);
            this.BtnAgregarDocente.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAgregarDocente.Name = "BtnAgregarDocente";
            this.BtnAgregarDocente.Size = new System.Drawing.Size(90, 31);
            this.BtnAgregarDocente.TabIndex = 39;
            this.BtnAgregarDocente.Text = "Asignar";
            this.BtnAgregarDocente.UseVisualStyleBackColor = true;
            this.BtnAgregarDocente.Click += new System.EventHandler(this.BtnAgregarDocente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Profesor Asignado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre Seccion:";
            // 
            // TxtNombreSeccion
            // 
            this.TxtNombreSeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombreSeccion.Location = new System.Drawing.Point(232, 37);
            this.TxtNombreSeccion.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNombreSeccion.Name = "TxtNombreSeccion";
            this.TxtNombreSeccion.Size = new System.Drawing.Size(309, 24);
            this.TxtNombreSeccion.TabIndex = 28;
            this.TxtNombreSeccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreSeccion_KeyPress);
            // 
            // CboCurso
            // 
            this.CboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCurso.FormattingEnabled = true;
            this.CboCurso.Location = new System.Drawing.Point(232, 76);
            this.CboCurso.Margin = new System.Windows.Forms.Padding(5);
            this.CboCurso.Name = "CboCurso";
            this.CboCurso.Size = new System.Drawing.Size(309, 27);
            this.CboCurso.TabIndex = 28;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatAppearance.BorderSize = 2;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(620, 463);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(140, 40);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnActualizar.FlatAppearance.BorderSize = 2;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Location = new System.Drawing.Point(342, 463);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(140, 40);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Curso:";
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnInsertar.FlatAppearance.BorderSize = 2;
            this.BtnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertar.Location = new System.Drawing.Point(342, 463);
            this.BtnInsertar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(140, 40);
            this.BtnInsertar.TabIndex = 5;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.CboCurso2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.BtnEliminar);
            this.tabPage1.Controls.Add(this.BtnDesactivar);
            this.tabPage1.Controls.Add(this.BtnActivar);
            this.tabPage1.Controls.Add(this.ChkSeleccionar);
            this.tabPage1.Controls.Add(this.DgvListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1105, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(403, 21);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(91, 29);
            this.BtnBuscar.TabIndex = 30;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CboCurso2
            // 
            this.CboCurso2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCurso2.FormattingEnabled = true;
            this.CboCurso2.Location = new System.Drawing.Point(144, 21);
            this.CboCurso2.Margin = new System.Windows.Forms.Padding(5);
            this.CboCurso2.Name = "CboCurso2";
            this.CboCurso2.Size = new System.Drawing.Size(235, 27);
            this.CboCurso2.TabIndex = 29;
            this.CboCurso2.SelectedIndexChanged += new System.EventHandler(this.CboCurso2_SelectedIndexChanged);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1139, 604);
            this.Controls.Add(this.TabGeneral);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSeccion";
            this.Text = "FrmSeccion";
            this.Load += new System.EventHandler(this.FrmSeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.TabGeneral.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.paneldocente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocente)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnDesactivar;
        private System.Windows.Forms.Button BtnActivar;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombreSeccion;
        private System.Windows.Forms.ComboBox CboCurso;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel paneldocente;
        private System.Windows.Forms.DataGridView DgvDocente;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtProfeJefe;
        private System.Windows.Forms.Button BtnAgregarDocente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDocenteAsignado;
        private System.Windows.Forms.ComboBox CboCurso2;
        private System.Windows.Forms.Button BtnBuscar;
    }
}