using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe)
        {
            Header = recipe.Name;
            ShowHeaderPanel();

            foreach (Ingredient ingredientz in recipe.Ingredients)
            { 

                Console.WriteLine(ingredientz);
            }
            foreach (string instructionz in recipe.Instructions)
            {
                Console.WriteLine(instructionz);
            }
        }
        public void Show(IEnumerable<IRecipe> recipes)
        {
            foreach (IRecipe recipe in recipes)
            {
                Show(recipe);
                ContinueOnKeyPressed();
            }
        }
    }
}
