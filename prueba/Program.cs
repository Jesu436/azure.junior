using System.Collections;
using System.Text;
Random dados = new Random();
int total = 0;
string resultado = "";
for (int i = 0; i < 3; i++)
{
    int roll =  dados.Next(1, 7);
    total += roll;
    resultado += (i > 0 ? " + " : "") + roll;
}

 Console.WriteLine($"dados roll: {resultado} = {total}");


if (total > 14)
{
    Console.WriteLine("You win");
}
if (total < 15)
{
    Console.WriteLine("You lose");
}









