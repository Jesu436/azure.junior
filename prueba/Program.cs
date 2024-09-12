using System.Text;
var value = 38;
value++;
Console.WriteLine(value);

value+= 5;
Console.WriteLine(value);
value-= 8;
Console.WriteLine(value);
value*= 85;
Console.WriteLine(value);
value/= 70;
Console.WriteLine(value);
Console.Clear();

var values = 1;
values++;
Console.WriteLine("first: " + values);
Console.WriteLine($"second: {value++}");

var fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * 5/9;
Console.WriteLine("The temperetaure in celsius is: " + Math.Round(celsius,1) + " Celsius");
Console.WriteLine("The temperetaure in celsius is: " + celsius.ToString("0.0") + " Celsius");












