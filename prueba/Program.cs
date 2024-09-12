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

Console.Clear();
int result = 3 + 1 * 5 / 2;
Console.WriteLine(result);
Console.WriteLine(5/10);

Console.Clear();


var sophia1 = 93;
var sophia2 = 87;
var sophia3 = 98;
var sophia4 = 95;
var sophia5 = 100;
 
var andrew1 = 80;
var andrew2 = 83;
var andrew3 = 82;
var andrew4 = 88;
var andrew5 = 85;

var emma1 = 84;
var emma2 = 96;
var emma3 = 73;
var emma4 = 85;
var emma5 = 79;

var logan1 = 90;
var logan2 = 92;
var logan3 = 98;
var logan4 = 100;
var logan5 = 97;

var sophiasum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
var andrewsum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
var emmasum = emma1 + emma2 + emma3 + emma4 + emma5;
var logansum = logan1 + logan2 + logan3 + logan4 + logan5;

Console.WriteLine( "sophia " + sophiasum);
Console.WriteLine("andrew " + andrewsum);
Console.WriteLine("emma " + emmasum);
Console.WriteLine("logan " + logansum);

Console.WriteLine("Sophia " + (decimal)sophiasum / 5 + " A");
Console.WriteLine("Sophia " + (decimal)andrewsum / 5 + " B");
Console.WriteLine("Sophia " + (decimal)emmasum / 5 + " B");
Console.WriteLine("Sophia " + (decimal)logansum / 5 + " A");





