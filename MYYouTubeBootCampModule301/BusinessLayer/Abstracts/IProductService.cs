using EntityLayer.Concretes;
using System.Collections.Generic;

namespace BusinessLayer.Abstracts
{
    public interface IProductService : IGenericService<Product>
    {
        List<object> TGetProductsListByCategory();
    }
}
