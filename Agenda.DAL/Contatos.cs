using System;
using Microsoft.Data.SqlClient;
using Agenda.Domain;

namespace Agenda.DAL;

public class Contatos
{
    private string _connectionString;
    private SqlConnection _con;

    public Contatos()
    {
        _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        _con = new SqlConnection(_connectionString);
    }

    public void Adicionar(Contato contato)
    {
        _con.Open();

        var sql = $"INSERT INTO Contato (Id, Nome) VALUES ('{contato.Id}', '{contato.Nome}')";
        var cmd = new SqlCommand(sql, _con);
        cmd.ExecuteNonQuery();

        _con.Close();
    }

    public Contato Obter(Guid Id)
    {
        _con.Open();

        var sql = $"SELECT Id, Nome FROM Contato WHERE Id = '{Id}'";
        var cmd = new SqlCommand(sql, _con);

        var sqlDataReader = cmd.ExecuteReader();
        sqlDataReader.Read();

        var contato = new Contato
        {
            Id = Guid.Parse(sqlDataReader["Id"].ToString()),
            Nome = sqlDataReader["Nome"].ToString()
        };

        return contato;
    }

    public List<Contato> ObterTodos()
    {
        var contatos = new List<Contato>();
        _con.Open();

        var sql = $"SELECT Id, Nome FROM Contato";
        var cmd = new SqlCommand(sql, _con);

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

        return contatos;
    }
}