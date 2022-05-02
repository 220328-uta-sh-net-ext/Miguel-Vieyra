global using Serilog;
using ResturantReviewBL;
using ResturantReviewDL;
using ResturantReviewUI;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console().MinimumLevel.Debug()
    .WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()
    .CreateLogger();


string connectionStringFilePath = "../../../../ResturantReviewDL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

IRepository repository = new SqlRepository(connectionString);
IResturantLogic logic = new ResturantLogic(repository);
ResturantOperations operations = new(repository);

bool repeat = true;
IMenu menu = new MainMenu();


while (repeat)
{
   
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchResturant":
            Log.Debug("Displaying SearchResturant menu to the user");
            menu = new SearchResturantMenu(logic);
            break;
        case "AddResturant":
            Log.Debug("Displaying AddResturant Menu to the user");
            menu = new AddResturantMenu(logic);
            break;
        case "GetAllResturant":
            Log.Debug("Displaying all resturants to the user");
            Console.WriteLine("Retreiving all resturants");
            operations.GetAllResturant();
            break;
        case "MainMenu":
            Log.Debug("Displaying Main menu to the user");
            menu = new MainMenu();
            break;
        case "Exit":
            Log.Debug("Exiting the application");
            Log.CloseAndFlush();
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }

}
