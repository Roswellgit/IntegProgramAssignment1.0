using CocktailBusinessLayer;
using CocktailModel;

namespace IntegProgramAssignment1._0
{
    internal class Program
    {
        public static void ShowHistory(Calbum cocktail)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Here's your Drink!");
            Console.WriteLine(cocktail.cname);
            Console.WriteLine(cocktail.mainingredients);
            Console.WriteLine(cocktail.prep);
            Console.WriteLine(cocktail.flavor);
            Console.WriteLine(cocktail.type1);
            Console.WriteLine(cocktail.type2);
            Console.WriteLine("-----------------------");

        }

        static void Main(string[] args)
        {
            
            CLib businessServices = new CLib();
            List<Calbum> Drinktionary = businessServices.GetDrinktionary();

            Console.WriteLine("WELCOME TO VA-11-HALL-A");
            Console.WriteLine("Choose your Drink");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Bad Touch");
            Console.WriteLine("2. Fluffy Dream");
            Console.WriteLine("3. Gut Punch");
            Console.WriteLine("4. Cobalt Velvet");
            Console.WriteLine("5. Mercuryblast");
            Console.WriteLine("------------------");




            int drinknumber = Convert.ToInt32(Console.ReadLine());
            
            switch (drinknumber)
            {
                case 1:
                    ShowHistory(Drinktionary[0]);
                    break;
                case 2:
                    ShowHistory(Drinktionary[1]);
                    break;
                case 3:
                    ShowHistory(Drinktionary[2]);
                    break;
                case 4:
                    ShowHistory(Drinktionary[3]);
                    break;
                case 5:
                    ShowHistory(Drinktionary[4]);
                    break;
                default:
                    Console.WriteLine("UNIDENTIFIED DRINK NUMBER");
                    break;
            }




        }
       
    }
}