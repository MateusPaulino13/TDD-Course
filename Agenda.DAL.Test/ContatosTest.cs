using Microsoft.Extensions.DependencyModel;
using NUnit.Framework;
using Agenda.Domain;
using AutoFixture;

namespace Agenda.DAL.Test
{
    [TestFixture]
    public class ContatosTest : BaseTest
    {
        Contatos _contatos;
        Fixture _fixture;

        [SetUp]
        public void Setup()
        {
            _contatos = new Contatos();
            _fixture = new Fixture();
        }

        //AdicionarContatoTest
        [Test]
        public void AdicionarContatoTest()
        {
            //arrange
            var contato = _fixture.Create<Contato>();

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
            Contato contato = _fixture.Create<Contato>();
            Contato contatoResultado;

            //act
            _contatos.Adicionar(contato);
            contatoResultado = _contatos.Obter(contato.Id);

            //assert
            Assert.AreEqual(contato.Id, contatoResultado.Id);
            Assert.AreEqual(contato.Nome, contatoResultado.Nome);
        }

        [TearDown]
        public void Teardown()
        {
            _contatos = null;
            _fixture = null;
        }
    }
}