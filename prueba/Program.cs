using System.Text;

string[] values = { "12,3", "45", "ABC", "11", "DEF" };
var total = 0.0;
var message = "";

foreach (var value in values)
{
    double number;
    if (double.TryParse(value, out number))
        {total += number;}
        else
        {message += value;}
}
Console.WriteLine("mensaje: " + message);
Console.WriteLine("total: " + total);