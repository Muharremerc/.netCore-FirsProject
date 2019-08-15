using DrinkETic.Data.Interfaces;
using DrinkETic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkETic.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;

        private readonly ShoppingCart _shoppingCart;
        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _appDbContext.Orders.Add(order);
            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            foreach (var item in shoppingCartItems)
            {
                _appDbContext.OrderDetails.Add(new OrderDetail
                {
                    Amount=item.Amount,
                    DrinkId=item.Id,
                    OrderId=order.Id,
                    Price=item.Drink.Price
                });
               
            }
            _appDbContext.SaveChanges();
        }
    }
}
