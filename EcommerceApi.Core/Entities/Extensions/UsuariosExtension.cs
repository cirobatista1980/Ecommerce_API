using EcommerceApi.Core.Entities.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApi.Core.Entities.Extensions
{
    public static class UsuariosExtension
    {
        public static bool IsValid(this Usuario usuario)
        {
            UsuarioValidator validator = new UsuarioValidator();
            return validator.Validate(usuario).IsValid;
        }
    }
}
