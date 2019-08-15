using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkETic.Data.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        
         }
        public string Id { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }


        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string CartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", CartId);
            return new ShoppingCart(context){ Id = CartId };
        }

        public void AddToCart(Drink drink,int amount)
        {

            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Drink.Id == drink.Id && s.ShoppingCardID == Id);
            if(shoppingCartItem==null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCardID = Id,
                    Drink = drink,
                    Amount = 1
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);

            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }
  
        public int RemoveFromCart(Drink drink)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(s => s.Drink.Id == drink.Id && s.ShoppingCardID == Id);
            int localAmount = 0;
            if(shoppingCartItem!=null)
            {
                if(shoppingCartItem.Amount>1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _appDbContext.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where(x => x.ShoppingCardID == Id).Include(x => x.Drink).ToList());
        }
        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(x => x.ShoppingCardID == Id);
            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }
        public decimal GetShoppingCartTotal()
        {
            return  _appDbContext.ShoppingCartItems.Where(x => x.ShoppingCardID == Id).Select(x => x.Drink.Price * x.Amount).Sum();
        }
    }
}
