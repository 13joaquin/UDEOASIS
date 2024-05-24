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
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel_Contenedor = new Panel();
            pbtnCerrarSesion = new PictureBox();
            panel_BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbtnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbtnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbtnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbtnCerrar).BeginInit();
            panel_MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbtnCerrarSesion).BeginInit();
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
            pbtnMinimizar.Image = (Image)resources.GetObject("pbtnMinimizar.Image");
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
            pbtnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbtnCerrar.Cursor = Cursors.Hand;
            pbtnCerrar.Image = (Image)resources.GetObject("pbtnCerrar.Image");
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
            panel_MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            panel_MenuVertical.Controls.Add(pbtnCerrarSesion);
            panel_MenuVertical.Controls.Add(panel1);
            panel_MenuVertical.Controls.Add(button1);
            panel_MenuVertical.Controls.Add(pictureBox1);
            panel_MenuVertical.Dock = DockStyle.Left;
            panel_MenuVertical.Location = new Point(0, 40);
            panel_MenuVertical.Name = "panel_MenuVertical";
            panel_MenuVertical.Size = new Size(220, 610);
            panel_MenuVertical.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(1, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 35);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 156);
            button1.Name = "button1";
            button1.Size = new Size(202, 35);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_Contenedor
            // 
            panel_Contenedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel_Contenedor.BackColor = Color.FromArgb(49, 66, 82);
            panel_Contenedor.Location = new Point(220, 40);
            panel_Contenedor.Name = "panel_Contenedor";
            panel_Contenedor.Size = new Size(1080, 610);
            panel_Contenedor.TabIndex = 2;
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
            panel_BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbtnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbtnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbtnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbtnCerrar).EndInit();
            panel_MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbtnCerrarSesion).EndInit();
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
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pbtnCerrarSesion;
    }
}