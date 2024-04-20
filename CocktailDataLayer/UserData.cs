using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CocktailModel;

namespace CocktailDataLayer
{
    public class Data
    {
        List<UserModel> dummyUser = new List<UserModel>();


        public Data()
        {
            CreateDummyData();
        }
        private void CreateDummyData()
        {
            UserModel user1 = new UserModel { userID = "Dante", pass = "Durante" };
            UserModel user2 = new UserModel { userID = "DonQui", pass = "SuenoImposible" };
            UserModel user3 = new UserModel { userID = "Outis", pass = "Odyssey" };

            dummyUser.Add(user1);
            dummyUser.Add(user2);
            dummyUser.Add(user3);


        }
        public UserModel GetDummyData(string userID, string pass)
        {
            UserModel foundUser = new UserModel();

            foreach (var dummy in dummyUser)
            {
                if (userID == dummy.userID && pass == dummy.pass)
                {
                    foundUser = dummy;
                }

            }
            return foundUser;
        }
    }
}