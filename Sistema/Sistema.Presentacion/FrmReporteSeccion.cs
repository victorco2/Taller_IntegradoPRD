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
    public partial class FrmReporteSeccion : Form
    {
        public FrmReporteSeccion()
        {
            InitializeComponent();
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



        private void FrmReporteSeccion_Load(object sender, EventArgs e)
        {
            this.cargarSemestre();
            this.cargarCurso();
            this.cargarSeccion();
            this.cargarAsignatura();
        }
    }
}
