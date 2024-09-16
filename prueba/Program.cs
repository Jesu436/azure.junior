using System.Collections;
using System.Text;
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
if (daysUntilExpiration >= 10)
{
    Console.WriteLine("Your suscription will expire soon renew now!");
}    
else if (daysUntilExpiration >= 5)
{
    Console.WriteLine($"Your suscription will expire in {daysUntilExpiration} days. " + $"Renew now to enjoy a {discountPercentage}% of discount!.");
    discountPercentage = 10;
}

else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your suscription expires withting a day!" + $" Renew now to enjoy a {discountPercentage}% of discount!.");
}
else 
{
    Console.WriteLine("Your suscription has expired.");
}






