//Defines the contract for any class that wants to get updates when recipes change

public interface IRecipeObserver
{
    void Update(Recipe updatedRecipe);
}