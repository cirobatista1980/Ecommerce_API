using EcommerceApi.Core.Entities;
using EcommerceApi.Core.Interfaces;
using EcommerceApi.Core.Entities.Extensions;
using NUnit.Framework;
using EcommerceApi.Core.Services;
using Moq;

namespace EcommerceApi.Test
{
    [TestFixture]
    public class UsuarioServiceTest
    {
        private readonly IUsuarioService service;
        private readonly IRepositoryBase<Usuario> repository;
        private readonly Usuario usuarioValido;
        private readonly Usuario usuarioInValido;
        public UsuarioServiceTest()
        {
            usuarioInValido = new Usuario();

            usuarioValido = new Usuario()
            {
                Codigo = 0,
                Email = "usuario@usuario.com",
                Login = "user",
                Nome = "user",
                Senha = "12345678"
            };

            Mock<IRepositoryBase<Usuario>> mockRepository = new Mock<IRepositoryBase<Usuario>>();
            mockRepository.Setup(x => x.GetById(usuarioValido)).Returns(usuarioValido);
            repository = mockRepository.Object;
            service = new UsuarioService(repository);
        }



        [Test]
        public void UsuarioEhValido()
        {
            Assert.IsTrue(usuarioValido.IsValid());
        }

        [Test]
        public void UsuarioEhInValido()
        {
            Assert.IsFalse(usuarioInValido.IsValid());
        }

        [Test]
        public void LogarUsuarioValido()
        {
            Assert.IsTrue(service.Login(usuarioValido));
        }
        [Test]
        public void LogarUsuarioInValido()
        {
            Assert.IsFalse(service.Login(usuarioInValido));
        }
    }
}
