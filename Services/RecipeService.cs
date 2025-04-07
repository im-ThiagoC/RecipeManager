using DataAccess.Models;

namespace RecipeManager.Services
{
    public class RecipeService : IRecipeService
    {
        public Task AddRecipeAsync(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRecipeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Recipe>> GetAllRecipesAsync()
        {
            var recipes = new List<Recipe>
            {
                new Recipe
                {
                    Id = 1,
                    Title = "Spaghetti Bolognese",
                    Description = "A classic Italian pasta dish with a rich meat sauce.",
                    //Ingredients = "Spaghetti, ground beef, tomato sauce, onion, garlic, herbs",
                    //Instructions = "Cook spaghetti. Brown beef with onion and garlic. Add tomato sauce and herbs. Combine with spaghetti.",
                    //CookingTime = 30,
                    //Servings = 4,
                    //ImageUrl = "https://example.com/spaghetti.jpg",
                    CreatedAt = DateTime.Now.AddHours(-1),
                    UpdatedAt = DateTime.Now,
                },
                new Recipe
                {
                    Id = 2,
                    Title = "Chicken Curry",
                    Description = "A spicy and flavorful chicken dish cooked in a rich curry sauce.",
                    //Ingredients = "Chicken, curry powder, coconut milk, onion, garlic, ginger",
                    //Instructions = "Sauté onion, garlic, and ginger. Add chicken and curry powder. Pour in coconut milk and simmer.",
                    //CookingTime = 45,
                    //Servings = 4,
                    //ImageUrl = "https://example.com/chicken_curry.jpg",
                    CreatedAt = DateTime.Now.AddHours(-2),
                    UpdatedAt = DateTime.Now,
                },
                new Recipe
                {
                    Id = 3,
                    Title = "Caesar Salad",
                    Description = "A fresh salad with romaine lettuce, croutons, and Caesar dressing.",
                    //Ingredients = "Romaine lettuce, croutons, Parmesan cheese, Caesar dressing",
                    //Instructions = "Toss lettuce with croutons and dressing. Top with Parmesan cheese.",
                    //CookingTime = 15,
                    //Servings = 2,
                    //ImageUrl = "https://example.com/caesar_salad.jpg",
                    CreatedAt = DateTime.Now.AddHours(-3),
                    UpdatedAt = DateTime.Now,
                }

            };

            return Task.FromResult(recipes);
        }

        public Task<Recipe> GetRecipeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRecipeAsync(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
