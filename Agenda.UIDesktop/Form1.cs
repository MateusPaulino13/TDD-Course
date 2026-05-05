using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Agenda.UIDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string name = TxtContatoNovo.Text;
            //TxtContatoSalvo.Text = name;

            //conexão com o banco de dados
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string Id = Guid.NewGuid().ToString();
            var con = new SqlConnection(connectionString);

            con.Open();

            string sql = $"INSERT INTO Contato (Id, Nome) VALUES ('{Id}', '{name}')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            sql = $"SELECT Nome FROM Contato WHERE Id = '{Id}'";
            cmd = new SqlCommand(sql, con);
            TxtContatoSalvo.Text = cmd.ExecuteScalar().ToString();

            con.Close();
        }
    }
}
