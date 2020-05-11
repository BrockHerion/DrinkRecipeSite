using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkRecipeSite.Models {
    public class Recipe {
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
