using FluentValidation;

namespace Ecommerce.Application.Features.Products.Commands.Create
{
    public class CreateProductValiator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductValiator()
        {
            RuleFor(v => v.Name)
                .MaximumLength(500)
                .NotEmpty().WithMessage("Không được để trống");
        }
    }
}
