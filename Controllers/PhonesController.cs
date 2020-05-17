using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class PhonesController : Controller
    {
        private readonly IAllPhones _allPhones;
        private readonly ICategory _categories;

        public PhonesController(IAllPhones allPhones, ICategory categories)
        {
            _allPhones = allPhones;
            _categories = categories;
        }

        public ViewResult List()
        {
            var phones = _allPhones.Phones;
            return View(phones);
        }
    }
}
