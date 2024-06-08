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
            components = new System.ComponentModel.Container();
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
            pictureBox1 = new PictureBox();
            lbl_Date = new Label();
            lbl_Time = new Label();
            timerFrom = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBx_Camara).BeginInit();
            groupBx_PelEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox_FIL
            // 
            comboBox_FIL.FormattingEnabled = true;
            comboBox_FIL.Location = new Point(49, 117);
            comboBox_FIL.Name = "comboBox_FIL";
            comboBox_FIL.Size = new Size(151, 28);
            comboBox_FIL.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(61, 42, 85);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(344, 22);
            label1.Name = "label1";
            label1.Size = new Size(334, 41);
            label1.TabIndex = 1;
            label1.Text = "Scan QR para Asistencia";
            // 
            // pictureBx_Camara
            // 
            pictureBx_Camara.BorderStyle = BorderStyle.FixedSingle;
            pictureBx_Camara.Location = new Point(49, 186);
            pictureBx_Camara.Name = "pictureBx_Camara";
            pictureBx_Camara.Size = new Size(151, 188);
            pictureBx_Camara.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBx_Camara.TabIndex = 2;
            pictureBx_Camara.TabStop = false;
            // 
            // btn_OpenCamera
            // 
            btn_OpenCamera.Location = new Point(49, 411);
            btn_OpenCamera.Name = "btn_OpenCamera";
            btn_OpenCamera.Size = new Size(151, 40);
            btn_OpenCamera.TabIndex = 3;
            btn_OpenCamera.Text = "OpenCamera";
            btn_OpenCamera.UseVisualStyleBackColor = true;
            btn_OpenCamera.Click += btn_OpenCamera_Click;
            // 
            // btn_ScanQR
            // 
            btn_ScanQR.Location = new Point(49, 504);
            btn_ScanQR.Name = "btn_ScanQR";
            btn_ScanQR.Size = new Size(151, 40);
            btn_ScanQR.TabIndex = 4;
            btn_ScanQR.Text = "ScanQR";
            btn_ScanQR.UseVisualStyleBackColor = true;
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
            groupBx_PelEstudiante.Controls.Add(pictureBox1);
            groupBx_PelEstudiante.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBx_PelEstudiante.Location = new Point(226, 117);
            groupBx_PelEstudiante.Name = "groupBx_PelEstudiante";
            groupBx_PelEstudiante.Size = new Size(821, 453);
            groupBx_PelEstudiante.TabIndex = 5;
            groupBx_PelEstudiante.TabStop = false;
            groupBx_PelEstudiante.Text = "Perfil de Estudiantes";
            // 
            // txt_Genero
            // 
            txt_Genero.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Genero.Location = new Point(424, 389);
            txt_Genero.Name = "txt_Genero";
            txt_Genero.Size = new Size(162, 39);
            txt_Genero.TabIndex = 45;
            // 
            // txt_Fecha
            // 
            txt_Fecha.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Fecha.Location = new Point(424, 225);
            txt_Fecha.Name = "txt_Fecha";
            txt_Fecha.Size = new Size(162, 39);
            txt_Fecha.TabIndex = 44;
            // 
            // txtCurso
            // 
            txtCurso.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurso.Location = new Point(424, 278);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(162, 39);
            txtCurso.TabIndex = 43;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(424, 124);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(162, 39);
            txtApellido.TabIndex = 42;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(424, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 39);
            txtEmail.TabIndex = 41;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(424, 332);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(162, 39);
            txtTelefono.TabIndex = 40;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(424, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 39);
            txtNombre.TabIndex = 39;
            // 
            // lbl_Genero
            // 
            lbl_Genero.AutoSize = true;
            lbl_Genero.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Genero.Location = new Point(260, 396);
            lbl_Genero.Name = "lbl_Genero";
            lbl_Genero.Size = new Size(82, 32);
            lbl_Genero.TabIndex = 36;
            lbl_Genero.Text = "Genero:";
            lbl_Genero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Telefono.Location = new Point(260, 332);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(97, 32);
            lbl_Telefono.TabIndex = 35;
            lbl_Telefono.Text = "Telefono:";
            lbl_Telefono.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Curso
            // 
            lbl_Curso.AutoSize = true;
            lbl_Curso.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Curso.Location = new Point(260, 281);
            lbl_Curso.Name = "lbl_Curso";
            lbl_Curso.Size = new Size(70, 32);
            lbl_Curso.TabIndex = 34;
            lbl_Curso.Text = "Curso:";
            lbl_Curso.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Fecha.Location = new Point(196, 228);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(208, 32);
            lbl_Fecha.TabIndex = 33;
            lbl_Fecha.Text = "Fecha de Cumpleaños:";
            lbl_Fecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Email.Location = new Point(213, 176);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(144, 32);
            lbl_Email.TabIndex = 32;
            lbl_Email.Text = "Email Address:";
            lbl_Email.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Apellidos
            // 
            lbl_Apellidos.AutoSize = true;
            lbl_Apellidos.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Apellidos.Location = new Point(228, 127);
            lbl_Apellidos.Name = "lbl_Apellidos";
            lbl_Apellidos.Size = new Size(102, 32);
            lbl_Apellidos.TabIndex = 31;
            lbl_Apellidos.Text = "Apellidos:";
            lbl_Apellidos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.Location = new Point(228, 69);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(89, 32);
            lbl_Nombre.TabIndex = 29;
            lbl_Nombre.Text = "Nombre:";
            lbl_Nombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_ID
            // 
            txt_ID.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ID.Location = new Point(424, 23);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(162, 39);
            txt_ID.TabIndex = 28;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ID.Location = new Point(228, 26);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(39, 32);
            lbl_ID.TabIndex = 27;
            lbl_ID.Text = "ID:";
            lbl_ID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(31, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Date.Location = new Point(321, 74);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(49, 25);
            lbl_Date.TabIndex = 6;
            lbl_Date.Text = "Date";
            // 
            // lbl_Time
            // 
            lbl_Time.AutoSize = true;
            lbl_Time.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Time.Location = new Point(401, 89);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(50, 25);
            lbl_Time.TabIndex = 7;
            lbl_Time.Text = "Time";
            // 
            // timerFrom
            // 
            timerFrom.Tick += timerFrom_Tick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ScanQRasistenciaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 616);
            Controls.Add(lbl_Time);
            Controls.Add(lbl_Date);
            Controls.Add(groupBx_PelEstudiante);
            Controls.Add(btn_ScanQR);
            Controls.Add(btn_OpenCamera);
            Controls.Add(pictureBx_Camara);
            Controls.Add(label1);
            Controls.Add(comboBox_FIL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScanQRasistenciaForm";
            Text = "ScanQRasistenciaForm";
            FormClosing += ScanQRasistenciaForm_FormClosing;
            Load += ScanQRasistenciaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBx_Camara).EndInit();
            groupBx_PelEstudiante.ResumeLayout(false);
            groupBx_PelEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
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
        private System.Windows.Forms.Timer timerFrom;
        private System.Windows.Forms.Timer timer1;
    }
}