using Agenda.DAL;
using Agenda.Domain;
using AutoFixture;
using Moq;
using NUnit.Framework;

namespace Agenda.Repos.Test
{
    [TestFixture]
    public class RepositorioContatosTest
    {
        private Mock<IContatos> _contatos;
        private Mock<ITelefones> _telefones;
        private RepositorioContatos _repositorioContatos;
        private Fixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _contatos = new Mock<IContatos>();
            _telefones = new Mock<ITelefones>();
            _repositorioContatos = new RepositorioContatos(_contatos.Object, _telefones.Object);
            _fixture = new Fixture();
        }

        [Test]
        public void DeveSerPossivelObterContatoComListaTelefonica()
        {
            var ltsTelefone = new List<ITelefone>();
            var telefoneId = Guid.NewGuid();
            var contatoId = Guid.NewGuid();

            //arrange
            var mContato = IContatoConstr
                .Um()
                .ComId(contatoId)
                .ComNome(_fixture.Create<string>())
                .ObterMock();
            mContato.SetupSet(c => c.Telefones = It.IsAny<List<ITelefone>>()).Callback<List<ITelefone>>(x => ltsTelefone = x);
            _contatos.Setup(x => x.Obter(contatoId)).Returns(mContato.Object);

            var mockTelefone = ITelefoneConstr
                .Um()
                .Padrao()
                .ComId(telefoneId)
                .ComContatoId(contatoId)
                .Construir();
            _telefones.Setup(x => x.ObterTodosDoContato(contatoId)).Returns(new List<ITelefone> { mockTelefone });

            //act
            IContato contatoResultado = _repositorioContatos.ObterPorId(contatoId);
            mContato.SetupGet(x => x.Telefones).Returns(ltsTelefone);

            //assert
            Assert.AreEqual(mContato.Object.Id, contatoResultado.Id);
            Assert.AreEqual(mContato.Object.Nome, contatoResultado.Nome);
            Assert.AreEqual(mContato.Object.Id, contatoResultado.Telefones[0].ContatoId);
            Assert.AreEqual(1, contatoResultado.Telefones.Count);
            Assert.AreEqual(mockTelefone.Numero, contatoResultado.Telefones[0].Numero);
            Assert.AreEqual(mockTelefone.Id, contatoResultado.Telefones[0].Id);
        }

        [TearDown]
        public void TearDown()
        {
            _contatos = null;
            _telefones = null;
            _repositorioContatos = null;
            _fixture = null;
        }
    }
}