namespace prueba;
//Mi primera CI
/*for (int i = 1; i < 16; i++)
{
   if ((i % 3 == 0) && (i % 5 == 0))
   
      Console.WriteLine($"{i} - FizzBuzz");
      else if ((i % 3 == 0))
      Console.WriteLine($"{i} - Fizz");
      else if (i % 5 == 0)
      Console.WriteLine($"{i} - Buzz");
      else
      Console.WriteLine($"{i}");
      
}*/
public class FizzBuzz
{
    public bool multiplo3(int numero)
    {
        int resutlado = numero % 3;
        if (resutlado == 0)
            return true;
        else
            return false;
    }

    public bool multiplo5(int numero)
    {
        int resutlado = numero % 5;
        if (resutlado == 0)
            return true;
        else
            return false;
    }

    public bool multiplo35(int numero)
    {
        if (multiplo3(numero) && multiplo5(numero))
            return true;
        else
            return false;
    }

    public bool multiplo7(int numero)
    {
        int resutlado = numero % 7;
        if (resutlado == 0)
            return true;
        else
            return false;
    }

    public bool numeroPrimo(int numero)
    {
        if (numero <= 1) 
            return false;
        
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false; 
            } 
        }
        return true;
    }

    public string printFizzBuzz(int numero)
    {
        if (multiplo35(numero))
            return "FizzBuzz";
        else if (multiplo5(numero))
            return "Buzz";
        else if (multiplo3(numero))
            return "Fizz";
        else if (multiplo7(numero))
            return "Numero Suerte";
        else if (numeroPrimo(numero))
            return "Es numero Primo";
        else
            return $"{numero}";
    }

}