using CocktailDataLayer;
using CocktailModel;
using System.Security.Cryptography.X509Certificates;

namespace CocktailBusinessLayer
{
    public class CLib
    {

        public List<Calbum> cocktails = new List<Calbum>();
        public List<Calbum> GetDrinktionary()
        {
            Callist dataServices = new Callist();
            return dataServices.GetDrinktionary();
        }
        public void AddCocktail(Calbum cocktail)
        {     
            cocktails.Add(cocktail); 
        }
        public void DeleteCocktail(Calbum cocktail)
        {
            cocktails.Remove(cocktail);
        }
    }
}

        
    


