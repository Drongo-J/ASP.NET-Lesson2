using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            var vm = new EmployeeAddViewModel()
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>()
                {
                    new SelectListItem{Text="Baku", Value="10" },
                    new SelectListItem{Text="Xirdalan", Value="01" },
                    new SelectListItem{Text="Sumqayit", Value="50" }
                }
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult Add(EmployeeAddViewModel viewModel )
        {
            if (ModelState.IsValid)
            {
                return Redirect("/home/index");
            }
            return View();
        }
    }
}
