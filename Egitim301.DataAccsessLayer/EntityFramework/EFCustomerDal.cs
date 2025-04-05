using Egitim301.DataAccsessLayer.Abstract;
using Egitim301.DataAccsessLayer.Repositories;
using Egitim301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim301.DataAccsessLayer.EntityFramework
{
    public class EFCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
    }
}
