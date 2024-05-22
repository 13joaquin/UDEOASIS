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
            panel1 = new Panel();
            labeltitle1 = new Label();
            pictureBox1 = new PictureBox();
            labelsub2 = new Label();
            USERNAME = new Label();
            PASSWORD = new Label();
            textUSER = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(labeltitle1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 60);
            panel1.TabIndex = 0;
            // 
            // labeltitle1
            // 
            labeltitle1.AutoSize = true;
            labeltitle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labeltitle1.ForeColor = Color.White;
            labeltitle1.Location = new Point(84, 7);
            labeltitle1.Name = "labeltitle1";
            labeltitle1.Size = new Size(444, 41);
            labeltitle1.TabIndex = 0;
            labeltitle1.Text = "Sistema de Atención al Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelsub2
            // 
            labelsub2.AutoSize = true;
            labelsub2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelsub2.ForeColor = Color.Red;
            labelsub2.Location = new Point(96, 208);
            labelsub2.Name = "labelsub2";
            labelsub2.Size = new Size(337, 31);
            labelsub2.TabIndex = 2;
            labelsub2.Text = "Por favor inserte cuenta Login";
            // 
            // USERNAME
            // 
            USERNAME.AutoSize = true;
            USERNAME.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            USERNAME.Location = new Point(96, 303);
            USERNAME.Name = "USERNAME";
            USERNAME.Size = new Size(115, 31);
            USERNAME.TabIndex = 3;
            USERNAME.Text = "USUARIO";
            // 
            // PASSWORD
            // 
            PASSWORD.AutoSize = true;
            PASSWORD.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PASSWORD.Location = new Point(45, 359);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.Size = new Size(166, 31);
            PASSWORD.TabIndex = 4;
            PASSWORD.Text = "CONTRASEÑA";
            // 
            // textUSER
            // 
            textUSER.Location = new Point(217, 304);
            textUSER.Name = "textUSER";
            textUSER.Size = new Size(180, 27);
            textUSER.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 365);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(634, 455);
            Controls.Add(textBox1);
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
        private Label USERNAME;
        private Label PASSWORD;
        private TextBox textUSER;
        private TextBox textBox1;
    }
}