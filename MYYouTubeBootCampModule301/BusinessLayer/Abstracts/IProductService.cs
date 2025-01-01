using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface IProductService : IGenericService<Product>
    {
        List<object> TGetProductsWithCategory();
    }
}
