using Agenda.Domain;
using AutoFixture;
using Moq;

namespace Agenda.Repos.Test
{
    public class ITelefoneConstr
    {
        private readonly Mock<ITelefone> _mockTelefone;
        private readonly Fixture _fixture;

        protected ITelefoneConstr(Mock<ITelefone> mockTelefone, Fixture fixture)
        {
            _mockTelefone = mockTelefone;
            _fixture = fixture;
        }

        public static ITelefoneConstr Um()
        {
            return new ITelefoneConstr(new Mock<ITelefone>(), new Fixture());
        }

        public ITelefone Construir()
        {
            return _mockTelefone.Object;
        }

        public ITelefoneConstr Padrao()
        {
            _mockTelefone.SetupGet(c => c.Id).Returns(_fixture.Create<Guid>());
            _mockTelefone.SetupGet(c => c.Numero).Returns(_fixture.Create<string>());
            _mockTelefone.SetupGet(c => c.ContatoId).Returns(_fixture.Create<Guid>());
            return this;
        }

        public ITelefoneConstr ComId(Guid id)
        {
            _mockTelefone.SetupGet(c => c.Id).Returns(id);
            return this;
        }

        public ITelefoneConstr ComNumero(string numero)
        {
            _mockTelefone.SetupGet(c => c.Numero).Returns(numero);
            return this;
        }

        public ITelefoneConstr ComContatoId(Guid contatoId)
        {
            _mockTelefone.SetupGet(c => c.ContatoId).Returns(contatoId);
            return this;
        }
    }
}