using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApi.Core.Entities.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.Codigo).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(x => x.Login).NotNull().NotEmpty().MaximumLength(40);
            RuleFor(x => x.Nome).NotNull().NotEmpty().MaximumLength(40);
            RuleFor(x => x.Senha).NotNull().NotEmpty().MinimumLength(8);
        }
    }
}
