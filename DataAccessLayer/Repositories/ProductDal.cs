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
    public class ProductDal : IProductDal
    {
        Context C = new Context();
        public void Delete(Product p)
        {
            C.Remove(p);
            C.SaveChanges();
        }

        public List<Product> GetList()
        {
            return C.Products.ToList();
        }
        public void Insert(Product p)
        {
            C.Products.Add(p);
            C.SaveChanges();
        }

        public void Update(Product p)
        {
            C.Products.Update(p);
            C.SaveChanges();
        }
    }
}
