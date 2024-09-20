using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},\n");
Console.WriteLine($"As avalued customer of our {currentProduct} offering, we are excited to introduce you to a new financial product that could significantly enhance your returns.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares with a return {currentReturn:P2}%.\n");
Console.WriteLine($"Our new product, {newProduct}, offers a return of {newReturn:P2}%. Given your current volume your potential profit will increase to ${newProfit}.\n");
Console.WriteLine("Here`s a quick comparison\n");
Console.WriteLine($"Magic Yield: {currentReturn:P2}% - €{currentProfit}".PadLeft(38));
Console.WriteLine($"Glorious Future: {newReturn:P2}% - €{newProfit}");
Console.WriteLine("We believe this new product could be a great fit for your investment strategy.\n");
Console.WriteLine("Best regards,\n[Jesus Duran]");
