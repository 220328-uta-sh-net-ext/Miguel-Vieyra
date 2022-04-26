using ResturantReviewUI;

bool repeat = true;
IMenu menu = new MainMenu();


while (true)
{
   
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchResturant":
            Console.WriteLine("SearchResturant() Method is in progress.....");
            break;
        case "AddResturant":
            ResturantOperations.AddDummyResturant();
            Console.WriteLine("AddResturant() Method implementation is in progress....");
            break;
        case "GetAllResturants":
            ResturantOperations.GetAllResturants();
            break ;
        case "MainMenu":
            menu=new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;

        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }

}
