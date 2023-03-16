using Ecommerce.Infrastructure;

namespace Ecommerce.Application
{
    public abstract class BaseHandler
    {
        protected readonly IUnitOfWork _unitOfWork;

        protected BaseHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
