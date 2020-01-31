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
    public partial class FrmEstudiantes : Form
    {
        private string RutaOrigen;
        private string RutaDestino;
        private string Directorio = "D:\\sistema2\\";
        private string NombreAnt;
        public FrmEstudiantes()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DgvListado.DataSource = NEstudiantes.Listar();
                this.Formato();
                this.Limpiar();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                DgvListado.DataSource = NEstudiantes.Buscar(TxtBuscar.Text);
                //this.Formato();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListado.Rows.Count);
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
                //CboSeccion.DataSource = NSeleccionar.SeleccionarSeccion(Convert.ToInt32(CboCurso.SelectedValue));
                CboSeccion.DataSource = NSeleccionar.SeleccionarSeccion(Convert.ToInt32(CboCurso.SelectedValue));
                CboSeccion.ValueMember = "Id";
                CboSeccion.DisplayMember = "Nombre";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        private void Formato()
        {
            DgvListado.Columns[0].Visible = false; //seleccionar
            DgvListado.Columns[1].Visible = false; //id
            DgvListado.Columns[2].Width = 100; //nombre
            DgvListado.Columns[3].Width = 120; //apellido paterno
            DgvListado.Columns[4].Width = 120; //apellido materno
            DgvListado.Columns[5].Width = 100;  //rut
            DgvListado.Columns[6].Width = 120; //fecha nacimiento
            DgvListado.Columns[7].Width = 100; //direcccion
            DgvListado.Columns[8].Width = 120; //telefono
            DgvListado.Columns[9].Width = 90; //email
            DgvListado.Columns[10].Visible = false; //sexo
            DgvListado.Columns[11].Width = 120; //id_curso
            DgvListado.Columns[12].Width = 120; //id_seccion
            DgvListado.Columns[13].Visible = false; //id_imagen
            DgvListado.Columns[14].Width =90 ; //estado          

        }
        private void Limpiar()
        {
            TxtRut.Clear();
            TxtNombre.Clear();
            TxtApellidoPaterno.Clear();
            TxtApellidoMaterno.Clear();
            TxtBuscar.Clear();
            TxtId.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
            TxtEmail.Clear();
            TxtImagen.Clear();
            
            
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();
            TxtImagen.Clear();
            PicImagen.Image = null;
            this.RutaDestino = "";
            this.RutaOrigen = "";

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
        private void CargarSexo()
        {
            try
            {
                CboEstudiantes.DataSource = NEstudiantes.Seleccionar();
                CboEstudiantes.ValueMember = "Id";
                CboEstudiantes.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarSexo();
            this.cargarCurso();
            this.cargarSeccion();

        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string Rpta = "";
                if (TxtNombre.Text == string.Empty || TxtApellidoPaterno.Text== string.Empty || TxtRut.Text ==string.Empty || TxtTelefono.Text==string.Empty || TxtEmail.Text==string.Empty || TxtImagen.Text==string.Empty || CboCurso.Text==string.Empty || CboSeccion.Text==string.Empty)
              
              
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre.");
                    ErrorIcono.SetError(TxtApellidoPaterno, "Ingrese un Apellido Paterno.");
                    ErrorIcono.SetError(TxtRut, "Ingrese un rut.");
                    ErrorIcono.SetError(TxtTelefono, "Ingrese un telefono.");
                    ErrorIcono.SetError(TxtEmail, "Ingrese un Email.");
                    ErrorIcono.SetError(TxtImagen, "Ingrese una imagen.");
                    ErrorIcono.SetError(CboCurso, "Seleccionar un curso.");
                    ErrorIcono.SetError(CboSeccion, "Selecionar una seccion.");

                }
                else
                {
                    Rpta = NEstudiantes.Insertar(TxtNombre.Text.Trim(), TxtApellidoPaterno.Text.Trim(), TxtApellidoMaterno.Text.Trim(),TxtRut.Text.Trim(), Convert.ToDateTime(TxtFechaNacimiento.Text.Trim()), Convert.ToInt32(CboEstudiantes.SelectedValue),TxtDireccion.Text.Trim(),Convert.ToInt32(TxtTelefono.Text.Trim()),TxtEmail.Text.Trim(),Convert.ToInt32(CboCurso.SelectedValue),Convert.ToInt32(CboSeccion.SelectedValue), TxtImagen.Text.Trim());

                

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta");

                        if (TxtImagen.Text != string.Empty)
                        {
                            this.RutaDestino = this.Directorio + TxtImagen.Text;
                            File.Copy(this.RutaOrigen, this.RutaDestino);
                        }
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;
                TxtId.Text = Convert.ToString(DgvListado.CurrentRow.Cells["ID"].Value);
                TxtRut.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Rut"].Value);
                this.NombreAnt = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtNombre.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Nombre"].Value);
                TxtApellidoPaterno.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Apellido Paterno"].Value);
                TxtApellidoMaterno.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Apellido Materno"].Value);
                TxtFechaNacimiento.Text =Convert.ToString(DgvListado.CurrentRow.Cells["Fecha Nacimiento"].Value);
                CboEstudiantes.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Sexo"].Value);
                TxtDireccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Direccion"].Value);
                TxtTelefono.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Telefono"].Value);
                TxtEmail.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Email"].Value);
                //CboCurso.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Curso"].Value);
                //CboSeccion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Seccion"].Value);
                string Imagen;
                Imagen = Convert.ToString(DgvListado.CurrentRow.Cells["Imagen"].Value);
                if (Imagen != string.Empty)
                {
                    PicImagen.Image = Image.FromFile(this.Directorio + Imagen);
                    TxtImagen.Text = Imagen;
                }
                else
                {
                    PicImagen.Image = null;
                    TxtImagen.Text = "";
                }
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda nombre.");
            }
            
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtNombre.Text == string.Empty || TxtId.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = NEstudiantes.Actualizar(Convert.ToInt32(TxtId.Text.Trim()),this.NombreAnt,TxtNombre.Text.Trim(), TxtApellidoPaterno.Text.Trim(), TxtApellidoMaterno.Text.Trim(), TxtRut.Text.Trim(), Convert.ToDateTime(TxtFechaNacimiento.Text.Trim()), Convert.ToInt32(CboEstudiantes.SelectedValue), TxtDireccion.Text.Trim(), Convert.ToInt32(TxtTelefono.Text.Trim()), TxtEmail.Text.Trim(), Convert.ToInt32(CboCurso.SelectedValue), Convert.ToInt32(CboSeccion.SelectedValue), TxtImagen.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
                        if (TxtImagen.Text != string.Empty && this.RutaOrigen != string.Empty)
                        {
                            this.RutaDestino = this.Directorio + TxtImagen.Text;
                            File.Copy(this.RutaOrigen, this.RutaDestino);
                        }
                        this.Listar();
                        TabGeneral.SelectedIndex = 0;
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

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkSeleccionar.Checked)
            {
                DgvListado.Columns[0].Visible = true;
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

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)?", "Sistema Escolar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    string Imagen = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Imagen = Convert.ToString(row.Cells[9].Value);
                            Rpta = NEstudiantes.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
                                File.Delete(this.Directorio + Imagen);
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

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas activar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NEstudiantes.Activar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se activó el Estudiante con Rut: " + Convert.ToString(row.Cells[5].Value));
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
                Opcion = MessageBox.Show("Realmente deseas desactivar el(los) registro(s)?", "Sistema de calificaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NEstudiantes.Desactivar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivó el Estudiantes con Rut: " + Convert.ToString(row.Cells[5].Value));
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

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                PicImagen.Image = Image.FromFile(file.FileName);
                TxtImagen.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\") + 1);
                this.RutaOrigen = file.FileName;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmImportarEstudiantes frm = new FrmImportarEstudiantes();
            
            frm.Show();

        }

        private void CboEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void TxtRut_Leave(object sender, EventArgs e)
        {
            bool respuesta = false;
            string rut = TxtRut.Text;
            TxtRut.Text = formatoRut(rut);
            rut = TxtRut.Text;
            respuesta = validarRut(rut);

            if (respuesta == false)
            {
                TxtRut.Focus();
                TxtRut.BackColor = Color.Red;
                MessageBox.Show("Rut Malo");
               
            }
            else
            {
                TxtRut.ForeColor = Color.Black;
                TxtRut.BackColor = Color.GreenYellow;
                 MessageBox.Show("Rut OK");
            }



        }

        private string formatoRut(string rut)
        {
            int cont = 0;
            string format;
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            format = "-" + rut.Substring(rut.Length - 1);
            for (int i = rut.Length - 2; i >= 0; i--)
            {
                format = rut.Substring(i, 1) + format;
                cont++;
                if (cont == 3 && i != 0)
                {
                    format = "." + format;
                    cont = 0;
                }
            }
            return format;
        }


        private bool validarRut(string rut)
        {
            bool validacion = false;
            rut = rut.ToUpper();
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
            char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
            int m = 0, s = 1;
            for (; rutAux != 0; rutAux /= 10)
            {
                s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
            }
            if (dv == (char)(s != 0 ? s + 47 : 75))
            {
                validacion = true;
            }
            return validacion;
        }

        private void CboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cargarSeccion();
        }

        private void CboCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cargarSeccion();
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void TxtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void TxtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void TxtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
    
}
