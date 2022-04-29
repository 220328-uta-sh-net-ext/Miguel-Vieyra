using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResturantReviewDL;

namespace ResturantReviewUI
{
    internal class ResturantOperations
    {
        static Repository repository= new Repository();


        public static void GetAllResturants()
        {
            var resturants = repository.GetAllResturants();
            foreach (var rest in resturants)
            {
                Console.WriteLine(rest.ToString());
            }
        }
        public static void AddDummyResturant()
        {
            Resturant resturant1 = new Resturant()
                {
                Resturants = new List<Resturant>()
                {
                    new Resturant()
                    {
                         Name = "Mexican Resturant";
                         Menu = ("Tacos burrito beans");
                         Location = "Los Angeles";
                         Decor = "Good";
        }
                }
            }
        repository.AddResturant(Resturant1);
        }
    }
}
