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

            Console.Write("Enter Username:  ");
            string userID = Console.ReadLine();

            Console.Write("Enter Password:  ");
            string pass = Console.ReadLine();

            Business veri = new Business();
            bool result = veri.Verification(userID, pass);

            if (result)
            {


                Console.WriteLine("WELCOME TO VA-11-HALL-A");
                Console.WriteLine("Please Choose an Option");
                Console.WriteLine("1.Drinktionary");
                Console.WriteLine("2.Add to Drinktionary");
                Console.WriteLine("3.Remove from Drinktionary");


                int options = Convert.ToInt32(Console.ReadLine());

                switch (options)

                {
                    case 1:


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
                        break;

                    case 2:

                        Calbum userip = new Calbum();

                        Console.WriteLine("Enter Cocktail Name");
                        userip.cname = Console.ReadLine();
                        Console.WriteLine("Enter Prep");
                        userip.prep = Console.ReadLine();
                        Console.WriteLine("Enter Ingredients");
                        userip.mainingredients = Console.ReadLine();
                        Console.WriteLine("Enter Flavor");
                        userip.flavor = Console.ReadLine();
                        Console.WriteLine("Enter First Type");
                        userip.type1 = Console.ReadLine();
                        Console.WriteLine("Enter Second Type");
                        userip.type2 = Console.ReadLine();

                        ShowHistory(Drinktionary[0]);
                        ShowHistory(Drinktionary[1]);
                        ShowHistory(Drinktionary[2]);
                        ShowHistory(Drinktionary[3]);
                        ShowHistory(Drinktionary[4]);
                        Console.WriteLine("\nHere's your added Drink!\n");
                        ShowHistory(userip);

                        break;
                    case 3:

                        int drinkdelete = Convert.ToInt32(Console.ReadLine());

                        switch (drinkdelete)
                        {
                            case 1:
                                businessServices.DeleteCocktail(Drinktionary[0]);
                                Console.WriteLine("The Cocktail has been Deleted");
                                break;
                            case 2:
                                businessServices.DeleteCocktail(Drinktionary[1]);
                                Console.WriteLine("The Cocktail has been Deleted");
                                break;
                            case 3:
                                businessServices.DeleteCocktail(Drinktionary[2]);
                                Console.WriteLine("The Cocktail has been Deleted");
                                break;
                            case 4:
                                businessServices.DeleteCocktail(Drinktionary[3]);
                                Console.WriteLine("The Cocktail has been Deleted");
                                break;
                            case 5:
                                businessServices.DeleteCocktail(Drinktionary[4]);
                                Console.WriteLine("The Cocktail has been Deleted");
                                break;
                            default:
                                Console.WriteLine("UNIDENTIFIED DRINK NUMBER");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("ERROR IN CHOOSING");
                        break;


                }
            }

            else
            {
                Console.WriteLine("You are not a Registered User");
            }


        }


    }
}
    

