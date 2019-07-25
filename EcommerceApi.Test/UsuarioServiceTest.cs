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
        private readonly IUsuarioRepository repository;
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
                Senha = "12345678",
                Ativo = true
            };

            Mock<IUsuarioRepository> mockRepository = new Mock<IUsuarioRepository>();
            mockRepository.Setup(x => x.GetUsuarioByLoginSenha(usuarioValido)).Returns(usuarioValido);
            mockRepository.Setup(x => x.Insert(usuarioValido)).Returns(usuarioValido);
            mockRepository.Setup(x => x.Update(usuarioValido)).Returns(new Usuario(){Ativo = false});
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
        [Test]
        public void Sigin()
        {
            Assert.IsTrue(service.Sigin(usuarioValido));
        }
        [Test]
        public void SiginFall()
        {
            Assert.IsFalse(service.Sigin(usuarioInValido));
        }
        [Test]
        public void Sigout()
        {
            Assert.IsTrue(service.Sigout(usuarioValido));
        }
        [Test]
        public void SigoutFall()
        {
            Assert.IsTrue(service.Sigout(usuarioValido));
        }
    }
}
