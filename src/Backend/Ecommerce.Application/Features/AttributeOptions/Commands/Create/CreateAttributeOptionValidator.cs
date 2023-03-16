using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.AttributeOptions.Commands.Create
{
    public class CreateAttributeOptionValidator : AbstractValidator<CreateAttributeOptionRequest>
    {
        public CreateAttributeOptionValidator()
        {
            RuleFor(v => v.Name)
                .MaximumLength(500)
                .NotEmpty().WithMessage("Không được để trống");
        }
    }
}
