using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concretes
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetListAll()
        {
            return _customerDal.GetListAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.Name != "" && entity.Name.Length >= 3 && entity.City != null && entity.Name.Length <= 30)
            {
                _customerDal.Insert(entity);
            }
            else
            {
                //error message
            }
        }

        public void TUpdate(Customer entity)
        {
            if (entity.CustomerId != 0 && entity.City.Length >= 3)
            {
                _customerDal.Update(entity);
            }
            else
            {
                //error message            
            }
        }
    }
}
