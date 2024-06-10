namespace UDEOASIS
{
    partial class InicioForm
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
            lblFecha = new Label();
            lblHora = new Label();
            timerHoraFecha = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label2 = new Label();
            Btn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.Location = new Point(643, 111);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(67, 23);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.Location = new Point(710, 145);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(54, 23);
            lblHora.TabIndex = 2;
            lblHora.Text = "Hora";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerHoraFecha
            // 
            timerHoraFecha.Enabled = true;
            timerHoraFecha.Tick += timerHoraFecha_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Inicio;
            pictureBox1.Location = new Point(590, 136);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(162, 24, 46);
            label2.Font = new Font("Gill Sans MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(94, 136);
            label2.Name = "label2";
            label2.Size = new Size(258, 34);
            label2.TabIndex = 5;
            label2.Text = "Asistencia Estudiantil";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Btn
            // 
            Btn.BackColor = Color.FromArgb(61, 42, 85);
            Btn.FlatAppearance.BorderSize = 0;
            Btn.FlatStyle = FlatStyle.Flat;
            Btn.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            Btn.ForeColor = Color.White;
            Btn.Image = Properties.Resources.estudiante_icon;
            Btn.ImageAlign = ContentAlignment.MiddleRight;
            Btn.Location = new Point(55, 11);
            Btn.Margin = new Padding(3, 2, 3, 2);
            Btn.Name = "Btn";
            Btn.Size = new Size(208, 64);
            Btn.TabIndex = 14;
            Btn.Text = "Estudiantes";
            Btn.TextAlign = ContentAlignment.MiddleLeft;
            Btn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(238, 172, 25);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.catedratico_icon;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(263, 11);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(208, 64);
            button1.TabIndex = 15;
            button1.Text = "Catedráticos";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(233, 231, 237);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Image = Properties.Resources.cursos_icon;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(472, 11);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(208, 64);
            button2.TabIndex = 16;
            button2.Text = "Cursos";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(162, 24, 46);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Dubai", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.c_academico_icon;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(679, 11);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(208, 64);
            button3.TabIndex = 17;
            button3.Text = "Ctrl. Académico";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(94, 183);
            label1.Name = "label1";
            label1.Size = new Size(484, 72);
            label1.TabIndex = 18;
            label1.Text = "Estamos aquí para gestionar todos los aspectos \r\ndel control de asistencia estudiantil de la universidad. \r\n";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(94, 288);
            label3.Name = "label3";
            label3.Size = new Size(430, 72);
            label3.TabIndex = 19;
            label3.Text = "Nuestro objetivo es brindar los recursos ideales\r\npara una experiencia fluida y exitosa. \r\n";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.triangulo2;
            pictureBox4.Location = new Point(560, 384);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.triangulo2;
            pictureBox2.Location = new Point(894, 52);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.triangulo2;
            pictureBox3.Location = new Point(12, 418);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Comment_desva;
            pictureBox8.Location = new Point(894, 162);
            pictureBox8.Margin = new Padding(3, 2, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(39, 46);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 27;
            pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Comment_desva;
            pictureBox5.Location = new Point(600, 402);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 46);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Comment_desva;
            pictureBox6.Location = new Point(42, 384);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(39, 46);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.circulo_negro;
            pictureBox9.Location = new Point(889, 288);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(44, 54);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 31;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.circulo_negro;
            pictureBox10.Location = new Point(12, 332);
            pictureBox10.Margin = new Padding(3, 2, 3, 2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(26, 42);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 32;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.rombo;
            pictureBox11.Location = new Point(554, 268);
            pictureBox11.Margin = new Padding(3, 2, 3, 2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(14, 42);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 33;
            pictureBox11.TabStop = false;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(945, 461);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Btn);
            Controls.Add(label2);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "InicioForm";
            Text = "InicioForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timerHoraFecha;
        private PictureBox pictureBox1;
        private Label label2;
        private Button Btn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
    }
}