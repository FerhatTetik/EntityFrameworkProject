using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Egitim301.DataAccsessLayer.Abstract;
using Egitim301.DataAccsessLayer.Repositories;
using Egitim301.EntityLayer.Concrete;

namespace Egitim301.DataAccsessLayer.EntityFramework
{
    public class EFAdminDal : GenericRepository<Admin>, IAdminDal
    {

    }
}
