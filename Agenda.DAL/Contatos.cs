using Agenda.Domain;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Agenda.DAL;

public class Contatos
{
    private string _connectionString;

    public Contatos()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    }

    public void Adicionar(Contato contato)
    {
        using(var con = new SqlConnection(_connectionString))
        {
            con.Open();

            var sql = $"INSERT INTO Contato (Id, Nome) VALUES ('{contato.Id}', '{contato.Nome}')";
            var cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }

    public Contato Obter(Guid Id)
    {
        Contato contato;
        using (var con = new SqlConnection(_connectionString))
        {
            con.Open();

            var sql = $"SELECT Id, Nome FROM Contato WHERE Id = '{Id}'";
            var cmd = new SqlCommand(sql, con);

            var sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();

            contato = new Contato
            {
                Id = Guid.Parse(sqlDataReader["Id"].ToString()),
                Nome = sqlDataReader["Nome"].ToString()
            };
        }
        return contato;
    }

    public List<Contato> ObterTodos()
    {
        var contatos = new List<Contato>();
        using (var con = new SqlConnection(_connectionString))
        {
            con.Open();

            var sql = $"SELECT Id, Nome FROM Contato";
            var cmd = new SqlCommand(sql, con);

            var sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                var contato = new Contato
                {
                    Id = Guid.Parse(sqlDataReader["Id"].ToString()),
                    Nome = sqlDataReader["Nome"].ToString()
                };
                contatos.Add(contato);
            }
        }
        return contatos;
    }
}