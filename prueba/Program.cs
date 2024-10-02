using System;

namespace prueba;

class Program
{
    static void Main(string[] args)
    {
        var calculadora = new Calculadora();
        Console.WriteLine(calculadora.suma(2,2));
        Console.WriteLine(calculadora.resta(2,2));
    }
} 

