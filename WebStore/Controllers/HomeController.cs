using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35
            }
        };

        // GET
        public IActionResult Index()
        {
            return View(_employees);
        }

        public IActionResult Details(int id)
        {
            return View(_employees.FirstOrDefault(x => x.Id == id));
        }

    }
}