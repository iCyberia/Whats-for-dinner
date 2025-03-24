﻿namespace MenuAppBlazor.Models
{
    public class DishIngredient
    {
        public int DishId { get; set; }
        public Dish Dish { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public double Quantity { get; set; }
        public string QuantityType { get; set; } = string.Empty;
    }
}
