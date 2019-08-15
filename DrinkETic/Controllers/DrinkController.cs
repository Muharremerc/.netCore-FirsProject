using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkETic.Data.Interfaces;
using DrinkETic.Data.Models;
using DrinkETic.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkETic.Controllers
{
    public class DrinkController : Controller
    {
        public readonly ICategoryRepository _categoryRepository;
        public readonly IDrinkRepository _drinkRepository;
        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult List(string Category)
        {
            string _category = Category;
            IEnumerable<Drink> drinks;
            string currentCategory = string.Empty;
            if (string.IsNullOrEmpty(_category))
            {
                drinks = _drinkRepository.Drinks.OrderBy(x=>x.Id); 
            }
            else
            {
                drinks = _drinkRepository.Drinks.Where(x => x.Category.CategoryName == _category);
            }
            DrinksListViewModel vm = new DrinksListViewModel();
            vm.Drinks = _drinkRepository.Drinks;
            vm.CurrentCategory = currentCategory;
            return View(vm);
        }
    }
}