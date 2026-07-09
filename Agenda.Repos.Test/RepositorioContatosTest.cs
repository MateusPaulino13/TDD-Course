using Agenda.DAL;
using Agenda.Domain;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Repos.Test
{
    [TestFixture]
    public class RepositorioContatosTest
    {
        Mock<IContatos> _contatos;
        Mock<ITelefones> _telefones;
        RepositorioContatos _repositorioContatos;

        [SetUp] 
        public void SetUp() 
        {
            _contatos = new Mock<IContatos>();
            _telefones = new Mock<ITelefones>();
            _repositorioContatos = new RepositorioContatos(_contatos.Object, _telefones.Object);
        }

        [Test]
        public void DeveSerPossivelObterContatoComListaTelefonica()
        {
            var ltsTelefone = new List<ITelefone>();
            Guid telefoneId = Guid.NewGuid();
            Guid contatoId = Guid.NewGuid();

            //arrange
            Mock<IContato> mContato = new Mock<IContato>();
            mContato.SetupGet(c => c.Id).Returns(contatoId);
            mContato.SetupGet(c => c.Nome).Returns("John Doe");
            mContato.SetupSet(c => c.Telefones = It.IsAny<List<ITelefone>>()).Callback<List<ITelefone>>(x => ltsTelefone = x);
            _contatos.Setup(x => x.Obter(contatoId)).Returns(mContato.Object);

            Mock<ITelefone> mTelefone = new Mock<ITelefone>();
            mTelefone.SetupGet(c => c.Id).Returns(telefoneId);
            mTelefone.SetupGet(c => c.Numero).Returns("1234-5678");
            mTelefone.SetupGet(c => c.ContatoId).Returns(contatoId);
            _telefones.Setup(x => x.ObterTodosDoContato(contatoId)).Returns(new List<ITelefone> { mTelefone.Object });

            //act
            IContato contatoResultado = _repositorioContatos.ObterPorId(contatoId);
            mContato.SetupGet(x => x.Telefones).Returns(ltsTelefone);

            //assert
            Assert.AreEqual(mContato.Object.Id, contatoResultado.Id);
            Assert.AreEqual(mContato.Object.Nome, contatoResultado.Nome);
            Assert.AreEqual(mContato.Object.Id, contatoResultado.Telefones[0].ContatoId);
            Assert.AreEqual(1, contatoResultado.Telefones.Count);
            Assert.AreEqual(mTelefone.Object.Numero, contatoResultado.Telefones[0].Numero);
            Assert.AreEqual(mTelefone.Object.Id, contatoResultado.Telefones[0].Id);
        }
        
        [TearDown]
        public void TearDown() 
        {
            _contatos = null;
            _telefones = null;
            _repositorioContatos = null;
        }
    }
}
