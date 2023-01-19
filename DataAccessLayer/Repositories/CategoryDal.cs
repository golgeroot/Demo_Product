using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryDal : ICategoryDal
    {
        Context C = new Context();
        public void Delete(Category p)
        {
            C.Categories.Remove(p);
        }

        public List<Category> GetList()
        {
            return C.Categories.ToList();
        }

        public void Insert(Category p)
        {
            C.Add(p);
            C.SaveChanges();
        }

        public void Update(Category p)
        {
            C.Update(p);
            C.SaveChanges();
        }
    }
}
