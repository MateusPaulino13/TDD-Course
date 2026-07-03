using Microsoft.Extensions.DependencyModel;
using NUnit.Framework;
using Agenda.Domain;
using AutoFixture;

namespace Agenda.DAL.Test
{
    [TestFixture]
    public class ContatosTest : BaseTest
    {
        private Contatos _contatos;
        private Fixture _fixture;

        [SetUp]
        public void Setup()
        {
            _contatos = new Contatos();
        }

        //AdicionarContatoTest
        [Test]
        public void AdicionarContatoTest()
        {
            //arrange
            var contato = new Contato()
            {
                Id = Guid.NewGuid(),
                Nome = "Mateus"
            };

            //act
            _contatos.Adicionar(contato);

            //assert
            Assert.True(true);
        }

        //ObterContatoTest
        [Test]
        public void ObterContatoTest()
        {
            //arrange
            var contato = new Contato()
            {
                Id = Guid.NewGuid(),
                Nome = "Mateus"
            };

            Contato contatoResultado;

            //act
            _contatos.Adicionar(contato);
            contatoResultado = _contatos.Obter(contato.Id);

            //assert
            Assert.AreEqual(contato.Id, contatoResultado.Id);
            Assert.AreEqual(contato.Nome, contatoResultado.Nome);
        }
        
        //ObterContatoTest
        [Test]
        public void ObterTodosOsContatoTest()
        {
            //arrange
            var contato1 = new Contato() {Id = Guid.NewGuid(),Nome = "Mateus"};
            var contato2 = new Contato() {Id = Guid.NewGuid(),Nome = "Maria"};

            //act
            _contatos.Adicionar(contato1);
            _contatos.Adicionar(contato2);
            var listContato = _contatos.ObterTodos();
            var contatoResultado = listContato.Where(x => x.Id == contato1.Id).First();

            //assert
            Assert.IsTrue(listContato.Count() > 1);
            Assert.AreEqual(contato1.Id, contatoResultado.Id);
            Assert.AreEqual(contato1.Nome, contatoResultado.Nome);
        }

        [TearDown]
        public void Teardown()
        {
            _contatos = null;
        }
    }
}