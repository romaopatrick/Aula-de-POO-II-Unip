using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string strConxao = "Data Source=DESKTOP-D6TJO8S\\SQLEXPRESS;Initial Catalog=dbAula01;Integrated Security=True";
            string Query = "Select * from tb01";
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDados.DataSource = dt;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            //String de conexão com o banco de dados
            string strConexao = "Data Source=DESKTOP-D6TJO8S\\SQLEXPRESS;Initial Catalog=dbAula01;Integrated Security=True";
            //String de comandos SQL
            string cmdSelect =
                "SELECT * FROM TB01 WHERE ID=" + txtID01.Text;
            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand sqlQuery = new SqlCommand(cmdSelect, con);
            SqlDataReader dr = null;
            con.Open();
            dr = sqlQuery.ExecuteReader();

            if (dr.Read())
            {
                txtNome01.Text = dr["Nome"].ToString();
            }
            con.Close();

            lblStatus.Text =
                "Registro selecionado com sucesso!!";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            //String de conexão com o banco de dados
            string strConexao = "Data Source=DESKTOP-D6TJO8S\\SQLEXPRESS;Initial Catalog=dbAula01;Integrated Security=True";

            string cmdInsert = "INSERT INTO tb01(Nome)VALUES" +
                "(" + "'" + txtNome02.Text + "'" + ")";
            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand sqlCommand = new SqlCommand(cmdInsert, con);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
            lblStatus.Text = "Registro Inserido Com Sucesso";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            //String de conexão com o banco de dados
            string strConexao = "Data Source=DESKTOP-D6TJO8S\\SQLEXPRESS;Initial Catalog=dbAula01;Integrated Security=True";
            string cmdDelete =
             "DELETE tb01 where Id=" + txtID02.Text;
            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand sqlCommand = new SqlCommand(cmdDelete, con);
            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
            lblStatus.Text = "Registro Apagado com Sucesso!!";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            string strConexao = "Data Source=DESKTOP-D6TJO8S\\SQLEXPRESS;Initial Catalog=dbAula01;Integrated Security=True";
            string cmdUpdate =
                "UPDATE tb01 SET Nome=" +
                "'" + txtNome03.Text + "' where Id=" + txtID03.Text;
            SqlConnection con = new SqlConnection(strConexao);
            SqlCommand sqlCommand = new SqlCommand(cmdUpdate, con);
            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
            lblStatus.Text = "Registro Atualizado Com Sucesso";
        }
    }
}
