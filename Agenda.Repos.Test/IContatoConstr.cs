using Agenda.Domain;
using AutoFixture;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Repos.Test
{
    public class IContatoConstr
    {
        private readonly Mock<IContato> _mockContato;
        private readonly Fixture _fixture;

        protected IContatoConstr(Mock<IContato> mockContato, Fixture fixture)
        {
            _mockContato = mockContato;
            _fixture = fixture;
        }

        public static IContatoConstr Um()
        {
            return new IContatoConstr(new Mock<IContato>(), new Fixture());
        }

        public Mock<IContato> ObterMock()
        {
            return _mockContato;
        }

        public IContatoConstr ComNome(string nome)
        {
            _mockContato.SetupGet(c => c.Nome).Returns(nome);
            return this;
        }

        public IContatoConstr ComId(Guid id)
        {
            _mockContato.SetupGet(c => c.Id).Returns(id);
            return this;
        }
    }
}