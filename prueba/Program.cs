using System.Runtime.ExceptionServices;
using System.Text;

var Name = "Bob";
var messagesnumber = 3;
var temperature = 34.4;
Console.Write("Hello, ");
Console.Write(Name);
Console.Write("! You have  ");
Console.Write(messagesnumber);
Console.Write(" messagess in your inbox. the temperature is ");
Console.Write(temperature);
Console.WriteLine(" celsius.");


Console.WriteLine("Hello " + Name + " ! You have  " + messagesnumber + " messagess in your inbox. the temperature is " + temperature + "  celsius.");
var name = "my nigga";
var message = "whats up";
var numberpistol= 4;
Console.Write(message + " " + name + " here is your package of " + numberpistol + " pistols take care bro.");

Console.WriteLine("Hello\nWorld");
Console.WriteLine("Hello\tWorld");

Console.WriteLine("Genereting invoices for custumers \"contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Console.WriteLine(@"c:\source\repos");
Console.WriteLine("c:\\source\\repos");
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
Console.Write(@"c:\invoices");
Console.OutputEncoding = Encoding.UTF8;
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");


string firstname = "Jesus";
string greeting = "sup my nigga";
message = $"{greeting} {firstname}!";
Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

string ProjectName = "First-Project";
var path = $@"C:\Output\{projectName}\Data";
Console.WriteLine(path);




