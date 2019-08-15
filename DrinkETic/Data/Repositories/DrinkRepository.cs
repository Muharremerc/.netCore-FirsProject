using DrinkETic.Data.Interfaces;
using DrinkETic.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkETic.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _appDbContext;
        public DrinkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Drink> Drinks => _appDbContext.Drinks.Include(x => x.Category);

        public IEnumerable<Drink> PreferredDrinks { get => _appDbContext.Drinks.Where(x=>x.IsPreferredDrink).Include(x=>x.Category); set => throw new NotImplementedException(); }

        public Drink GetDrinkById(int id)
        {
            return _appDbContext.Drinks.FirstOrDefault(X => X.Id == id);
        }
    }
}
