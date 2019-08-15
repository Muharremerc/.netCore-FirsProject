using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkETic.Data.Interfaces;
using DrinkETic.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrinkETic.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            if(_shoppingCart.ShoppingCartItems.Count==0)
            {
                ModelState.AddModelError("", "Your card is emty,add some drinks first");
            }
            if(ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplate");
            }
            return View(order);
        }

        public IActionResult CheckoutComplate()
        {
            ViewBag.CheckoutComplateMessage = "Thanks for your order!";
            return View();
        }
    }
}