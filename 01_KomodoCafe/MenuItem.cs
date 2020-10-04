﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe
{
    public class MenuItem
    {
        public string MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

      
        public MenuItem()
        {

        }
        public MenuItem(string mealName, string mealNumber, string description, double price, string ingredients)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Price = price;
            Ingredients = ingredients;
        }
       /* public void SetMealName(string mealName)
        {
            MealName = mealName;
        }
        public void SetMealNumber(int mealNumber)
        {
            Price = Price;
        }
        public void SetMealDescription(string description)
        {
            Description = description;
        }
       public void SetMealPrice(double price)
        {
            Price = price;
        }
        public void SetIngredients(string ingredients)
        {
            Ingredients = ingredients;
        }*/
    }
}
