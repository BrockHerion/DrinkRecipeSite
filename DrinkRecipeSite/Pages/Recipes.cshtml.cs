using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkRecipeSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrinkRecipeSite
{
    public class RecipesModel : PageModel
    {
        public List<Recipe> Recipes { get; set; }
        public void OnGet()
        {
            Recipes = new List<Recipe>();

            var moscowMule = new Recipe {
                RecipeName = "Moscow Mule",
                RecipeDescription = "A drink Brock likes to get fucked up on",
                Ingredients = new List<Ingredient>(new Ingredient[] {
                    new Ingredient {
                        Name = "Ginger Beer",
                        Amount = 1,
                        Unit = "Can"
                    },
                    new Ingredient {
                        Name = "Vodka",
                        Amount = 2,
                        Unit = "oz"
                    },
                    new Ingredient {
                        Name = "Lime",
                        Amount = 0.5f,
                        Unit = string.Empty
                    }
                })
            };

            var rumAndCoke = new Recipe {
                RecipeName = "Rum and Coke",
                RecipeDescription = "A classic and simple drink",
                Ingredients = new List<Ingredient>(new Ingredient[] {
                    new Ingredient {
                        Name = "Rum",
                        Amount = 2,
                        Unit = "oz"
                    },
                    new Ingredient {
                        Name = "Coke",
                        Amount = 1,
                        Unit = "Can"
                    }
                })
            };

            var darkAndStormy = new Recipe {
                RecipeName = "Dark and Stormy",
                RecipeDescription = "A drink Brock also likes to get fucked up on",
                Ingredients = new List<Ingredient>(new Ingredient[] {
                    new Ingredient {
                        Name = "Ginger Beer",
                        Amount = 1,
                        Unit = "Can"
                    },
                    new Ingredient {
                        Name = "Rum",
                        Amount = 2,
                        Unit = "oz"
                    },
                    new Ingredient {
                        Name = "Lime",
                        Amount = 0.5f,
                        Unit = string.Empty
                    }
                })
            };

            Recipes.Add(moscowMule);
            Recipes.Add(rumAndCoke);
            Recipes.Add(darkAndStormy);
        }
    }
}