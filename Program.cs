// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Symbols

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine(firstFriend + secondFriend);

// String Interpolation

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters."); 

// Working with Strings (Trim)

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// Working with Strings (Replace)

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// Search Strings with Boolean Values

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

// StartsWith and EndsWith methods

string moreSongLyrics = "You say goodbye, and I say hello";
Console.WriteLine(moreSongLyrics.StartsWith("You"));
Console.WriteLine(moreSongLyrics.StartsWith("goodbye"));
Console.WriteLine(moreSongLyrics.EndsWith("hello"));
Console.WriteLine(moreSongLyrics.EndsWith("goodbye"));

// Exploring Integer Math

// int a = 18;
// int b = 6;
// int c = a + b;
// Console.WriteLine(c);

// int d = a - b;
// int e = a * b;
// int f = a / b;
// Console.WriteLine(d);
// Console.WriteLine(e);
// Console.WriteLine(f);

// Order of operations

// int a = 5;
// int b = 4;
// int c = 2;
// int d = a + b * c;
// Console.WriteLine(d);

// The output demonstrates that the multiplication is performed before the addition.

int a = 5;
int b = 4;
int c = 2;
int d = (a + b) * c;
Console.WriteLine(d);

// We can force a different order of operation by adding parenthesis