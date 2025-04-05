using Egitim301.BusinnesLayer.Abstract;
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
        public void TInsert(Customer entity)
        {
            if (entity.CustomerName.Length <= 2 && entity.CustomerName != "") // Arttırılabilir.
            {
                throw new Exception("Müşteri adı boş olamaz ve en az 2 karakter olmalıdır.");
            }
            else
            {
                // Müşteri ekleme işlemi
                // Örnek: _customerRepository.Add(entity);
            }
        }
        public void TDelete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
