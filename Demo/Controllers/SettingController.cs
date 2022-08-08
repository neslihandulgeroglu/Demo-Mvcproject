using Demo.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
   
    public class SettingController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            UserEditViewModel userEditViewModel=new UserEditViewModel();

            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname=values.Surname;
            userEditViewModel.Mail = values.Email;

            return View(userEditViewModel);
        }
        [HttpPost]
       
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.Email = p.Mail;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Product");   
            }
            else
            {
                //hatamesajları
              
            }
            return View();

        }
        
    }
}
