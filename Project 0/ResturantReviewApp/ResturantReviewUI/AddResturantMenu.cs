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

        private readonly IResturantLogic logic;

        public AddResturantMenu(IResturantLogic logic)
        {
            this.logic = logic;
        }

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
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    try
                    {
                        Log.Information("Adding a resturant - " + newResturant.Name);
                        logic.AddResturant(newResturant);
                        Log.Information("Resturant added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add Resturant");
                        Console.WriteLine(ex.Message);

                    }
                    return "MainMenu";
                case "2":
                    Console.Write("Please enter a Review ");
                    newResturant.review = Convert.ToInt32(Console.ReadLine());
                    return "AddReview";
                case "3":
                    Console.Write("Please enter a name! ");
                    if (Console.ReadLine() is string input)
                        newResturant.Name = input;
                    else
                        throw new InvalidDataException("end of input");
                    return "AddResturant";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddResturant";
            }
        }
    }

}
