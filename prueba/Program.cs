using System.Text;
var value1 = 11;
var value2 = 6.2;
var value3 = 4.3;

var result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($" El resultado de los valores dividido es {result1};");
var result2 = (decimal)value2 / (decimal)value3;
Console.WriteLine($"El resultado de los valores es {result2}");
var result3 = (float)value3 / value1;
Console.WriteLine($"El resultado de los valores es {result3}");

