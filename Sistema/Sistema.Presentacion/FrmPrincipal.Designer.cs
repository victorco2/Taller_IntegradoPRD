namespace Sistema.Presentacion
{
    partial class FrmPrincipal
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.paneltop = new System.Windows.Forms.Panel();
            this.btnMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelleft = new System.Windows.Forms.Panel();
            this.menuHoriz = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMantenedor = new System.Windows.Forms.Panel();
            this.btnProfesores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEstudiantes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MnuMantenedor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelGestionar = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSemestres = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAsignaturas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSecciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCursos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MnuGestionar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelCalificaciones = new System.Windows.Forms.Panel();
            this.btnInformes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIngresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MnuCalificaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelAccesos = new System.Windows.Forms.Panel();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRoles = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MnuAccesos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelConsultas = new System.Windows.Forms.Panel();
            this.btnCertificados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSituacionFinal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MnuConsultas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MnuSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.CurvaMenuHoriz = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timeMantenedor = new System.Windows.Forms.Timer(this.components);
            this.timeGestionar = new System.Windows.Forms.Timer(this.components);
            this.timeCalificaciones = new System.Windows.Forms.Timer(this.components);
            this.timeAccesos = new System.Windows.Forms.Timer(this.components);
            this.timeConsultas = new System.Windows.Forms.Timer(this.components);
            this.Animacion1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Animacion2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelleft.SuspendLayout();
            this.menuHoriz.SuspendLayout();
            this.panelMantenedor.SuspendLayout();
            this.panelGestionar.SuspendLayout();
            this.panelCalificaciones.SuspendLayout();
            this.panelAccesos.SuspendLayout();
            this.panelConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.paneltop.Controls.Add(this.btnMenu);
            this.paneltop.Controls.Add(this.pictureBox1);
            this.Animacion2.SetDecoration(this.paneltop, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.paneltop, BunifuAnimatorNS.DecorationType.None);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(2);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1036, 100);
            this.paneltop.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.ButtonText = "Menu";
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenu.Iconimage = global::Sistema.Presentacion.Properties.Resources.Menu_48px;
            this.btnMenu.Iconimage_right = null;
            this.btnMenu.Iconimage_right_Selected = null;
            this.btnMenu.Iconimage_Selected = null;
            this.btnMenu.IconMarginLeft = 0;
            this.btnMenu.IconMarginRight = 0;
            this.btnMenu.IconRightVisible = true;
            this.btnMenu.IconRightZoom = 0D;
            this.btnMenu.IconVisible = true;
            this.btnMenu.IconZoom = 90D;
            this.btnMenu.IsTab = false;
            this.btnMenu.Location = new System.Drawing.Point(7, 26);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMenu.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenu.selected = false;
            this.btnMenu.Size = new System.Drawing.Size(135, 49);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenu.Textcolor = System.Drawing.Color.White;
            this.btnMenu.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.Animacion1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.panelleft.Controls.Add(this.menuHoriz);
            this.Animacion2.SetDecoration(this.panelleft, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.panelleft, BunifuAnimatorNS.DecorationType.None);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 100);
            this.panelleft.Margin = new System.Windows.Forms.Padding(2);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(225, 509);
            this.panelleft.TabIndex = 2;
            // 
            // menuHoriz
            // 
            this.menuHoriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.menuHoriz.Controls.Add(this.panelMantenedor);
            this.menuHoriz.Controls.Add(this.panelGestionar);
            this.menuHoriz.Controls.Add(this.panelCalificaciones);
            this.menuHoriz.Controls.Add(this.bunifuFlatButton1);
            this.menuHoriz.Controls.Add(this.panelAccesos);
            this.menuHoriz.Controls.Add(this.panelConsultas);
            this.menuHoriz.Controls.Add(this.MnuSalir);
            this.Animacion1.SetDecoration(this.menuHoriz, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.menuHoriz, BunifuAnimatorNS.DecorationType.None);
            this.menuHoriz.Location = new System.Drawing.Point(0, 0);
            this.menuHoriz.Margin = new System.Windows.Forms.Padding(2);
            this.menuHoriz.Name = "menuHoriz";
            this.menuHoriz.Size = new System.Drawing.Size(225, 731);
            this.menuHoriz.TabIndex = 0;
            // 
            // panelMantenedor
            // 
            this.panelMantenedor.Controls.Add(this.btnProfesores);
            this.panelMantenedor.Controls.Add(this.btnEstudiantes);
            this.panelMantenedor.Controls.Add(this.MnuMantenedor);
            this.Animacion2.SetDecoration(this.panelMantenedor, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.panelMantenedor, BunifuAnimatorNS.DecorationType.None);
            this.panelMantenedor.Location = new System.Drawing.Point(8, 16);
            this.panelMantenedor.Margin = new System.Windows.Forms.Padding(8, 16, 2, 2);
            this.panelMantenedor.MaximumSize = new System.Drawing.Size(195, 154);
            this.panelMantenedor.MinimumSize = new System.Drawing.Size(195, 73);
            this.panelMantenedor.Name = "panelMantenedor";
            this.panelMantenedor.Size = new System.Drawing.Size(195, 73);
            this.panelMantenedor.TabIndex = 1;
            // 
            // btnProfesores
            // 
            this.btnProfesores.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProfesores.BackColor = System.Drawing.Color.Transparent;
            this.btnProfesores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfesores.BorderRadius = 0;
            this.btnProfesores.ButtonText = "Profesores";
            this.btnProfesores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnProfesores, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnProfesores, BunifuAnimatorNS.DecorationType.None);
            this.btnProfesores.DisabledColor = System.Drawing.Color.Gray;
            this.btnProfesores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProfesores.Iconimage = null;
            this.btnProfesores.Iconimage_right = null;
            this.btnProfesores.Iconimage_right_Selected = null;
            this.btnProfesores.Iconimage_Selected = null;
            this.btnProfesores.IconMarginLeft = 0;
            this.btnProfesores.IconMarginRight = 0;
            this.btnProfesores.IconRightVisible = true;
            this.btnProfesores.IconRightZoom = 0D;
            this.btnProfesores.IconVisible = true;
            this.btnProfesores.IconZoom = 90D;
            this.btnProfesores.IsTab = false;
            this.btnProfesores.Location = new System.Drawing.Point(20, 105);
            this.btnProfesores.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProfesores.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnProfesores.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProfesores.selected = false;
            this.btnProfesores.Size = new System.Drawing.Size(172, 48);
            this.btnProfesores.TabIndex = 7;
            this.btnProfesores.TabStop = false;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesores.Textcolor = System.Drawing.Color.White;
            this.btnProfesores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnEstudiantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstudiantes.BorderRadius = 0;
            this.btnEstudiantes.ButtonText = "Estudiantes";
            this.btnEstudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnEstudiantes, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnEstudiantes, BunifuAnimatorNS.DecorationType.None);
            this.btnEstudiantes.DisabledColor = System.Drawing.Color.Gray;
            this.btnEstudiantes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEstudiantes.Iconimage = null;
            this.btnEstudiantes.Iconimage_right = null;
            this.btnEstudiantes.Iconimage_right_Selected = null;
            this.btnEstudiantes.Iconimage_Selected = null;
            this.btnEstudiantes.IconMarginLeft = 0;
            this.btnEstudiantes.IconMarginRight = 0;
            this.btnEstudiantes.IconRightVisible = true;
            this.btnEstudiantes.IconRightZoom = 0D;
            this.btnEstudiantes.IconVisible = true;
            this.btnEstudiantes.IconZoom = 90D;
            this.btnEstudiantes.IsTab = false;
            this.btnEstudiantes.Location = new System.Drawing.Point(20, 58);
            this.btnEstudiantes.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEstudiantes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEstudiantes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEstudiantes.selected = false;
            this.btnEstudiantes.Size = new System.Drawing.Size(172, 48);
            this.btnEstudiantes.TabIndex = 6;
            this.btnEstudiantes.TabStop = false;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.Textcolor = System.Drawing.Color.White;
            this.btnEstudiantes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // MnuMantenedor
            // 
            this.MnuMantenedor.Activecolor = System.Drawing.Color.SteelBlue;
            this.MnuMantenedor.BackColor = System.Drawing.Color.Transparent;
            this.MnuMantenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MnuMantenedor.BorderRadius = 0;
            this.MnuMantenedor.ButtonText = "       Mantenedor";
            this.MnuMantenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.MnuMantenedor, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.MnuMantenedor, BunifuAnimatorNS.DecorationType.None);
            this.MnuMantenedor.DisabledColor = System.Drawing.Color.Gray;
            this.MnuMantenedor.Iconcolor = System.Drawing.Color.Transparent;
            this.MnuMantenedor.Iconimage = ((System.Drawing.Image)(resources.GetObject("MnuMantenedor.Iconimage")));
            this.MnuMantenedor.Iconimage_right = null;
            this.MnuMantenedor.Iconimage_right_Selected = null;
            this.MnuMantenedor.Iconimage_Selected = null;
            this.MnuMantenedor.IconMarginLeft = 0;
            this.MnuMantenedor.IconMarginRight = 0;
            this.MnuMantenedor.IconRightVisible = true;
            this.MnuMantenedor.IconRightZoom = 0D;
            this.MnuMantenedor.IconVisible = true;
            this.MnuMantenedor.IconZoom = 85D;
            this.MnuMantenedor.IsTab = false;
            this.MnuMantenedor.Location = new System.Drawing.Point(0, 3);
            this.MnuMantenedor.Margin = new System.Windows.Forms.Padding(4);
            this.MnuMantenedor.Name = "MnuMantenedor";
            this.MnuMantenedor.Normalcolor = System.Drawing.Color.Transparent;
            this.MnuMantenedor.OnHovercolor = System.Drawing.Color.Transparent;
            this.MnuMantenedor.OnHoverTextColor = System.Drawing.Color.White;
            this.MnuMantenedor.selected = false;
            this.MnuMantenedor.Size = new System.Drawing.Size(195, 61);
            this.MnuMantenedor.TabIndex = 5;
            this.MnuMantenedor.Text = "       Mantenedor";
            this.MnuMantenedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MnuMantenedor.Textcolor = System.Drawing.Color.White;
            this.MnuMantenedor.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuMantenedor.Click += new System.EventHandler(this.MnuMantenedor_Click);
            // 
            // panelGestionar
            // 
            this.panelGestionar.Controls.Add(this.bunifuFlatButton2);
            this.panelGestionar.Controls.Add(this.btnSemestres);
            this.panelGestionar.Controls.Add(this.btnAsignaturas);
            this.panelGestionar.Controls.Add(this.btnSecciones);
            this.panelGestionar.Controls.Add(this.btnCursos);
            this.panelGestionar.Controls.Add(this.MnuGestionar);
            this.Animacion2.SetDecoration(this.panelGestionar, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.panelGestionar, BunifuAnimatorNS.DecorationType.None);
            this.panelGestionar.Location = new System.Drawing.Point(8, 107);
            this.panelGestionar.Margin = new System.Windows.Forms.Padding(8, 16, 2, 2);
            this.panelGestionar.MaximumSize = new System.Drawing.Size(195, 292);
            this.panelGestionar.MinimumSize = new System.Drawing.Size(195, 73);
            this.panelGestionar.Name = "panelGestionar";
            this.panelGestionar.Size = new System.Drawing.Size(195, 73);
            this.panelGestionar.TabIndex = 3;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Plan Academico";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(23, 243);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(172, 48);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.Text = "Plan Academico";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // btnSemestres
            // 
            this.btnSemestres.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSemestres.BackColor = System.Drawing.Color.Transparent;
            this.btnSemestres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSemestres.BorderRadius = 0;
            this.btnSemestres.ButtonText = "Semestres";
            this.btnSemestres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnSemestres, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnSemestres, BunifuAnimatorNS.DecorationType.None);
            this.btnSemestres.DisabledColor = System.Drawing.Color.Gray;
            this.btnSemestres.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSemestres.Iconimage = null;
            this.btnSemestres.Iconimage_right = null;
            this.btnSemestres.Iconimage_right_Selected = null;
            this.btnSemestres.Iconimage_Selected = null;
            this.btnSemestres.IconMarginLeft = 0;
            this.btnSemestres.IconMarginRight = 0;
            this.btnSemestres.IconRightVisible = true;
            this.btnSemestres.IconRightZoom = 0D;
            this.btnSemestres.IconVisible = true;
            this.btnSemestres.IconZoom = 90D;
            this.btnSemestres.IsTab = false;
            this.btnSemestres.Location = new System.Drawing.Point(20, 198);
            this.btnSemestres.Margin = new System.Windows.Forms.Padding(4);
            this.btnSemestres.Name = "btnSemestres";
            this.btnSemestres.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSemestres.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSemestres.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSemestres.selected = false;
            this.btnSemestres.Size = new System.Drawing.Size(172, 48);
            this.btnSemestres.TabIndex = 4;
            this.btnSemestres.Text = "Semestres";
            this.btnSemestres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSemestres.Textcolor = System.Drawing.Color.White;
            this.btnSemestres.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemestres.Click += new System.EventHandler(this.btnSemestres_Click);
            // 
            // btnAsignaturas
            // 
            this.btnAsignaturas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAsignaturas.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignaturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsignaturas.BorderRadius = 0;
            this.btnAsignaturas.ButtonText = "Asignaturas";
            this.btnAsignaturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnAsignaturas, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnAsignaturas, BunifuAnimatorNS.DecorationType.None);
            this.btnAsignaturas.DisabledColor = System.Drawing.Color.Gray;
            this.btnAsignaturas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAsignaturas.Iconimage = null;
            this.btnAsignaturas.Iconimage_right = null;
            this.btnAsignaturas.Iconimage_right_Selected = null;
            this.btnAsignaturas.Iconimage_Selected = null;
            this.btnAsignaturas.IconMarginLeft = 0;
            this.btnAsignaturas.IconMarginRight = 0;
            this.btnAsignaturas.IconRightVisible = true;
            this.btnAsignaturas.IconRightZoom = 0D;
            this.btnAsignaturas.IconVisible = true;
            this.btnAsignaturas.IconZoom = 90D;
            this.btnAsignaturas.IsTab = false;
            this.btnAsignaturas.Location = new System.Drawing.Point(20, 156);
            this.btnAsignaturas.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignaturas.Name = "btnAsignaturas";
            this.btnAsignaturas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAsignaturas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAsignaturas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAsignaturas.selected = false;
            this.btnAsignaturas.Size = new System.Drawing.Size(172, 48);
            this.btnAsignaturas.TabIndex = 3;
            this.btnAsignaturas.Text = "Asignaturas";
            this.btnAsignaturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignaturas.Textcolor = System.Drawing.Color.White;
            this.btnAsignaturas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaturas.Click += new System.EventHandler(this.btnAsignaturas_Click);
            // 
            // btnSecciones
            // 
            this.btnSecciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSecciones.BackColor = System.Drawing.Color.Transparent;
            this.btnSecciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSecciones.BorderRadius = 0;
            this.btnSecciones.ButtonText = "Secciones";
            this.btnSecciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnSecciones, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnSecciones, BunifuAnimatorNS.DecorationType.None);
            this.btnSecciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnSecciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSecciones.Iconimage = null;
            this.btnSecciones.Iconimage_right = null;
            this.btnSecciones.Iconimage_right_Selected = null;
            this.btnSecciones.Iconimage_Selected = null;
            this.btnSecciones.IconMarginLeft = 0;
            this.btnSecciones.IconMarginRight = 0;
            this.btnSecciones.IconRightVisible = true;
            this.btnSecciones.IconRightZoom = 0D;
            this.btnSecciones.IconVisible = true;
            this.btnSecciones.IconZoom = 90D;
            this.btnSecciones.IsTab = false;
            this.btnSecciones.Location = new System.Drawing.Point(20, 114);
            this.btnSecciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecciones.Name = "btnSecciones";
            this.btnSecciones.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSecciones.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSecciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSecciones.selected = false;
            this.btnSecciones.Size = new System.Drawing.Size(172, 48);
            this.btnSecciones.TabIndex = 2;
            this.btnSecciones.Text = "Secciones";
            this.btnSecciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecciones.Textcolor = System.Drawing.Color.White;
            this.btnSecciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecciones.Click += new System.EventHandler(this.btnSecciones_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCursos.BackColor = System.Drawing.Color.Transparent;
            this.btnCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCursos.BorderRadius = 0;
            this.btnCursos.ButtonText = "Cursos";
            this.btnCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnCursos, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnCursos, BunifuAnimatorNS.DecorationType.None);
            this.btnCursos.DisabledColor = System.Drawing.Color.Gray;
            this.btnCursos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCursos.Iconimage = null;
            this.btnCursos.Iconimage_right = null;
            this.btnCursos.Iconimage_right_Selected = null;
            this.btnCursos.Iconimage_Selected = null;
            this.btnCursos.IconMarginLeft = 0;
            this.btnCursos.IconMarginRight = 0;
            this.btnCursos.IconRightVisible = true;
            this.btnCursos.IconRightZoom = 0D;
            this.btnCursos.IconVisible = true;
            this.btnCursos.IconZoom = 90D;
            this.btnCursos.IsTab = false;
            this.btnCursos.Location = new System.Drawing.Point(20, 76);
            this.btnCursos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCursos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCursos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCursos.selected = false;
            this.btnCursos.Size = new System.Drawing.Size(172, 48);
            this.btnCursos.TabIndex = 1;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.Textcolor = System.Drawing.Color.White;
            this.btnCursos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // MnuGestionar
            // 
            this.MnuGestionar.Activecolor = System.Drawing.Color.SteelBlue;
            this.MnuGestionar.BackColor = System.Drawing.Color.Transparent;
            this.MnuGestionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MnuGestionar.BorderRadius = 0;
            this.MnuGestionar.ButtonText = "  Gestionar";
            this.MnuGestionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.MnuGestionar, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.MnuGestionar, BunifuAnimatorNS.DecorationType.None);
            this.MnuGestionar.DisabledColor = System.Drawing.Color.Gray;
            this.MnuGestionar.Iconcolor = System.Drawing.Color.Transparent;
            this.MnuGestionar.Iconimage = ((System.Drawing.Image)(resources.GetObject("MnuGestionar.Iconimage")));
            this.MnuGestionar.Iconimage_right = null;
            this.MnuGestionar.Iconimage_right_Selected = null;
            this.MnuGestionar.Iconimage_Selected = null;
            this.MnuGestionar.IconMarginLeft = 0;
            this.MnuGestionar.IconMarginRight = 0;
            this.MnuGestionar.IconRightVisible = true;
            this.MnuGestionar.IconRightZoom = 0D;
            this.MnuGestionar.IconVisible = true;
            this.MnuGestionar.IconZoom = 85D;
            this.MnuGestionar.IsTab = false;
            this.MnuGestionar.Location = new System.Drawing.Point(0, 12);
            this.MnuGestionar.Margin = new System.Windows.Forms.Padding(4);
            this.MnuGestionar.Name = "MnuGestionar";
            this.MnuGestionar.Normalcolor = System.Drawing.Color.Transparent;
            this.MnuGestionar.OnHovercolor = System.Drawing.Color.Transparent;
            this.MnuGestionar.OnHoverTextColor = System.Drawing.Color.White;
            this.MnuGestionar.selected = false;
            this.MnuGestionar.Size = new System.Drawing.Size(195, 61);
            this.MnuGestionar.TabIndex = 0;
            this.MnuGestionar.Text = "  Gestionar";
            this.MnuGestionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MnuGestionar.Textcolor = System.Drawing.Color.White;
            this.MnuGestionar.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuGestionar.Click += new System.EventHandler(this.MnuGestionar_Click);
            // 
            // panelCalificaciones
            // 
            this.panelCalificaciones.Controls.Add(this.btnInformes);
            this.panelCalificaciones.Controls.Add(this.btnReportes);
            this.panelCalificaciones.Controls.Add(this.btnIngresar);
            this.panelCalificaciones.Controls.Add(this.MnuCalificaciones);
            this.Animacion2.SetDecoration(this.panelCalificaciones, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.panelCalificaciones, BunifuAnimatorNS.DecorationType.None);
            this.panelCalificaciones.Location = new System.Drawing.Point(8, 198);
            this.panelCalificaciones.Margin = new System.Windows.Forms.Padding(8, 16, 2, 2);
            this.panelCalificaciones.MaximumSize = new System.Drawing.Size(195, 228);
            this.panelCalificaciones.MinimumSize = new System.Drawing.Size(195, 73);
            this.panelCalificaciones.Name = "panelCalificaciones";
            this.panelCalificaciones.Size = new System.Drawing.Size(195, 73);
            this.panelCalificaciones.TabIndex = 5;
            // 
            // btnInformes
            // 
            this.btnInformes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInformes.BackColor = System.Drawing.Color.Transparent;
            this.btnInformes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInformes.BorderRadius = 0;
            this.btnInformes.ButtonText = "Informes";
            this.btnInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnInformes, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnInformes, BunifuAnimatorNS.DecorationType.None);
            this.btnInformes.DisabledColor = System.Drawing.Color.Gray;
            this.btnInformes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInformes.Iconimage = null;
            this.btnInformes.Iconimage_right = null;
            this.btnInformes.Iconimage_right_Selected = null;
            this.btnInformes.Iconimage_Selected = null;
            this.btnInformes.IconMarginLeft = 0;
            this.btnInformes.IconMarginRight = 0;
            this.btnInformes.IconRightVisible = true;
            this.btnInformes.IconRightZoom = 0D;
            this.btnInformes.IconVisible = true;
            this.btnInformes.IconZoom = 90D;
            this.btnInformes.IsTab = false;
            this.btnInformes.Location = new System.Drawing.Point(20, 173);
            this.btnInformes.Margin = new System.Windows.Forms.Padding(4);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInformes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnInformes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInformes.selected = false;
            this.btnInformes.Size = new System.Drawing.Size(172, 48);
            this.btnInformes.TabIndex = 3;
            this.btnInformes.Text = "Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Textcolor = System.Drawing.Color.White;
            this.btnInformes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnReportes
            // 
            this.btnReportes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.BorderRadius = 0;
            this.btnReportes.ButtonText = "Reportes";
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnReportes, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnReportes, BunifuAnimatorNS.DecorationType.None);
            this.btnReportes.DisabledColor = System.Drawing.Color.Gray;
            this.btnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReportes.Iconimage = null;
            this.btnReportes.Iconimage_right = null;
            this.btnReportes.Iconimage_right_Selected = null;
            this.btnReportes.Iconimage_Selected = null;
            this.btnReportes.IconMarginLeft = 0;
            this.btnReportes.IconMarginRight = 0;
            this.btnReportes.IconRightVisible = true;
            this.btnReportes.IconRightZoom = 0D;
            this.btnReportes.IconVisible = true;
            this.btnReportes.IconZoom = 90D;
            this.btnReportes.IsTab = false;
            this.btnReportes.Location = new System.Drawing.Point(20, 127);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReportes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReportes.selected = false;
            this.btnReportes.Size = new System.Drawing.Size(172, 48);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Textcolor = System.Drawing.Color.White;
            this.btnReportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresar.BorderRadius = 0;
            this.btnIngresar.ButtonText = "Ingresar";
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnIngresar, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnIngresar, BunifuAnimatorNS.DecorationType.None);
            this.btnIngresar.DisabledColor = System.Drawing.Color.Gray;
            this.btnIngresar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIngresar.Iconimage = null;
            this.btnIngresar.Iconimage_right = null;
            this.btnIngresar.Iconimage_right_Selected = null;
            this.btnIngresar.Iconimage_Selected = null;
            this.btnIngresar.IconMarginLeft = 0;
            this.btnIngresar.IconMarginRight = 0;
            this.btnIngresar.IconRightVisible = true;
            this.btnIngresar.IconRightZoom = 0D;
            this.btnIngresar.IconVisible = true;
            this.btnIngresar.IconZoom = 90D;
            this.btnIngresar.IsTab = false;
            this.btnIngresar.Location = new System.Drawing.Point(20, 80);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnIngresar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnIngresar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIngresar.selected = false;
            this.btnIngresar.Size = new System.Drawing.Size(172, 48);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Textcolor = System.Drawing.Color.White;
            this.btnIngresar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // MnuCalificaciones
            // 
            this.MnuCalificaciones.Activecolor = System.Drawing.Color.SteelBlue;
            this.MnuCalificaciones.BackColor = System.Drawing.Color.Transparent;
            this.MnuCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MnuCalificaciones.BorderRadius = 0;
            this.MnuCalificaciones.ButtonText = "     Calificaciones";
            this.MnuCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.MnuCalificaciones, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.MnuCalificaciones, BunifuAnimatorNS.DecorationType.None);
            this.MnuCalificaciones.DisabledColor = System.Drawing.Color.Gray;
            this.MnuCalificaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.MnuCalificaciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("MnuCalificaciones.Iconimage")));
            this.MnuCalificaciones.Iconimage_right = null;
            this.MnuCalificaciones.Iconimage_right_Selected = null;
            this.MnuCalificaciones.Iconimage_Selected = null;
            this.MnuCalificaciones.IconMarginLeft = 0;
            this.MnuCalificaciones.IconMarginRight = 0;
            this.MnuCalificaciones.IconRightVisible = true;
            this.MnuCalificaciones.IconRightZoom = 0D;
            this.MnuCalificaciones.IconVisible = true;
            this.MnuCalificaciones.IconZoom = 85D;
            this.MnuCalificaciones.IsTab = false;
            this.MnuCalificaciones.Location = new System.Drawing.Point(0, 12);
            this.MnuCalificaciones.Margin = new System.Windows.Forms.Padding(4);
            this.MnuCalificaciones.Name = "MnuCalificaciones";
            this.MnuCalificaciones.Normalcolor = System.Drawing.Color.Transparent;
            this.MnuCalificaciones.OnHovercolor = System.Drawing.Color.Transparent;
            this.MnuCalificaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.MnuCalificaciones.selected = false;
            this.MnuCalificaciones.Size = new System.Drawing.Size(195, 57);
            this.MnuCalificaciones.TabIndex = 0;
            this.MnuCalificaciones.Text = "     Calificaciones";
            this.MnuCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MnuCalificaciones.Textcolor = System.Drawing.Color.White;
            this.MnuCalificaciones.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuCalificaciones.Click += new System.EventHandler(this.MnuCalificaciones_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.SteelBlue;
            this.bunifuFlatButton1.AllowDrop = true;
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Promover";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = global::Sistema.Presentacion.Properties.Resources.ARROW_DASHBOARD_EXPANDIR;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 85D;
            this.bunifuFlatButton1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(8, 289);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(8, 16, 3, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(195, 61);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Promover";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelAccesos
            // 
            this.panelAccesos.Controls.Add(this.btnUsuarios);
            this.panelAccesos.Controls.Add(this.btnRoles);
            this.panelAccesos.Controls.Add(this.MnuAccesos);
            this.Animacion2.SetDecoration(this.panelAccesos, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.panelAccesos, BunifuAnimatorNS.DecorationType.None);
            this.panelAccesos.Location = new System.Drawing.Point(8, 369);
            this.panelAccesos.Margin = new System.Windows.Forms.Padding(8, 16, 2, 2);
            this.panelAccesos.MaximumSize = new System.Drawing.Size(195, 162);
            this.panelAccesos.MinimumSize = new System.Drawing.Size(195, 73);
            this.panelAccesos.Name = "panelAccesos";
            this.panelAccesos.Size = new System.Drawing.Size(195, 73);
            this.panelAccesos.TabIndex = 6;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.BorderRadius = 0;
            this.btnUsuarios.ButtonText = "Usuarios";
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnUsuarios, BunifuAnimatorNS.DecorationType.None);
            this.btnUsuarios.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Iconimage = null;
            this.btnUsuarios.Iconimage_right = null;
            this.btnUsuarios.Iconimage_right_Selected = null;
            this.btnUsuarios.Iconimage_Selected = null;
            this.btnUsuarios.IconMarginLeft = 0;
            this.btnUsuarios.IconMarginRight = 0;
            this.btnUsuarios.IconRightVisible = true;
            this.btnUsuarios.IconRightZoom = 0D;
            this.btnUsuarios.IconVisible = true;
            this.btnUsuarios.IconZoom = 90D;
            this.btnUsuarios.IsTab = false;
            this.btnUsuarios.Location = new System.Drawing.Point(20, 101);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsuarios.selected = false;
            this.btnUsuarios.Size = new System.Drawing.Size(172, 48);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Textcolor = System.Drawing.Color.White;
            this.btnUsuarios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRoles.BackColor = System.Drawing.Color.Transparent;
            this.btnRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoles.BorderRadius = 0;
            this.btnRoles.ButtonText = "Roles";
            this.btnRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnRoles, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnRoles, BunifuAnimatorNS.DecorationType.None);
            this.btnRoles.DisabledColor = System.Drawing.Color.Gray;
            this.btnRoles.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRoles.Iconimage = null;
            this.btnRoles.Iconimage_right = null;
            this.btnRoles.Iconimage_right_Selected = null;
            this.btnRoles.Iconimage_Selected = null;
            this.btnRoles.IconMarginLeft = 0;
            this.btnRoles.IconMarginRight = 0;
            this.btnRoles.IconRightVisible = true;
            this.btnRoles.IconRightZoom = 0D;
            this.btnRoles.IconVisible = true;
            this.btnRoles.IconZoom = 90D;
            this.btnRoles.IsTab = false;
            this.btnRoles.Location = new System.Drawing.Point(20, 58);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRoles.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnRoles.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRoles.selected = false;
            this.btnRoles.Size = new System.Drawing.Size(172, 48);
            this.btnRoles.TabIndex = 1;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Textcolor = System.Drawing.Color.White;
            this.btnRoles.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // MnuAccesos
            // 
            this.MnuAccesos.Activecolor = System.Drawing.Color.SteelBlue;
            this.MnuAccesos.BackColor = System.Drawing.Color.Transparent;
            this.MnuAccesos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MnuAccesos.BorderRadius = 0;
            this.MnuAccesos.ButtonText = "Accesos";
            this.MnuAccesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.MnuAccesos, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.MnuAccesos, BunifuAnimatorNS.DecorationType.None);
            this.MnuAccesos.DisabledColor = System.Drawing.Color.Gray;
            this.MnuAccesos.Iconcolor = System.Drawing.Color.Transparent;
            this.MnuAccesos.Iconimage = ((System.Drawing.Image)(resources.GetObject("MnuAccesos.Iconimage")));
            this.MnuAccesos.Iconimage_right = null;
            this.MnuAccesos.Iconimage_right_Selected = null;
            this.MnuAccesos.Iconimage_Selected = null;
            this.MnuAccesos.IconMarginLeft = 0;
            this.MnuAccesos.IconMarginRight = 0;
            this.MnuAccesos.IconRightVisible = true;
            this.MnuAccesos.IconRightZoom = 0D;
            this.MnuAccesos.IconVisible = true;
            this.MnuAccesos.IconZoom = 85D;
            this.MnuAccesos.IsTab = false;
            this.MnuAccesos.Location = new System.Drawing.Point(0, 12);
            this.MnuAccesos.Margin = new System.Windows.Forms.Padding(4);
            this.MnuAccesos.Name = "MnuAccesos";
            this.MnuAccesos.Normalcolor = System.Drawing.Color.Transparent;
            this.MnuAccesos.OnHovercolor = System.Drawing.Color.Transparent;
            this.MnuAccesos.OnHoverTextColor = System.Drawing.Color.White;
            this.MnuAccesos.selected = false;
            this.MnuAccesos.Size = new System.Drawing.Size(195, 61);
            this.MnuAccesos.TabIndex = 0;
            this.MnuAccesos.Text = "Accesos";
            this.MnuAccesos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MnuAccesos.Textcolor = System.Drawing.Color.White;
            this.MnuAccesos.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuAccesos.Click += new System.EventHandler(this.MnuAccesos_Click);
            // 
            // panelConsultas
            // 
            this.panelConsultas.Controls.Add(this.btnCertificados);
            this.panelConsultas.Controls.Add(this.btnSituacionFinal);
            this.panelConsultas.Controls.Add(this.MnuConsultas);
            this.Animacion2.SetDecoration(this.panelConsultas, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.panelConsultas, BunifuAnimatorNS.DecorationType.None);
            this.panelConsultas.Location = new System.Drawing.Point(8, 460);
            this.panelConsultas.Margin = new System.Windows.Forms.Padding(8, 16, 2, 2);
            this.panelConsultas.MaximumSize = new System.Drawing.Size(195, 162);
            this.panelConsultas.MinimumSize = new System.Drawing.Size(195, 73);
            this.panelConsultas.Name = "panelConsultas";
            this.panelConsultas.Size = new System.Drawing.Size(195, 73);
            this.panelConsultas.TabIndex = 7;
            // 
            // btnCertificados
            // 
            this.btnCertificados.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCertificados.BackColor = System.Drawing.Color.Transparent;
            this.btnCertificados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCertificados.BorderRadius = 0;
            this.btnCertificados.ButtonText = "Certificados";
            this.btnCertificados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnCertificados, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnCertificados, BunifuAnimatorNS.DecorationType.None);
            this.btnCertificados.DisabledColor = System.Drawing.Color.Gray;
            this.btnCertificados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCertificados.Iconimage = null;
            this.btnCertificados.Iconimage_right = null;
            this.btnCertificados.Iconimage_right_Selected = null;
            this.btnCertificados.Iconimage_Selected = null;
            this.btnCertificados.IconMarginLeft = 0;
            this.btnCertificados.IconMarginRight = 0;
            this.btnCertificados.IconRightVisible = true;
            this.btnCertificados.IconRightZoom = 0D;
            this.btnCertificados.IconVisible = true;
            this.btnCertificados.IconZoom = 90D;
            this.btnCertificados.IsTab = false;
            this.btnCertificados.Location = new System.Drawing.Point(20, 114);
            this.btnCertificados.Margin = new System.Windows.Forms.Padding(4);
            this.btnCertificados.Name = "btnCertificados";
            this.btnCertificados.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCertificados.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCertificados.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCertificados.selected = false;
            this.btnCertificados.Size = new System.Drawing.Size(172, 48);
            this.btnCertificados.TabIndex = 2;
            this.btnCertificados.Text = "Certificados";
            this.btnCertificados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCertificados.Textcolor = System.Drawing.Color.White;
            this.btnCertificados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSituacionFinal
            // 
            this.btnSituacionFinal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSituacionFinal.BackColor = System.Drawing.Color.Transparent;
            this.btnSituacionFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSituacionFinal.BorderRadius = 0;
            this.btnSituacionFinal.ButtonText = "Situacion Final";
            this.btnSituacionFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.btnSituacionFinal, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.btnSituacionFinal, BunifuAnimatorNS.DecorationType.None);
            this.btnSituacionFinal.DisabledColor = System.Drawing.Color.Gray;
            this.btnSituacionFinal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSituacionFinal.Iconimage = null;
            this.btnSituacionFinal.Iconimage_right = null;
            this.btnSituacionFinal.Iconimage_right_Selected = null;
            this.btnSituacionFinal.Iconimage_Selected = null;
            this.btnSituacionFinal.IconMarginLeft = 0;
            this.btnSituacionFinal.IconMarginRight = 0;
            this.btnSituacionFinal.IconRightVisible = true;
            this.btnSituacionFinal.IconRightZoom = 0D;
            this.btnSituacionFinal.IconVisible = true;
            this.btnSituacionFinal.IconZoom = 90D;
            this.btnSituacionFinal.IsTab = false;
            this.btnSituacionFinal.Location = new System.Drawing.Point(20, 58);
            this.btnSituacionFinal.Margin = new System.Windows.Forms.Padding(4);
            this.btnSituacionFinal.Name = "btnSituacionFinal";
            this.btnSituacionFinal.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSituacionFinal.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSituacionFinal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSituacionFinal.selected = false;
            this.btnSituacionFinal.Size = new System.Drawing.Size(172, 48);
            this.btnSituacionFinal.TabIndex = 1;
            this.btnSituacionFinal.Text = "Situacion Final";
            this.btnSituacionFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSituacionFinal.Textcolor = System.Drawing.Color.White;
            this.btnSituacionFinal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSituacionFinal.Click += new System.EventHandler(this.btnSituacionFinal_Click);
            // 
            // MnuConsultas
            // 
            this.MnuConsultas.Activecolor = System.Drawing.Color.SteelBlue;
            this.MnuConsultas.BackColor = System.Drawing.Color.Transparent;
            this.MnuConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MnuConsultas.BorderRadius = 0;
            this.MnuConsultas.ButtonText = "Consultas";
            this.MnuConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.MnuConsultas, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.MnuConsultas, BunifuAnimatorNS.DecorationType.None);
            this.MnuConsultas.DisabledColor = System.Drawing.Color.Gray;
            this.MnuConsultas.Iconcolor = System.Drawing.Color.Transparent;
            this.MnuConsultas.Iconimage = ((System.Drawing.Image)(resources.GetObject("MnuConsultas.Iconimage")));
            this.MnuConsultas.Iconimage_right = null;
            this.MnuConsultas.Iconimage_right_Selected = null;
            this.MnuConsultas.Iconimage_Selected = null;
            this.MnuConsultas.IconMarginLeft = 0;
            this.MnuConsultas.IconMarginRight = 0;
            this.MnuConsultas.IconRightVisible = true;
            this.MnuConsultas.IconRightZoom = 0D;
            this.MnuConsultas.IconVisible = true;
            this.MnuConsultas.IconZoom = 85D;
            this.MnuConsultas.IsTab = false;
            this.MnuConsultas.Location = new System.Drawing.Point(0, 12);
            this.MnuConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.MnuConsultas.Name = "MnuConsultas";
            this.MnuConsultas.Normalcolor = System.Drawing.Color.Transparent;
            this.MnuConsultas.OnHovercolor = System.Drawing.Color.Transparent;
            this.MnuConsultas.OnHoverTextColor = System.Drawing.Color.White;
            this.MnuConsultas.selected = false;
            this.MnuConsultas.Size = new System.Drawing.Size(195, 61);
            this.MnuConsultas.TabIndex = 0;
            this.MnuConsultas.Text = "Consultas";
            this.MnuConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MnuConsultas.Textcolor = System.Drawing.Color.White;
            this.MnuConsultas.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuConsultas.Click += new System.EventHandler(this.MnuConsultas_Click);
            // 
            // MnuSalir
            // 
            this.MnuSalir.Activecolor = System.Drawing.Color.SteelBlue;
            this.MnuSalir.AllowDrop = true;
            this.MnuSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MnuSalir.BackColor = System.Drawing.Color.Transparent;
            this.MnuSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MnuSalir.BorderRadius = 0;
            this.MnuSalir.ButtonText = "Salir";
            this.MnuSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animacion1.SetDecoration(this.MnuSalir, BunifuAnimatorNS.DecorationType.None);
            this.Animacion2.SetDecoration(this.MnuSalir, BunifuAnimatorNS.DecorationType.None);
            this.MnuSalir.DisabledColor = System.Drawing.Color.Gray;
            this.MnuSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.MnuSalir.Iconimage = ((System.Drawing.Image)(resources.GetObject("MnuSalir.Iconimage")));
            this.MnuSalir.Iconimage_right = null;
            this.MnuSalir.Iconimage_right_Selected = null;
            this.MnuSalir.Iconimage_Selected = null;
            this.MnuSalir.IconMarginLeft = 0;
            this.MnuSalir.IconMarginRight = 0;
            this.MnuSalir.IconRightVisible = true;
            this.MnuSalir.IconRightZoom = 0D;
            this.MnuSalir.IconVisible = true;
            this.MnuSalir.IconZoom = 85D;
            this.MnuSalir.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MnuSalir.IsTab = false;
            this.MnuSalir.Location = new System.Drawing.Point(8, 551);
            this.MnuSalir.Margin = new System.Windows.Forms.Padding(8, 16, 3, 3);
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Normalcolor = System.Drawing.Color.Transparent;
            this.MnuSalir.OnHovercolor = System.Drawing.Color.Transparent;
            this.MnuSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.MnuSalir.selected = false;
            this.MnuSalir.Size = new System.Drawing.Size(195, 61);
            this.MnuSalir.TabIndex = 6;
            this.MnuSalir.Text = "Salir";
            this.MnuSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MnuSalir.Textcolor = System.Drawing.Color.White;
            this.MnuSalir.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Animacion2.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(225, 100);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(811, 509);
            this.panelContenedor.TabIndex = 3;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.btsdfs_Paint);
            // 
            // CurvaMenuHoriz
            // 
            this.CurvaMenuHoriz.ElipseRadius = 5;
            this.CurvaMenuHoriz.TargetControl = this.menuHoriz;
            // 
            // timeMantenedor
            // 
            this.timeMantenedor.Interval = 10;
            this.timeMantenedor.Tag = "panelMantenedor";
            this.timeMantenedor.Tick += new System.EventHandler(this.timeMantenedor_Tick);
            // 
            // timeGestionar
            // 
            this.timeGestionar.Interval = 10;
            this.timeGestionar.Tag = "panelGestionar";
            this.timeGestionar.Tick += new System.EventHandler(this.timeGestionar_Tick);
            // 
            // timeCalificaciones
            // 
            this.timeCalificaciones.Interval = 10;
            this.timeCalificaciones.Tag = "panelCalificaciones";
            this.timeCalificaciones.Tick += new System.EventHandler(this.timeCalificaciones_Tick);
            // 
            // timeAccesos
            // 
            this.timeAccesos.Interval = 10;
            this.timeAccesos.Tag = "panelAccesos";
            this.timeAccesos.Tick += new System.EventHandler(this.timeAccesos_Tick);
            // 
            // timeConsultas
            // 
            this.timeConsultas.Interval = 10;
            this.timeConsultas.Tag = "panelConsultas";
            this.timeConsultas.Tick += new System.EventHandler(this.timeConsultas_Tick);
            // 
            // Animacion1
            // 
            this.Animacion1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Animacion1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.Animacion1.DefaultAnimation = animation4;
            // 
            // Animacion2
            // 
            this.Animacion2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Animacion2.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.Animacion2.DefaultAnimation = animation3;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 609);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.paneltop);
            this.Animacion2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Animacion1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelleft.ResumeLayout(false);
            this.menuHoriz.ResumeLayout(false);
            this.panelMantenedor.ResumeLayout(false);
            this.panelGestionar.ResumeLayout(false);
            this.panelCalificaciones.ResumeLayout(false);
            this.panelAccesos.ResumeLayout(false);
            this.panelConsultas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.FlowLayoutPanel menuHoriz;
        private System.Windows.Forms.Panel panelMantenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnProfesores;
        private Bunifu.Framework.UI.BunifuFlatButton btnEstudiantes;
        private Bunifu.Framework.UI.BunifuFlatButton MnuMantenedor;
        private System.Windows.Forms.Panel panelGestionar;
        private Bunifu.Framework.UI.BunifuFlatButton btnSecciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnCursos;
        private Bunifu.Framework.UI.BunifuFlatButton MnuGestionar;
        private System.Windows.Forms.Panel panelCalificaciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnIngresar;
        private Bunifu.Framework.UI.BunifuFlatButton MnuCalificaciones;
        private System.Windows.Forms.Panel panelAccesos;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuarios;
        private Bunifu.Framework.UI.BunifuFlatButton btnRoles;
        private Bunifu.Framework.UI.BunifuFlatButton MnuAccesos;
        private System.Windows.Forms.Panel panelConsultas;
        private Bunifu.Framework.UI.BunifuFlatButton btnCertificados;
        private Bunifu.Framework.UI.BunifuFlatButton btnSituacionFinal;
        private Bunifu.Framework.UI.BunifuFlatButton MnuConsultas;
        private Bunifu.Framework.UI.BunifuFlatButton btnSemestres;
        private Bunifu.Framework.UI.BunifuFlatButton btnAsignaturas;
        private Bunifu.Framework.UI.BunifuFlatButton btnInformes;
        private Bunifu.Framework.UI.BunifuFlatButton btnReportes;
        private BunifuAnimatorNS.BunifuTransition Animacion1;
        private BunifuAnimatorNS.BunifuTransition Animacion2;
        private Bunifu.Framework.UI.BunifuElipse CurvaMenuHoriz;
        private System.Windows.Forms.Timer timeMantenedor;
        private System.Windows.Forms.Timer timeGestionar;
        private System.Windows.Forms.Timer timeCalificaciones;
        private System.Windows.Forms.Timer timeAccesos;
        private System.Windows.Forms.Timer timeConsultas;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton MnuSalir;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}