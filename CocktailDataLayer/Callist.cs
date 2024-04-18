using CocktailModel;

namespace CocktailDataLayer
{
    public class Callist
    {
        List<Calbum> Drinktionary = new List<Calbum>();

        public Callist()
        {
            Drinks();
        }
        public void Drinks()
        {
            Calbum one = new Calbum
            {
                cname = "Bad Touch",
                mainingredients = "2 Bronson Ext 2 Pwd Delta 2 Flanergide 4 Alcohol",
                prep = "On the Rocks and Mixed",
                flavor = "Sour",
                type1 = "Classy",
                type2 = "Vintage",
            };

            Drinktionary.Add(one);

            Calbum two = new Calbum
            {
                cname = "Fluffy Dream",
                mainingredients = "3 Adelhyde 3 Pwd Delta (optional) Alcohol",
                prep = "Aged and Mixed",
                flavor = "Sour",
                type1 = "Girly",
                type2 = "Soft",
            };

            Drinktionary.Add(two);
            Calbum three = new Calbum
            {
                cname = "Gut Punch",
                mainingredients = "5 Bronson Ext 1 Flanergide (optional) Alcohol",
                prep = "Aged and Mixed",
                flavor = "Bitter",
                type1 = "Manly",
                type2 = "Strong",
            };

            Drinktionary.Add(three);
            Calbum four = new Calbum
            {
                cname = "Cobalt Velvet",
                mainingredients = "2 Adelhyde 3 Flanergide 5 Alcohol",
                prep = "On the Rocks and Mixed",
                flavor = "Bubbly",
                type1 = "Classy",
                type2 = "Burning",
            };

            Drinktionary.Add(four);
            Calbum five = new Calbum
            {
                cname = "Mercuryblast",
                mainingredients = "1 Adelhyde 1 Bronson Ext 3 Pwd Delta 3 Flanergide 2 Alcohol",
                prep = "On the Rocks and Blended",
                flavor = "Sour",
                type1 = "Classy",
                type2 = "Burning",
            };

            Drinktionary.Add(five);
        }

        public List<Calbum> GetDrinktionary()
        {
            return Drinktionary;
        }

    }
}
