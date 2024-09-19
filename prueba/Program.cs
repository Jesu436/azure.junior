using System.Runtime.CompilerServices;
using System.Text;
string pangram = "The quick fox jumps over the lazy dog";
string[] message = pangram.Split(" ");
string [] reverse = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    string word = message[i];
    string reverseword = string.Join("",word.ToCharArray().Reverse());
    reverse[i] = reverseword;
}  
Console.WriteLine(string.Join(" ",reverse));