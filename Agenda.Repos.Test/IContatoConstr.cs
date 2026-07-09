using Agenda.Domain;
using AutoFixture;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Repos.Test
{
    public class IContatoConstr : BaseConstr<IContato>
    {
        protected IContatoConstr() : base(new Mock<IContato>(), new Fixture())
        {
        }

        public static IContatoConstr Um()
        {
            return new IContatoConstr();
        }

        public IContatoConstr ComNome(string nome)
        {
            _mock.SetupGet(c => c.Nome).Returns(nome);
            return this;
        }

        public IContatoConstr ComId(Guid id)
        {
            _mock.SetupGet(c => c.Id).Returns(id);
            return this;
        }
    }
}