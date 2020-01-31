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
    public partial class FrmCalificacion : Form
    {
       

        public FrmCalificacion()
        {
            InitializeComponent();
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cargarSemestre()
        {
            try
            {
                CboSemestre2.DataSource = NPlanAcademico.seleccionSemestre();
                CboSemestre2.ValueMember = "Id";
                CboSemestre2.DisplayMember = "Nombre";
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
                CboSeccion.DataSource = NPlanAcademico.seleccionSeccion();
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



        private void Formato()
        {
            DgvListado.Columns[0].Width = 70;
            DgvListado.Columns[1].Width = 70;
            DgvListado.Columns[2].Width = 70;
            DgvListado.Columns[3].Width = 70;
            DgvListado.Columns[4].Width = 70;
            DgvListado.Columns[5].Width = 70;
            DgvListado.Columns[6].Width = 70;
            DgvListado.Columns[7].Width = 70;
            DgvListado.Columns[8].Width = 70;


        }

        private void Listar()
        {

            try
            {

                DgvListado.DataSource = NCalificaciones.buscarCalificaciones(Convert.ToInt32(CboSemestre2.SelectedValue), Convert.ToInt32(CboCurso.SelectedValue), Convert.ToInt32(CboSeccion.SelectedValue), Convert.ToInt32(CboAsignatura.SelectedValue));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void FrmCalificacion_Load_1(object sender, EventArgs e)
        {
            this.cargarSemestre();
            this.cargarCurso();
            this.cargarSeccion();
            this.cargarAsignatura();
            
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            this.Listar();

            this.Formato();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)


        {
            try
            {
                    DataTable Rpta;

                    //DataTable Rpta2;

                    double v = 0;


                foreach (DataGridViewRow row in DgvListado.Rows)
                {
                    int Codigo = Convert.ToInt32(this.DgvListado.CurrentRow.Cells[1].Value.ToString());
                    int Codigo2 = Convert.ToInt32(this.DgvListado.CurrentRow.Cells[2].Value.ToString());


                    Rpta = NPromedio.calcularPromedio(Codigo, Codigo2);

                    v = Convert.ToDouble(Rpta.Rows[0][0].ToString());

                    /*Rpta2 = */NPromedio.guardarPromedio(Codigo, Codigo2, v);
                    
                    this.DgvListado.CurrentRow.Cells[9].Value = v;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns[0].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells[0];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
        
                string Rpta = "";

                foreach (DataGridViewRow row in DgvListado.Rows)
                {


                int ide = Convert.ToInt32 (this.DgvListado.CurrentRow.Cells[1].Value.ToString());
                int ida = Convert.ToInt32(this.DgvListado.CurrentRow.Cells[2].Value.ToString());
                double n1 =Convert.ToDouble(this.DgvListado.CurrentRow.Cells[4].Value.ToString());
                double n2 = Convert.ToDouble(this.DgvListado.CurrentRow.Cells[5].Value.ToString());
                double n3 = Convert.ToDouble(this.DgvListado.CurrentRow.Cells[6].Value.ToString());
                double n4 = Convert.ToDouble(this.DgvListado.CurrentRow.Cells[7].Value.ToString());
                double n5 = Convert.ToDouble(this.DgvListado.CurrentRow.Cells[8].Value.ToString());

                    Rpta = NCalificaciones.Actualizar(n1, n2, n3,n4,n5, ide, ida);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CboSemestre2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
