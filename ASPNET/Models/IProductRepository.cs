using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
