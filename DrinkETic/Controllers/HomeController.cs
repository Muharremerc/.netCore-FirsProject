using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkETic.Data.Interfaces;
using DrinkETic.Data.Repositories;
using DrinkETic.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkETic.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        public HomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredDrinks = _drinkRepository.PreferredDrinks
            };
            return View(homeViewModel);
        }
    }
}