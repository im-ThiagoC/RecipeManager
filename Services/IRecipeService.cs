using DataAccess.Models;

namespace RecipeManager.Services
{
    public interface IRecipeService
    {
        // Define the methods for the recipe service

        // Create
        Task AddRecipeAsync(Recipe recipe);

        // Get
        Task<Recipe> GetRecipeByIdAsync(int id);

        // List
        Task<List<Recipe>> GetAllRecipesAsync();

        // Update
        Task UpdateRecipeAsync(Recipe recipe);

        // Delete
        Task DeleteRecipeAsync(int id);
    }
}
