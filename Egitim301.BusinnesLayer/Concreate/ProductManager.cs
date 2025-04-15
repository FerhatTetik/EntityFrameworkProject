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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

        public List<Product> GetProductListWithCategoryName()
        {
            return _productDal.GetProductListWithCategoryName();
        }
    }
}
