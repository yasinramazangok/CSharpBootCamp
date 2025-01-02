using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using System.Collections.Generic;

namespace BusinessLayer.Concretes
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<object> TGetProductsListByCategory()
        {
            return _productDal.GetProductsListByCategory();
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}