using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");
var hoy = new DateTime(2024, 05, 31);  
Console.WriteLine(hoy.AddMonths(1).Ticks);
TimeSpan today = TimeSpan.FromDays(36);

