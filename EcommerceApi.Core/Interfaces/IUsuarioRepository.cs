using System;
using System.Collections.Generic;
using System.Text;
using EcommerceApi.Core.Entities;

namespace EcommerceApi.Core.Interfaces
{
    public interface IUsuarioRepository: IRepositoryBase<Usuario>
    {
        Usuario GetUsuarioByLoginSenha(Usuario usuario);
    }
}
