using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

            if (string.IsNullOrWhiteSpace(txtInstancia.Text) || string.IsNullOrWhiteSpace(txtBanco.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            
            //condição para salvar as informações da tela de acesso ao banco
            else if(checkBox1.Checked == true)
            {
                try
                {
                    //escrever o arquivo que vai conter as informações de acesso ao banco
                    StreamWriter arquivo = new StreamWriter("ConfigurandoBancoDados.txt", false);
                    arquivo.WriteLine(txtInstancia.Text);
                    arquivo.WriteLine(txtBanco.Text);
                    arquivo.WriteLine(txtUsuario.Text);
                    arquivo.WriteLine(txtSenha.Text);
                    arquivo.Close();
                    
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }
            }

            else
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
                    connetionString = @"Data Source=" + txtInstancia.Text + ";Initial Catalog=" + txtBanco.Text + ";User ID=" + txtUsuario.Text + ";Password=" + txtSenha.Text;
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

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfigurandoBancoDados.txt");
                txtInstancia.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();
            }
            catch (SqlException errob)
            {
                MessageBox.Show(errob.Message);

            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Height = 500;
            lblInstancia.Text = "Buscando instancia, por favor aguarde";
            dgvInstancias.DataSource = null;
            SqlDataSourceEnumerator sqls = SqlDataSourceEnumerator.Instance;
            Refresh();
            dgvInstancias.DataSource = sqls.GetDataSources();
            if (dgvInstancias.Rows.Count == 0)
            {
                lblInstancia.Text = "Não consegui encontrar nenhuma instancia, favor avisar ao TI";
            }
            else
            {
                lblInstancia.Text = "Busca concluida";
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
