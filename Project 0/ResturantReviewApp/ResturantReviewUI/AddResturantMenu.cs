using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResturantReviewModel;

namespace ResturantReviewUI
{
    internal class AddResturantMenu : IMenu
    {
        private static Resturant newResturant=new Resturant();
        public void Display()
        {
            Console.WriteLine("Enter Resturant Information");
            Console.WriteLine("<3> Resturant Name " + newResturant.Name);
            Console.WriteLine("<2> Review " + newResturant.Review);
            Console.WriteLine("<1> save");
            Console.WriteLine("<0> Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();
        }
    }

}
