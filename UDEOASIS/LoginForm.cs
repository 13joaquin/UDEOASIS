﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDEOASIS
{
    public partial class LoginForm : Form
    {
        private MySqlConnection on = new MySqlConnection();

        public LoginForm()
        {
            InitializeComponent();
            on.ConnectionString = @"server=localhost;database=udeo_info;userid=root;password=;";

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            on.Open();
            if (on.State == ConnectionState.Open)
            {
                MessageBox.Show("Coneccion de base de datos Iniciada");
                on.Close();
            }
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            MySqlDataReader rd;
            try
            {
                on.Open();
                cmd = new MySqlCommand();
                cmd.Connection = on;
                cmd.CommandText = "SELECT * FROM login_info WHERE Username = '" + textUSER.Text + "' AND Password = '" + textPASS.Text + "' ";
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    MessageBox.Show("Successful");
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Not Successful, Por favor ingreso usuario y contrseña");
                }
            }
            finally
            {
                if (on != null)
                {
                    on.Close();
                }
            }
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.ToLongTimeString();
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
