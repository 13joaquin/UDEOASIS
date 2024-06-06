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
            pnlBarraTitulo.Margin = new Padding(3, 2, 3, 2);
            pnlBarraTitulo.Name = "pnlBarraTitulo";
            pnlBarraTitulo.Size = new Size(1138, 26);
            pnlBarraTitulo.TabIndex = 0;
            pnlBarraTitulo.MouseDown += pnlBarraTitulo_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.Dashboard_icon;
            pictureBox2.Location = new Point(190, 3);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(218, 3);
            label1.Name = "label1";
            label1.Size = new Size(89, 18);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // btnRestablecer
            // 
            btnRestablecer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestablecer.Cursor = Cursors.Hand;
            btnRestablecer.Image = Properties.Resources.restablecer_icon;
            btnRestablecer.Location = new Point(1024, 2);
            btnRestablecer.Margin = new Padding(3, 2, 3, 2);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(22, 19);
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
            btnMinimizar.Location = new Point(1051, 2);
            btnMinimizar.Margin = new Padding(3, 2, 3, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(22, 19);
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
            btnMaximizar.Location = new Point(1078, 2);
            btnMaximizar.Margin = new Padding(3, 2, 3, 2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(22, 19);
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
            btnCerrar.Location = new Point(1105, 3);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(22, 19);
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
            pnl_MenuVertical.Controls.Add(btn_ListaEstudientesInfo);
            pnl_MenuVertical.Controls.Add(panel2);
            pnl_MenuVertical.Controls.Add(btn_ListaRecord);
            pnl_MenuVertical.Controls.Add(panel1);
            pnl_MenuVertical.Controls.Add(btn_QRAtencion);
            pnl_MenuVertical.Controls.Add(panelCorto);
            pnl_MenuVertical.Controls.Add(btn_RegistroEstudientes);
            pnl_MenuVertical.Controls.Add(btnInicio);
            pnl_MenuVertical.Dock = DockStyle.Left;
            pnl_MenuVertical.Location = new Point(0, 26);
            pnl_MenuVertical.Margin = new Padding(3, 2, 3, 2);
            pnl_MenuVertical.Name = "pnl_MenuVertical";
            pnl_MenuVertical.Size = new Size(192, 462);
            pnl_MenuVertical.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Image = Properties.Resources.cerrar_sesion_icon;
            btnSalir.Location = new Point(64, 376);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(47, 46);
            btnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnSalir.TabIndex = 9;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(162, 24, 46);
            panel3.Location = new Point(2, 303);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(7, 36);
            panel3.TabIndex = 8;
            // 
            // btn_ListaEstudientesInfo
            // 
            btn_ListaEstudientesInfo.BackColor = Color.FromArgb(162, 24, 46);
            btn_ListaEstudientesInfo.Cursor = Cursors.Hand;
            btn_ListaEstudientesInfo.FlatAppearance.BorderSize = 0;
            btn_ListaEstudientesInfo.FlatStyle = FlatStyle.Flat;
            btn_ListaEstudientesInfo.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ListaEstudientesInfo.ForeColor = Color.White;
            btn_ListaEstudientesInfo.Location = new Point(11, 303);
            btn_ListaEstudientesInfo.Margin = new Padding(3, 2, 3, 2);
            btn_ListaEstudientesInfo.Name = "btn_ListaEstudientesInfo";
            btn_ListaEstudientesInfo.Size = new Size(179, 36);
            btn_ListaEstudientesInfo.TabIndex = 7;
            btn_ListaEstudientesInfo.Text = "Lista de Información";
            btn_ListaEstudientesInfo.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(233, 231, 237);
            panel2.Location = new Point(2, 240);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(7, 36);
            panel2.TabIndex = 6;
            // 
            // btn_ListaRecord
            // 
            btn_ListaRecord.BackColor = Color.FromArgb(233, 231, 237);
            btn_ListaRecord.Cursor = Cursors.Hand;
            btn_ListaRecord.FlatAppearance.BorderSize = 0;
            btn_ListaRecord.FlatStyle = FlatStyle.Flat;
            btn_ListaRecord.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ListaRecord.Location = new Point(11, 240);
            btn_ListaRecord.Margin = new Padding(3, 2, 3, 2);
            btn_ListaRecord.Name = "btn_ListaRecord";
            btn_ListaRecord.Size = new Size(178, 36);
            btn_ListaRecord.TabIndex = 5;
            btn_ListaRecord.Text = "Lista de Record";
            btn_ListaRecord.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 172, 25);
            panel1.Location = new Point(2, 177);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 36);
            panel1.TabIndex = 4;
            // 
            // btn_QRAtencion
            // 
            btn_QRAtencion.BackColor = Color.FromArgb(238, 172, 25);
            btn_QRAtencion.Cursor = Cursors.Hand;
            btn_QRAtencion.FlatAppearance.BorderSize = 0;
            btn_QRAtencion.FlatStyle = FlatStyle.Flat;
            btn_QRAtencion.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_QRAtencion.Location = new Point(11, 177);
            btn_QRAtencion.Margin = new Padding(3, 2, 3, 2);
            btn_QRAtencion.Name = "btn_QRAtencion";
            btn_QRAtencion.Size = new Size(178, 36);
            btn_QRAtencion.TabIndex = 3;
            btn_QRAtencion.Text = "QR";
            btn_QRAtencion.UseVisualStyleBackColor = false;
            // 
            // panelCorto
            // 
            panelCorto.BackColor = Color.FromArgb(61, 42, 85);
            panelCorto.Location = new Point(2, 116);
            panelCorto.Margin = new Padding(3, 2, 3, 2);
            panelCorto.Name = "panelCorto";
            panelCorto.Size = new Size(7, 36);
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
            btn_RegistroEstudientes.Location = new Point(11, 116);
            btn_RegistroEstudientes.Margin = new Padding(3, 2, 3, 2);
            btn_RegistroEstudientes.Name = "btn_RegistroEstudientes";
            btn_RegistroEstudientes.Size = new Size(178, 36);
            btn_RegistroEstudientes.TabIndex = 1;
            btn_RegistroEstudientes.Text = "Registro Estudiante";
            btn_RegistroEstudientes.UseVisualStyleBackColor = false;
            btn_RegistroEstudientes.Click += btn_RegistroEstudientes_Click;
            // 
            // btnInicio
            // 
            btnInicio.Image = Properties.Resources.Logo_Vertical;
            btnInicio.Location = new Point(3, 2);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(185, 76);
            btnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnl_Contenedor
            // 
            pnl_Contenedor.BackColor = Color.FromArgb(239, 239, 239);
            pnl_Contenedor.Dock = DockStyle.Fill;
            pnl_Contenedor.Location = new Point(192, 26);
            pnl_Contenedor.Margin = new Padding(3, 2, 3, 2);
            pnl_Contenedor.Name = "pnl_Contenedor";
            pnl_Contenedor.Size = new Size(946, 462);
            pnl_Contenedor.TabIndex = 2;
            // 
            // MenuFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 488);
            Controls.Add(pnl_Contenedor);
            Controls.Add(pnl_MenuVertical);
            Controls.Add(pnlBarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btn_ListaEstudientesInfo;
        private Panel panel2;
        private Button btn_ListaRecord;
        private Panel panel1;
        private Button btn_QRAtencion;
        private PictureBox btnSalir;
        private Label label1;
        private PictureBox pictureBox2;
    }
}