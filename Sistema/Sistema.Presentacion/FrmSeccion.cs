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
    public partial class FrmSeccion : Form
    {
        public FrmSeccion()
        {
            InitializeComponent();
        }

     
        private void Listar()
        {
           
            try
            {

                DgvListado.DataSource = NSeccion.Listar(Convert.ToInt32(CboCurso2.SelectedValue));

                this.Limpiar();
                this.Formato();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FormatoDocente()
        {
            DgvDocente.Columns[0].Visible = false;
            DgvDocente.Columns[1].Width = 80;
            DgvDocente.Columns[2].Width = 200;
        
                   

        }

        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].Width = 150;
            DgvListado.Columns[3].Visible= false;
            DgvListado.Columns[4].Width = 150;


        }

        private void Limpiar()
        {
            TxtNombreSeccion.Clear();
            TxtId.Clear();
            TxtProfeJefe.Clear();
            TxtDocenteAsignado.Clear();
            

            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            DgvListado.Columns[0].Visible = false;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnEliminar.Visible = false;
            ChkSeleccionar.Checked = false;

        }


        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void cargarSeccion()
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

        private void cargarCurso()
        {
            
            try
            {
               
                CboCurso2.DataSource = NSeleccionar.Seleccionar();
                CboCurso2.ValueMember = "Id";
                CboCurso2.DisplayMember = "Curso";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmSeccion_Load(object sender, EventArgs e)
        {
         
            this.cargarSeccion();
            this.cargarCurso();
            this.Listar();
          
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtNombreSeccion.Text == string.Empty || CboCurso.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtNombreSeccion, "Ingrese nombre del curso.");
                    ErrorIcono.SetError(CboCurso, "Ingrese el cupo.");
                }
                else
                {
                    Rpta = NSeccion.insertar(TxtNombreSeccion.Text.Trim(),Convert.ToInt32(TxtProfeJefe.Text.Trim()), Convert.ToInt32(CboCurso.SelectedValue));

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro");

                        this.Listar();

                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnAgregarDocente_Click(object sender, EventArgs e)
        {
            paneldocente.Visible = true;

            DgvDocente.DataSource = NDocente.BuscarDocenteJefe();
            this.FormatoDocente();
        }

        private void DgvDocente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtProfeJefe.Text = DgvDocente.CurrentRow.Cells["Id"].Value.ToString();
                TxtDocenteAsignado.Text= DgvDocente.CurrentRow.Cells["Docente Disponible"].Value.ToString();
                paneldocente.Visible = false;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            paneldocente.Visible = false;
        }

        private void CboCurso2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();

                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                TxtNombreSeccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre de la seccion"].Value);
                TxtProfeJefe.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID Docente"].Value);
                TxtDocenteAsignado.Text=Convert.ToString(DgvListado.CurrentRow.Cells["Profesor Jefe"].Value);
            


                TabGeneral.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda nombre.");
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

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
           
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
                DgvListado.Columns[1].Visible = true;
                BtnActivar.Visible = true;
                BtnDesactivar.Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                DgvListado.Columns[0].Visible = false;
                BtnActivar.Visible = false;
                BtnDesactivar.Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtNombreSeccion.Text == string.Empty || TxtId.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtNombreSeccion, "Ingrese nombre del curso.");

                }
                else
                {
                    Rpta = NSeccion.Actualizar(Convert.ToInt32(TxtId.Text.Trim()),TxtNombreSeccion.Text.Trim(), Convert.ToInt32(TxtProfeJefe.Text.Trim()), Convert.ToInt32(CboCurso.SelectedValue));

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Actualizó de forma correcta el registro");

                        this.Limpiar();
                        this.Listar();

                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
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
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NSeccion.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                               // MessageBox.Show("Hay"+" " + Convert.ToString(row.Cells[3].Value)+"  "+ "estudiantes asociados a la sección, se debe eliminar las asociaciones");
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas activar el(los) registro(s)?", "Sistema de calificaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NSeccion.Activar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se activó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas desactivar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NSeccion.Desactivar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 1;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombreSeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }
    }
}
