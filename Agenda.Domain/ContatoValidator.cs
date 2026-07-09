using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Domain
{
    public class ContatoValidator : AbstractValidator<Contato>
    {
        public ContatoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithName("Nome do Contato").WithMessage("O {PropertyName} do contato é obrigatório.");
            RuleFor(x => x.Nome).MinimumLength(6).WithMessage("O {PropertyName} do contato deve ter pelo menos 6 caracteres.");
            RuleFor(x => x.Nome).MaximumLength(100).WithMessage("O {PropertyName} do contato deve ter no máximo 100 caracteres.");
            RuleFor(x => x.Id).NotEmpty().WithName("ID do Contato").WithMessage("O {PropertyName} do contato é obrigatório.");
            RuleFor(x => x.Id).Must(id => id != Guid.Empty).WithMessage("O {PropertyName} do contato não pode ser vazio.");
        }
    }
}
