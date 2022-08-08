using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System.Collections;
using ValidationResult = FluentValidation.Results.ValidationResult;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class ProductController : Controller
    {
#pragma warning disable IDE0090 // 'new(...)' kullanın
        ProductManager productManager = new ProductManager(new EfProductDal());
#pragma warning restore IDE0090 // 'new(...)' kullanın
        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);

        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p )
        {
            ProductValidator validationRules = new ProductValidator();

            ValidationResult results = validationRules.Validate(p);
            if (results.IsValid)
            {
                productManager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View(p);

        }
        public IActionResult DeleteProduct(int id)
        {
            var value=productManager.TGetById(id);
            productManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)//Güncelleme yapılmasını istediğim alanı bul
        {
            var value = productManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p)//buldugumuz alanı guncelle
        {
          
            productManager.TUpdate(p);
            return RedirectToAction("Index");

        }

      
    }
}
