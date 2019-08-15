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
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly ICategoryRepository _categoryRepository;
        public ShoppingCartController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository, ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
            _drinkRepository = drinkRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            return View(new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            });
        }

        public RedirectToActionResult AddToShoppingCart(int drinkId)
        {
            var SelectedDrink = _drinkRepository.PreferredDrinks.FirstOrDefault(x => x.Id == drinkId);
            if(SelectedDrink!=null)
            {
                _shoppingCart.AddToCart(SelectedDrink,1);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int drinkId)
        {
            var SelectedDrink = _drinkRepository.PreferredDrinks.FirstOrDefault(x => x.Id == drinkId);
            if (SelectedDrink != null)
            {
                _shoppingCart.RemoveFromCart(SelectedDrink);
            }
            return RedirectToAction("Index");
        }
    }
}