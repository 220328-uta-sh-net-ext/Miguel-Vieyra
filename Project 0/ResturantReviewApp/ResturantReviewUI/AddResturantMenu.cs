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

        private IRepository _repository = new Repository();

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
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                    case "1":
                        _repository.AddResturant(newResturant);
                    return "MainMenu";
                    case"2":
                    Console.WriteLine("Please enter a Resturant name");
                    newResturant.Name = Console.ReadLine();
                    return "AddResturant";
                case "3":
                    Console.WriteLine("Please enter a User name");
                    newResturant.User = Console.ReadLine();
                    return "AddResturant";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press enter to continue");
                    Console.ReadLine();
                    return "AddResturant";
            }
        }
    }

}
