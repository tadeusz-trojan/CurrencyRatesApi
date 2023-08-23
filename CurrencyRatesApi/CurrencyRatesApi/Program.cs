using CurrencyRatesApi;

int chosenOption;
int menuOptionsCount;
do
{
    Console.WriteLine("==================================================================");
    Console.WriteLine("           Welcome in currency rates API!\n");
    Console.WriteLine("==================================================================");

    Console.WriteLine("\nSelect an option\n");
    List<string> menuOptions = new List<string>
    {
        "  1. Exchange £ to PLN.",
        "  2. Exchange PLN to £.",
        "  3. Exit."
    };

    menuOptionsCount = menuOptions.Count;

    foreach (var option in menuOptions)
    {
        Console.WriteLine($"{option}");
    }

    Console.WriteLine("_____________________________________");
    Console.WriteLine();
    Console.WriteLine("Enter your selection");

    int minOptionMenu = 1;
    GetChosenOption(out chosenOption, minOptionMenu, menuOptionsCount);
    Console.WriteLine($"Your chose: \t{menuOptions[chosenOption -1]}");
    CurrencyService currencyService = new CurrencyService();

    {
        switch (chosenOption)
        {
            case 1:
                currencyService.PlnsToPounds();
                break;
            case 2:
                currencyService.PoundsToPlns();
                break;
        }
    }
    Console.Write("\nEnter any key to return:");
    Console.ReadKey();
} while (chosenOption < menuOptionsCount);

static int GetChosenOption(out int chosenOption, int minOption, int maxOption)
{
    if (!int.TryParse(Console.ReadLine(), out chosenOption))
    {
        Console.WriteLine("Wrong value! Only numbers: ");
        GetChosenOption(out chosenOption, minOption, maxOption);
    }
    else if (chosenOption > maxOption || chosenOption < minOption)
    {
        Console.WriteLine("Wrong value! Enter your selection: ");
        GetChosenOption(out chosenOption, minOption, maxOption);
    }
    return chosenOption;
}