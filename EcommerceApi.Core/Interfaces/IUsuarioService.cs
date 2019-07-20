using EcommerceApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApi.Core.Interfaces
{
    public interface IUsuarioService
    {
        bool Login(Usuario usuario);
        bool Logout(Usuario usuario);
        bool Sigin(Usuario usuario);
        bool Sigout(Usuario usuario);
    }
}
