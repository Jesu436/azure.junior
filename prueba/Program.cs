using System.Text;
namespace prueba;

class Program
{
    static void Main(string[] args)
    {
        var FizzBuzz = new FizzBuzz();

        for (int i = 1; i < 16; i++)
        {
            Console.WriteLine(FizzBuzz.printFizzBuzz(i));
        }
    }
}