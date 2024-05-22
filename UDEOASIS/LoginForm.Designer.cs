namespace UDEOASIS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            labeltitle1 = new Label();
            pictureBox1 = new PictureBox();
            labelsub2 = new Label();
            textPASS = new TextBox();
            textUSER = new TextBox();
            PASSWORD = new Label();
            USERNAME = new Label();
            Loginbutton = new Button();
            label_hora = new Label();
            lbl_fecha = new Label();
            horafecha = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(labeltitle1);
            panel1.Location = new Point(0, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 67);
            panel1.TabIndex = 2;
            // 
            // labeltitle1
            // 
            labeltitle1.AutoSize = true;
            labeltitle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labeltitle1.ForeColor = Color.White;
            labeltitle1.Location = new Point(88, 19);
            labeltitle1.Name = "labeltitle1";
            labeltitle1.Size = new Size(444, 41);
            labeltitle1.TabIndex = 0;
            labeltitle1.Text = "Sistema de Atención al Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 369);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelsub2
            // 
            labelsub2.AutoSize = true;
            labelsub2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelsub2.ForeColor = Color.Red;
            labelsub2.Location = new Point(285, 177);
            labelsub2.Name = "labelsub2";
            labelsub2.Size = new Size(337, 31);
            labelsub2.TabIndex = 4;
            labelsub2.Text = "Por favor inserte cuenta Login";
            // 
            // textPASS
            // 
            textPASS.Location = new Point(427, 304);
            textPASS.Name = "textPASS";
            textPASS.Size = new Size(180, 27);
            textPASS.TabIndex = 12;
            // 
            // textUSER
            // 
            textUSER.Location = new Point(427, 236);
            textUSER.Name = "textUSER";
            textUSER.Size = new Size(180, 27);
            textUSER.TabIndex = 11;
            // 
            // PASSWORD
            // 
            PASSWORD.AutoSize = true;
            PASSWORD.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PASSWORD.Location = new Point(255, 298);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.Size = new Size(166, 31);
            PASSWORD.TabIndex = 10;
            PASSWORD.Text = "CONTRASEÑA";
            // 
            // USERNAME
            // 
            USERNAME.AutoSize = true;
            USERNAME.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            USERNAME.Location = new Point(306, 236);
            USERNAME.Name = "USERNAME";
            USERNAME.Size = new Size(115, 31);
            USERNAME.TabIndex = 9;
            USERNAME.Text = "USUARIO";
            // 
            // Loginbutton
            // 
            Loginbutton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Loginbutton.Location = new Point(276, 368);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(322, 39);
            Loginbutton.TabIndex = 13;
            Loginbutton.Text = "Inicio de Sesion";
            Loginbutton.UseVisualStyleBackColor = true;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // label_hora
            // 
            label_hora.AutoSize = true;
            label_hora.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label_hora.Location = new Point(399, 74);
            label_hora.Name = "label_hora";
            label_hora.Size = new Size(109, 46);
            label_hora.TabIndex = 14;
            label_hora.Text = "label1";
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_fecha.Location = new Point(351, 115);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(91, 38);
            lbl_fecha.TabIndex = 15;
            lbl_fecha.Text = "label1";
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(634, 455);
            Controls.Add(lbl_fecha);
            Controls.Add(label_hora);
            Controls.Add(Loginbutton);
            Controls.Add(textPASS);
            Controls.Add(textUSER);
            Controls.Add(PASSWORD);
            Controls.Add(USERNAME);
            Controls.Add(labelsub2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labeltitle1;
        private PictureBox pictureBox1;
        private Label labelsub2;
        private TextBox textPASS;
        private TextBox textUSER;
        private Label PASSWORD;
        private Label USERNAME;
        private Button Loginbutton;
        private Label label_hora;
        private Label lbl_fecha;
        private System.Windows.Forms.Timer horafecha;
    }
}