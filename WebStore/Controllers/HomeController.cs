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
                Age = 22,
                City = "Москва",
                Profession = "Слесарь",
                Experience = 3
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35,
                City = "Москва",
                Profession = "Токарь",
                Experience = 9
            },
             new EmployeeView
            {
                Id = 3,
                FirstName = "Геннадий",
                SurName = "Орлов",
                Patronymic = "Петрович",
                Age = 33,
                City = "Санкт-Петербург",
                Profession = "Экономист",
                Experience = 7
            },
              new EmployeeView
            {
                Id = 4,
                FirstName = "Семен",
                SurName = "Семенов",
                Patronymic = "Семенович",
                Age = 28,
                City = "Москва",
                Profession = "Переводчик",
                Experience = 5
            },
               new EmployeeView
            {
                Id = 5,
                FirstName = "Владислав",
                SurName = "Галкин",
                Patronymic = "Иванович",
                Age = 40,
                City = "Саратов",
                Profession = "Водитель",
                Experience = 12
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