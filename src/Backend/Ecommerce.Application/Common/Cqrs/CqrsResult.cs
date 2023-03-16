using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Common.Cqrs
{
    internal class CqrsResult
    {
        public interface ICommand : IRequest<IResult>
        {
        }

        public interface IQuery : IRequest<IResult>
        {
        }
    }
}
