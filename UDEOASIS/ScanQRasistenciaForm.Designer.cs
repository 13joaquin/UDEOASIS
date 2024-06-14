namespace UDEOASIS
{
    partial class ScanQRasistenciaForm
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
            comboBox_FIL = new ComboBox();
            label1 = new Label();
            pictureBx_Camara = new PictureBox();
            btn_OpenCamera = new Button();
            btn_ScanQR = new Button();
            groupBx_PelEstudiante = new GroupBox();
            txt_Genero = new TextBox();
            txt_Fecha = new TextBox();
            txtCurso = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            lbl_Genero = new Label();
            lbl_Telefono = new Label();
            lbl_Curso = new Label();
            lbl_Fecha = new Label();
            lbl_Email = new Label();
            lbl_Apellidos = new Label();
            lbl_Nombre = new Label();
            txt_ID = new TextBox();
            lbl_ID = new Label();
            PicShowPhoto = new PictureBox();
            lbl_Time = new Label();
            lbl_Date = new Label();
            label2 = new Label();
            radioBtn_Asistencia = new RadioButton();
            radioBtn_NoAsistencia = new RadioButton();
            btn_AbrirIMGQR = new Button();
            btn_UpdateAsis = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBx_Camara).BeginInit();
            groupBx_PelEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicShowPhoto).BeginInit();
            SuspendLayout();
            // 
            // comboBox_FIL
            // 
            comboBox_FIL.Font = new Font("Dubai", 9.749999F);
            comboBox_FIL.FormattingEnabled = true;
            comboBox_FIL.Location = new Point(52, 54);
            comboBox_FIL.Margin = new Padding(3, 2, 3, 2);
            comboBox_FIL.Name = "comboBox_FIL";
            comboBox_FIL.Size = new Size(133, 30);
            comboBox_FIL.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(61, 42, 85);
            label1.Font = new Font("Gill Sans MT", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 34);
            label1.TabIndex = 1;
            label1.Text = "Scan QR para Asistencia";
            // 
            // pictureBx_Camara
            // 
            pictureBx_Camara.BorderStyle = BorderStyle.FixedSingle;
            pictureBx_Camara.Location = new Point(53, 120);
            pictureBx_Camara.Margin = new Padding(3, 2, 3, 2);
            pictureBx_Camara.Name = "pictureBx_Camara";
            pictureBx_Camara.Size = new Size(132, 142);
            pictureBx_Camara.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBx_Camara.TabIndex = 2;
            pictureBx_Camara.TabStop = false;
            // 
            // btn_OpenCamera
            // 
            btn_OpenCamera.BackColor = Color.FromArgb(61, 42, 85);
            btn_OpenCamera.FlatAppearance.BorderSize = 0;
            btn_OpenCamera.FlatStyle = FlatStyle.Flat;
            btn_OpenCamera.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold);
            btn_OpenCamera.ForeColor = Color.White;
            btn_OpenCamera.Image = Properties.Resources.camara_fotografica_icon;
            btn_OpenCamera.ImageAlign = ContentAlignment.MiddleRight;
            btn_OpenCamera.Location = new Point(29, 308);
            btn_OpenCamera.Margin = new Padding(3, 2, 3, 2);
            btn_OpenCamera.Name = "btn_OpenCamera";
            btn_OpenCamera.Size = new Size(170, 40);
            btn_OpenCamera.TabIndex = 3;
            btn_OpenCamera.Text = "OpenCamera";
            btn_OpenCamera.TextAlign = ContentAlignment.MiddleLeft;
            btn_OpenCamera.UseVisualStyleBackColor = false;
            btn_OpenCamera.Click += btn_OpenCamera_Click;
            // 
            // btn_ScanQR
            // 
            btn_ScanQR.BackColor = Color.FromArgb(162, 24, 46);
            btn_ScanQR.FlatAppearance.BorderSize = 0;
            btn_ScanQR.FlatStyle = FlatStyle.Flat;
            btn_ScanQR.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold);
            btn_ScanQR.ForeColor = Color.White;
            btn_ScanQR.Image = Properties.Resources.codigo_qr_icon1;
            btn_ScanQR.ImageAlign = ContentAlignment.MiddleRight;
            btn_ScanQR.Location = new Point(29, 378);
            btn_ScanQR.Margin = new Padding(3, 2, 3, 2);
            btn_ScanQR.Name = "btn_ScanQR";
            btn_ScanQR.Size = new Size(170, 40);
            btn_ScanQR.TabIndex = 4;
            btn_ScanQR.Text = "ScanQR";
            btn_ScanQR.TextAlign = ContentAlignment.MiddleLeft;
            btn_ScanQR.UseVisualStyleBackColor = false;
            btn_ScanQR.Click += btn_ScanQR_Click;
            // 
            // groupBx_PelEstudiante
            // 
            groupBx_PelEstudiante.Controls.Add(txt_Genero);
            groupBx_PelEstudiante.Controls.Add(txt_Fecha);
            groupBx_PelEstudiante.Controls.Add(txtCurso);
            groupBx_PelEstudiante.Controls.Add(txtApellido);
            groupBx_PelEstudiante.Controls.Add(txtEmail);
            groupBx_PelEstudiante.Controls.Add(txtTelefono);
            groupBx_PelEstudiante.Controls.Add(txtNombre);
            groupBx_PelEstudiante.Controls.Add(lbl_Genero);
            groupBx_PelEstudiante.Controls.Add(lbl_Telefono);
            groupBx_PelEstudiante.Controls.Add(lbl_Curso);
            groupBx_PelEstudiante.Controls.Add(lbl_Fecha);
            groupBx_PelEstudiante.Controls.Add(lbl_Email);
            groupBx_PelEstudiante.Controls.Add(lbl_Apellidos);
            groupBx_PelEstudiante.Controls.Add(lbl_Nombre);
            groupBx_PelEstudiante.Controls.Add(txt_ID);
            groupBx_PelEstudiante.Controls.Add(lbl_ID);
            groupBx_PelEstudiante.Controls.Add(PicShowPhoto);
            groupBx_PelEstudiante.Font = new Font("Gill Sans MT", 11.25F, FontStyle.Bold);
            groupBx_PelEstudiante.Location = new Point(227, 67);
            groupBx_PelEstudiante.Margin = new Padding(3, 2, 3, 2);
            groupBx_PelEstudiante.Name = "groupBx_PelEstudiante";
            groupBx_PelEstudiante.Padding = new Padding(3, 2, 3, 2);
            groupBx_PelEstudiante.Size = new Size(516, 385);
            groupBx_PelEstudiante.TabIndex = 5;
            groupBx_PelEstudiante.TabStop = false;
            groupBx_PelEstudiante.Text = "Perfil de Estudiantes";
            // 
            // txt_Genero
            // 
            txt_Genero.Font = new Font("Dubai", 11.25F);
            txt_Genero.Location = new Point(349, 302);
            txt_Genero.Margin = new Padding(3, 2, 3, 2);
            txt_Genero.Name = "txt_Genero";
            txt_Genero.Size = new Size(142, 33);
            txt_Genero.TabIndex = 45;
            // 
            // txt_Fecha
            // 
            txt_Fecha.Font = new Font("Dubai", 11.25F);
            txt_Fecha.Location = new Point(349, 179);
            txt_Fecha.Margin = new Padding(3, 2, 3, 2);
            txt_Fecha.Name = "txt_Fecha";
            txt_Fecha.Size = new Size(142, 33);
            txt_Fecha.TabIndex = 44;
            // 
            // txtCurso
            // 
            txtCurso.Font = new Font("Dubai", 11.25F);
            txtCurso.Location = new Point(349, 218);
            txtCurso.Margin = new Padding(3, 2, 3, 2);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(142, 33);
            txtCurso.TabIndex = 43;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Dubai", 11.25F);
            txtApellido.Location = new Point(349, 104);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(142, 33);
            txtApellido.TabIndex = 42;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Dubai", 11.25F);
            txtEmail.Location = new Point(349, 140);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(142, 33);
            txtEmail.TabIndex = 41;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Dubai", 11.25F);
            txtTelefono.Location = new Point(349, 260);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(142, 33);
            txtTelefono.TabIndex = 40;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Dubai", 11.25F);
            txtNombre.Location = new Point(349, 67);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 33);
            txtNombre.TabIndex = 39;
            // 
            // lbl_Genero
            // 
            lbl_Genero.AutoSize = true;
            lbl_Genero.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold);
            lbl_Genero.Location = new Point(178, 308);
            lbl_Genero.Name = "lbl_Genero";
            lbl_Genero.Size = new Size(68, 25);
            lbl_Genero.TabIndex = 36;
            lbl_Genero.Text = "Genero:";
            lbl_Genero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold);
            lbl_Telefono.Location = new Point(178, 262);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(80, 25);
            lbl_Telefono.TabIndex = 35;
            lbl_Telefono.Text = "Telefono:";
            lbl_Telefono.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Curso
            // 
            lbl_Curso.AutoSize = true;
            lbl_Curso.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold);
            lbl_Curso.Location = new Point(178, 221);
            lbl_Curso.Name = "lbl_Curso";
            lbl_Curso.Size = new Size(58, 25);
            lbl_Curso.TabIndex = 34;
            lbl_Curso.Text = "Curso:";
            lbl_Curso.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold);
            lbl_Fecha.Location = new Point(174, 182);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(169, 25);
            lbl_Fecha.TabIndex = 33;
            lbl_Fecha.Text = "Fecha de Cumpleaños:";
            lbl_Fecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold);
            lbl_Email.Location = new Point(178, 143);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(118, 25);
            lbl_Email.TabIndex = 32;
            lbl_Email.Text = "Email Address:";
            lbl_Email.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Apellidos
            // 
            lbl_Apellidos.AutoSize = true;
            lbl_Apellidos.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold);
            lbl_Apellidos.Location = new Point(178, 106);
            lbl_Apellidos.Name = "lbl_Apellidos";
            lbl_Apellidos.Size = new Size(84, 25);
            lbl_Apellidos.TabIndex = 31;
            lbl_Apellidos.Text = "Apellidos:";
            lbl_Apellidos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold);
            lbl_Nombre.Location = new Point(178, 62);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(74, 25);
            lbl_Nombre.TabIndex = 29;
            lbl_Nombre.Text = "Nombre:";
            lbl_Nombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_ID
            // 
            txt_ID.Font = new Font("Dubai", 11.25F);
            txt_ID.Location = new Point(349, 28);
            txt_ID.Margin = new Padding(3, 2, 3, 2);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(142, 33);
            txt_ID.TabIndex = 28;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold);
            lbl_ID.Location = new Point(178, 31);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(32, 25);
            lbl_ID.TabIndex = 27;
            lbl_ID.Text = "ID:";
            lbl_ID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PicShowPhoto
            // 
            PicShowPhoto.BorderStyle = BorderStyle.FixedSingle;
            PicShowPhoto.Location = new Point(21, 34);
            PicShowPhoto.Margin = new Padding(3, 2, 3, 2);
            PicShowPhoto.Name = "PicShowPhoto";
            PicShowPhoto.Size = new Size(132, 142);
            PicShowPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            PicShowPhoto.TabIndex = 6;
            PicShowPhoto.TabStop = false;
            // 
            // lbl_Time
            // 
            lbl_Time.AutoSize = true;
            lbl_Time.BackColor = Color.Transparent;
            lbl_Time.Font = new Font("Dubai", 12F);
            lbl_Time.Location = new Point(858, 27);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(44, 27);
            lbl_Time.TabIndex = 7;
            lbl_Time.Text = "Time";
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.BackColor = Color.Transparent;
            lbl_Date.Font = new Font("Dubai", 12F);
            lbl_Date.Location = new Point(694, 9);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(43, 27);
            lbl_Date.TabIndex = 6;
            lbl_Date.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(807, 91);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 8;
            label2.Text = "Marcar:";
            // 
            // radioBtn_Asistencia
            // 
            radioBtn_Asistencia.AutoSize = true;
            radioBtn_Asistencia.Location = new Point(780, 120);
            radioBtn_Asistencia.Margin = new Padding(3, 2, 3, 2);
            radioBtn_Asistencia.Name = "radioBtn_Asistencia";
            radioBtn_Asistencia.Size = new Size(78, 19);
            radioBtn_Asistencia.TabIndex = 9;
            radioBtn_Asistencia.TabStop = true;
            radioBtn_Asistencia.Text = "Asistencia";
            radioBtn_Asistencia.UseVisualStyleBackColor = true;
            // 
            // radioBtn_NoAsistencia
            // 
            radioBtn_NoAsistencia.AutoSize = true;
            radioBtn_NoAsistencia.Location = new Point(780, 152);
            radioBtn_NoAsistencia.Margin = new Padding(3, 2, 3, 2);
            radioBtn_NoAsistencia.Name = "radioBtn_NoAsistencia";
            radioBtn_NoAsistencia.Size = new Size(97, 19);
            radioBtn_NoAsistencia.TabIndex = 10;
            radioBtn_NoAsistencia.TabStop = true;
            radioBtn_NoAsistencia.Text = "No Asistencia";
            radioBtn_NoAsistencia.UseVisualStyleBackColor = true;
            // 
            // btn_AbrirIMGQR
            // 
            btn_AbrirIMGQR.Location = new Point(778, 191);
            btn_AbrirIMGQR.Margin = new Padding(3, 2, 3, 2);
            btn_AbrirIMGQR.Name = "btn_AbrirIMGQR";
            btn_AbrirIMGQR.Size = new Size(117, 28);
            btn_AbrirIMGQR.TabIndex = 11;
            btn_AbrirIMGQR.Text = "Abrir QR";
            btn_AbrirIMGQR.UseVisualStyleBackColor = true;
            btn_AbrirIMGQR.Click += btn_AbrirIMGQR_Click;
            // 
            // btn_UpdateAsis
            // 
            btn_UpdateAsis.Location = new Point(778, 234);
            btn_UpdateAsis.Margin = new Padding(3, 2, 3, 2);
            btn_UpdateAsis.Name = "btn_UpdateAsis";
            btn_UpdateAsis.Size = new Size(117, 28);
            btn_UpdateAsis.TabIndex = 12;
            btn_UpdateAsis.Text = "Update";
            btn_UpdateAsis.UseVisualStyleBackColor = true;
            btn_UpdateAsis.Click += btn_UpdateAsis_Click;
            // 
            // ScanQRasistenciaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(927, 462);
            Controls.Add(btn_UpdateAsis);
            Controls.Add(btn_AbrirIMGQR);
            Controls.Add(radioBtn_NoAsistencia);
            Controls.Add(radioBtn_Asistencia);
            Controls.Add(label2);
            Controls.Add(lbl_Time);
            Controls.Add(lbl_Date);
            Controls.Add(groupBx_PelEstudiante);
            Controls.Add(btn_ScanQR);
            Controls.Add(btn_OpenCamera);
            Controls.Add(pictureBx_Camara);
            Controls.Add(label1);
            Controls.Add(comboBox_FIL);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ScanQRasistenciaForm";
            Text = "ScanQRasistenciaForm";
            FormClosing += ScanQRasistenciaForm_FormClosing;
            Load += ScanQRasistenciaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBx_Camara).EndInit();
            groupBx_PelEstudiante.ResumeLayout(false);
            groupBx_PelEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicShowPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_FIL;
        private Label label1;
        private PictureBox pictureBx_Camara;
        private Button btn_OpenCamera;
        private Button btn_ScanQR;
        private GroupBox groupBx_PelEstudiante;
        private PictureBox PicShowPhoto;
        private TextBox txt_Genero;
        private TextBox txt_Fecha;
        private TextBox txtCurso;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label lbl_Genero;
        private Label lbl_Telefono;
        private Label lbl_Curso;
        private Label lbl_Fecha;
        private Label lbl_Email;
        private Label lbl_Apellidos;
        private Label lbl_Nombre;
        private TextBox txt_ID;
        private Label lbl_ID;
        private Label lbl_Date;
        private Label lbl_Time;
        private Label label2;
        private RadioButton radioBtn_Asistencia;
        private RadioButton radioBtn_NoAsistencia;
        private Button btn_AbrirIMGQR;
        private Button btn_UpdateAsis;
    }
}