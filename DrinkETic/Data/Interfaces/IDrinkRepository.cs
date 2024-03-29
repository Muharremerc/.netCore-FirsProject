﻿using DrinkETic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkETic.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get;}
        IEnumerable<Drink> PreferredDrinks { get; set; }
        Drink GetDrinkById(int id);
    }
}
