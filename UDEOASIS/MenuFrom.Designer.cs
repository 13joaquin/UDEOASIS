namespace UDEOASIS
{
    partial class MenuFrom
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
            pnlBarraTitulo = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnRestablecer = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            pnl_MenuVertical = new Panel();
            btnSalir = new PictureBox();
            panel3 = new Panel();
            btn_VerListaRegAsis = new Button();
            panel2 = new Panel();
            btn_ListaInfoEs = new Button();
            panel1 = new Panel();
            btn_ScanQR = new Button();
            panelCorto = new Panel();
            btn_RegistroEstudientes = new Button();
            btnInicio = new PictureBox();
            pnl_Contenedor = new Panel();
            pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestablecer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            pnl_MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            pnlBarraTitulo.BackColor = Color.FromArgb(162, 24, 46);
            pnlBarraTitulo.Controls.Add(pictureBox2);
            pnlBarraTitulo.Controls.Add(label1);
            pnlBarraTitulo.Controls.Add(btnRestablecer);
            pnlBarraTitulo.Controls.Add(btnMinimizar);
            pnlBarraTitulo.Controls.Add(btnMaximizar);
            pnlBarraTitulo.Controls.Add(btnCerrar);
            pnlBarraTitulo.Dock = DockStyle.Top;
            pnlBarraTitulo.Location = new Point(0, 0);
            pnlBarraTitulo.Name = "pnlBarraTitulo";
            pnlBarraTitulo.Size = new Size(1301, 35);
            pnlBarraTitulo.TabIndex = 0;
            pnlBarraTitulo.MouseDown += pnlBarraTitulo_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.Dashboard_icon;
            pictureBox2.Location = new Point(217, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(249, 4);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // btnRestablecer
            // 
            btnRestablecer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestablecer.Cursor = Cursors.Hand;
            btnRestablecer.Image = Properties.Resources.restablecer_icon;
            btnRestablecer.Location = new Point(1170, 3);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(25, 25);
            btnRestablecer.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestablecer.TabIndex = 3;
            btnRestablecer.TabStop = false;
            btnRestablecer.Visible = false;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.minimizar_icon;
            btnMinimizar.Location = new Point(1201, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = Properties.Resources.maximizar_icon;
            btnMaximizar.Location = new Point(1232, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.cerrar_icon1;
            btnCerrar.Location = new Point(1263, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnl_MenuVertical
            // 
            pnl_MenuVertical.BackColor = Color.White;
            pnl_MenuVertical.Controls.Add(btnSalir);
            pnl_MenuVertical.Controls.Add(panel3);
            pnl_MenuVertical.Controls.Add(btn_VerListaRegAsis);
            pnl_MenuVertical.Controls.Add(panel2);
            pnl_MenuVertical.Controls.Add(btn_ListaInfoEs);
            pnl_MenuVertical.Controls.Add(panel1);
            pnl_MenuVertical.Controls.Add(btn_ScanQR);
            pnl_MenuVertical.Controls.Add(panelCorto);
            pnl_MenuVertical.Controls.Add(btn_RegistroEstudientes);
            pnl_MenuVertical.Controls.Add(btnInicio);
            pnl_MenuVertical.Dock = DockStyle.Left;
            pnl_MenuVertical.Location = new Point(0, 35);
            pnl_MenuVertical.Name = "pnl_MenuVertical";
            pnl_MenuVertical.Size = new Size(242, 616);
            pnl_MenuVertical.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Image = Properties.Resources.cerrar_sesion_icon;
            btnSalir.Location = new Point(76, 552);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(54, 61);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 9;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(162, 24, 46);
            panel3.Location = new Point(5, 447);
            panel3.Name = "panel3";
            panel3.Size = new Size(8, 87);
            panel3.TabIndex = 8;
            // 
            // btn_VerListaRegAsis
            // 
            btn_VerListaRegAsis.BackColor = Color.FromArgb(162, 24, 46);
            btn_VerListaRegAsis.Cursor = Cursors.Hand;
            btn_VerListaRegAsis.FlatAppearance.BorderSize = 0;
            btn_VerListaRegAsis.FlatStyle = FlatStyle.Flat;
            btn_VerListaRegAsis.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_VerListaRegAsis.ForeColor = Color.White;
            btn_VerListaRegAsis.Location = new Point(16, 447);
            btn_VerListaRegAsis.Name = "btn_VerListaRegAsis";
            btn_VerListaRegAsis.Size = new Size(223, 87);
            btn_VerListaRegAsis.TabIndex = 7;
            btn_VerListaRegAsis.Text = "Ver Lista de Registro de Asistencia";
            btn_VerListaRegAsis.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(233, 231, 237);
            panel2.Location = new Point(3, 339);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 90);
            panel2.TabIndex = 6;
            // 
            // btn_ListaInfoEs
            // 
            btn_ListaInfoEs.BackColor = Color.FromArgb(233, 231, 237);
            btn_ListaInfoEs.Cursor = Cursors.Hand;
            btn_ListaInfoEs.FlatAppearance.BorderSize = 0;
            btn_ListaInfoEs.FlatStyle = FlatStyle.Flat;
            btn_ListaInfoEs.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ListaInfoEs.Location = new Point(16, 339);
            btn_ListaInfoEs.Name = "btn_ListaInfoEs";
            btn_ListaInfoEs.Size = new Size(220, 90);
            btn_ListaInfoEs.TabIndex = 5;
            btn_ListaInfoEs.Text = "Lista de Informacion del Estudiante";
            btn_ListaInfoEs.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 172, 25);
            panel1.Location = new Point(2, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(8, 75);
            panel1.TabIndex = 4;
            // 
            // btn_ScanQR
            // 
            btn_ScanQR.BackColor = Color.FromArgb(238, 172, 25);
            btn_ScanQR.Cursor = Cursors.Hand;
            btn_ScanQR.FlatAppearance.BorderSize = 0;
            btn_ScanQR.FlatStyle = FlatStyle.Flat;
            btn_ScanQR.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ScanQR.Location = new Point(18, 236);
            btn_ScanQR.Name = "btn_ScanQR";
            btn_ScanQR.Size = new Size(221, 75);
            btn_ScanQR.TabIndex = 3;
            btn_ScanQR.Text = "Scan QR para Asistencia";
            btn_ScanQR.UseVisualStyleBackColor = false;
            btn_ScanQR.Click += btn_ScanQR_Click;
            // 
            // panelCorto
            // 
            panelCorto.BackColor = Color.FromArgb(61, 42, 85);
            panelCorto.Location = new Point(2, 155);
            panelCorto.Name = "panelCorto";
            panelCorto.Size = new Size(8, 48);
            panelCorto.TabIndex = 2;
            // 
            // btn_RegistroEstudientes
            // 
            btn_RegistroEstudientes.AccessibleRole = AccessibleRole.None;
            btn_RegistroEstudientes.BackColor = Color.FromArgb(61, 42, 85);
            btn_RegistroEstudientes.Cursor = Cursors.Hand;
            btn_RegistroEstudientes.FlatAppearance.BorderSize = 0;
            btn_RegistroEstudientes.FlatStyle = FlatStyle.Flat;
            btn_RegistroEstudientes.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_RegistroEstudientes.ForeColor = Color.White;
            btn_RegistroEstudientes.Location = new Point(13, 155);
            btn_RegistroEstudientes.Name = "btn_RegistroEstudientes";
            btn_RegistroEstudientes.Size = new Size(223, 48);
            btn_RegistroEstudientes.TabIndex = 1;
            btn_RegistroEstudientes.Text = "Registro Estudiante";
            btn_RegistroEstudientes.UseVisualStyleBackColor = false;
            btn_RegistroEstudientes.Click += btn_RegistroEstudientes_Click;
            // 
            // btnInicio
            // 
            btnInicio.Image = Properties.Resources.Logo_Vertical;
            btnInicio.Location = new Point(3, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(211, 101);
            btnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnl_Contenedor
            // 
            pnl_Contenedor.BackColor = Color.FromArgb(239, 239, 239);
            pnl_Contenedor.Dock = DockStyle.Fill;
            pnl_Contenedor.Location = new Point(242, 35);
            pnl_Contenedor.Name = "pnl_Contenedor";
            pnl_Contenedor.Size = new Size(1059, 616);
            pnl_Contenedor.TabIndex = 2;
            // 
            // MenuFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 651);
            Controls.Add(pnl_Contenedor);
            Controls.Add(pnl_MenuVertical);
            Controls.Add(pnlBarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuFrom";
            Text = "MenuFrom";
            Load += MenuFrom_Load;
            pnlBarraTitulo.ResumeLayout(false);
            pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestablecer).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            pnl_MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBarraTitulo;
        private Panel pnl_MenuVertical;
        private Panel pnl_Contenedor;
        private PictureBox btnCerrar;
        private PictureBox btnRestablecer;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnInicio;
        private Button btn_RegistroEstudientes;
        private Panel panelCorto;
        private Panel panel3;
        private Button btn_VerListaRegAsis;
        private Panel panel2;
        private Button btn_ListaInfoEs;
        private Panel panel1;
        private Button btn_ScanQR;
        private PictureBox btnSalir;
        private Label label1;
        private PictureBox pictureBox2;
    }
}