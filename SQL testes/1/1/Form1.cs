﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                //nota sobre connetionString
                //Source: nome da instancia do SQL(Server name)
                //Initial catalog: nome do banco
                //id: id do usuario, nesse caso o teste
                //password: password daquele usuario
                //connetionString = @"Data Source=DESKTOP-VPP5IMI;Initial Catalog=IS_Administrativo;User ID=teste;Password=123";
                connetionString = @"Data Source=" + txtInstancia.Text + ";Initial Catalog=" + txtBanco.Text + ";User ID=" + txtUsuario.Text + ";Password=" + txtSenha.Text ;
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                MessageBox.Show("Connection Open !");
                cnn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" + "Verifique os dados informados" + erro);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}