using AutoFixture;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Repos.Test
{
    public class BaseConstr<T> where T : class
    {
        protected readonly Mock<T> _mock;
        protected readonly Fixture _fixture;

        protected BaseConstr(Mock<T> mock, Fixture fixture)
        {
            _mock = mock;
            _fixture = fixture;
        }

        public T Construir()
        {
            return _mock.Object;
        }

        public Mock<T> ObterMock()
        {
            return _mock;
        }
    }
}