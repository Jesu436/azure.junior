using System.Text;
Random dice = new Random();
int Heroe = 10;
int Monstruo = 10;
do
{
   Console.ReadKey();
   int roll = dice.Next(1, 11);
   Monstruo -= roll;
   Console.WriteLine($"El heroe ataca y causa " + roll + " Puntos de daño");
   Console.WriteLine("Salud del monstruo " + Monstruo);

   if (Monstruo <= 0) continue;
   roll = dice.Next(1, 11);
   Heroe -= roll;
   Console.WriteLine($"El Monstruo ataca y causa " + roll + " Puntos de daño");
   Console.WriteLine($"Salud del Heroe " + Heroe);
   

} while (Heroe > 0 && Monstruo > 0 );

Console.WriteLine(Heroe > Monstruo ? "Heroe Gana" : "Monstruo Gana");
