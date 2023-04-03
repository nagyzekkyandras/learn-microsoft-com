// sor törés
Console.WriteLine("Hello\nWorld!");
// tabulálás
Console.WriteLine("Hello\tWorld!");
// escape karakterek
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");
// formatting
// example 1
Console.WriteLine("Generating invoices for customer \"Contoso Corp\"\' ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
Console.WriteLine(@"c:\invoices");

// using variables
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

string message2 = $"Hello {firstName}!";
Console.WriteLine(message2);

int version = 11;
string updateText = "Update to Windows";
string message3 = $"{updateText} {version}";
Console.WriteLine(message3);
