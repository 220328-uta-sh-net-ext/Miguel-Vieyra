using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResturantReviewBL;

namespace ResturantReviewUI
{
    internal class SearchResturantMenu : IMenu
    {
        private readonly IResturantLogic logic;

        public SearchResturantMenu(IResturantLogic logic)
        {
            this.logic = logic;
        }

        public void Display()
        {
            Console.WriteLine("Please select an option to filter the Resturant database");
            Console.WriteLine("Press <1> By Name");
            Console.WriteLine("Press <0> Go Back");
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
                    // Logic to display results
                    Console.Write("Please enter the name ");
                    if (Console.ReadLine() is not string name)
                        throw new InvalidDataException("end of input");
                    var results = logic.SearchResturant(name);
                    if (results.Count() > 0)
                    {
                        foreach (var r in results)
                        {
                            Console.WriteLine("===");
                            Console.WriteLine(r.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Resturant with search string {name} not found");
                    }
                    Console.WriteLine("Press <enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                default:
                    Console.WriteLine("Please enter a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "SearchResturant";
            }
        }
    }
}
