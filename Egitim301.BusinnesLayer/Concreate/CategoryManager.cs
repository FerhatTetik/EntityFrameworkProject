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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }
        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }
        public List<Category> TGetList()
        {
            return _categoryDal.GetAll();
        }
        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
