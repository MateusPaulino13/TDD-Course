using Agenda.Domain;
using AutoFixture;
using Moq;

namespace Agenda.Repos.Test
{
    public class ITelefoneConstr : BaseConstr<ITelefone>
    {
        protected ITelefoneConstr() : base(new Mock<ITelefone>(), new Fixture())
        {
        }

        public static ITelefoneConstr Um()
        {
            return new ITelefoneConstr();
        }

        public ITelefoneConstr Padrao()
        {
            _mock.SetupGet(c => c.Id).Returns(_fixture.Create<Guid>());
            _mock.SetupGet(c => c.Numero).Returns(_fixture.Create<string>());
            _mock.SetupGet(c => c.ContatoId).Returns(_fixture.Create<Guid>());
            return this;
        }

        public ITelefoneConstr ComId(Guid id)
        {
            _mock.SetupGet(c => c.Id).Returns(id);
            return this;
        }

        public ITelefoneConstr ComNumero(string numero)
        {
            _mock.SetupGet(c => c.Numero).Returns(numero);
            return this;
        }

        public ITelefoneConstr ComContatoId(Guid contatoId)
        {
            _mock.SetupGet(c => c.ContatoId).Returns(contatoId);
            return this;
        }
    }
}