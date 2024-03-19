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