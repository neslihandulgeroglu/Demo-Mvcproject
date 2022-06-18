using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IPoductDal _productDal;

        public ProductManager(IPoductDal productDal)
        {
            _productDal = productDal;
        }
        public void TDelete(Product t)
        {
           _productDal.Delete(t);
        }

        public Product TGetById(int id)
        {
           return _productDal.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }

        //yapıcı metot

    }
}
