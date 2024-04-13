using CocktailDataLayer;
using CocktailModel;

namespace CocktailBusinessLayer
{
    public class CLib
    {

        public List<Calbum> GetDrinktionary()
        {
            Callist dataServices = new Callist();
            return dataServices.GetDrinktionary();
        }

    }
}
