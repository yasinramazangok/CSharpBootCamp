using EntityLayer.Concretes;
using System.Collections.Generic;

namespace DataAccessLayer.Abstracts
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<object> GetProductsListByCategory();
    }
}
