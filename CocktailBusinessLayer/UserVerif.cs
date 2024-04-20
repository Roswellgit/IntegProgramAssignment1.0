using CocktailDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailBusinessLayer
{
    public class Business
    {

        public bool Verification(string userID, string pass)
        {
            Data dataservice = new Data();
            var result = dataservice.GetDummyData(userID, pass);

            if (result.userID == userID && result.pass == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
