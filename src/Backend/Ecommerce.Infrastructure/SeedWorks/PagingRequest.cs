using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.SeedWorks
{
    public class PagingRequest
    {
        private const int maxPaging = 50;
        private int _pagingSize = 2;
        public int PagingSize
        {
            get => _pagingSize; set => _pagingSize = (value > maxPaging) ? maxPaging : value;
        }
        public int PageNumber { get; set; } = 1;
    }
}
