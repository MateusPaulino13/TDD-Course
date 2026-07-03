using Microsoft.Extensions.DependencyModel;
using NUnit.Framework;
using Agenda.Domain;
using AutoFixture;

namespace Agenda.DAL.Test
{
    [TestFixture]
    public class Contatos2Test : BaseTest
    {
        Contatos _contatos;
        Fixture _fixture;

        [SetUp]
        public void Setup()
        {
            _contatos = new Contatos();
            _fixture = new Fixture();
        }

        //ObterContatoTest
        [Test]
        public void ObterTodosOsContatoTest()
        {
            //arrange
            var contato1 = _fixture.Create<Contato>();
            var contato2 = _fixture.Create<Contato>();

            //act
            _contatos.Adicionar(contato1);
            _contatos.Adicionar(contato2);
            var listContato = _contatos.ObterTodos();
            var contatoResultado = listContato.Where(x => x.Id == contato1.Id).First();

            //assert
            Assert.AreEqual(2, listContato.Count());
            Assert.AreEqual(contato1.Id, contatoResultado.Id);
            Assert.AreEqual(contato1.Nome, contatoResultado.Nome);
        }

        [TearDown]
        public void Teardown()
        {
            _contatos = null;
            _fixture = null;
        }
    }
}
