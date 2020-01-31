using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;
using System.Drawing.Imaging;
using System.IO;

namespace Sistema.Presentacion
{
    public partial class FrmPlanificacionAcademica : Form
    {
        public FrmPlanificacionAcademica()
        {
            InitializeComponent();
        }



        private void dgvasignaturas()
        {

            try
            {

                dgvDocenteAsignatura.DataSource = NPlanAcademico.seleccionarDgvAsignatura(Convert.ToInt32(CboSemestre.SelectedValue), Convert.ToInt32(CboCurso.SelectedValue),Convert.ToInt32(CboSeccion.SelectedValue));

                //this.FormatoAsignaturaDocente();
                this.Limpiar();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FormatoDocente()
        {
            DgvDocente.Columns[0].Width = 40;
            DgvDocente.Columns[1].Width = 210;

        }

        private void FormatoAsignaturaDocente()
        {
            dgvDocenteAsignatura.Columns[0].Width = 94;
            dgvDocenteAsignatura.Columns[1].Visible = false;
            dgvDocenteAsignatura.Columns[2].Visible = false;
            dgvDocenteAsignatura.Columns[3].Visible = false;
            dgvDocenteAsignatura.Columns[4].Visible = false;
            dgvDocenteAsignatura.Columns[5].Visible = false;
            dgvDocenteAsignatura.Columns[6].Width = 150;
            dgvDocenteAsignatura.Columns[7].Width = 250;
        }

        private void cargarSemestre()
        {
            try
            {
                CboSemestre.DataSource = NPlanAcademico.seleccionSemestre();
                CboSemestre.ValueMember = "Id";
                CboSemestre.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cargarCurso()
        {
            try
            {
                CboCurso.DataSource = NSeleccionar.Seleccionar();
                CboCurso.ValueMember = "Id";
                CboCurso.DisplayMember = "Curso";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cargarSeccion()
        {
            try
            {
                CboSeccion.DataSource = NSeleccionar.SeleccionarSeccion(Convert.ToInt32(CboCurso.SelectedValue));
                CboSeccion.ValueMember = "Id";
                CboSeccion.DisplayMember = "Nombre";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void cargarAsignatura()
        {
            try
            {
                CboAsignatura.DataSource = NPlanAcademico.seleccionAsignatura();
                CboAsignatura.ValueMember = "Id";
                CboAsignatura.DisplayMember = "asignatura";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void Limpiar()
        {
 
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            txtDocente.Clear();

        }

        private void FrmPlanificacionAcademica_Load(object sender, EventArgs e)
        {
            this.cargarSemestre();
            this.cargarCurso();
            this.cargarSeccion();
            this.cargarAsignatura();
            this.Limpiar();
            this.dgvasignaturas();
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
         
            
                    Rpta = NPlanAcademico.insertar(Convert.ToInt32(CboSemestre.SelectedValue),Convert.ToInt32(CboCurso.SelectedValue), Convert.ToInt32(CboSeccion.SelectedValue), Convert.ToInt32(CboAsignatura.SelectedValue), Convert.ToInt32(txtIdDocente.Text.Trim()));

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");

                     

                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                this.dgvasignaturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CboSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarSeccion();
        }

        private void CboCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cargarSeccion();
        }

        private void BtnAgregarDocente_Click(object sender, EventArgs e)
        {
            paneldocente.Visible = true;

            DgvDocente.DataSource = NPlanAcademico.seleccionDocente();
            this.FormatoDocente();
        }

        private void DgvDocente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdDocente.Text = DgvDocente.CurrentRow.Cells["Id"].Value.ToString();
                txtDocente.Text = DgvDocente.CurrentRow.Cells["Nombre"].Value.ToString();
                paneldocente.Visible = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            paneldocente.Visible = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.dgvasignaturas();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DgvDocenteAsignatura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDocenteAsignatura.Columns[0].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvDocenteAsignatura.Rows[e.RowIndex].Cells[0];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)?", "Sistema de Calificaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Semestre;
                    int Curso;
                    int Seccion;
                    int Asignatura;
                    int Docente;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvDocenteAsignatura.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Semestre = Convert.ToInt32(row.Cells[1].Value);
                            Curso = Convert.ToInt32(row.Cells[2].Value);
                            Seccion = Convert.ToInt32(row.Cells[3].Value);
                            Asignatura = Convert.ToInt32(row.Cells[4].Value);
                            Docente= Convert.ToInt32(row.Cells[5].Value);



                            Rpta = NPlanAcademico.Eliminar(Semestre,Curso,Seccion,Asignatura,Docente);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro ");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.dgvasignaturas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboSeccion_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }

}
