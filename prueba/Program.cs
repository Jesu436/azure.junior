string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

void DisplayEmails(string[,] names, string domain = "contoso.com")
{
    for (int i = 0; i < names.GetLength(0); i++)
    {
        string email = names[i, 0].Substring(0, 2) + names[i, 1];
        email = email.ToLower();
        Console.WriteLine($"{email}@{domain}");
    }
}

DisplayEmails(corporate);
DisplayEmails(external, externalDomain);
