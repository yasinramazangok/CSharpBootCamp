using DataAccessLayer.Abstracts;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<object> GetProductsListByCategory()
        {
            var context = new Context();
            var values = context.Products
                .Select(x => new
                {
                    ProductId = x.ProductId,
                    Name = x.Name,
                    Stock = x.Stock,
                    Price = x.Price,
                    Description = x.Description,
                    CategoryName = x.Category.Name
                }).ToList();

            return values.Cast<object>().ToList();
        }
    }
}
