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
        private readonly IUsuarioRepository repository;
        public UsuarioService(IUsuarioRepository _repository)
        {
            repository = _repository;
        }

        public bool Login(Usuario usuario)
        {
            if (usuario.IsValid())
            {
                var user = repository.GetUsuarioByLoginSenha(usuario);
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
            if(usuario.IsValid())
            {
                var user = repository.Insert(usuario);
                return (user != null);
            }
            else
            {
                return false;
            }
        }

        public bool Sigout(Usuario usuario)
        {
            if(usuario.IsValid())
            {
                usuario.Ativo = false;
                var user = repository.Update(usuario);
                return (user != null);
            }
            else
            {
                return false;
            }
        }
    }
}
