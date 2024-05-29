namespace UDEOASIS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel_BarraTitulo = new Panel();
            pbtnRestaurar = new PictureBox();
            pbtnMinimizar = new PictureBox();
            pbtnMaximizar = new PictureBox();
            pbtnCerrar = new PictureBox();
            panel_MenuVertical = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            pictureBox4 = new PictureBox();
            panel11 = new Panel();
            btnVistaRecor = new Button();
            panel9 = new Panel();
            panel10 = new Panel();
            button6 = new Button();
            btnQR = new Button();
            panel6 = new Panel();
            btnListaEstudientes = new Button();
            panel8 = new Panel();
            btnRegitstro = new Button();
            pictureInicio = new PictureBox();
            panel3 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            btnListStudent = new Button();
            pbtnCerrarSesion = new PictureBox();
            panel1 = new Panel();
            btnStudentReg = new Button();
            pictureBox1 = new PictureBox();
            panel_Contenedor = new Panel();
            panel_BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbtnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbtnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbtnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbtnCerrar).BeginInit();
            panel_MenuVertical.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbtnCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_BarraTitulo
            // 
            panel_BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            panel_BarraTitulo.Controls.Add(pbtnRestaurar);
            panel_BarraTitulo.Controls.Add(pbtnMinimizar);
            panel_BarraTitulo.Controls.Add(pbtnMaximizar);
            panel_BarraTitulo.Controls.Add(pbtnCerrar);
            panel_BarraTitulo.Dock = DockStyle.Top;
            panel_BarraTitulo.Location = new Point(0, 0);
            panel_BarraTitulo.Name = "panel_BarraTitulo";
            panel_BarraTitulo.Size = new Size(1300, 40);
            panel_BarraTitulo.TabIndex = 0;
            panel_BarraTitulo.MouseDown += panel_BarraTitulo_MouseDown;
            // 
            // pbtnRestaurar
            // 
            pbtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbtnRestaurar.Cursor = Cursors.Hand;
            pbtnRestaurar.Image = (Image)resources.GetObject("pbtnRestaurar.Image");
            pbtnRestaurar.Location = new Point(1159, 4);
            pbtnRestaurar.Name = "pbtnRestaurar";
            pbtnRestaurar.Size = new Size(30, 30);
            pbtnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            pbtnRestaurar.TabIndex = 3;
            pbtnRestaurar.TabStop = false;
            pbtnRestaurar.Visible = false;
            pbtnRestaurar.Click += pbtnRestaurar_Click;
            // 
            // pbtnMinimizar
            // 
            pbtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbtnMinimizar.Cursor = Cursors.Hand;
            pbtnMinimizar.Image = Properties.Resources.minimizar_icon;
            pbtnMinimizar.Location = new Point(1195, 3);
            pbtnMinimizar.Name = "pbtnMinimizar";
            pbtnMinimizar.Size = new Size(30, 30);
            pbtnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pbtnMinimizar.TabIndex = 2;
            pbtnMinimizar.TabStop = false;
            pbtnMinimizar.Click += pbtnMinimizar_Click;
            // 
            // pbtnMaximizar
            // 
            pbtnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbtnMaximizar.Cursor = Cursors.Hand;
            pbtnMaximizar.Image = (Image)resources.GetObject("pbtnMaximizar.Image");
            pbtnMaximizar.Location = new Point(1231, 4);
            pbtnMaximizar.Name = "pbtnMaximizar";
            pbtnMaximizar.Size = new Size(30, 30);
            pbtnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            pbtnMaximizar.TabIndex = 1;
            pbtnMaximizar.TabStop = false;
            pbtnMaximizar.Click += pbtnMaximizar_Click;
            // 
            // pbtnCerrar
            // 
            pbtnCerrar.Cursor = Cursors.Hand;
            pbtnCerrar.Image = Properties.Resources.cerrar_icon1;
            pbtnCerrar.Location = new Point(1267, 4);
            pbtnCerrar.Name = "pbtnCerrar";
            pbtnCerrar.Size = new Size(30, 30);
            pbtnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            pbtnCerrar.TabIndex = 0;
            pbtnCerrar.TabStop = false;
            pbtnCerrar.Click += pbtnCerrar_Click;
            // 
            // panel_MenuVertical
            // 
            panel_MenuVertical.BackColor = Color.White;
            panel_MenuVertical.Controls.Add(panel4);
            panel_MenuVertical.Controls.Add(panel2);
            panel_MenuVertical.Controls.Add(btnListStudent);
            panel_MenuVertical.Controls.Add(pbtnCerrarSesion);
            panel_MenuVertical.Controls.Add(panel1);
            panel_MenuVertical.Controls.Add(btnStudentReg);
            panel_MenuVertical.Controls.Add(pictureBox1);
            panel_MenuVertical.Dock = DockStyle.Left;
            panel_MenuVertical.Location = new Point(0, 40);
            panel_MenuVertical.Name = "panel_MenuVertical";
            panel_MenuVertical.Size = new Size(220, 610);
            panel_MenuVertical.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 610);
            panel4.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(panel11);
            panel7.Controls.Add(btnVistaRecor);
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(btnQR);
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(btnListaEstudientes);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(btnRegitstro);
            panel7.Controls.Add(pictureInicio);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(220, 610);
            panel7.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 533);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(0, 80, 200);
            panel11.Location = new Point(5, 357);
            panel11.Name = "panel11";
            panel11.Size = new Size(5, 35);
            panel11.TabIndex = 9;
            // 
            // btnVistaRecor
            // 
            btnVistaRecor.FlatAppearance.BorderSize = 0;
            btnVistaRecor.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnVistaRecor.FlatStyle = FlatStyle.Flat;
            btnVistaRecor.ForeColor = Color.Black;
            btnVistaRecor.Location = new Point(16, 357);
            btnVistaRecor.Name = "btnVistaRecor";
            btnVistaRecor.Size = new Size(202, 35);
            btnVistaRecor.TabIndex = 8;
            btnVistaRecor.Text = "Lista de atenccion";
            btnVistaRecor.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(0, 80, 200);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(button6);
            panel9.Location = new Point(5, 289);
            panel9.Name = "panel9";
            panel9.Size = new Size(5, 35);
            panel9.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 80, 200);
            panel10.Location = new Point(-104, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(5, 35);
            panel10.TabIndex = 7;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(-93, 0);
            button6.Name = "button6";
            button6.Size = new Size(202, 35);
            button6.TabIndex = 6;
            button6.Text = "List Estudientes Informacion";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnQR
            // 
            btnQR.FlatAppearance.BorderSize = 0;
            btnQR.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnQR.FlatStyle = FlatStyle.Flat;
            btnQR.ForeColor = Color.Black;
            btnQR.Location = new Point(16, 289);
            btnQR.Name = "btnQR";
            btnQR.Size = new Size(202, 35);
            btnQR.TabIndex = 6;
            btnQR.Text = "QR de Attencion";
            btnQR.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(3, 232);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 35);
            panel6.TabIndex = 5;
            // 
            // btnListaEstudientes
            // 
            btnListaEstudientes.FlatAppearance.BorderSize = 0;
            btnListaEstudientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnListaEstudientes.FlatStyle = FlatStyle.Flat;
            btnListaEstudientes.ForeColor = Color.Black;
            btnListaEstudientes.Location = new Point(14, 232);
            btnListaEstudientes.Name = "btnListaEstudientes";
            btnListaEstudientes.Size = new Size(202, 35);
            btnListaEstudientes.TabIndex = 4;
            btnListaEstudientes.Text = "List Estudientes Informacion";
            btnListaEstudientes.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 80, 200);
            panel8.Location = new Point(1, 156);
            panel8.Name = "panel8";
            panel8.Size = new Size(5, 35);
            panel8.TabIndex = 2;
            // 
            // btnRegitstro
            // 
            btnRegitstro.FlatAppearance.BorderSize = 0;
            btnRegitstro.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnRegitstro.FlatStyle = FlatStyle.Flat;
            btnRegitstro.ForeColor = Color.Black;
            btnRegitstro.Location = new Point(12, 156);
            btnRegitstro.Name = "btnRegitstro";
            btnRegitstro.Size = new Size(202, 35);
            btnRegitstro.TabIndex = 1;
            btnRegitstro.Text = "Registro Studiantes";
            btnRegitstro.UseVisualStyleBackColor = true;
            // 
            // pictureInicio
            // 
            pictureInicio.Image = Properties.Resources.Logo_Horizontal;
            pictureInicio.Location = new Point(3, 0);
            pictureInicio.Name = "pictureInicio";
            pictureInicio.Size = new Size(217, 97);
            pictureInicio.SizeMode = PictureBoxSizeMode.Zoom;
            pictureInicio.TabIndex = 0;
            pictureInicio.TabStop = false;
            pictureInicio.Click += pictureInicio_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(3, 232);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 35);
            panel3.TabIndex = 5;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(14, 232);
            button1.Name = "button1";
            button1.Size = new Size(202, 35);
            button1.TabIndex = 4;
            button1.Text = "List Estudientes Informacion";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 533);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(1, 156);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 35);
            panel5.TabIndex = 2;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(12, 156);
            button2.Name = "button2";
            button2.Size = new Size(202, 35);
            button2.TabIndex = 1;
            button2.Text = "Registro Studiantes";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo_Horizontal;
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(217, 97);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(3, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 35);
            panel2.TabIndex = 5;
            // 
            // btnListStudent
            // 
            btnListStudent.FlatAppearance.BorderSize = 0;
            btnListStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnListStudent.FlatStyle = FlatStyle.Flat;
            btnListStudent.ForeColor = Color.Black;
            btnListStudent.Location = new Point(14, 232);
            btnListStudent.Name = "btnListStudent";
            btnListStudent.Size = new Size(202, 35);
            btnListStudent.TabIndex = 4;
            btnListStudent.Text = "List Estudientes Informacion";
            btnListStudent.UseVisualStyleBackColor = true;
            // 
            // pbtnCerrarSesion
            // 
            pbtnCerrarSesion.Image = (Image)resources.GetObject("pbtnCerrarSesion.Image");
            pbtnCerrarSesion.Location = new Point(12, 533);
            pbtnCerrarSesion.Name = "pbtnCerrarSesion";
            pbtnCerrarSesion.Size = new Size(78, 65);
            pbtnCerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            pbtnCerrarSesion.TabIndex = 3;
            pbtnCerrarSesion.TabStop = false;
            pbtnCerrarSesion.Click += pbtnCerrarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(1, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 35);
            panel1.TabIndex = 2;
            // 
            // btnStudentReg
            // 
            btnStudentReg.FlatAppearance.BorderSize = 0;
            btnStudentReg.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnStudentReg.FlatStyle = FlatStyle.Flat;
            btnStudentReg.ForeColor = Color.Black;
            btnStudentReg.Location = new Point(12, 156);
            btnStudentReg.Name = "btnStudentReg";
            btnStudentReg.Size = new Size(202, 35);
            btnStudentReg.TabIndex = 1;
            btnStudentReg.Text = "Registro Studiantes";
            btnStudentReg.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Horizontal;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_Contenedor
            // 
            panel_Contenedor.BackColor = Color.FromArgb(49, 66, 82);
            panel_Contenedor.Dock = DockStyle.Fill;
            panel_Contenedor.Location = new Point(220, 40);
            panel_Contenedor.Name = "panel_Contenedor";
            panel_Contenedor.Size = new Size(1080, 610);
            panel_Contenedor.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(panel_Contenedor);
            Controls.Add(panel_MenuVertical);
            Controls.Add(panel_BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel_BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbtnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbtnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbtnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbtnCerrar).EndInit();
            panel_MenuVertical.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbtnCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_BarraTitulo;
        private Panel panel_MenuVertical;
        private Panel panel_Contenedor;
        private PictureBox pbtnCerrar;
        private PictureBox pbtnMaximizar;
        private PictureBox pbtnRestaurar;
        private PictureBox pbtnMinimizar;
        private Button btnStudentReg;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pbtnCerrarSesion;
        private Panel panel2;
        private Button btnListStudent;
        private Panel panel4;
        private Panel panel7;
        private Panel panel11;
        private Button btnVistaRecor;
        private Panel panel9;
        private Panel panel10;
        private Button button6;
        private Button btnQR;
        private Panel panel6;
        private Button btnListaEstudientes;
        private PictureBox pictureBox4;
        private Panel panel8;
        private Button btnRegitstro;
        private PictureBox pictureInicio;
        private Panel panel3;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Button button2;
        private PictureBox pictureBox3;
    }
}