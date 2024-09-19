using System.Text;
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string resulto = string.Join("," ,valueArray);
Console.WriteLine(resulto);


string pangram = "The quick brown fox jumps over the lazy dog";
string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}
string result = String.Join(" ", newMessage);
Console.WriteLine(result);
