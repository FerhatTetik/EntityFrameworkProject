using Egitim301.BusinnesLayer.Abstract;
using Egitim301.DataAccsessLayer.Abstract;
using Egitim301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim301.BusinnesLayer.Concreate
{
    class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void TInsert(Customer entity)
        {
            _customerDal.Insert(entity);
        }
        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
