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
            comboBox1 = new ComboBox();
            label1 = new Label();
            pictureBx_Camara = new PictureBox();
            btn_OpenCamera = new Button();
            btn_ScanQR = new Button();
            groupBx_PelEstudiante = new GroupBox();
            pictureBox1 = new PictureBox();
            txtCurso = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txt_ID = new TextBox();
            lbl_ID = new Label();
            txt_Fecha = new TextBox();
            txt_Genero = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBx_Camara).BeginInit();
            groupBx_PelEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(49, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
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
            groupBx_PelEstudiante.Controls.Add(label9);
            groupBx_PelEstudiante.Controls.Add(label8);
            groupBx_PelEstudiante.Controls.Add(label7);
            groupBx_PelEstudiante.Controls.Add(label6);
            groupBx_PelEstudiante.Controls.Add(label5);
            groupBx_PelEstudiante.Controls.Add(label4);
            groupBx_PelEstudiante.Controls.Add(label3);
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
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(26, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(260, 396);
            label9.Name = "label9";
            label9.Size = new Size(82, 32);
            label9.TabIndex = 36;
            label9.Text = "Genero:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(260, 332);
            label8.Name = "label8";
            label8.Size = new Size(97, 32);
            label8.TabIndex = 35;
            label8.Text = "Telefono:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(260, 281);
            label7.Name = "label7";
            label7.Size = new Size(70, 32);
            label7.TabIndex = 34;
            label7.Text = "Curso:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(193, 225);
            label6.Name = "label6";
            label6.Size = new Size(208, 32);
            label6.TabIndex = 33;
            label6.Text = "Fecha de Cumpleaños:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(228, 180);
            label5.Name = "label5";
            label5.Size = new Size(144, 32);
            label5.TabIndex = 32;
            label5.Text = "Email Address:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(228, 127);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 31;
            label4.Text = "Apellidos:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(228, 69);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 29;
            label3.Text = "Nombre:";
            label3.TextAlign = ContentAlignment.MiddleRight;
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
            // txt_Fecha
            // 
            txt_Fecha.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Fecha.Location = new Point(424, 225);
            txt_Fecha.Name = "txt_Fecha";
            txt_Fecha.Size = new Size(162, 39);
            txt_Fecha.TabIndex = 44;
            // 
            // txt_Genero
            // 
            txt_Genero.Font = new Font("Dubai", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Genero.Location = new Point(424, 389);
            txt_Genero.Name = "txt_Genero";
            txt_Genero.Size = new Size(162, 39);
            txt_Genero.TabIndex = 45;
            // 
            // ScanQRasistenciaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 616);
            Controls.Add(groupBx_PelEstudiante);
            Controls.Add(btn_ScanQR);
            Controls.Add(btn_OpenCamera);
            Controls.Add(pictureBx_Camara);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScanQRasistenciaForm";
            Text = "ScanQRasistenciaForm";
            ((System.ComponentModel.ISupportInitialize)pictureBx_Camara).EndInit();
            groupBx_PelEstudiante.ResumeLayout(false);
            groupBx_PelEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
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
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txt_ID;
        private Label lbl_ID;
    }
}