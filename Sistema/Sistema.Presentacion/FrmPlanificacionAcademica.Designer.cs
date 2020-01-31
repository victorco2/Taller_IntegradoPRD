namespace Sistema.Presentacion
{
    partial class FrmPlanificacionAcademica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDocenteAsignatura = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtIdDocente = new System.Windows.Forms.TextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.paneldocente = new System.Windows.Forms.Panel();
            this.DgvDocente = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAgregarDocente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CboAsignatura = new System.Windows.Forms.ComboBox();
            this.CboSeccion = new System.Windows.Forms.ComboBox();
            this.CboCurso = new System.Windows.Forms.ComboBox();
            this.CboSemestre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.TabGeneral.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteAsignatura)).BeginInit();
            this.paneldocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabGeneral.Location = new System.Drawing.Point(10, 11);
            this.TabGeneral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1113, 576);
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
            this.tabPage2.Size = new System.Drawing.Size(1105, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CboSeccion);
            this.groupBox1.Controls.Add(this.CboCurso);
            this.groupBox1.Controls.Add(this.CboSemestre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnActualizar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnInsertar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1087, 521);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creacion de un Curso";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(496, 467);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 40);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(885, 41);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 31);
            this.btnBuscar.TabIndex = 46;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDocenteAsignatura);
            this.groupBox2.Controls.Add(this.txtIdDocente);
            this.groupBox2.Controls.Add(this.txtDocente);
            this.groupBox2.Controls.Add(this.paneldocente);
            this.groupBox2.Controls.Add(this.BtnAgregarDocente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CboAsignatura);
            this.groupBox2.Location = new System.Drawing.Point(8, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1071, 385);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignatura - Docente";
            // 
            // dgvDocenteAsignatura
            // 
            this.dgvDocenteAsignatura.AllowUserToAddRows = false;
            this.dgvDocenteAsignatura.AllowUserToDeleteRows = false;
            this.dgvDocenteAsignatura.AllowUserToOrderColumns = true;
            this.dgvDocenteAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocenteAsignatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocenteAsignatura.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocenteAsignatura.Location = new System.Drawing.Point(91, 75);
            this.dgvDocenteAsignatura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDocenteAsignatura.Name = "dgvDocenteAsignatura";
            this.dgvDocenteAsignatura.ReadOnly = true;
            this.dgvDocenteAsignatura.RowHeadersWidth = 51;
            this.dgvDocenteAsignatura.RowTemplate.Height = 24;
            this.dgvDocenteAsignatura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocenteAsignatura.Size = new System.Drawing.Size(555, 181);
            this.dgvDocenteAsignatura.TabIndex = 48;
            this.dgvDocenteAsignatura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDocenteAsignatura_CellContentClick);
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "Seleccionar";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // txtIdDocente
            // 
            this.txtIdDocente.Location = new System.Drawing.Point(182, -5);
            this.txtIdDocente.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdDocente.Name = "txtIdDocente";
            this.txtIdDocente.Size = new System.Drawing.Size(148, 24);
            this.txtIdDocente.TabIndex = 47;
            this.txtIdDocente.Visible = false;
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(401, 31);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(5);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.ReadOnly = true;
            this.txtDocente.Size = new System.Drawing.Size(236, 24);
            this.txtDocente.TabIndex = 46;
            // 
            // paneldocente
            // 
            this.paneldocente.BackColor = System.Drawing.Color.Azure;
            this.paneldocente.Controls.Add(this.DgvDocente);
            this.paneldocente.Controls.Add(this.BtnSalir);
            this.paneldocente.Location = new System.Drawing.Point(744, 23);
            this.paneldocente.Margin = new System.Windows.Forms.Padding(5);
            this.paneldocente.Name = "paneldocente";
            this.paneldocente.Size = new System.Drawing.Size(319, 243);
            this.paneldocente.TabIndex = 45;
            this.paneldocente.Visible = false;
            // 
            // DgvDocente
            // 
            this.DgvDocente.AllowUserToAddRows = false;
            this.DgvDocente.AllowUserToDeleteRows = false;
            this.DgvDocente.AllowUserToOrderColumns = true;
            this.DgvDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDocente.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDocente.Location = new System.Drawing.Point(12, 30);
            this.DgvDocente.Margin = new System.Windows.Forms.Padding(5);
            this.DgvDocente.Name = "DgvDocente";
            this.DgvDocente.ReadOnly = true;
            this.DgvDocente.RowHeadersWidth = 51;
            this.DgvDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDocente.Size = new System.Drawing.Size(298, 203);
            this.DgvDocente.TabIndex = 4;
            this.DgvDocente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDocente_CellDoubleClick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(285, 2);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(25, 22);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAgregarDocente
            // 
            this.BtnAgregarDocente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAgregarDocente.FlatAppearance.BorderSize = 2;
            this.BtnAgregarDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarDocente.Location = new System.Drawing.Point(647, 23);
            this.BtnAgregarDocente.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAgregarDocente.Name = "BtnAgregarDocente";
            this.BtnAgregarDocente.Size = new System.Drawing.Size(69, 31);
            this.BtnAgregarDocente.TabIndex = 44;
            this.BtnAgregarDocente.Text = "Ver";
            this.BtnAgregarDocente.UseVisualStyleBackColor = true;
            this.BtnAgregarDocente.Click += new System.EventHandler(this.BtnAgregarDocente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Profesor Asignado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Asignatura:";
            // 
            // CboAsignatura
            // 
            this.CboAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAsignatura.FormattingEnabled = true;
            this.CboAsignatura.Location = new System.Drawing.Point(93, 27);
            this.CboAsignatura.Name = "CboAsignatura";
            this.CboAsignatura.Size = new System.Drawing.Size(155, 27);
            this.CboAsignatura.TabIndex = 41;
            // 
            // CboSeccion
            // 
            this.CboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSeccion.FormattingEnabled = true;
            this.CboSeccion.Location = new System.Drawing.Point(697, 41);
            this.CboSeccion.Margin = new System.Windows.Forms.Padding(5);
            this.CboSeccion.Name = "CboSeccion";
            this.CboSeccion.Size = new System.Drawing.Size(140, 27);
            this.CboSeccion.TabIndex = 44;
            this.CboSeccion.SelectedIndexChanged += new System.EventHandler(this.CboSeccion_SelectedIndexChanged_1);
            // 
            // CboCurso
            // 
            this.CboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCurso.FormattingEnabled = true;
            this.CboCurso.Location = new System.Drawing.Point(396, 41);
            this.CboCurso.Margin = new System.Windows.Forms.Padding(5);
            this.CboCurso.Name = "CboCurso";
            this.CboCurso.Size = new System.Drawing.Size(140, 27);
            this.CboCurso.TabIndex = 43;
            this.CboCurso.SelectedIndexChanged += new System.EventHandler(this.CboCurso_SelectedIndexChanged);
            this.CboCurso.SelectionChangeCommitted += new System.EventHandler(this.CboCurso_SelectionChangeCommitted);
            // 
            // CboSemestre
            // 
            this.CboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSemestre.FormattingEnabled = true;
            this.CboSemestre.Location = new System.Drawing.Point(121, 41);
            this.CboSemestre.Name = "CboSemestre";
            this.CboSemestre.Size = new System.Drawing.Size(140, 27);
            this.CboSemestre.TabIndex = 38;
            this.CboSemestre.SelectedIndexChanged += new System.EventHandler(this.CboSemestre_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Seccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Curso:";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnActualizar.FlatAppearance.BorderSize = 2;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(269, 467);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(140, 40);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Semestre:";
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnInsertar.FlatAppearance.BorderSize = 2;
            this.BtnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsertar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.Location = new System.Drawing.Point(269, 467);
            this.BtnInsertar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(140, 40);
            this.BtnInsertar.TabIndex = 5;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // FrmPlanificacionAcademica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1136, 599);
            this.Controls.Add(this.TabGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPlanificacionAcademica";
            this.Text = "FrmPlanificacionAcademica";
            this.Load += new System.EventHandler(this.FrmPlanificacionAcademica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.TabGeneral.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteAsignatura)).EndInit();
            this.paneldocente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.ComboBox CboAsignatura;
        private System.Windows.Forms.ComboBox CboSemestre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboSeccion;
        private System.Windows.Forms.ComboBox CboCurso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Panel paneldocente;
        private System.Windows.Forms.DataGridView DgvDocente;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAgregarDocente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdDocente;
        private System.Windows.Forms.DataGridView dgvDocenteAsignatura;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
    }
}