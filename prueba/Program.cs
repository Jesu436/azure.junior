using System.Text;

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

var uno = 2;
var dos = "4";
var resultado = uno + int.Parse(dos);
Console.WriteLine(resultado);


try
{
    string firs = "2";
    string secon = "4";
    int sum = int.Parse(firs) + int.Parse(secon);
    Console.WriteLine(sum);

}
catch (System.Exception)
{
    Console.WriteLine("numero no valido");
}


string fir = "2";
string seco = "4";
int sumas; 
Console.WriteLine(int.TryParse (seco, out sumas));
int suman = int.Parse(fir) + sumas;
Console.WriteLine(suman);


string value1 = "5";
string value2 = "7";
int resultados = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(resultados);
