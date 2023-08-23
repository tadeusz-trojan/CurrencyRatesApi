using CurrencyRatesApi;

do
{
    Console.WriteLine("Welcome in currency rates API!");
    Console.WriteLine("1. Exchange £ to PLN.");
    Console.WriteLine("2. Exchange PLN to £.");
    Console.WriteLine("Press E to exit!");

    string operation = Console.ReadLine();
    Console.WriteLine($"You have chosen option number: {operation}");

    int chosenOperation = 0;
    Int32.TryParse(operation, out chosenOperation);
    CurrencyService currencyService = new CurrencyService();
    if (chosenOperation > 0 && chosenOperation <= 2)
    {
        switch (chosenOperation)
        {
            case 1:
                currencyService.PlnsToPounds();
                break;
            case 2:
                currencyService.PoundsToPlns();
                break;
            default:
                currencyService.IncorrectValue();
                break;
        }
    }
    else
    {
        currencyService.IncorrectValue();
    }
} while (true);