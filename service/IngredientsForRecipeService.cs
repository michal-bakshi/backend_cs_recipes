using Core.Reposetories;
using Core.Services;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class IngredientsForRecipeService:IIngredientsForRecipeService
    {
        public readonly IIngredientsForRecipeReposetory _IngredientsForResipeRepository;

        public IngredientsForRecipeService(IIngredientsForRecipeReposetory ingredientsForRecipeRepository)
        {
            _IngredientsForResipeRepository = ingredientsForRecipeRepository;
        }

        public List<IngredientsForRecipe> AddIngredient(int id, Dictionary<int, string> intIngredient)
        {
           return _IngredientsForResipeRepository.AddIngredient(id, intIngredient);
        }

        public List<IngredientsForRecipe> GetIngredientRecipe(int id)
        {
            return _IngredientsForResipeRepository.GetIngredientRecipe(id);
        }
    }
}

