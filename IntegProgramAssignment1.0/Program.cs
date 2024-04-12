using CocktailDataLayer;

namespace IntegProgramAssignment1._0
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Callist Drinktionary = new Callist();


            Console.WriteLine("WELCOME TO VA-11-HALL-A");
            Console.WriteLine("Choose your Drink");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Bad Touch");
            Console.WriteLine("2. Fluffy Dream");
            Console.WriteLine("3. Gut Punch");
            Console.WriteLine("4. Cobalt Velvet");
            Console.WriteLine("5. Mercuryblast");
            Console.WriteLine("------------------");

            Drinktionary.Drinks();





        }
    }
}