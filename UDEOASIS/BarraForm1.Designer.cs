namespace UDEOASIS
{
    partial class BarraForm1
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
            label1 = new Label();
            panel1 = new Panel();
            panelP = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panelbARRA = new Panel();
            timerBARRA = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 128);
            label1.Name = "label1";
            label1.Size = new Size(426, 71);
            label1.TabIndex = 3;
            label1.Text = "Bienvenidos";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Location = new Point(-3, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 4;
            // 
            // panelP
            // 
            panelP.BackColor = Color.FromArgb(100, 210, 145);
            panelP.Location = new Point(1, 327);
            panelP.Name = "panelP";
            panelP.Size = new Size(0, 0);
            panelP.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Location = new Point(1, 327);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 17);
            panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Horizontal;
            pictureBox1.Location = new Point(178, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(191, 199);
            label2.Name = "label2";
            label2.Size = new Size(227, 50);
            label2.TabIndex = 8;
            label2.Text = "LOADING....";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(1, 293);
            label3.Name = "label3";
            label3.Size = new Size(277, 31);
            label3.TabIndex = 9;
            label3.Text = "Creando inicio de Sesión";
            // 
            // panelbARRA
            // 
            panelbARRA.BackColor = Color.FromArgb(100, 210, 145);
            panelbARRA.Location = new Point(0, 328);
            panelbARRA.Name = "panelbARRA";
            panelbARRA.Size = new Size(90, 17);
            panelbARRA.TabIndex = 7;
            // 
            // timerBARRA
            // 
            timerBARRA.Enabled = true;
            timerBARRA.Interval = 15;
            timerBARRA.Tick += timerBARRA_Tick;
            // 
            // BarraForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(600, 345);
            Controls.Add(panelbARRA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panelP);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BarraForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BarraForm1";
            Load += BarraForm1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panelP;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Panel panelbARRA;
        private System.Windows.Forms.Timer timerBARRA;
    }
}