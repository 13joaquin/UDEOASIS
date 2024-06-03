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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(169, 178);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(109, 46);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "label1";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.Location = new Point(235, 108);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(160, 67);
            lblHora.TabIndex = 2;
            lblHora.Text = "label1";
            // 
            // timerHoraFecha
            // 
            timerHoraFecha.Enabled = true;
            timerHoraFecha.Tick += timerHoraFecha_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Vertical;
            pictureBox1.Location = new Point(673, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 615);
            Controls.Add(pictureBox1);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InicioForm";
            Text = "InicioForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timerHoraFecha;
        private PictureBox pictureBox1;
    }
}