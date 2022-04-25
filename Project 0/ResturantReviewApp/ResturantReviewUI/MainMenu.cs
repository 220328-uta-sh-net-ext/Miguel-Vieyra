using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantReviewUI
{
    class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to Resturant App");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press <2> to Search Resturant");
            Console.WriteLine("Press <1> to Add Resturant to your profile");
            Console.WriteLine("Press <0> to Exit");
        }


        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "AddResturant";
                case "2":
                    return "SearchResturant";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "Mainmenu";
            }
        }
    }
}
