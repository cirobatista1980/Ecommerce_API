using EcommerceApi.Core.Entities;
using EcommerceApi.Core.Interfaces;
using EcommerceApi.Core.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApi.Core.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IRepositoryBase<Usuario> repository;
        public UsuarioService(IRepositoryBase<Usuario> _repository)
        {
            repository = _repository;
        }

        public bool Login(Usuario usuario)
        {
            if (usuario.IsValid())
            {
                var user = repository.GetById(usuario);
                return (user != null);
            }
            else
                return false;
        }

        public bool Logout(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool Sigin(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool Sigout(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
