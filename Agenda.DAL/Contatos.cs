using Agenda.Domain;
using Dapper;
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
        using (var con = new SqlConnection(_connectionString))
        {
            con.Execute("INSERT INTO Contato (Id, Nome) VALUES (@Id, @Nome)", contato);
        }
    }

    public Contato Obter(Guid id)
    {
        Contato contato;
        using (var con = new SqlConnection(_connectionString))
        {
            contato = con.QueryFirst<Contato>("SELECT Id, Nome FROM Contato WHERE Id = @Id", new { Id = id });
        }
        return contato;
    }

    public List<Contato> ObterTodos()
    {
        var contatos = new List<Contato>();
        using (var con = new SqlConnection(_connectionString))
        {
            contatos = con.Query<Contato>("SELECT Id, Nome FROM Contato").ToList();
        }

        return contatos;
    }
}