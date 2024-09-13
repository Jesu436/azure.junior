using System.Collections;
using System.Text;
var dados = new Random();
for(int i = 0; i < 15; i++)
{
    var roll = dados.Next(1, 7);
    Console.WriteLine(roll);
}




