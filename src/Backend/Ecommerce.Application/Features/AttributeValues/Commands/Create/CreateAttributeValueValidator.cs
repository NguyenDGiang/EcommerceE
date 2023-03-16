using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.AttributeValues.Commands.Create
{
    internal class CreateAttributeValueValidator : AbstractValidator<CreateAttributeValueRequest>
    {
        CreateAttributeValueValidator()
        {
            RuleFor(x => x.Value)
                .MaximumLength(50)
                .NotEmpty()
                .WithMessage("Value không để trống");
            RuleFor(x => x.AttributeOptionId)
                .NotEmpty()
                .WithMessage("AttributeOption không để trống");
        }
    }
}
