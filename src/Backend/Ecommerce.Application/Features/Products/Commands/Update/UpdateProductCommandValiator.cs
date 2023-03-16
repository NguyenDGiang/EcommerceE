using FluentValidation;

namespace Ecommerce.Application.Features.Products.Commands.Create
{
    public class UpdateProductCommandValiator : AbstractValidator<UpdateProductRequest>
    {
        public UpdateProductCommandValiator()
        {
            RuleFor(v => v.Name)
                .MaximumLength(500)
                .NotEmpty().WithMessage("Không được để trống");
        }
    }
}
