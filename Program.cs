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