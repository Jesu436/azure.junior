using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";


int start = input.IndexOf("<span>") + 6;
int end = input.IndexOf("</span>");
string quantity = input.Substring(start, end - start);
string output = input.Replace("&trade;", "&reg;");
output = output.Replace("<div>", "").Replace("</div>", "");
Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Output:" + output);




