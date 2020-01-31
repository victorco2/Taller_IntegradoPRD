using Sistema.Presentacion.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        public int IdUsuario;
        public int IdRol;
        public string Nombre;
        public string Rol;
        public bool Estado;
        private bool Desglozar;
        private bool Open;
        public FrmPrincipal()
        {
            InitializeComponent();
            
            RenderMenu();


            Open = true;
        }

        private void RenderMenu()
        {

            menuHoriz.Width = 65;
            panelleft.Width = 80;

            SlideMenu(panelMantenedor, MnuMantenedor, false, timeMantenedor);
            SlideMenu(panelGestionar, MnuGestionar, false, timeGestionar);
            SlideMenu(panelCalificaciones, MnuCalificaciones, false, timeCalificaciones);
            SlideMenu(panelAccesos, MnuAccesos, false, timeAccesos);
            SlideMenu(panelConsultas, MnuConsultas, false, timeConsultas);
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formato()
        {
              if (menuHoriz.Width == 200)
            {
                menuHoriz.Visible = false;
                menuHoriz.Width = 50;
                panelleft.Width = 60;
                Animacion1.Show(menuHoriz);
            }
            else
            {
                menuHoriz.Visible = false;
                menuHoriz.Width = 224;
                panelleft.Width = 224;
                Animacion2.Show(menuHoriz);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.formato();
            MessageBox.Show("Bienvenido: " + this.Nombre, "Sistema de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //switch ( this.Rol) { 
            // case "Administrador":
            //        MnuMantenedor.Enabled = true;
            //        MnuCalificaciones.Enabled = true;
            //        MnuGestionar.Enabled = true;
            //        MnuAccesos.Enabled = true;
            //        break;
            //  case "Profesor":
            //        MnuMantenedor.Enabled = false;
            //        MnuCalificaciones.Enabled = true;
            //        MnuGestionar.Enabled = false;
            //        MnuAccesos.Enabled = false;
            //        break;

            //}
               


            if (this.Rol.Equals("Administrador"))
            {
                MnuMantenedor.Enabled = true;
                MnuCalificaciones.Enabled = true;
                MnuGestionar.Enabled = true;
                MnuAccesos.Enabled = true;


            }
            else if (this.Rol.Equals("Profesor"))
                {
                    MnuMantenedor.Enabled = false;
                    MnuCalificaciones.Enabled = true;
                    MnuGestionar.Enabled = false;
                    MnuAccesos.Enabled = false;


                }
            else if (this.Rol.Equals("ProfesorJefe"))
                    {
                        MnuMantenedor.Enabled = true;
                        MnuCalificaciones.Enabled = true;
                        MnuGestionar.Enabled = false;
                        MnuAccesos.Enabled = false;


                    }
            else
                    {
                        MnuMantenedor.Enabled = false;
                        MnuCalificaciones.Enabled = false;
                        MnuGestionar.Enabled = false;
                        MnuAccesos.Enabled = false;


                    } 
        }  

        private void btsdfs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Deseas salir del Sistema?", "Sistema de Calificaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormHijos(new FrmEstudiantes());
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            AbrirFormHijos(new FrmDocente ());
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AbrirFormHijos(new FrmCalificacion());
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            AbrirFormHijos(new FrmRol());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHijos(new FrmUsuario());
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            AbrirFormHijos(new FrmCreacionCurso());
        }

        private void btnSecciones_Click(object sender, EventArgs e)
        {
            AbrirFormHijos(new FrmSeccion());
        }

        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            AbrirFormHijos(new FrmIngresoMateria());
        }

        private void btnSemestres_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSituacionFinal_Click(object sender, EventArgs e)
        {
          

        }

        private void SlideMenu(Panel panel, Bunifu.Framework.UI.BunifuFlatButton button, bool status, Timer timer)
        {
            if (status)
            {
                button.Iconimage_right = Resources.ARROW_DASHBOARD_CONTRAER;
                panel.Height = panel.MaximumSize.Height;
            }
            else
            {
                button.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
                panel.Height = panel.MinimumSize.Height;

            }


        }
        private void timeMantenedor_Tick(object sender, EventArgs e)
        {
            if (Desglozar)
            {
                MnuMantenedor.Iconimage_right = Resources.ARROW_DASHBOARD_CONTRAER;
                panelMantenedor.Height += 10;
                if (panelMantenedor.Size == panelMantenedor.MaximumSize)
                {
                    timeMantenedor.Stop();
                    Desglozar = false;
                }
            }
            else
            {
                MnuMantenedor.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
                panelMantenedor.Height -= 10;
                if (panelMantenedor.Size == panelMantenedor.MinimumSize)
                {
                    timeMantenedor.Stop();
                    Desglozar = true;
                }
            } 
            
        }

        private void MnuMantenedor_Click(object sender, EventArgs e)
        {
           timeMantenedor.Start();
             
            
        }

        private void timeGestionar_Tick(object sender, EventArgs e)
        {
            if (Desglozar)
            {
                MnuGestionar.Iconimage_right = Resources.ARROW_DASHBOARD_CONTRAER;
                panelGestionar.Height += 10;
                if (panelGestionar.Size == panelGestionar.MaximumSize)
                {
                    timeGestionar.Stop();
                    Desglozar = false;
                }
            }
            else
            {
                MnuGestionar.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
                panelGestionar.Height -= 10;
                if (panelGestionar.Size == panelGestionar.MinimumSize)
                {
                    timeGestionar.Stop();
                    Desglozar = true;
                }
            } 
        }

        private void MnuGestionar_Click(object sender, EventArgs e)
        {
            timeGestionar.Start();
        }

        private void timeCalificaciones_Tick(object sender, EventArgs e)
        {
            if (Desglozar)
            {
                MnuCalificaciones.Iconimage_right = Resources.ARROW_DASHBOARD_CONTRAER;
                panelCalificaciones.Height += 10;
                if (panelCalificaciones.Size == panelCalificaciones.MaximumSize)
                {
                    timeCalificaciones.Stop();
                    Desglozar = false;
                }
            }
            else
            {
                MnuCalificaciones.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
                panelCalificaciones.Height -= 10;
                if (panelCalificaciones.Size == panelCalificaciones.MinimumSize)
                {
                    timeCalificaciones.Stop();
                    Desglozar = true;
                }
            }
            if (Open)
            {
                MnuCalificaciones.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
                panelCalificaciones.Height -= 10;
                if (panelCalificaciones.Size == panelCalificaciones.MinimumSize)
                {
                    timeCalificaciones.Stop();
                    Desglozar = true;
                }
            }
            Open = false;
        }

        private void MnuCalificaciones_Click(object sender, EventArgs e)
        {
            timeCalificaciones.Start();
        }

        private void timeAccesos_Tick(object sender, EventArgs e)
        {
            if (Desglozar)
            {
                MnuAccesos.Iconimage_right = Resources.ARROW_DASHBOARD_CONTRAER;
                panelAccesos.Height += 10;
                if (panelAccesos.Size == panelAccesos.MaximumSize)
                {
                    timeAccesos.Stop();
                    Desglozar = false;
                }
            }
            else
            {
                MnuAccesos.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
                panelAccesos.Height -= 10;
                if (panelAccesos.Size == panelAccesos.MinimumSize)
                {
                    timeAccesos.Stop();
                    Desglozar = true;
                }
            }
            if (Open)
            {
                MnuAccesos.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
                panelAccesos.Height -= 10;
                if (panelAccesos.Size == panelAccesos.MinimumSize)
                {
                    timeAccesos.Stop();
                    Desglozar = true;
                }
            }
            Open = false;
        }

        private void MnuAccesos_Click(object sender, EventArgs e)
        {
            timeAccesos.Start();
        }

        private void timeConsultas_Tick(object sender, EventArgs e)
        {
            if (Desglozar)
            {
                MnuConsultas.Iconimage_right = Resources.ARROW_DASHBOARD_CONTRAER;
                panelConsultas.Height += 10;
                if (panelConsultas.Size == panelConsultas.MaximumSize)
                {
                    timeConsultas.Stop();
                    Desglozar = false;
                }
            }
            else
            {
                MnuConsultas.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
                panelConsultas.Height -= 10;
                if (panelConsultas.Size == panelConsultas.MinimumSize)
                {
                    timeConsultas.Stop();
                    Desglozar = true;
                }
            }
            //if (Open)
            //{
            //    MnuConsultas.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
            //    panelConsultas.Height -= 10;
            //    if (panelConsultas.Size == panelConsultas.MinimumSize)
            //    {
            //        timeConsultas.Stop();
            //        Desglozar = true;
            //    }
            //}
            //Open = false;  
        }

        private void MnuConsultas_Click(object sender, EventArgs e)
        {
            timeConsultas.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menuHoriz.Width == 280)
            {
                menuHoriz.Visible = false;
                menuHoriz.Width = 65;
                panelleft.Width = 80;
                Animacion1.Show(menuHoriz);
            }
            else
            {
                menuHoriz.Visible = false;
                menuHoriz.Width = 280;
                panelleft.Width = 300;
                Animacion2.Show(menuHoriz);
            }
        }
        
        private void AbrirFormHijos(object formhijos)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijos as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //Reportes frm = new Reportes();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();


            FrmReporteSeccion frm = new FrmReporteSeccion();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFormHijos(new FrmPlanificacionAcademica());
        }
    }
}
