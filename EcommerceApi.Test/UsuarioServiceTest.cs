using EcommerceApi.Core.Entities;
using EcommerceApi.Core.Interfaces;
using EcommerceApi.Core.Entities.Extensions;
using NUnit.Framework;
using EcommerceApi.Core.Services;

namespace EcommerceApi.Test
{
    [TestFixture]
    public class UsuarioServiceTest
    {
        private readonly IUsuarioService service;
        public UsuarioServiceTest()
        {
            service = new UsuarioService();
        }

        [Test]
        public void ValidarUsuario()
        {
            Usuario user = new Usuario();
            Assert.IsTrue(user.IsValid());
        }
    }
}
