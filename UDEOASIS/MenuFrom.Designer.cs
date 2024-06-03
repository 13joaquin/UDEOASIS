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
            btnRestablecer = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            pnl_MenuVertical = new Panel();
            btnSalir = new PictureBox();
            panel3 = new Panel();
            btn_ListaEstudientesInfo = new Button();
            panel2 = new Panel();
            btn_ListaRecord = new Button();
            panel1 = new Panel();
            btn_QRAtencion = new Button();
            panelCorto = new Panel();
            btn_RegistroEstudientes = new Button();
            btnInicio = new PictureBox();
            pnl_Contenedor = new Panel();
            pnlBarraTitulo.SuspendLayout();
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
            pnlBarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            pnlBarraTitulo.Controls.Add(btnRestablecer);
            pnlBarraTitulo.Controls.Add(btnMinimizar);
            pnlBarraTitulo.Controls.Add(btnMaximizar);
            pnlBarraTitulo.Controls.Add(btnCerrar);
            pnlBarraTitulo.Dock = DockStyle.Top;
            pnlBarraTitulo.Location = new Point(0, 0);
            pnlBarraTitulo.Name = "pnlBarraTitulo";
            pnlBarraTitulo.Size = new Size(1300, 35);
            pnlBarraTitulo.TabIndex = 0;
            pnlBarraTitulo.MouseDown += pnlBarraTitulo_MouseDown;
            // 
            // btnRestablecer
            // 
            btnRestablecer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestablecer.Cursor = Cursors.Hand;
            btnRestablecer.Image = Properties.Resources.circulo_negro;
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
            btnMaximizar.Image = Properties.Resources.Comment_desva;
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
            pnl_MenuVertical.BackColor = SystemColors.ControlLight;
            pnl_MenuVertical.Controls.Add(btnSalir);
            pnl_MenuVertical.Controls.Add(panel3);
            pnl_MenuVertical.Controls.Add(btn_ListaEstudientesInfo);
            pnl_MenuVertical.Controls.Add(panel2);
            pnl_MenuVertical.Controls.Add(btn_ListaRecord);
            pnl_MenuVertical.Controls.Add(panel1);
            pnl_MenuVertical.Controls.Add(btn_QRAtencion);
            pnl_MenuVertical.Controls.Add(panelCorto);
            pnl_MenuVertical.Controls.Add(btn_RegistroEstudientes);
            pnl_MenuVertical.Controls.Add(btnInicio);
            pnl_MenuVertical.Dock = DockStyle.Left;
            pnl_MenuVertical.Location = new Point(0, 35);
            pnl_MenuVertical.Name = "pnl_MenuVertical";
            pnl_MenuVertical.Size = new Size(220, 615);
            pnl_MenuVertical.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Image = Properties.Resources.cerrar_icon1;
            btnSalir.Location = new Point(21, 517);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(71, 72);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 9;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(3, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 35);
            panel3.TabIndex = 8;
            // 
            // btn_ListaEstudientesInfo
            // 
            btn_ListaEstudientesInfo.FlatAppearance.BorderSize = 0;
            btn_ListaEstudientesInfo.FlatStyle = FlatStyle.Flat;
            btn_ListaEstudientesInfo.Location = new Point(12, 277);
            btn_ListaEstudientesInfo.Name = "btn_ListaEstudientesInfo";
            btn_ListaEstudientesInfo.Size = new Size(202, 48);
            btn_ListaEstudientesInfo.TabIndex = 7;
            btn_ListaEstudientesInfo.Text = "Lista de Informacion Estudiantes";
            btn_ListaEstudientesInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(3, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 32);
            panel2.TabIndex = 6;
            // 
            // btn_ListaRecord
            // 
            btn_ListaRecord.FlatAppearance.BorderSize = 0;
            btn_ListaRecord.FlatStyle = FlatStyle.Flat;
            btn_ListaRecord.Location = new Point(12, 239);
            btn_ListaRecord.Name = "btn_ListaRecord";
            btn_ListaRecord.Size = new Size(202, 32);
            btn_ListaRecord.TabIndex = 5;
            btn_ListaRecord.Text = "Lista de Record";
            btn_ListaRecord.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(3, 201);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 32);
            panel1.TabIndex = 4;
            // 
            // btn_QRAtencion
            // 
            btn_QRAtencion.FlatAppearance.BorderSize = 0;
            btn_QRAtencion.FlatStyle = FlatStyle.Flat;
            btn_QRAtencion.Location = new Point(12, 201);
            btn_QRAtencion.Name = "btn_QRAtencion";
            btn_QRAtencion.Size = new Size(202, 32);
            btn_QRAtencion.TabIndex = 3;
            btn_QRAtencion.Text = "QR";
            btn_QRAtencion.UseVisualStyleBackColor = true;
            // 
            // panelCorto
            // 
            panelCorto.BackColor = Color.FromArgb(0, 80, 200);
            panelCorto.Location = new Point(3, 151);
            panelCorto.Name = "panelCorto";
            panelCorto.Size = new Size(5, 32);
            panelCorto.TabIndex = 2;
            // 
            // btn_RegistroEstudientes
            // 
            btn_RegistroEstudientes.AccessibleRole = AccessibleRole.None;
            btn_RegistroEstudientes.Cursor = Cursors.Hand;
            btn_RegistroEstudientes.FlatAppearance.BorderSize = 0;
            btn_RegistroEstudientes.FlatStyle = FlatStyle.Flat;
            btn_RegistroEstudientes.Location = new Point(12, 151);
            btn_RegistroEstudientes.Name = "btn_RegistroEstudientes";
            btn_RegistroEstudientes.Size = new Size(202, 32);
            btn_RegistroEstudientes.TabIndex = 1;
            btn_RegistroEstudientes.Text = "Registro Estudiante";
            btn_RegistroEstudientes.UseVisualStyleBackColor = true;
            btn_RegistroEstudientes.Click += btn_RegistroEstudientes_Click;
            // 
            // btnInicio
            // 
            btnInicio.Image = Properties.Resources.Logo_Horizontal;
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
            pnl_Contenedor.BackColor = Color.FromArgb(49, 66, 82);
            pnl_Contenedor.Dock = DockStyle.Fill;
            pnl_Contenedor.Location = new Point(220, 35);
            pnl_Contenedor.Name = "pnl_Contenedor";
            pnl_Contenedor.Size = new Size(1080, 615);
            pnl_Contenedor.TabIndex = 2;
            // 
            // MenuFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(pnl_Contenedor);
            Controls.Add(pnl_MenuVertical);
            Controls.Add(pnlBarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuFrom";
            Text = "MenuFrom";
            Load += MenuFrom_Load;
            pnlBarraTitulo.ResumeLayout(false);
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
        private Button btn_ListaEstudientesInfo;
        private Panel panel2;
        private Button btn_ListaRecord;
        private Panel panel1;
        private Button btn_QRAtencion;
        private PictureBox btnSalir;
    }
}