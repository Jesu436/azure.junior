using System.Text;
Random dice = new Random();
int Heroe = 10;
int Monstruo = 10;
var roll = 0;
var isHero = true;

do
{
   roll = dice.Next(1, 11);
   if (isHero)
   {Monstruo -= roll;
   Console.WriteLine($"El montruo ha recibido {roll} puntos de daño. Y le quedan {Monstruo} puntos de vida");
   }
   else
   {
      Heroe -= roll;
      Console.WriteLine($"El heroe ha recibido {roll} puntos de daño. y le quedan {Heroe} puntos de vida");
   }
   isHero = !isHero;
   
} while (Heroe > 0 && Monstruo > 0);
Console.WriteLine($"El combate ha finalizado, ha ganado {(Heroe > 0 ? "Heroe" : "Monstruo")}");


