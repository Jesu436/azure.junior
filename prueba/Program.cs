using System.Text;
int[] pallets = { 4, 1, 2, 3 };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- " + pallet);
}


